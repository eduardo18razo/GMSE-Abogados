using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Dropbox.Api;
using Dropbox.Api.Files;

namespace Polizas.Business
{
    public class DropBoxManager
    {
        #region Variables
        private DropboxClient DBClient;
        private ListFolderArg DBFolders;
        private string oauth2State;
        private const string RedirectUri = "https://localhost/authorize"; // Same as we have configured Under [Application] -> settings -> redirect URIs.  
        #endregion

        #region Constructor
        public DropBoxManager(string applicationName = "PolizasJuricas")
        {
            try
            {
                AppName = applicationName;
                DBClient = new DropboxClient(BusinessVariables.Dropbox.Token);
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region Properties
        public string AppName
        {
            get;
            private set;
        }
        public string AuthenticationURL
        {
            get;
            private set;
        }
        public string AppKey
        {
            get;
            private set;
        }

        public string AppSecret
        {
            get;
            private set;
        }

        public string AccessTocken
        {
            get;
            private set;
        }
        public string Uid
        {
            get;
            private set;
        }
        #endregion

        #region UserDefined Methods

        /// <summary>  
        /// This method is to generate Authentication URL to redirect user for login process in Dropbox.  
        /// </summary>  
        /// <returns></returns>  
        public string GeneratedAuthenticationURL()
        {
            try
            {
                this.oauth2State = Guid.NewGuid().ToString("N");
                Uri authorizeUri = DropboxOAuth2Helper.GetAuthorizeUri(OAuthResponseType.Token, AppKey, RedirectUri, state: oauth2State);
                AuthenticationURL = authorizeUri.AbsoluteUri.ToString();
                return authorizeUri.AbsoluteUri.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>  
        /// Method to create new folder on Dropbox  
        /// </summary>  
        /// <param name="path"> path of the folder we want to create on Dropbox</param>  
        /// <returns></returns>  
        public bool CreateFolder(string path)
        {
            try
            {
                //if (AccessTocken == null)
                //{
                //    throw new Exception("AccessToken not generated !");
                //}
                //if (AuthenticationURL == null)
                //{
                //    throw new Exception("AuthenticationURI not generated !");
                //}

                var folderArg = new CreateFolderArg(path);
                var folder = DBClient.Files.CreateFolderAsync(folderArg);
                var result = folder.Result;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        /// <summary>  
        /// Method is to check that whether folder exists on Dropbox or not.  
        /// </summary>  
        /// <param name="path"> Path of the folder we want to check for existance.</param>  
        /// <returns></returns>  
        public bool FolderExists(string path)
        {
            try
            {
                //if (AccessTocken == null)
                //{
                //    throw new Exception("AccessToken not generated !");
                //}
                //if (AuthenticationURL == null)
                //{
                //    throw new Exception("AuthenticationURI not generated !");
                //}
                //var folderArg = new CreateFolderArg(path);
                var folders = DBClient.Files.ListFolderAsync(path);
                var result = folders.Result;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>  
        /// Method to delete file/folder from Dropbox  
        /// </summary>  
        /// <param name="path">path of file.folder to delete</param>  
        /// <returns></returns>  
        public bool Delete(string path)
        {
            try
            {
                if (AccessTocken == null)
                {
                    throw new Exception("AccessToken not generated !");
                }
                if (AuthenticationURL == null)
                {
                    throw new Exception("AuthenticationURI not generated !");
                }

                var folders = DBClient.Files.DeleteAsync(path);
                var result = folders.Result;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /// <summary>  
        /// Method to upload files on Dropbox  
        /// </summary>  
        /// <param name="uploadfolderPath"> Dropbox path where we want to upload files</param>  
        /// <param name="uploadfileName"> File name to be created in Dropbox</param>  
        /// <param name="sourceFilePath"> Local file path which we want to upload</param>  
        /// <returns></returns>  
        public bool Upload(string uploadfolderPath, string uploadfileName, string sourceFilePath)
        {
            try
            {
                uploadfolderPath = "/" + uploadfolderPath;
                if (!FolderExists(BusinessVariables.Directorio.CarpetaPrincipalDropBox))
                    CreateFolder(BusinessVariables.Directorio.CarpetaPrincipalDropBox);
                if (!FolderExists(BusinessVariables.Directorio.CarpetaPrincipalDropBox + uploadfolderPath))
                    CreateFolder(BusinessVariables.Directorio.CarpetaPrincipalDropBox + uploadfolderPath);

                using (var stream = new MemoryStream(File.ReadAllBytes(sourceFilePath)))
                {
                    var response = DBClient.Files.UploadAsync(BusinessVariables.Directorio.CarpetaPrincipalDropBox + uploadfolderPath + "/" + uploadfileName, WriteMode.Overwrite.Instance, body: stream);
                    var rest = response.Result; //Added to wait for the result from Async method  
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public Dictionary<string, string> GetFiles(string registryName)
        {
            Dictionary<string, string> result;
            try
            {
                var response = DBClient.Files.ListFolderAsync(string.Format("{0}/{1}", BusinessVariables.Directorio.CarpetaPrincipalDropBox, registryName));
                ListFolderResult rest = response.Result;
                result = rest.Entries.Where(metadata => metadata.IsFile).ToDictionary(metadata => metadata.PathDisplay, metadata => metadata.Name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public async Task<bool> DownloadFile(string dropboxFolderPath, string fileNameOut)
        {
            try
            {
                using (var response = await DBClient.Files.DownloadAsync(dropboxFolderPath))
                {
                    using (var fileStream = File.Create(BusinessVariables.Directorio.DirectorioAplciacion + BusinessVariables.Directorio.CarpetaTemporales + fileNameOut))
                    {
                        (await response.GetContentAsStreamAsync()).CopyTo(fileStream);
                    }
                }
                return true;
                //var response = DBClient.Files.DownloadAsync(dropboxFolderPath);
                //var result = response.Result.GetContentAsStreamAsync().; //Added to wait for the result from Async method  

                //return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool Download(string dropboxFolderPath, string dropboxFileName, string downloadFolderPath, string downloadFileName)
        {
            try
            {
                var response = DBClient.Files.DownloadAsync(dropboxFolderPath + "/" + dropboxFileName);
                var result = response.Result.GetContentAsStreamAsync(); //Added to wait for the result from Async method  

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        #endregion
        #region Validation Methods
        /// <summary>  
        /// Validation method to verify that AppKey and AppSecret is not blank.  
        /// Mendatory to complete Authentication process successfully.  
        /// </summary>  
        /// <returns></returns>  
        public bool CanAuthenticate()
        {
            try
            {
                if (AppKey == null)
                {
                    throw new ArgumentNullException("AppKey");
                }
                if (AppSecret == null)
                {
                    throw new ArgumentNullException("AppSecret");
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }
        #endregion
    }
}
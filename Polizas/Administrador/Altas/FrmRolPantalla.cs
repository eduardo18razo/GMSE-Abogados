using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Polizas.Business;
using Polizas.Entities.Roles;
using Polizas.Utils;

namespace Polizas.Administrador
{
    public partial class FrmRolPantalla : Form
    {
        private BusinessRol _bRol = new BusinessRol();

        public FrmRolPantalla()
        {
            InitializeComponent();
        }

        private void LlenaRoles()
        {
            try
            {
                cmbRoles.DisplayMember = "Descripcion";
                cmbRoles.ValueMember = "Id";
                cmbRoles.DataSource = _bRol.ObtenerRoles(true);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void LoadTreeView()
        {
            List<Pantalla> categories = _bRol.ObtenerMenus(false);


            foreach (Pantalla menus in categories)
            {
                TreeNode nodeMenu = new TreeNode(menus.Descripcion) { Tag = menus.Id };
                foreach (Pantalla subMenus in _bRol.ObtenerPantallas(false).Where(w => w.IdPadre == menus.Id).ToList())
                {
                    TreeNode nodePantalla = new TreeNode(subMenus.Descripcion) { Tag = subMenus.Id };
                    nodeMenu.Nodes.Add(nodePantalla);
                }

                tvMenus.Nodes.Add(nodeMenu);
            }

        }

        private void LimpiarSeleccion()
        {
            try
            {
                foreach (TreeNode node in tvMenus.Nodes)
                {
                    node.Checked = false;
                    foreach (TreeNode childNode in node.Nodes)
                    {
                        childNode.Checked = false;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void ObtenerRolPantalla()
        {
            try
            {
                List<RolPantalla> lstRolPantalla = _bRol.ObtenerRolPantalla(int.Parse(cmbRoles.SelectedValue.ToString()));
                foreach (TreeNode parent in tvMenus.Nodes)
                {
                    parent.Checked = lstRolPantalla.Any(a => a.IdPantalla == int.Parse(parent.Tag.ToString()));
                    foreach (TreeNode child in parent.Nodes)
                    {
                        child.Checked = lstRolPantalla.Any(a => a.IdPantalla == int.Parse(child.Tag.ToString()));
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private void Limpiar()
        {
            try
            {
                cmbRoles.SelectedIndex = BusinessVariables.ComboBoxCatalogo.IndexSeleccione;
                LimpiarSeleccion();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private bool ValidaCaptura()
        {
            try
            {
                if (cmbRoles.SelectedIndex == BusinessVariables.ComboBoxCatalogo.IndexSeleccione)
                    throw new Exception("Seleccione un rol.");
                bool seleccionMenu = tvMenus.Nodes.Cast<TreeNode>().Any(parent => parent.Checked);
                if (!seleccionMenu)
                    throw new Exception("Seleccione al menos una pantalla.");

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return true;
        }

        private void FrmRolPantalla_Load(object sender, EventArgs e)
        {
            try
            {
                LlenaRoles();
                LoadTreeView();
                tvMenus.AfterCheck += tvMenus_AfterCheck;
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbRoles.SelectedIndex == BusinessVariables.ComboBoxCatalogo.IndexSeleccione)
                {
                    LimpiarSeleccion();
                    return;
                }
                ObtenerRolPantalla();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void tvMenus_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                tvMenus.AfterCheck -= tvMenus_AfterCheck;

                if (e.Node.Checked)
                {
                    if (e.Node.Parent != null)
                    {
                        //bool result = true;
                        //foreach (TreeNode node in e.Node.Parent.Nodes)
                        //{
                        //    if (!node.Checked)
                        //    {
                        //        result = false;
                        //        break;
                        //    }
                        //}

                        e.Node.Parent.Checked = true;

                    }
                }
                else
                {
                    if (e.Node.Parent != null)
                    {
                        bool result = false;
                        foreach (TreeNode node in e.Node.Parent.Nodes)
                        {
                            if (node.Checked)
                            {
                                result = true;
                                break;
                            }
                        }

                        e.Node.Parent.Checked = result;

                    }
                }


                if (e.Node.Nodes.Count > 0)
                {
                    foreach (TreeNode node in e.Node.Nodes)
                    {
                        node.Checked = e.Node.Checked;
                    }
                }


                tvMenus.AfterCheck += tvMenus_AfterCheck;
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCaptura())
                {
                    List<RolPantalla> rolPantalla = new List<RolPantalla>();
                    int idRol = int.Parse(cmbRoles.SelectedValue.ToString());
                    foreach (TreeNode parent in tvMenus.Nodes)
                    {
                        if (parent.Checked)
                            rolPantalla.Add(new RolPantalla { IdRol = idRol, IdPantalla = int.Parse(parent.Tag.ToString()) });
                        foreach (TreeNode child in parent.Nodes)
                        {
                            if (child.Checked)
                                rolPantalla.Add(new RolPantalla
                                {
                                    IdRol = idRol,
                                    IdPantalla = int.Parse(child.Tag.ToString())
                                });
                        }
                    }
                    _bRol.CrearRolPantalla(rolPantalla);
                    Limpiar();
                    Mensajes.Exito("Se guardo correctamente.");

                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }
    }
}

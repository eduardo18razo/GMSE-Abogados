using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Polizas.Business;
using Polizas.Business.Manager;
using Polizas.Entities.Usuarios;
using Polizas.Utils;

namespace Polizas.Temporales
{
    public partial class FrmConfiguracionTemplate : Form
    {
        public FrmConfiguracionTemplate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {

                    ofdTemplate.ShowDialog(this);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }
        private Dictionary<string, string> GetProperties(object obj)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add(BusinessVariables.ComboBoxCatalogo.DescripcionSeleccione, BusinessVariables.ComboBoxCatalogo.DescripcionSeleccione);
            foreach (PropertyInfo property in obj.GetType().GetProperties())
            {
                var z = property.PropertyType;
                switch (property.PropertyType.Name)
                {
                    case "Int64":
                    case "String":
                    case "Boolean":
                        result.Add(property.Name, property.Name);
                        break;
                    default:
                        break;
                }
                //if(property.PropertyType == )

            }
            return result;
        }

        private void ofdTemplate_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                lbxMarcadores.DataSource = new DocumentManager().GetMarkers(ofdTemplate.FileName);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                DataTable dt = new DataTable();
                dt.Columns.Add("Marcador", typeof(String));
                dt.Columns.Add("Valor", typeof(String));

                foreach (string marker in new DocumentManager().GetMarkers(ofdTemplate.FileName))
                {
                    dt.Rows.Add(new object[] { marker, 100 });
                }



                var properties = GetProperties(new Usuario());

                //foreach (var p in properties)
                //{
                //    string name = p.Name;
                //    var value = p.GetValue(some_object, null);
                //}


                DataGridViewComboBoxColumn money = new DataGridViewComboBoxColumn();
                var list11 = properties;
                money.DataSource = new BindingSource(list11, null); 
                money.DisplayMember = "Key";
                money.ValueMember = "Value";
                
                //money.HeaderText = "Money";
                //money.DataPropertyName = "Money";

                DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
                name.HeaderText = "Marcador";
                name.DataPropertyName = "Marcador";

                dataGridView1.DataSource = dt;
                dataGridView1.Columns.AddRange(name, money);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[dataGridView1.Columns.Count - 1].Value = BusinessVariables.ComboBoxCatalogo.DescripcionSeleccione;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lbxMarcadores_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                FrmAsignaMarcador frmAsignacion = new FrmAsignaMarcador();
                frmAsignacion.StartPosition = FormStartPosition.CenterParent;
                frmAsignacion.ShowDialog(this);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

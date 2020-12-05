using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOra
{
    public partial class ModificarArea : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form q1;
        public ModificarArea(Form q=null)
        {
            InitializeComponent();
            q1 = q;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            q1.Enabled = true;
            q1.Focus();
            this.Dispose();
        }

        private void ModificarArea_Load(object sender, EventArgs e)
        {
            try
            {
            CbNomArea.DataSource = null;
            OracleCommand comandoarea = new OracleCommand("seleccionarArea", ora);
            comandoarea.CommandType = CommandType.StoredProcedure;
            comandoarea.Parameters.Add("curArea", OracleType.Cursor).Direction = ParameterDirection.Output;
            var rarea = comandoarea.ExecuteReader();
            List<object> listarea = new List<object>();
            while (rarea.Read())
            {
                listarea.Add(new { idarea = rarea.GetValue(0), nombrearea = rarea.GetValue(1) });
            }
            CbNomArea.DataSource = listarea;
            CbNomArea.ValueMember = "idarea";
            CbNomArea.DisplayMember = "nombrearea";
            CbNomArea.SelectedValue = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtNombreArea.Text = ((dynamic)CbNomArea.SelectedItem).nombrearea;
            
        }

        private void btnModificarAreas_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidarCampos())
            {
                try
                {
                    OracleCommand comando = new OracleCommand("actualizarArea", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_id_area", OracleType.Number).Value = Convert.ToInt32(CbNomArea.SelectedValue);
                    comando.Parameters.Add("v_nombre_area", OracleType.VarChar).Value = txtNombreArea.Text;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Area actualizado exitosamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El Area no se ha actualizado");
                }
            }
            else
            {
                MessageBox.Show("Datos no se han Ingresado Correctamente");
            }
            ValidarCampos();
            if (CbNomArea.SelectedItem == null)
            {
                errorProvider1.SetError(CbNomArea, "");
                label2.Text = "Selecciona Area";

            }
            else
            {
                label2.Text = "";
                errorProvider1.Clear();
            }
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtNombreArea.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtNombreArea, "Ingresar Nombre del Area");
            }
            else
            {
                errorProvider2.Clear();
            }
            return ok;
        }

        private void BorrarMensaje()
        {
            errorProvider1.SetError(CbNomArea, "");
            errorProvider2.SetError(txtNombreArea, "");
        }

        private void ModificarArea_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CbNomArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbNomArea.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ModificarJerarquia : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form j1;
        public ModificarJerarquia(Form j=null)
        {
            InitializeComponent();
            j1 = j;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            j1.Enabled = true;
            j1.Focus();
            this.Dispose();
        }

        private void ModificarJerarquia_Load(object sender, EventArgs e)
        {
            try
            {
                CbJera.DataSource = null;
                OracleCommand comandojera = new OracleCommand("seleccionarJerarquia", ora);
                comandojera.CommandType = CommandType.StoredProcedure;
                comandojera.Parameters.Add("curJera", OracleType.Cursor).Direction = ParameterDirection.Output;
                var rjera = comandojera.ExecuteReader();
                List<object> listjera = new List<object>();
                while (rjera.Read())
                {
                    listjera.Add(new { idjera = rjera.GetValue(0), nombrejera = rjera.GetValue(1), desjera= rjera.GetValue(2) });
                }
                CbJera.DataSource = listjera;
                CbJera.ValueMember = "idjera";
                CbJera.DisplayMember = "nombrejera";
                CbJera.SelectedValue = "";
                CbJera.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnModificarJera_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidarCampos())
            {
                try
                {
                    OracleCommand comando = new OracleCommand("actualizarJerarquia", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_id_jerarquia", OracleType.Number).Value = Convert.ToInt32(CbJera.SelectedValue);
                    comando.Parameters.Add("v_nombre", OracleType.VarChar).Value = txtModificarNomJ.Text;
                    comando.Parameters.Add("v_porcentaje_importancia", OracleType.VarChar).Value = txtModiPorcentajeJera.Text;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Jerarquia ha sido actualizada exitosamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("La Jerarquia no sido ha actualizada");
                }
            }
            else
            {
                MessageBox.Show("Datos no se han Ingresado Correctamente");
            }
            if (CbJera.SelectedItem == null)
            {
                errorProvider1.SetError(CbJera, "");
                label4.Text = "Selecciona Jerarquia";

            }
            else
            {
                label4.Text = "";
                errorProvider1.Clear();
            }
        }
        private void CbJera_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtModificarNomJ.Text = ((dynamic)CbJera.SelectedItem).nombrejera;
            txtModiPorcentajeJera.Text = ((dynamic)CbJera.SelectedItem).desjera.ToString();
        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtModificarNomJ.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtModificarNomJ, "Ingresar Nombre");
            }
            else
            {
                errorProvider2.Clear();
            }
            if (txtModiPorcentajeJera.Text == "")
            {
                ok = false;
                errorProvider3.SetError(txtModiPorcentajeJera, "Ingrese porcentaje de jerarquia");
            }
            else
            {
                errorProvider3.Clear();
            }
            return ok;
        }

        private void BorrarMensaje()
        {
            errorProvider2.SetError(txtModificarNomJ, "");
            errorProvider1.SetError(CbJera, "");
            errorProvider3.SetError(txtModiPorcentajeJera, "");
        }
       
        private void CbJera_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbJera.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ModificarJerarquia_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

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
    public partial class CrearJerarquia : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form j1;
        public CrearJerarquia(Form j=null)
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarJera_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidarCampos())
            {
                try
                {
                    OracleCommand comando = new OracleCommand("insertarJerarquia", ora);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("p_nombreJera", OracleType.VarChar).Value = txtNombreJera.Text;
                    comando.Parameters.Add("p_porcentajeImportancia", OracleType.VarChar).Value = txtPorcentajeJera.Text;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Jerarquia creada correctamente");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error, Jerarquia no ha sido creada.");
                }
            }
            else
            {
                MessageBox.Show("Datos no se han Ingresado Correctamente");
            }
        }

        private void CrearJerarquia_Load(object sender, EventArgs e)
        {

        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtNombreJera.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombreJera, "Ingresar Nombre");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtPorcentajeJera.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtPorcentajeJera, "Ingresar Numero de Importacia");
            }
            else
            {
                errorProvider2.Clear();
            }
            return ok;
        }
        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtNombreJera, "");
            errorProvider1.SetError(txtPorcentajeJera, "");
        }

        private void txtNombreJera_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtPorcentajeJera_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void CrearJerarquia_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

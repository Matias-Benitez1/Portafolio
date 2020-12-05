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
    public partial class CrearRoles : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form f;

        public CrearRoles(Form d=null)
        {
            InitializeComponent();
            f = d;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCrearRol_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidarCampos())
            {
                try
                {
                    OracleCommand comando = new OracleCommand("insertarRoles", ora);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("p_nombre", OracleType.VarChar).Value = tbRol.Text;
                    comando.Parameters.Add("p_descripcion", OracleType.VarChar).Value = txtDesRol.Text;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Rol creado correctamente");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error, Rol no creado.");
                }
            }
            else
            {
                MessageBox.Show("Datos no se han Ingresado Correctamente");
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            f.Enabled = true;
            f.Focus();
            this.Dispose();
        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (tbRol.Text == "")
            {
                ok = false;
                errorProvider1.SetError(tbRol, "Ingresar Nombre del Rol");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtDesRol.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtDesRol, "Ingresar Descripcion Rol");
            }
            else
            {
                errorProvider2.Clear();
            }
            return ok;
        }
        private void BorrarMensaje()
        {
            errorProvider1.SetError(tbRol, "");
            errorProvider1.SetError(txtDesRol, "");
        }

        private void tbRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtDesRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void CrearRoles_Load(object sender, EventArgs e)
        {

        }

        private void CrearRoles_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); 
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

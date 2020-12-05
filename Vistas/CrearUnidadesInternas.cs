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
using ProyectoOra;

namespace ProyectoOra
{
    public partial class CrearUnidadesInternas : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form d2;
        public CrearUnidadesInternas(Form d)
        {
            InitializeComponent();
            d2 = d;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            d2.Enabled = true;
            d2.Focus();
            this.Dispose();
        }

        private void CrearUnidadesInternas_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarUI_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidarCampos())
            {
                try
                {
                    OracleCommand comando = new OracleCommand("insertarUnidadInterna", ora);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("p_nombre", OracleType.VarChar).Value = txtNombreUI.Text;
                    comando.Parameters.Add("p_descripcion", OracleType.VarChar).Value = txtDesUI.Text;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Unidad Interna creada correctamente");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error, Unidad Interna no ha sido creada.");
                }
            }
            else
            {
                MessageBox.Show("Datos no se han Ingresado Correctamente");
            }

        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtNombreUI.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombreUI, "Ingresar Nombre de Unidad Interna");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtDesUI.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtDesUI, "Ingresar Descripción Unidad Interna");
            }
            else
            {
                errorProvider2.Clear();
            }
            return ok;
        }
        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtNombreUI, "");
            errorProvider1.SetError(txtDesUI, "");
        }

        private void txtNombreUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);      
        }

        private void txtDesUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void CrearUnidadesInternas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

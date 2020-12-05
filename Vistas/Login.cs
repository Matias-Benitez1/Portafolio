using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Runtime.InteropServices;

namespace ProyectoOra
{
    public partial class Login : Form
    {

        OracleConnection ora = Conectar.Conexion;
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
                OracleCommand comando = new OracleCommand("SELECT ID_ROl FROM USUARIO WHERE USER_NAME = :user_name AND CONTRASEÑA = encriptar(:contraseña) AND ID_ROL IN (22,24) ", ora);
                comando.Parameters.AddWithValue(":user_name", tbusuario.Text);
                comando.Parameters.AddWithValue(":contraseña", tbclave.Text);
                
               
                
                OracleDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    MessageBox.Show("Se ha ingresado correctamente");
                    Main formulario = new Main(this);
                    Variable.id_rol = lector.GetInt32(0);
                    formulario.Show();
                    formulario.FormClosed += Logout;
                    this.Hide();
                }
            else
            {
                MessageBox.Show("No se pudo ingresar correctamente");

            }
        }
        private void Logout (object Sender, FormClosedEventArgs e)
        {
            tbusuario.Clear();
            tbclave.Clear();
            this.Show();
            tbusuario.Focus();
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE = LOCALHOST ; PASSWORD= lol123; USER ID = Admin;");
            
            MessageBox.Show("Conexion Exitosa");
        }

        private void tbusuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir de la aplicación?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void tbusuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tbclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbclave_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tbclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if(e.KeyChar==Convert.ToChar(Keys.Enter))
               
            {
                
                OracleCommand comando = new OracleCommand("SELECT ID_ROL FROM usuario WHERE USER_NAME = :user_name AND CONTRASEÑA = encriptar(:contraseña)  AND ID_ROL IN (22,24) ", ora);

                comando.Parameters.AddWithValue(":user_name", tbusuario.Text);
                comando.Parameters.AddWithValue(":contraseña", tbclave.Text);

                OracleDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    MessageBox.Show("Se ha ingresado correctamente");
                    Main formulario = new Main(this);
                    Variable.id_rol = lector.GetInt32(0);
                    formulario.Show();
                    formulario.FormClosed += Logout;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se pudo :(");

                }

                
            }*/
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace ProyectoOra
{
    public partial class Main : Form
    {
        OracleConnection ora = Conectar.Conexion;
        /*int tipoUsuario;*/
        Login m;
        public Main(Login m = null)
        {
            InitializeComponent();
            this.m = m;
            lblTitulo.Text += " " + m.tbusuario.Text;

           /*tipoUsuario = Variable.id_rol;

            if (tipoUsuario == 22)
            {
                this.btnPersonas.Visible = true;
                this.btnTareas.Visible = true;
                
            }
            else if (tipoUsuario !=22)
            {
                this.btnjera.Visible = false;
                this.btnFT.Visible = false;
                this.btnMR.Visible = false;
                this.btnUinternas.Visible = false;
                this.btnAreas.Visible = false;
            }
       
            if (tipoUsuario == 24)
            {
                this.btnjera.Visible = true;
                this.btnFT.Visible = true;
                this.btnMR.Visible = true;
                this.btnUinternas.Visible = true;
                this.btnAreas.Visible = true;
                
            }
            else if(tipoUsuario !=24)
            {
                this.btnPersonas.Visible = false;
                this.btnTareas.Visible = false;
            }*/
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAreas.Enabled = false;
            btnFT.Enabled = false;
            btnjera.Enabled = false;
            btnUinternas.Enabled = false;
            btnTareas.Enabled = false;
            btnMR.Enabled = false;
            btnPersonas.Enabled = false;
            if (Variable.id_rol == 22)
            {
                btnPersonas.Enabled = true;
                btnAreas.Enabled = true;
                btnTareas.Enabled = true;
                btnjera.Enabled = true;
            }
            else 
            {
                btnFT.Enabled = true;
                btnMR.Enabled = true;
                btnUinternas.Enabled = true;
            }
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE = LOCALHOST ; PASSWORD= system; USER ID = system;");
            MessageBox.Show("Conexion Exitosa");
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cerrar Sesion?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void pbmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void btnTareas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmRoles(this));
        }

        private void panelContenedor_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnUinternas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmUnidadesInternas(this));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmArea(this));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmFlujoTareas(this));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmJerarquia(this));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmResumen());
        }
        private void btnPersonas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmUsuarios(this));
        }
        private void panelContenedor_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cerrar Sesion?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}

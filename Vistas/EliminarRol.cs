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
    public partial class EliminarRol : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form f3;
        public EliminarRol(Form f)
        {
            InitializeComponent();
            f3 = f;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            f3.Enabled = true;
            f3.Focus();
            this.Dispose();
        }

        private void EliminarRol_Load(object sender, EventArgs e)
        {
            try
            {
            CbEliRol.DataSource = null;
            OracleCommand comandorol = new OracleCommand("seleccionarRol", ora);
            comandorol.CommandType = CommandType.StoredProcedure;
            comandorol.Parameters.Add("curRol", OracleType.Cursor).Direction = ParameterDirection.Output;
            var rrol = comandorol.ExecuteReader();
            List<object> listrol = new List<object>();
            while (rrol.Read())
            {
                listrol.Add(new { idrol = rrol.GetValue(0), nombrerol = rrol.GetValue(1) });
            }
            CbEliRol.DataSource = listrol;
            CbEliRol.ValueMember = "idrol";
            CbEliRol.DisplayMember = "nombrerol";
            CbEliRol.SelectedValue = "";
            CbEliRol.Text= "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidarCampos())
            {
                try
                {
                    OracleCommand comando = new OracleCommand("EliminarRoles", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_id", OracleType.Number).Value = Convert.ToInt32(CbEliRol.SelectedValue);
                    comando.ExecuteNonQuery();
                    MessageBox.Show(" Rol eliminado exitosamente. ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(" Error, no se pudo eliminar Rol. ");
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado Rol");
            }
            if (CbEliRol.SelectedItem == null)
            {
                errorProvider1.SetError(CbEliRol, "");
                label3.Text = "Selecciona Rol";
            }
            else
            {
                label3.Text = "";
                errorProvider1.Clear();
            }
        }
        private void BorrarMensaje()
        {
            errorProvider1.SetError(CbEliRol, "");

        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (CbEliRol.Text == "")
            {
                ok = false;
                errorProvider2.SetError(CbEliRol, "");
            }
            else
            {
                errorProvider2.Clear();
            }
            return ok;
        }


        private void EliminarRol_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); 
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CbEliRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbEliRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}

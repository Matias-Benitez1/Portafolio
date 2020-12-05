using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OracleClient;

namespace ProyectoOra
{
    public partial class EliminarUsuarios : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form l1;

        public EliminarUsuarios(Form l=null)
        {
            InitializeComponent();
            l1 = l;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            l1.Enabled = true;
            l1.Focus();
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmEliminar_Load(object sender, EventArgs e)
        {
            try
            {
                CbEliusu.DataSource = null;
                OracleCommand comandousu = new OracleCommand("seleccionarUsuario", ora);
                comandousu.CommandType = CommandType.StoredProcedure;
                comandousu.Parameters.Add("curUsu", OracleType.Cursor).Direction = ParameterDirection.Output;
                var rusu = comandousu.ExecuteReader();
                List<object> listusu = new List<object>();
                while (rusu.Read())
                {
                    listusu.Add(new { idusu = rusu.GetValue(0), nombreusu = rusu.GetValue(1), apeusu = rusu.GetValue(2), areausu = rusu.GetValue(3), rolusu = rusu.GetValue(4), unidadusu = rusu.GetValue(5), jerausu = rusu.GetValue(6), username = rusu.GetValue(7),
                    contraseñausu = rusu.GetValue(8) });
                }
                CbEliusu.DataSource = listusu;
                CbEliusu.ValueMember = "idusu";
                CbEliusu.DisplayMember = "nombreusu";
                CbEliusu.SelectedValue = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btneliminarusu_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidarCampos())
            {
                try
                {
                    OracleCommand comando = new OracleCommand("EliminarUsuario", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_id", OracleType.Number).Value = Convert.ToInt32(CbEliusu.SelectedValue);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Usuario eliminado exitosamente!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("El usuario no sido ha Eliminado.");
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado Usuario");
            }
            if (CbEliusu.SelectedItem == null)
            {
                errorProvider1.SetError(CbEliusu, "");
                label2.Text = "Selecciona Usuario";
            }
            else
            {
                label2.Text = "";
                errorProvider1.Clear();
            }
        }
        private void BorrarMensaje()
        {
            errorProvider1.SetError(CbEliusu, "");

        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (CbEliusu.Text == "")
            {
                ok = false;
                errorProvider2.SetError(CbEliusu, "");
            }
            else
            {
                errorProvider2.Clear();
            }
            return ok;
        }
        private void CbEliusu_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbEliusu.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}

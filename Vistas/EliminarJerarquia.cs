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
    public partial class EliminarJerarquia : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form j1;
        public EliminarJerarquia(Form j=null)
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

        private void EliminarJerarquia_Load(object sender, EventArgs e)
        {
            try
            {
                CbJerarquia.DataSource = null;
                OracleCommand comandorol = new OracleCommand("seleccionarJerarquia", ora);
                comandorol.CommandType = CommandType.StoredProcedure;
                comandorol.Parameters.Add("curJera", OracleType.Cursor).Direction = ParameterDirection.Output;
                var rjera = comandorol.ExecuteReader();
                List<object> listrol = new List<object>();
                while (rjera.Read())
                {
                    listrol.Add(new { idjera = rjera.GetValue(0), nombrejera = rjera.GetValue(1), porcentaje = rjera.GetValue(2) });
                }
                CbJerarquia.DataSource = listrol;
                CbJerarquia.ValueMember = "idjera";
                CbJerarquia.DisplayMember = "nombrejera";
                CbJerarquia.SelectedValue = "";
                CbJerarquia.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btneliminarJera_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidarCampos())
            {
                try
                {
                    OracleCommand comando = new OracleCommand("EliminarJerarquia", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_id", OracleType.Number).Value = Convert.ToInt32(CbJerarquia.SelectedValue);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Jerarquia eliminada exitosamente!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("La jerarquia no sido ha Eliminada.");
                }
                
            }
            else
            {
                MessageBox.Show("No ha selecccionado Jerarquia");
            }
            ValidarCampos();
            if (CbJerarquia.SelectedItem == null)
            {
                errorProvider1.SetError(CbJerarquia, "");
                label2.Text = "Selecciona Jerarquia";
            }
            else
            {
                label2.Text = "";
                errorProvider1.Clear();
            }
        }
        private void BorrarMensaje()
        {
            errorProvider1.SetError(CbJerarquia, "");

        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (CbJerarquia.Text == "")
            {
                ok = false;
                errorProvider2.SetError(CbJerarquia, "");
            }
            else
            {
                errorProvider2.Clear();
            }
            return ok;
        }

        private void CbJerarquia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbJerarquia.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void EliminarJerarquia_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

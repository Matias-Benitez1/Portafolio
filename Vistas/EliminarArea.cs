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
    public partial class EliminarArea : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form q1;
        public EliminarArea(Form q=null)
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

        private void EliminarArea_Load(object sender, EventArgs e)
        {
            try
            {
                OracleCommand comandoarea = new OracleCommand("seleccionarArea", ora);
                comandoarea.CommandType = CommandType.StoredProcedure;
                comandoarea.Parameters.Add("curArea", OracleType.Cursor).Direction = ParameterDirection.Output;
                var rarea = comandoarea.ExecuteReader();
                List<object> listarea = new List<object>();
                while (rarea.Read())
                {
                    listarea.Add(new { idarea = rarea.GetValue(0), nombrearea = rarea.GetValue(1) });
                }
                CbEliArea.DataSource = listarea;
                CbEliArea.ValueMember = "idarea";
                CbEliArea.DisplayMember = "nombrearea";
                CbEliArea.SelectedValue = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnEliminarArea_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidarCampos())
            {
                try
                {
                    OracleCommand comando = new OracleCommand("EliminarAreas", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_id", OracleType.Number).Value = Convert.ToInt32(CbEliArea.SelectedValue);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Area eliminada exitosamente!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("La Area no sido ha Eliminada.");
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado el Area");
            }
            ValidarCampos();
            if (CbEliArea.SelectedItem == null)
            {
                errorProvider1.SetError(CbEliArea, "");
                label1.Text = "Selecciona Area";
            }
            else
            {
                label1.Text = "";
                errorProvider1.Clear();
            }
        }
        private void BorrarMensaje()
        {
            errorProvider1.SetError(CbEliArea, "");

        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (CbEliArea.Text == "")
            {
                ok = false;
                errorProvider2.SetError(CbEliArea, "");
            }
            else
            {
                errorProvider2.Clear();
            }
            return ok;
        }

        private void EliminarArea_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CbEliArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbEliArea.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}

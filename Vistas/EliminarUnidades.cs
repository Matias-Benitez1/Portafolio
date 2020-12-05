using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
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
    public partial class EliminarUnidades : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form d2;
        public EliminarUnidades(Form d)
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

        private void EliminarUnidades_Load(object sender, EventArgs e)
        {
            try
            {
            CbUnidad.DataSource = null;
            OracleCommand comando = new OracleCommand("seleccionarUnidadInterna", ora);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("curUnidad", OracleType.Cursor).Direction = ParameterDirection.Output;
            var r = comando.ExecuteReader();
            List<object> list = new List<object>();
            while (r.Read())
            {
                list.Add(new { id = r.GetValue(0), nombre = r.GetValue(1), des = r.GetValue(2) });
            }
            CbUnidad.DataSource = list;
            CbUnidad.ValueMember = "id";
            CbUnidad.DisplayMember = "nombre";
            CbUnidad.SelectedValue = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnEliminarUI_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidarCampos())
            {
                try
                {
                    OracleCommand comando = new OracleCommand("EliminarUnidadInterna", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_id", OracleType.Number).Value = Convert.ToInt32(CbUnidad.SelectedValue);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Unidad Interna eliminada exitosamente!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("La Unidad Interna no sido ha Eliminada.");
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado Unidad Interna");
            }
            if (CbUnidad.SelectedItem == null)
            {
                errorProvider1.SetError(CbUnidad, "");
                label1.Text = "Selecciona Unindad Interna";
            }
            else
            {
                label1.Text = "";
                errorProvider1.Clear();
            }
        }
        private void BorrarMensaje()
        {
            errorProvider1.SetError(CbUnidad, "");

        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (CbUnidad.Text == "")
            {
                ok = false;
                errorProvider2.SetError(CbUnidad, "");
            }
            else
            {
                errorProvider2.Clear();
            }
            return ok;
        }
            
        

        private void CbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbUnidad.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void EliminarUnidades_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

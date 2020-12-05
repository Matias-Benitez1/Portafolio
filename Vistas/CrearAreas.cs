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
    public partial class CrearAreas : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form q1;
        public CrearAreas(Form q=null)
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

        private void CrearAreas_Load(object sender, EventArgs e)
        {
            try
            {
                CbAreaIn.DataSource = null;
                OracleCommand comando = new OracleCommand("seleccionarUnidadInterna", ora);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("curUnidad", OracleType.Cursor).Direction=ParameterDirection.Output;
                var r = comando.ExecuteReader();
                List<object> list = new List<object>();
                while (r.Read())
                {
                    list.Add(new { id = r.GetValue(0), nombre = r.GetValue(1), des = r.GetValue(2) });
                }
                CbAreaIn.DataSource = list;
                CbAreaIn.ValueMember = "id";
                CbAreaIn.DisplayMember = "nombre";
                CbAreaIn.SelectedItem = null;
                CbAreaIn.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnGuardarArea_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidarCampos())
            {
                try
                {
                    OracleCommand comando = new OracleCommand("insertarAreas", ora);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("p_nombreArea", OracleType.VarChar).Value = txtArea.Text;
                    comando.Parameters.Add("p_unidadesInternas", OracleType.VarChar).Value = CbAreaIn.SelectedValue;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Area creada correctamente");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Error, Area no ha sido creada.");
                }
            }
            else
            {
                MessageBox.Show("Datos no se han Ingresado Correctamente");
            }
            ValidarCampos();
            if (CbAreaIn.SelectedItem == null)
            {
                errorProvider2.SetError(CbAreaIn, "");
                lbl1.Text = "Selecciona Unidad Interna";
                
            }
            else
            {
                lbl1.Text = "";
                errorProvider2.Clear();
            }
        }

        private void txtArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            
        }
        private bool ValidarCampos ()
        {
            bool ok = true;
            if (txtArea.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtArea, "Ingresar Nombre");
            }
            else
            {
                errorProvider1.Clear();
            }
            return ok;
        }
        private void BorrarMensaje ()
        {
            errorProvider1.SetError(txtArea, "");
        }

        private void CrearAreas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CbAreaIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbAreaIn.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}

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
    public partial class ModificarUnidades : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form d2;
        public ModificarUnidades(Form d)
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

        private void ModificarUnidades_Load(object sender, EventArgs e)
        {
            try
            {
                CbModiUI.DataSource = null;
                OracleCommand comando = new OracleCommand("seleccionarUnidadInterna", ora);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("curUnidad", OracleType.Cursor).Direction = ParameterDirection.Output;
                var r = comando.ExecuteReader();
                List<object> list = new List<object>();
                while (r.Read())
                {
                    list.Add(new { id = r.GetValue(0), nombre = r.GetValue(1), des = r.GetValue(2) });
                }
                CbModiUI.DataSource = list;
                CbModiUI.ValueMember = "id";
                CbModiUI.DisplayMember = "nombre";
                CbModiUI.SelectedValue = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CbModiUI_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtModiUI.Text = ((dynamic)CbModiUI.SelectedItem).nombre;
            txtDesUI.Text = ((dynamic)CbModiUI.SelectedItem).des;
        }

        private void btnGuardarModiUI_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidarCampos())
            {
                try
                {
                    OracleCommand comando = new OracleCommand("actualizarUnidadInterna", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_id_unidadinterna", OracleType.Number).Value = Convert.ToInt32(CbModiUI.SelectedValue);
                    comando.Parameters.Add("v_nombre_unidadinterna", OracleType.VarChar).Value = txtModiUI.Text;
                    comando.Parameters.Add("v_descripcion_unidadinterna", OracleType.VarChar).Value = txtDesUI.Text;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Unidad Interna ha sido actualizada exitosamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("La Unidad Interna no sido ha actualizada");
                }
            }
            else
            {
                MessageBox.Show("Datos no se han Ingresado Correctamente");
            }
            ValidarCampos();
            if (CbModiUI.SelectedItem == null)
            {
                errorProvider1.SetError(CbModiUI, "");
                label4.Text = "Selecciona Unidad Interna";

            }
            else
            {
                label4.Text = "";
                errorProvider1.Clear();
            }
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtModiUI.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtModiUI, "Ingresar Nombre");
            }
            else
            {
                errorProvider2.Clear();
            }
            if (txtDesUI.Text == "")
            {
                ok = false;
                errorProvider3.SetError(txtDesUI, "Ingresar Descripción");
            }
            else
            {
                errorProvider3.Clear();
            }
            return ok;
        }

        private void BorrarMensaje()
        {
            errorProvider1.SetError(CbModiUI, "");
            errorProvider2.SetError(txtModiUI, "");
            errorProvider3.SetError(txtDesUI, "");
        }
          

        private void CbModiUI_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbModiUI.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ModificarUnidades_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

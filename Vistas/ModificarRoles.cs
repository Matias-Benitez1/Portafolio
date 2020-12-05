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
using System.Linq.Expressions;

namespace ProyectoOra
{
    public partial class ModificarRoles : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form f2;
        public ModificarRoles(Form f)
        {
            InitializeComponent();
            f2 = f;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnATsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            f2.Enabled = true;
            f2.Focus();
            this.Dispose();
        }

        private void ModificarRoles_Load(object sender, EventArgs e)
        {
            try
            {
                CbActRol.DataSource = null;
                OracleCommand comandorol = new OracleCommand("seleccionarRol", ora);
                comandorol.CommandType = CommandType.StoredProcedure;
                comandorol.Parameters.Add("curRol", OracleType.Cursor).Direction = ParameterDirection.Output;
                var rrol = comandorol.ExecuteReader();
                List<object> listrol = new List<object>();
                while (rrol.Read())
                {
                    listrol.Add(new { idrol = rrol.GetValue(0), nombrerol = rrol.GetValue(1), des = rrol.GetValue(2) });
                }
                CbActRol.DataSource = listrol;
                CbActRol.ValueMember = "idrol";
                CbActRol.DisplayMember = "nombrerol";
                CbActRol.SelectedValue = "";
                CbActRol.Text = "";
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
                    OracleCommand comando = new OracleCommand("actualizarRol", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_id_rol", OracleType.Number).Value = Convert.ToInt32(CbActRol.SelectedValue);
                    comando.Parameters.Add("v_nombre_rol", OracleType.VarChar).Value = txtroles.Text;
                    comando.Parameters.Add("v_descripcion", OracleType.VarChar).Value = txtDesRol.Text;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Rol actualizado exitosamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El rol no se ha actualizado");

                }
            }
            else
            {
                MessageBox.Show("Datos no se han Ingresado Correctamente");
            }
            if (CbActRol.SelectedItem == null)
            {
                errorProvider2.SetError(CbActRol, "");
                label5.Text = "Selecciona Rol";

            }
            else
            {
                label5.Text = "";
                errorProvider2.Clear();
            }
        }

        private void CbActRol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtroles.Text = ((dynamic)CbActRol.SelectedItem).nombrerol;
            txtDesRol.Text = ((dynamic)CbActRol.SelectedItem).des;
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtroles.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtroles, "Ingresar Nombre");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtDesRol.Text =="")
            {
                ok = false;
                errorProvider3.SetError(txtDesRol, "Ingresar Descripción");
            }
            else
            {
                errorProvider3.Clear();
            }
            return ok;
        }

        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtroles, "");
            errorProvider2.SetError(CbActRol, "");
            errorProvider3.SetError(txtDesRol, "");
        }

        private void ModificarRoles_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); 
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CbActRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbActRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

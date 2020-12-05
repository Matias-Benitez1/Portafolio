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
    public partial class ModificarUsuarios : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form l1;

        public ModificarUsuarios(Form l=null)
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

        private void frmActualizar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidarCampos())
            {
                try
                {
                    OracleCommand comando = new OracleCommand("actualizarUsuario", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_id_usuario", OracleType.Number).Value = Convert.ToInt32(CbSelectUsu.SelectedValue);
                    comando.Parameters.Add("v_nombre_usu", OracleType.VarChar).Value = txtnombresModi.Text;
                    comando.Parameters.Add("v_apellidos", OracleType.VarChar).Value = txtapellidosModi.Text;
                    comando.Parameters.Add("p_id_area", OracleType.VarChar).Value = Convert.ToInt32(CBAreaModi.SelectedValue);
                    comando.Parameters.Add("p_id_rol", OracleType.VarChar).Value = Convert.ToInt32(CBRolesModi.SelectedValue);
                    comando.Parameters.Add("p_id_unidadinterna", OracleType.VarChar).Value = Convert.ToInt32(CBUnidadModi.SelectedValue);
                    comando.Parameters.Add("p_id_jerarquia", OracleType.VarChar).Value = Convert.ToInt32(CBJerarquiaModi.SelectedValue);
                    comando.Parameters.Add("p_user_name", OracleType.VarChar).Value = txtMoUser.Text;
                    comando.Parameters.Add("p_contraseña", OracleType.VarChar).Value = txtMoContra.Text;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Usuario actualizado exitosamente!");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("El usuario no sido ha actualizado");

                }
            }
            else
            {
                MessageBox.Show("Datos no se han Ingresado Correctamente");
            }
            if (CbSelectUsu.SelectedItem == null)
            {
                errorProvider1.SetError(CbSelectUsu, "");
                label11.Text = "Selecciona Usuario";

            }
            else
            {
                label11.Text = "";
                errorProvider1.Clear();
            }
            if (CBAreaModi.SelectedItem == null)
            {
                errorProvider6.SetError(CBAreaModi, "");
                label12.Text = "Selecciona Area";

            }
            else
            {
                label12.Text = "";
                errorProvider6.Clear();
            }
            if (CBRolesModi.SelectedItem == null)
            {
                errorProvider7.SetError(CBRolesModi, "");
                label13.Text = "Selecciona Rol";

            }
            else
            {
                label13.Text = "";
                errorProvider7.Clear();
            }
            if (CBUnidadModi.SelectedItem == null)
            {
                errorProvider8.SetError(CBUnidadModi, "");
                label14.Text = "Selecciona Unidad Interna";

            }
            else
            {
                label14.Text = "";
                errorProvider8.Clear();
            }
            if (CBJerarquiaModi.SelectedItem == null)
            {
                errorProvider9.SetError(CBJerarquiaModi, "");
                label15.Text = "Selecciona Jerarquia";

            }
            else
            {
                label15.Text = "";
                errorProvider9.Clear();
            }
        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtnombresModi.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtnombresModi, "Ingrese Nombre");
            }
            else
            {
                errorProvider2.Clear();
            }
            if (txtapellidosModi.Text == "")
            {
                ok = false;
                errorProvider3.SetError(txtapellidosModi, "Ingrese Apellidos");
            }
            else
            {
                errorProvider3.Clear();
            }
            if (txtMoUser.Text == "")
            {
                ok = false;
                errorProvider4.SetError(txtMoUser, "Ingrese Usuario");
            }
            else
            {
                errorProvider4.Clear();
            }
            if (txtMoContra.Text == "")
            {
                ok = false;
                errorProvider5.SetError(txtMoContra, "Ingrese Contraseña");
            }
            else
            {
                errorProvider5.Clear();
            }
            return ok;
        }

        private void BorrarMensaje()
        {
            errorProvider1.SetError(CbSelectUsu, "");
            errorProvider2.SetError(txtnombresModi, "");
            errorProvider3.SetError(txtapellidosModi, "");
            errorProvider4.SetError(txtMoUser, "");
            errorProvider5.SetError(txtMoContra, "");
        }
          

        private void frmActualizar_Load(object sender, EventArgs e)
        {
            try
            {
                CbSelectUsu.DataSource = null;
                OracleCommand comandousu = new OracleCommand("seleccionarUsuario", ora);
                comandousu.CommandType = CommandType.StoredProcedure;
                comandousu.Parameters.Add("curUsu", OracleType.Cursor).Direction = ParameterDirection.Output;
                var rusu = comandousu.ExecuteReader();
                List<object> listusu = new List<object>();
                while (rusu.Read())
                {
                    listusu.Add(new { idusu = rusu.GetValue(0), nombreusu = rusu.GetValue(1), apeusu = rusu.GetValue(2), areausu = rusu.GetValue(3), rolusu = rusu.GetValue(4), unidadusu = rusu.GetValue(5), jerausu = rusu.GetValue(6), username = rusu.GetValue(7)
                    , contraseñausu = rusu.GetValue(8)});
                }
                CbSelectUsu.DataSource = listusu;
                CbSelectUsu.ValueMember = "idusu";
                CbSelectUsu.DisplayMember = "nombreusu";
                CbSelectUsu.SelectedValue = "";


                CBAreaModi.DataSource = null;
                OracleCommand comandoarea = new OracleCommand("seleccionarArea", ora);
                comandoarea.CommandType = CommandType.StoredProcedure;
                comandoarea.Parameters.Add("curArea", OracleType.Cursor).Direction = ParameterDirection.Output;
                var rarea = comandoarea.ExecuteReader();
                List<object> listarea = new List<object>();
                while (rarea.Read())
                {
                    listarea.Add(new { idarea = rarea.GetValue(0), nombrearea = rarea.GetValue(1) });
                }
                CBAreaModi.DataSource = listarea;
                CBAreaModi.ValueMember = "idarea";
                CBAreaModi.DisplayMember = "nombrearea";
                CBAreaModi.SelectedValue = "";



                CBUnidadModi.DataSource = null;
                OracleCommand comando = new OracleCommand("seleccionarUnidadInterna", ora);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("curUnidad", OracleType.Cursor).Direction = ParameterDirection.Output;
                var r = comando.ExecuteReader();
                List<object> list = new List<object>();
                while (r.Read())
                {
                    list.Add(new { id = r.GetValue(0), nombre = r.GetValue(1), des = r.GetValue(2) });
                }
                CBUnidadModi.DataSource = list;
                CBUnidadModi.ValueMember = "id";
                CBUnidadModi.DisplayMember = "nombre";
                CBUnidadModi.SelectedValue = "";




                CBRolesModi.DataSource = null;
                OracleCommand comandorol = new OracleCommand("seleccionarRol", ora);
                comandorol.CommandType = CommandType.StoredProcedure;
                comandorol.Parameters.Add("curRol", OracleType.Cursor).Direction = ParameterDirection.Output;
                var rrol = comandorol.ExecuteReader();
                List<object> listrol = new List<object>();
                while (rrol.Read())
                {
                    listrol.Add(new { idrol = rrol.GetValue(0), nombrerol = rrol.GetValue(1) });
                }
                CBRolesModi.DataSource = listrol;
                CBRolesModi.ValueMember = "idrol";
                CBRolesModi.DisplayMember = "nombrerol";
                CBRolesModi.SelectedValue = "";



                CBJerarquiaModi.DataSource = null;
                OracleCommand comandojera = new OracleCommand("seleccionarJerarquia", ora);
                comandojera.CommandType = CommandType.StoredProcedure;
                comandojera.Parameters.Add("curJera", OracleType.Cursor).Direction = ParameterDirection.Output;
                var rjera = comandojera.ExecuteReader();
                List<object> listjera = new List<object>();
                while (rjera.Read())
                {
                    listjera.Add(new { idjera = rjera.GetValue(0), nombrejera = rjera.GetValue(1) });
                }
                CBJerarquiaModi.DataSource = listjera;
                CBJerarquiaModi.ValueMember = "idjera";
                CBJerarquiaModi.DisplayMember = "nombrejera";
                CBJerarquiaModi.SelectedValue = "";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }

        private void CbSelectUsu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtnombresModi.Text = ((dynamic)CbSelectUsu.SelectedItem).nombreusu;
            txtapellidosModi.Text = ((dynamic)CbSelectUsu.SelectedItem).apeusu;
            CBAreaModi.SelectedValue = ((dynamic)CbSelectUsu.SelectedItem).areausu;
            CBRolesModi.SelectedValue = ((dynamic)CbSelectUsu.SelectedItem).rolusu;
            CBUnidadModi.SelectedValue = ((dynamic)CbSelectUsu.SelectedItem).unidadusu;
            CBJerarquiaModi.SelectedValue = ((dynamic)CbSelectUsu.SelectedItem).jerausu;
            txtMoUser.Text = ((dynamic)CbSelectUsu.SelectedItem).username;
            txtMoContra.Text = ((dynamic)CbSelectUsu.SelectedItem).contraseñausu;
        }

        private void CBAreaModi_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBAreaModi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CBRolesModi_SelectedIndexChanged(object sender, EventArgs e)
        {
           CBRolesModi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CBUnidadModi_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBUnidadModi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CBJerarquiaModi_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBJerarquiaModi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CbSelectUsu_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbSelectUsu.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}

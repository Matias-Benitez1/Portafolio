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
using System.Linq.Expressions;

namespace ProyectoOra
{
    public partial class CrearUsuarios : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form l1;

        public CrearUsuarios(Form l=null)
        {
            InitializeComponent();
            l1 = l;
        }
        private void frmAñadir_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            l1.Enabled = true;
            l1.Focus();
            this.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void frmAñadir_Load(object sender, EventArgs e)
        {

            try
            {
                CBArea.DataSource = null;
                OracleCommand comandoarea = new OracleCommand("seleccionarArea", ora);
                comandoarea.CommandType = CommandType.StoredProcedure;
                comandoarea.Parameters.Add("curArea", OracleType.Cursor).Direction = ParameterDirection.Output;
                var rarea = comandoarea.ExecuteReader();
                List<object> listarea = new List<object>();
                while (rarea.Read())
                {
                    listarea.Add(new { idarea = rarea.GetValue(0), nombrearea = rarea.GetValue(1) });
                }
                CBArea.DataSource = listarea;
                CBArea.ValueMember = "idarea";
                CBArea.DisplayMember = "nombrearea";
                CBArea.SelectedItem = null;
                CBArea.Text = "";



                Cbprobar.DataSource = null;
                OracleCommand comando = new OracleCommand("seleccionarUnidadInterna", ora);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("curUnidad", OracleType.Cursor).Direction = ParameterDirection.Output;
                var r = comando.ExecuteReader();
                List<object> list = new List<object>();
                while (r.Read())
                {
                    list.Add(new { id = r.GetValue(0), nombre = r.GetValue(1), des = r.GetValue(2) });
                }
                Cbprobar.DataSource = list;
                Cbprobar.ValueMember = "id";
                Cbprobar.DisplayMember = "nombre";
                Cbprobar.SelectedItem = null;
                Cbprobar.Text = "";




                CBRoles.DataSource = null;
                OracleCommand comandorol = new OracleCommand("seleccionarRol", ora);
                comandorol.CommandType = CommandType.StoredProcedure;
                comandorol.Parameters.Add("curRol", OracleType.Cursor).Direction = ParameterDirection.Output;
                var rrol = comandorol.ExecuteReader();
                List<object> listrol = new List<object>();
                while (rrol.Read())
                {
                    listrol.Add(new { idrol = rrol.GetValue(0), nombrerol = rrol.GetValue(1) });
                }
                CBRoles.DataSource = listrol;
                CBRoles.ValueMember = "idrol";
                CBRoles.DisplayMember = "nombrerol";
                CBRoles.SelectedItem = null;
                CBRoles.Text = "";



                CBJerarquia.DataSource = null;
                OracleCommand comandojera = new OracleCommand("seleccionarJerarquia", ora);
                comandojera.CommandType = CommandType.StoredProcedure;
                comandojera.Parameters.Add("curJera", OracleType.Cursor).Direction = ParameterDirection.Output;
                var rjera = comandojera.ExecuteReader();
                List<object> listjera = new List<object>();
                while (rjera.Read())
                {
                    listjera.Add(new { idjera = rjera.GetValue(0), nombrejera = rjera.GetValue(1) });
                }
                CBJerarquia.DataSource = listjera;
                CBJerarquia.ValueMember = "idjera";
                CBJerarquia.DisplayMember = "nombrejera";
                CBJerarquia.SelectedItem = null;
                CBJerarquia.Text = "";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidarCampos())
            {
                try
                {
                    OracleCommand comando = new OracleCommand("insertarUsuario", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_nombre", OracleType.VarChar).Value = txtnombres.Text;
                    comando.Parameters.Add("p_apellidos", OracleType.VarChar).Value = txtapellidos.Text;
                    comando.Parameters.Add("p_idarea", OracleType.VarChar).Value = CBArea.SelectedValue;
                    comando.Parameters.Add("p_idrol", OracleType.VarChar).Value = CBRoles.SelectedValue;
                    comando.Parameters.Add("p_idunidadinterna", OracleType.VarChar).Value = Cbprobar.SelectedValue;
                    comando.Parameters.Add("p_idjerarquia", OracleType.VarChar).Value = CBJerarquia.SelectedValue;
                    comando.Parameters.Add("p_user_name", OracleType.VarChar).Value = txtUsername.Text;
                    comando.Parameters.Add("p_contraseña", OracleType.VarChar).Value = txtContra.Text;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Usuario creado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, Usuario no ha sido creada.");
                }
            }
            else
            {
                MessageBox.Show("Datos no se han Ingresado Correctamente");
            }
            if (CBArea.SelectedItem == null)
            {
                errorProvider2.SetError(CBArea, "");
                label8.Text = "Selecciona Area";

            }
            else
            {
                label8.Text = "";
                errorProvider2.Clear();
            }
            if (CBRoles.SelectedItem == null)
            {
                errorProvider1.SetError(CBRoles, "");
                label9.Text = "Selecciona Rol";

            }
            else
            {
                label9.Text = "";
                errorProvider1.Clear();
            }
            if (Cbprobar.SelectedItem == null)
            {
                errorProvider2.SetError(Cbprobar, "");
                label10.Text = "Selecciona Unidad Interna";

            }
            else
            {
                label10.Text = "";
                errorProvider2.Clear();
            }
            if (CBJerarquia.SelectedItem == null)
            {
                errorProvider2.SetError(CBJerarquia, "");
                label11.Text = "Selecciona Jerarquia";

            }
            else
            {
                label11.Text = "";
                errorProvider2.Clear();
            }

        }

        private void txtrut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Letrasynumeros(e);
        }

        private void txtapellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Letrasynumeros(e);
        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtnombres.Text == "")
            {
                ok = false;
                errorProvider5.SetError(txtnombres, "Ingresar Nombre");
            }
            else
            {
                errorProvider5.Clear();
            }
            if (txtapellidos.Text == "")
            {
                ok = false;
                errorProvider6.SetError(txtapellidos, "Ingresar Apellido");
            }
            else
            {
                errorProvider6.Clear();
            }
            if (txtUsername.Text == "")
            {
                ok = false;
                errorProvider7.SetError(txtUsername, "Ingresar Username");
            }
            else
            {
                errorProvider7.Clear();
            }
            if (txtContra.Text == "")
            {
                ok = false;
                errorProvider8.SetError(txtContra, "Ingresar Contraseña");
            }
            else
            {
                errorProvider8.Clear();
            }
            return ok;
        }
        private void BorrarMensaje()
        {
            errorProvider5.SetError(txtnombres, "");
            errorProvider6.SetError(txtapellidos, "");
            errorProvider7.SetError(txtUsername, "");
            errorProvider8.SetError(txtContra, "");
        }

        private void CBArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBArea.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CBRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBRoles.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Cbprobar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cbprobar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CBJerarquia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBJerarquia.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOra
{
    public partial class ModificarFlujoTarea : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form h1;
        public ModificarFlujoTarea(Form h=null)
        {
            InitializeComponent();
            h1 = h;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            h1.Enabled = true;
            h1.Focus();
            this.Dispose();
        }

        private void ModificarFlujoTarea_Load(object sender, EventArgs e)
        {
            try
            {
                cbModi.DataSource = null;
                OracleCommand comandoft = new OracleCommand("seleccionarFlujodeTarea", ora);
                comandoft.CommandType = CommandType.StoredProcedure;
                comandoft.Parameters.Add("curFT", OracleType.Cursor).Direction = ParameterDirection.Output;
                var rft = comandoft.ExecuteReader();
                List<object> listft = new List<object>();
                while (rft.Read())
                {
                    listft.Add(new { idft = rft.GetValue(0),id_usu = rft.GetValue(1), nombreft = rft.GetValue(2), des = rft.GetValue(3)});
                }
                cbModi.DataSource = listft;
                cbModi.ValueMember = "idft";
                cbModi.DisplayMember = "nombreft";
                cbModi.SelectedValue = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }

        private void btnModificarDatos_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidarCampos())
            {
                try
                {
                    OracleCommand comando = new OracleCommand("actualizarFT", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_id_flujo", OracleType.Number).Value = Convert.ToInt32(cbModi.SelectedValue);
                    comando.Parameters.Add("v_nombre_ft", OracleType.VarChar).Value = txtNombreFTModi.Text;
                    comando.Parameters.Add("p_descripcion", OracleType.VarChar).Value = txtDesFTModi.Text;
                    //comando.Parameters.Add("p_terminado", OracleType.Char).Value = CbTerminadoModi.Checked ? 'T' : 'N';//
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Flujo de Tareas actualizado exitosamente!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("El Flujo de Tareas no se ha actualizado");
                }
            }
            else
            {
                MessageBox.Show("Datos no se han Ingresado Correctamente");
            }
            if (cbModi.SelectedItem == null)
            {
                errorProvider1.SetError(cbModi, "");
                label3.Text = "Selecciona Flujo de Tareas";

            }
            else
            {
                label3.Text = "";
                errorProvider1.Clear();
            }
        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtNombreFTModi.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtNombreFTModi, "Ingresar Nombre");
            }
            else
            {
                errorProvider2.Clear();
            }
            if (txtDesFTModi.Text == "")
            {
                ok = false;
                errorProvider3.SetError(txtDesFTModi, "Ingrese Descripción");
            }
            else
            {
                errorProvider3.Clear();
            }
            return ok;
        }

        private void BorrarMensaje()
        {
            errorProvider2.SetError(cbModi, "");
            errorProvider1.SetError(txtNombreFTModi, "");
            errorProvider3.SetError(txtDesFTModi, "");
        }
            
        

        private void cbModi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtNombreFTModi.Text = ((dynamic)cbModi.SelectedItem).nombreft;
            txtDesFTModi.Text = ((dynamic)cbModi.SelectedItem).des;
        }

        private void cbModi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbModi.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}

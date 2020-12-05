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
    public partial class CrearFTareas : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form h1;
        public CrearFTareas(Form h=null)
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

        private void CrearFTareas_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarFT_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidarCampos())
            {
                try
                {
                    OracleCommand comando = new OracleCommand("insertarFlujoDeTareas", ora);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("p_nombre", OracleType.VarChar).Value = txtNombreFT.Text;
                    comando.Parameters.Add("p_descripcion", OracleType.VarChar).Value = txtDesFT.Text;
                    //comando.Parameters.Add("p_Terminado", OracleType.Char).Value = CbTerminado.Checked ? 'T' : 'N';//
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Flujo de Tarea creada correctamente");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Error, Flujo de tarea no ha sido creada.");
                }
            }
            else
            {
                MessageBox.Show("Datos no se han Ingresado Correctamente");
            }
             
        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtNombreFT.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombreFT, "Ingresar Nombre de Flujo de Tareas");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtDesFT.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtDesFT, "Ingresar Descripción Flujo de Tareas");
            }
            else
            {
                errorProvider2.Clear();
            }
          
            return ok;
        }
        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtNombreFT, "");
            errorProvider2.SetError(txtDesFT, "");
        }

        private void txtNombreFT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtDesFT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        
       

    }
}

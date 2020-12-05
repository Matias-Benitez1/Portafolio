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
    public partial class EliminarFlujoTarea : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form h1;
        public EliminarFlujoTarea(Form h=null)
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

        private void EliminarFlujoTarea_Load(object sender, EventArgs e)
        {
            try
            {
                CbFlujoTarea.DataSource = null;
                OracleCommand comandorol = new OracleCommand("seleccionarFlujodeTarea", ora);
                comandorol.CommandType = CommandType.StoredProcedure;
                comandorol.Parameters.Add("curFT", OracleType.Cursor).Direction = ParameterDirection.Output;
                var rrol = comandorol.ExecuteReader();
                List<object> listrol = new List<object>();
                while (rrol.Read())
                {
                    listrol.Add(new { idFT = rrol.GetValue(0), idusu = rrol.GetValue(1), nombreFT = rrol.GetValue(2), desFT = rrol.GetValue(3),
                    horainicio = rrol.GetValue(4), horatermino = rrol.GetValue(5), porcenTF = rrol.GetValue(6), terminado = rrol.GetValue(7)});
                }
                CbFlujoTarea.DataSource = listrol;
                CbFlujoTarea.ValueMember = "idFT";
                CbFlujoTarea.DisplayMember = "nombreFT";
                CbFlujoTarea.SelectedValue = "";
                CbFlujoTarea.Text = "";
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
                    OracleCommand comando = new OracleCommand("EliminarFlujoDeTareas", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_id", OracleType.Number).Value = Convert.ToInt32(CbFlujoTarea.SelectedValue);
                    comando.ExecuteNonQuery();
                    CbFlujoTarea.SelectedItem = null;
                    MessageBox.Show(" Flujo de Tareas eliminado exitosamente. ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error, no se  pudo eliminar el Flujo de Tareas. ");
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado Flujo de Tareas");
            }
            ValidarCampos();
            if (CbFlujoTarea.SelectedItem == null)
            {
                errorProvider1.SetError(CbFlujoTarea, "");
                label2.Text = "Selecciona Flujo de Tarea";
            }
            else
            {
                label2.Text = "";
                errorProvider1.Clear();
            }
        }
        private void BorrarMensaje()
        {
            errorProvider1.SetError(CbFlujoTarea, "");

        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (CbFlujoTarea.Text == "")
            {
                ok = false;
                errorProvider2.SetError(CbFlujoTarea, "");
            }
            else
            {
                errorProvider2.Clear();
            }
            return ok;
        }

        private void CbFlujoTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbFlujoTarea.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}

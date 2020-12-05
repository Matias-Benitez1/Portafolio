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
    public partial class frmFlujoTareas : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form h1;
        public frmFlujoTareas(Form h=null)
        {
            InitializeComponent();
            h1 = h;
        }

        private void btnStarea_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAtareas_Click(object sender, EventArgs e)
        {
            CrearFTareas formularioCrear2 = new CrearFTareas(h1);
            h1.Enabled = false;
            formularioCrear2.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarFlujoTarea MFT = new ModificarFlujoTarea(h1);
            h1.Enabled = false;
            MFT.Show();
        }

        private void btnEtareas_Click(object sender, EventArgs e)
        {
            EliminarFlujoTarea EFT = new EliminarFlujoTarea(h1);
            h1.Enabled = false;
            EFT.Show();
        }

        private void frmFlujoTareas_Load(object sender, EventArgs e)
        {

        }

        private void btnCargaFT_Click(object sender, EventArgs e)
        {
            OracleCommand comando = new OracleCommand("cargarFlujoTareas", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvCrearTareas.DataSource = tabla;
            dgvCrearTareas.Columns["id_flujo"].Width = 74;
            dgvCrearTareas.Columns["id_usuario"].Width = 74;
            dgvCrearTareas.Columns["nombre_flujo"].Width = 74;
            dgvCrearTareas.Columns["descripcion"].Width = 74;
            dgvCrearTareas.Columns["horadeinicio"].Width = 74;
            dgvCrearTareas.Columns["horadetermino"].Width = 74;
            dgvCrearTareas.Columns["porcentaje_avance"].Width = 74;
            dgvCrearTareas.Columns["terminado"].Width = 74;



        }
    }
}

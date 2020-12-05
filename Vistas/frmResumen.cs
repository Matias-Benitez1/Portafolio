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
    public partial class frmResumen : Form
    {
        OracleConnection ora = Conectar.Conexion;
        public frmResumen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmResumen_Load(object sender, EventArgs e)
        {

        }

        private void dgvCrearTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncargarResumen_Click(object sender, EventArgs e)
        {
            OracleCommand comando = new OracleCommand("cargarTareasS", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvMostrarTareas.DataSource = tabla;
            dgvMostrarTareas.Columns["ID_TAREAS"].Width = 75;
            dgvMostrarTareas.Columns["ID_USUARIO"].Width = 75;
            dgvMostrarTareas.Columns["NOMBREUSUARIO"].Width = 75;
            dgvMostrarTareas.Columns["DESCRIPCION"].Width = 75;
            dgvMostrarTareas.Columns["HORADEINICIO"].Width = 75;
            dgvMostrarTareas.Columns["HORADETERMINO"].Width = 75;
            dgvMostrarTareas.Columns["PORCENTAJE_AVANCE"].Width = 75;
            dgvMostrarTareas.Columns["ESTADO_TAREA"].Width = 75;
            dgvMostrarTareas.Columns["ID_SUBORDINADA"].Width = 75;
        }
    }
}

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
    public partial class frmJerarquia : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form j1;
        public frmJerarquia(Form j=null)
        {
            InitializeComponent();
            j1 = j;
        }

        private void btnStarea_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAtareas_Click(object sender, EventArgs e)
        {
            CrearJerarquia frmcrearJerarquia = new CrearJerarquia(j1);
            j1.Enabled = false;
            frmcrearJerarquia.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarJerarquia MJ = new ModificarJerarquia(j1);
            j1.Enabled = false;
            MJ.Show();
        }

        private void btnEliminarJerarquia_Click(object sender, EventArgs e)
        {
            EliminarJerarquia EJ = new EliminarJerarquia(j1);
            j1.Enabled = false;
            EJ.Show();
        }

        private void frmJerarquia_Load(object sender, EventArgs e)
        {
            /*try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("seleccionarJerarquia", ora);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("curJera", OracleType.Cursor).Direction = ParameterDirection.Output;
                var r = comando.ExecuteReader();
                List<object> list = new List<object>();
                while (r.Read())
                {
                    list.Add(new { IdJera = r.GetValue(0), NombreJera = r.GetValue(1), DesJera = r.GetValue(2) });
                }
                dgvJerarquia.DataSource = list;
                dgvJerarquia.Columns["IdJera"].Width = 190;
                dgvJerarquia.Columns["NombreJera"].Width = 190;
                dgvJerarquia.Columns["DesJera"].Width = 190;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ora.Close();
            }*/
        }

        private void btnCargaJ_Click(object sender, EventArgs e)
        {
            
            OracleCommand comando = new OracleCommand("cargarJerarquia", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvJerarquia.DataSource = tabla;
            dgvJerarquia.Columns["id_jerarquia"].Width = 190;
            dgvJerarquia.Columns["nombre"].Width = 190;
            dgvJerarquia.Columns["porcentaje_importancia"].Width = 190;

        }

        private void dgvJerarquia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

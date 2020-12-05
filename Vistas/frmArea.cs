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
    public partial class frmArea : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form q1;
        
        public frmArea(Form q=null)
        {
            InitializeComponent();
            q1 = q;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUInternas_Click(object sender, EventArgs e)
        {
            CrearAreas frmAreas = new CrearAreas(q1);
            q1.Enabled = false;
            frmAreas.Show();
        }

        private void btnModificarUI_Click(object sender, EventArgs e)
        {
            ModificarArea frmModiArea = new ModificarArea(q1);
            q1.Enabled = false;
            frmModiArea.Show();
        }

        private void btnAsignarTrabajador_Click(object sender, EventArgs e)
        {
            EliminarArea A = new EliminarArea(q1);
            q1.Enabled = false;
            A.Show();
        }

        private void frmArea_Load(object sender, EventArgs e)
        {
            /*try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("seleccionarArea", ora);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("curArea", OracleType.Cursor).Direction = ParameterDirection.Output;
                var r = comando.ExecuteReader();
                List<object> list = new List<object>();
                while (r.Read())
                {
                    list.Add(new { IdArea = r.GetValue(0), NombreArea = r.GetValue(1), IdUnidadInterna = r.GetValue(2) });
                }
                dgvAreas.DataSource = list;
                dgvAreas.Columns["IdArea"].Width = 190;
                dgvAreas.Columns["NombreArea"].Width = 190;
                dgvAreas.Columns["IdUnidadInterna"].Width = 190;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ora.Close();
            }*/
        }

        private void btnCargarAreas_Click(object sender, EventArgs e)
        {
            OracleCommand comando = new OracleCommand("cargarAreas", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvAreas.DataSource = tabla;
            dgvAreas.Columns["id_area"].Width = 190;
            dgvAreas.Columns["nombre_area"].Width = 190;
            dgvAreas.Columns["id_unidadesinternas"].Width = 190;


        }
    }
}

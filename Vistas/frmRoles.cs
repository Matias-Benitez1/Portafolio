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
    public partial class frmRoles : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form f1;
        public frmRoles(Form f=null)
        {
            InitializeComponent();
            f1 = f;

        }

        private void btnAtareas_Click(object sender, EventArgs e)
        {
            CrearRoles formularioañadir2 = new CrearRoles(f1);
            f1.Enabled = false;
            formularioañadir2.Show();
        }

        private void btnStarea_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarRoles formularioModificar = new ModificarRoles(f1);
            f1.Enabled = false;
            formularioModificar.Show();
        }

        private void btnEtareas_Click(object sender, EventArgs e)
        {
            EliminarRol formularioEliminar = new EliminarRol(f1);
            f1.Enabled = false;
            formularioEliminar.Show();
        }

        private void dgvCrearTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            /*try
            {
                ora.Open();
                OracleCommand comandorol = new OracleCommand("seleccionarRol", ora);
                comandorol.CommandType = CommandType.StoredProcedure;
                comandorol.Parameters.Add("curRol", OracleType.Cursor).Direction = ParameterDirection.Output;
                var rrol = comandorol.ExecuteReader();
                List<object> listrol = new List<object>();
                while (rrol.Read())
                {
                    listrol.Add(new { IdRol = rrol.GetValue(0), NombreRol = rrol.GetValue(1), Descripción = rrol.GetValue(2) });
                }
                dgvInterRoles.DataSource = listrol;
                dgvInterRoles.Columns["IdRol"].Width = 190;
                dgvInterRoles.Columns["NombreRol"].Width = 190;
                dgvInterRoles.Columns["Descripción"].Width = 190;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ora.Close();
            }*/
        }

        private void btnCargarRol_Click(object sender, EventArgs e)
        {
            OracleCommand comando = new OracleCommand("cargarRoles", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvInterRoles.DataSource = tabla;
            dgvInterRoles.Columns["id_rol"].Width = 190;
            dgvInterRoles.Columns["nombre_rol"].Width = 190;
            dgvInterRoles.Columns["descripcion"].Width = 190;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

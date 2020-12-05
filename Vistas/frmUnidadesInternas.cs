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
    public partial class frmUnidadesInternas : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form d1;
        public frmUnidadesInternas(Form d=null)
        {
            InitializeComponent();
            d1 = d;
        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUInternas_Click(object sender, EventArgs e)
        {
            CrearUnidadesInternas frmUnidadesInternas = new CrearUnidadesInternas(d1);
            d1.Enabled = false;
            frmUnidadesInternas.Show();
        }

        private void btnModificarUI_Click(object sender, EventArgs e)
        {
            ModificarUnidades frmUI = new ModificarUnidades(d1);
            d1.Enabled = false;
            frmUI.Show();
        }

        private void btnEliunidad_Click(object sender, EventArgs e)
        {
            EliminarUnidades frmEliminarUI = new EliminarUnidades(d1);
            d1.Enabled = false;
            frmEliminarUI.Show();
        }

        private void frmUnidadesInternas_Load(object sender, EventArgs e)
        {
            /*try
            {
            ora.Open();
            OracleCommand comando = new OracleCommand("seleccionarUnidadInterna", ora);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("curUnidad", OracleType.Cursor).Direction = ParameterDirection.Output;
            var r = comando.ExecuteReader();
            List<object> list = new List<object>();
            while (r.Read())
            {
                list.Add(new { IdUnidad = r.GetValue(0), NombreUnidad = r.GetValue(1), Descripción = r.GetValue(2) });
            }
            dgvUnidadInterna.DataSource = list;
            dgvUnidadInterna.Columns["IdUnidad"].Width = 190;
            dgvUnidadInterna.Columns["NombreUnidad"].Width = 190;
            dgvUnidadInterna.Columns["Descripción"].Width = 190;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ora.Close();
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand comando = new OracleCommand("cargarUnidadInterna", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvUnidadInterna.DataSource = tabla;
            dgvUnidadInterna.Columns["ID_UNIDADINTERNA"].Width = 190;
            dgvUnidadInterna.Columns["NOMBRE_UNIDADINTERNA"].Width = 190;
            dgvUnidadInterna.Columns["DESCRIPCION"].Width = 190;



        }
    }
}

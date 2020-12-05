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
    public partial class frmUsuarios : Form
    {
        OracleConnection ora = Conectar.Conexion;
        Form l1;

        public frmUsuarios(Form l=null)
        {
            InitializeComponent();
            l1 = l;
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            CrearUsuarios FA = new CrearUsuarios(l1);
            l1.Enabled = false;
            FA.Show();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            ModificarUsuarios formularioactualizar = new ModificarUsuarios(l1);
            l1.Enabled = false;
            formularioactualizar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarUsuarios formularioeliminar = new EliminarUsuarios(l1);
            l1.Enabled = false;
            formularioeliminar.Show();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
          /* try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("seleccionarUsuario", ora);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("curUsu", OracleType.Cursor).Direction = ParameterDirection.Output;
                var r = comando.ExecuteReader();
                List<object> list = new List<object>();
                while (r.Read())
                {
                    list.Add(new { IdUsu = r.GetValue(0) , NombreUsu = r.GetValue(1), ApeUsu = r.GetValue(2), AreaUsu = r.GetValue(3), RolUsu = r.GetValue(4), UnidadUsu = r.GetValue(5), JeraUsu = r.GetValue(6), Username = r.GetValue(7), Contraseña = "".PadLeft(r.GetValue(8).ToString().Length, '*') });
                }
                dgvDatos.DataSource = list;

                dgvDatos.Columns["IdUsu"].Width = 70;
                dgvDatos.Columns["NombreUsu"].Width = 70;
                dgvDatos.Columns["ApeUsu"].Width = 70;
                dgvDatos.Columns["AreaUsu"].Width = 70;
                dgvDatos.Columns["RolUsu"].Width = 70;
                dgvDatos.Columns["UnidadUsu"].Width = 70;
                dgvDatos.Columns["JeraUsu"].Width = 70;
                dgvDatos.Columns["Username"].Width = 70;
                dgvDatos.Columns["Contraseña"].Width = 70;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ora.Close();
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            OracleCommand comando = new OracleCommand("cargarUsuarios", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvDatos.DataSource = tabla;
            dgvDatos.Columns["id_usuario"].Width = 84;
            dgvDatos.Columns["nombre"].Width = 84;
            dgvDatos.Columns["apellidos"].Width = 84;
            dgvDatos.Columns["id_area"].Width = 84;
            dgvDatos.Columns["id_rol"].Width = 84;
            dgvDatos.Columns["id_unidadinterna"].Width = 84;
            dgvDatos.Columns["id_jerarquia"].Width = 84;
            dgvDatos.Columns["user_name"].Width = 84;
            dgvDatos.Columns["contraseña"].Width = 84;

            cambiarTexto();


        }
        private void cambiarTexto ()
        {
            foreach (DataGridViewRow r in dgvDatos.Rows)
            {
                r.Cells[8].Value = "".PadLeft(r.Cells[8].Value.ToString().Length, '*');
            }
        }
    }
}

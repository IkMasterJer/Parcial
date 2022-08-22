using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL_CARRASCO_
{
    public partial class frmProductoEdit : Form
    {
        string cadenaConexion = "server=localhost; database=Parcial; Integrated Security=true";
        public frmProductoEdit()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmProductoEdit_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                // CARGAR DATOS DE CATEGORIA
                var sql = "SELECT * FROM Categoria";
                using (var comando = new SqlCommand(sql, conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Dictionary<string, string> categoriaSource = new Dictionary<string, string>();
                            while (lector.Read())
                            {
                                categoriaSource.Add(lector[0].ToString(), lector[2].ToString());
                            }
                            cbocategoria.DataSource = new BindingSource(categoriaSource, null);
                            cbocategoria.DisplayMember = "Value";
                            cbocategoria.ValueMember = "Key";
                        }
                    }
                }
            }
        }


    }
}

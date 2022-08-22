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
    public partial class fmrProducto : Form
    {
        /*SqlDataAdapter daModificarProducto;
        SqlConnection conexion;
        DataTable dtModificarProducto;*/

        string cadenaConexion = "server=localhost; database=Parcial; Integrated Security = true;";

        public fmrProducto()
        {
            InitializeComponent();
            /*var cadenaConexionn = "server=localhost; database=Parcial; Integrated Security = true;";
            dtModificarProducto = new DataTable();
            conexion = new SqlConnection(cadenaConexionn);
            daModificarProducto = new SqlDataAdapter();
            daModificarProducto.SelectCommand = new SqlCommand("SELECT * FROM Producto", conexion);

            daModificarProducto.UpdateCommand = new SqlCommand("UPDATE Producto SET Nombre=@nombre, Marca=@marca, Precio=@precio, Stock=@stock WHERE Nombre=@nombre1", conexion);
            //Definir parametros
            daModificarProducto.UpdateCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 20, "Nombre");
            daModificarProducto.UpdateCommand.Parameters.Add("@marca", SqlDbType.VarChar, 20, "Marca");
            daModificarProducto.UpdateCommand.Parameters.Add("@precio", SqlDbType.VarChar, 20, "Precio");
            daModificarProducto.UpdateCommand.Parameters.Add("@stock", SqlDbType.VarChar, 20, "Stock");
            daModificarProducto.UpdateCommand.Parameters.Add("@nombre1", SqlDbType.VarChar, 20, "Nombre");*/
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            var frm = new frmProductoEdit();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var nombre = ((TextBox)frm.Controls["txtnombre"]).Text;
                var marca = ((TextBox)frm.Controls["txtmarca"]).Text;
                var precio = ((TextBox)frm.Controls["txtprecio"]).Text;
                var stock = ((TextBox)frm.Controls["txtstock"]).Text;
                var categoria = ((ComboBox)frm.Controls["cbocategoria"]).SelectedValue.ToString();

                using (var conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    var sql = "INSERT INTO Producto (Nombre ,Marca, Precio, Stock, IdCategoria) VALUES(@nombre, @marca, @precio, @stock, @idcategoria)";

                    using (var comando = new SqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@marca", marca);
                        comando.Parameters.AddWithValue("@precio", precio);
                        comando.Parameters.AddWithValue("@stock", stock);
                        comando.Parameters.AddWithValue("@idcategoria", categoria);
                        int resultado = comando.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            MessageBox.Show("El Producto ha sido registrado", "Sistemas",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarDatos();
                        }
                        else
                        {
                            MessageBox.Show("El proceso de creación del Prodcuto ha fallado.", "Sistemas",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void cargarDatos()
        {
            dgvproducto.Rows.Clear();
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                var sql = "SELECT Nombre,Marca,Precio,Stock,IdCategoria FROM Producto";
                using (var comando = new SqlCommand(sql, conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            while (lector.Read())
                            {
                                dgvproducto.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4]);
                            }
                        }
                    }
                }
            }
        }

        private void fmrProducto_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void tsvEditar_Click(object sender, EventArgs e)
        {          

            var frm = new frmProductoEdit();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var nombre = ((TextBox)frm.Controls["txtnombre"]).Text;
                var nom = ((TextBox)frm.Controls["txtnombre"]).Text;
                var marca = ((TextBox)frm.Controls["txtmarca"]).Text;
                var precio = ((TextBox)frm.Controls["txtprecio"]).Text;
                var stock = ((TextBox)frm.Controls["txtstock"]).Text;
                var categoria = ((ComboBox)frm.Controls["cbocategoria"]).SelectedValue.ToString();

                using (var conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    var sql = "UPDATE Producto SET Nombre=@nombre, Marca=@marca, Precio=@precio, Stock=@stock, IdCategoria=@idcategoria WHERE Nombre=@nom ";

                    using (var comando = new SqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@marca", marca);
                        comando.Parameters.AddWithValue("@precio", precio);
                        comando.Parameters.AddWithValue("@stock", stock);
                        comando.Parameters.AddWithValue("@idcategoria", categoria);
                        comando.Parameters.AddWithValue("@nom", nom);
                        int resultado = comando.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            MessageBox.Show("El Producto ha sido modificado", "Sistemas",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarDatos();
                        }
                        else
                        {
                            MessageBox.Show("El proceso de modificado del Producto ha fallado.", "Sistemas",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }



        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            var frm = new frmProductoEdit();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var nombre = ((TextBox)frm.Controls["txtnombre"]).Text;
                var nom = ((TextBox)frm.Controls["txtnombre"]).Text;
                var marca = ((TextBox)frm.Controls["txtmarca"]).Text;
                var precio = ((TextBox)frm.Controls["txtprecio"]).Text;
                var stock = ((TextBox)frm.Controls["txtstock"]).Text;
                var categoria = ((ComboBox)frm.Controls["cbocategoria"]).SelectedValue.ToString();

                using (var conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    var sql = "DELETE FROM Producto WHERE Nombre=@nom";

                    using (var comando = new SqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@nom", nom);
                        int resultado = comando.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            MessageBox.Show("El Producto ha sido eliminado", "Sistemas",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarDatos();
                        }
                        else
                        {
                            MessageBox.Show("El proceso de modificado del Producto ha fallado.", "Sistemas",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}

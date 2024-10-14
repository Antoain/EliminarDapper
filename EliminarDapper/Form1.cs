using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace EliminarDapper
{
    public partial class Form1 : Form
    {
        CategoryRepo categR = new CategoryRepo();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarTods_Click(object sender, EventArgs e)
        {
            var categ = categR.ObtenerTodo();
            DgvCategorias.DataSource = categ;
        }

        private void btnBuscarID_Click(object sender, EventArgs e) // un Tryparse salvaje aparecio!, lo ponemos ya que no podemos poner un int en un txtBox
        {
            if (int.TryParse(txtBBuscarID.Text, out int id))
            {

                var categ = categR.ObtenerPoeID(id);
                DgvCategorias.DataSource = new List<Categoria> { categ };

                if (categ != null) { RellenarEspacios(categ); }
            }
            else
            {

                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
        }
        private void RellenarEspacios(Categoria categoria)
        {
            txtCategoriaID.Text = categoria.CategoryID.ToString(); 
            txtBCategoryName.Text = categoria.CategoryName;
            txtBDescripcion.Text = categoria.Description;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCategoriaID.Text, out int categoryID))
            {
                var eliminadas = categR.EliminarCategoria(categoryID);

                MessageBox.Show($"Se ha eliminado {eliminadas} filas ");
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido, porfax.");
            }
        }
        private Categoria CrearCate()
        {
            var nueva = new Categoria
            {
                CategoryID = int.Parse(txtCategoriaID.Text), 
                CategoryName = txtBCategoryName.Text,
                Description = txtBDescripcion.Text
            };
            return nueva;
        }
       
    }
}

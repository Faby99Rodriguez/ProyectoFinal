using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    
    public partial class FrmInventarios : Form
    {
        public int id=0;

        public FrmInventarios()
        {
            InitializeComponent();
        }

        private void FrmInventarios_Load(object sender, EventArgs e)
        {
            TodosProductos();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            AgregarProductos();
            TodosProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
            TodosProductos();
        }

        private void TodosProductos()
        {
            using (var context = new ApplicatiionDbContext())
            {
                var productos = context.Inventarios.ToList();
                dgvInventarios.DataSource = productos;
            }

        }

        private void AgregarProductos()
        {
            using (var context = new ApplicatiionDbContext())
            {
                var producto = new Inventarios();
                producto.Nombre = txtNombre.Text;
                producto.Proovedor = txtProovedor.Text; 
                producto.Precio = double.Parse(txtPrecio.Text);
                producto.Peso = double.Parse(txtPeso.Text);
                producto.Cajas = int.Parse(txtCajas.Text);

                context.Add(producto);

                context.SaveChanges();
            }
        }

        private void EliminarProducto()
        {
            using (var context = new ApplicatiionDbContext())
            {
                if (id != 0)
                {
                    var producto = context.Inventarios.First(x => x.Id == id);
                    if (producto != null)
                    {
                        context.Remove(producto);
                        context.SaveChanges();
                    }
                }
            }
        }

        private void dgvInventarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvInventarios.CurrentRow.Cells[0].Value);
        }
    }
}

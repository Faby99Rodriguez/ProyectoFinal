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
    public partial class FrmClientes : Form
    {
        public int id=0;
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            TodosClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCliente();
            TodosClientes();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            AgregarClientes();
            TodosClientes();
        }

        private void TodosClientes()
        {
            using (var context = new ApplicatiionDbContext())
            {
                var clientes = context.Clientes.ToList();
                dgvClientes.DataSource = clientes;
            }
        }

        private void BuscarClientes()
        {
            using (var context = new ApplicatiionDbContext())
            {
                var clientes = context.Clientes.Where(x => x.Nombre.Contains(txtBuscar.Text)).ToList();
                dgvClientes.DataSource = clientes;
            }
        }

        private void AgregarClientes()
        {
            using (var context = new ApplicatiionDbContext())
            {
                var cliente = new Clientes();
                cliente.Nombre= txtNombre.Text;
                cliente.ApellidoPaterno= txtApellidoPaterno.Text;
                cliente.ApellidoMaterno = txtApellidoMaterno.Text;
                cliente.sexo = rbtnFemenino.Checked ? "Femenino" : "Masculino";
                
                context.Clientes.Add(cliente);

                context.SaveChanges();
            }
        }

        private void ModificarClientes()
        {
            using (var context = new ApplicatiionDbContext())
            {
                if (id != 0)
                {
                    var cliente = context.Clientes.First(x => x.Id == id);
                    cliente.Nombre = txtNombre.Text;
                    cliente.ApellidoPaterno = txtApellidoPaterno.Text;
                    cliente.ApellidoMaterno = txtApellidoMaterno.Text;
                    cliente.sexo = rbtnFemenino.Checked ? "Femenino" : "Masculion";
                  
                    context.SaveChanges();
                }
            }
        }

        private void EliminarCliente()
        {
            using (var context = new ApplicatiionDbContext())
            {
                if (id != 0)
                {
                    var cliente = context.Clientes.First(x => x.Id == id);
                    if (cliente != null)
                    {
                        context.Remove(cliente);
                        context.SaveChanges();
                    }
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            txtNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtApellidoPaterno.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtApellidoMaterno.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            if (dgvClientes.CurrentRow.Cells[4].Value.ToString() == "Femenino")
            {
                rbtnFemenino.Checked = true;
            }
            else
            {
                rbtnMasculino.Checked = true;
            }
            
        }
    }
}

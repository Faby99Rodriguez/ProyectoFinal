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
   
    public partial class FrmEmplead : Form
    {
        public int id = 0;

        public FrmEmplead()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
             AgregarEmpleado();
             TodosEmpleados();
        }

       private void FrmEmplead_Load(object sender, EventArgs e)
        {
            TodosEmpleados();   
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarEmpleados();
        }

        private void BuscarEmpleados()
        {
            using (var context = new ApplicatiionDbContext())
            {
                var emplead = context.Empleados.Where(x => x.Nombre.Contains(txtBuscar.Text)).ToList();
                dgvEmplea.DataSource = emplead;
            }
        }

        private void AgregarEmpleado()
        {
            using (var context = new ApplicatiionDbContext())
            {
                //Paso 1: Crear el objeto
                var empleado = new Empleadoss();
                empleado.Nombre = txtNombre.Text;
                empleado.ApellidoPaterno = txtApellidoPaterno.Text;
                empleado.ApellidoMaterno = txtApellidoMaterno.Text;
                empleado.Sexo = rbtnFemenino.Checked ? "Femenino" : "Masculino";
                empleado.RFC = txtRfc.Text; 

                //Paso 2: Notificamos a EFC que  queremos agregar un empleado
                context.Empleados.Add(empleado);

                //Paso 3: Guardamos los cambios
                context.SaveChanges();
            }
        }

        private void TodosEmpleados()
        {
            using (var context = new ApplicatiionDbContext())
            {
                var empleados = context.Empleados.ToList();
                dgvEmplea.DataSource = empleados;
            }
        }

        private void dgvEmplea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvEmplea.CurrentRow.Cells[0].Value);
            txtNombre.Text = dgvEmplea.CurrentRow.Cells[1].Value.ToString();
            txtApellidoPaterno.Text = dgvEmplea.CurrentRow.Cells[2].Value.ToString();
            txtApellidoMaterno.Text = dgvEmplea.CurrentRow.Cells[3].Value.ToString();
            if (dgvEmplea.CurrentRow.Cells[4].Value.ToString() == "Femenino")
            {
                rbtnFemenino.Checked = true;
            }
            else
            {
                rbtnMasculino.Checked = true;
            }
            txtRfc.Text = dgvEmplea.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarEmpleado();
            TodosEmpleados();
        }

        private void ModificarEmpleado()
        {
            using (var context = new ApplicatiionDbContext())
            {
                //Paso 1: Crear el objeto
                if (id != 0)
                {
                    var empleadoM = context.Empleados.First(x => x.Id == id);
                    empleadoM.Nombre = txtNombre.Text;
                    empleadoM.ApellidoPaterno = txtApellidoPaterno.Text;
                    empleadoM.ApellidoMaterno = txtApellidoMaterno.Text;
                    empleadoM.Sexo = rbtnFemenino.Checked ? "Femenino" : "Masculino";
                    empleadoM.RFC = txtRfc.Text;
                    context.SaveChanges();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleado(); 
            TodosEmpleados();
        }

        private void EliminarEmpleado()
        {
            using (var context = new ApplicatiionDbContext())
            {
                //Paso 1: Crear el objeto
                if (id != 0)
                {
                    var empleado1 = context.Empleados.First(x => x.Id == id);
                    if (empleado1 != null)
                    {
                        context.Remove(empleado1);
                        context.SaveChanges();
                    }
                }
            }
        } 
    }
}

namespace ProyectoFinal
{
    public partial class FrmDashb : Form
    {
        public FrmDashb()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmplead empleadouno = new FrmEmplead();
            empleadouno.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes cliente=new FrmClientes();
            cliente.Show();
        }

        private void btnInventarios_Click(object sender, EventArgs e)
        {
            FrmInventarios inventario = new FrmInventarios();
            inventario.Show();
        }
    }
}
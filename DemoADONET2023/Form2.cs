using Negocio;
using System;
using System.Windows.Forms;

namespace DemoADONET2023
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            BProducto negocio = new BProducto();
            dgvProducto.DataSource = negocio.Listar(txtNombre.Text);
        }
    }
}

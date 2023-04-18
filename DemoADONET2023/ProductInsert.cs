using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace DemoADONET2023
{
    public partial class ProductInsert : Form
    {
        public ProductInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                BProducto negocio = new BProducto();
                negocio.Insertar(new Entidad.Producto
                {
                    IdProducto=int.Parse(txtId.Text),
                    Nombre = txtNombre.Text,
                    Precio = int.Parse(txtPrecio.Text),
                    FechaCreacion=DateTime.Parse(dtpFecha.Text)
                });
                MessageBox.Show("Registro exitoso");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");

            }


        }
    }
}

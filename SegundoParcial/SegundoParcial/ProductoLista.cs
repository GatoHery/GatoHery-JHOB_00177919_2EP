using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class ProductoLista : UserControl
    {
        public ProductoLista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = ConexionBD.EjecutarConsulta("SELECT * FROM PRODUCT;");

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("algo salio mal");
            }
        }
    }
}
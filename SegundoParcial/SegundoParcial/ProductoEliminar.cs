using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class ProductoEliminar : UserControl
    {
        public ProductoEliminar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                try
                {
                    throw new ErrorEmptyDataException("No se pueden dejar espacios vacios");
                }
                catch (ErrorEmptyDataException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    ConexionBD.EjecutarComando("DELETE FROM PRODUCT " +
                                               $"WHERE idProduct = {textBox1.Text}");

                    MessageBox.Show("Producto eliminado exitosamente");
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show("Algo salio mal");
                }   
            }
        }
    }
}
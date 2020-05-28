using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class EliminarNegocio : UserControl
    {
        public EliminarNegocio()
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
                    ConexionBD.EjecutarComando("DELETE FROM BUSINESS " +
                                               $"WHERE idBusiness = {textBox1.Text}");

                    MessageBox.Show("Negocio eliminado exitosamente");
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show("Algo salio mal");
                }
            }
        }
    }
}
using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class DireccionEliminar : UserControl
    {
        public DireccionEliminar()
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
                    ConexionBD.EjecutarComando("DELETE FROM ADDRESS " +
                                               $"WHERE idAddress = {textBox1.Text}");

                    MessageBox.Show("Direccion eliminado exitosamente");
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show("Algo salio mal");
                }   
            }
        }
    }
}
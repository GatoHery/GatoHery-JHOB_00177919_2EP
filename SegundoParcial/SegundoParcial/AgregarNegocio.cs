using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class AgregarNegocio : UserControl
    {
        public AgregarNegocio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
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
            else if (textBox2.Text.Length >= 50)
            {
                try
                {
                    throw new ErrorLengthDataException("Has excedido el tamano permitido en algun texto");
                }
                catch (ErrorNotValidDataException ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
            else
            {
                try
                {
                    ConexionBD.EjecutarComando("INSERT INTO BUSINESS(name, description) " +
                    $"VALUES ('{textBox2.Text}', '{textBox1.Text}');");

                    MessageBox.Show("Negocio Agregado exitosamente");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrio un problema");
                }
            }
        }
    }
}
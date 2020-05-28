using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class UsuarioAgregar : UserControl
    {
        public UsuarioAgregar()
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
            else if (!textBox1.Text.Equals(textBox2.Text))
            {
                try
                {
                    throw new ErrorNotValidDataException("El usuario y contrasena debes ser iguales");
                }
                catch (ErrorNotValidDataException ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
            else if (textBox3.Text.Length >= 100 || textBox1.Text.Length >= 25 
                                                 || textBox2.Text.Length >= 25)
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
                    ConexionBD.EjecutarComando("INSERT INTO APPUSER(fullname, username, password, userType) " +
                    $"VALUES('{textBox3.Text}', '{textBox1.Text}', '{textBox2.Text}', {comboBox1.Text});");

                    MessageBox.Show("Usuario Agregado exitosamente");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrio un problema");
                }
            }
        }
    }
}
using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class UsuarioEliminar : UserControl
    {
        public UsuarioEliminar()
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
                    ConexionBD.EjecutarComando("DELETE FROM APPUSER " +
                                               $"WHERE username = '{textBox1.Text}'");

                    MessageBox.Show("Usuario eliminado exitosamente");
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show("Algo salio mal");
                }   
            }
        }
    }
}
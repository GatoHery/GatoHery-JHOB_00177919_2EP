using System;
using System.Data;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class DirrecionAgregar : UserControl
    {
        private int id = 0;
        public DirrecionAgregar()
        {
            InitializeComponent();
            
            var dt = ConexionBD.EjecutarConsulta("SELECT app.iduser " +
                                                 "FROM APPUSER app " +
                                                 $"WHERE app.username = '{ActualUsuario.Persona}'");
            foreach (DataRow dr in dt.Rows)
            {
                id = Convert.ToInt32(dr[0].ToString());
            }

            textBox2.Text = Convert.ToString(id);
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
                    ConexionBD.EjecutarComando("INSERT INTO ADDRESS(idUser, address) " +
                    $"VALUES({textBox2.Text}, '{textBox1.Text}');");

                    MessageBox.Show("Direccion Agregado exitosamente");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrio un problema");
                }
            }
        }
    }
}
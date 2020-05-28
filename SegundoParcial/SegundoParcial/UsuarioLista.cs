using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class UsuarioLista : UserControl
    {
        public UsuarioLista()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = ConexionBD.EjecutarConsulta("SELECT * FROM APPUSER;");

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("algo salio mal");
            }
        }
    }
}
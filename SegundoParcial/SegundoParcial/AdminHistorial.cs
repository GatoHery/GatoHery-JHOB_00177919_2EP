using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class AdminHistorial : UserControl
    {
        public AdminHistorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = ConexionBD.EjecutarConsulta("SELECT * FROM APPORDER;");

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("algo salio mal");
            }
        }
    }
}
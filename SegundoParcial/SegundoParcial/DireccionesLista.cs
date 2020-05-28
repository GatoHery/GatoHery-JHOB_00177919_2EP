using System;
using System.Data;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class DireccionesLista : UserControl
    {
        public DireccionesLista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "";
                var dt1 = ConexionBD.EjecutarConsulta("SELECT app.iduser " +
                                                     "FROM APPUSER app " +
                                                     $"WHERE app.username = '{ActualUsuario.Persona}'");
                foreach (DataRow dr in dt1.Rows)
                {
                    id = dr[0].ToString();
                }
                
                var dt = ConexionBD.EjecutarConsulta("SELECT ad.idAddress, ad.address " +
                $"FROM ADDRESS ad WHERE idUser = {id}");

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("algo salio mal");
            }
        }
    }
}
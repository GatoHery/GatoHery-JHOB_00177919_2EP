using System;
using System.Data;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class OrdenLista : UserControl
    {
        public OrdenLista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                var dt2 = ConexionBD.EjecutarConsulta("SELECT app.iduser " +
                                                     "FROM APPUSER app " +
                                                     $"WHERE app.username = '{ActualUsuario.Persona}'");
                foreach (DataRow dr in dt2.Rows)
                {
                    id = Convert.ToInt32(dr[0].ToString());
                }
                
                var dt = ConexionBD.EjecutarConsulta("SELECT ao.idOrder, ao.createDate," +
                  " pr.name, au.fullname, ad.address " +
                  "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                   "WHERE ao.idProduct = pr.idProduct " +
                "AND ao.idAddress = ad.idAddress " +
                "AND ad.idUser = au.idUser " +
                $"AND au.idUser = {id};");

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("algo salio mal");
            }
        }
    }
}
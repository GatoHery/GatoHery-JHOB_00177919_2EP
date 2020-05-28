using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class OrdenAgregar : UserControl
    {
        public OrdenAgregar()
        {
            InitializeComponent();
            
            
            //id del usuario para las direcciones
            int id = 0;
            var dt4 = ConexionBD.EjecutarConsulta("SELECT app.iduser " +
                                                 "FROM APPUSER app " +
                                                 $"WHERE app.username = '{ActualUsuario.Persona}'");
            foreach (DataRow dr in dt4.Rows)
            {
                id = Convert.ToInt32(dr[0].ToString());
            }

            var dt2 = ConexionBD.EjecutarConsulta("SELECT ad.address " +
                                                  "FROM ADDRESS ad " +
                                                  $"WHERE ad.iduser = {id}");

            var dtcombo2 = new List<string>();
            foreach (DataRow dr in dt2.Rows)
            {
                dtcombo2.Add(dr[0].ToString());
            }
            
            comboBox2.DataSource = dtcombo2;

            //fecha actual
            DateTime hoy = DateTime.Now;
            textBox1.Text = hoy.ToString("dd/MM/yyyy");
            
            //Id empresa
            var dt5 = ConexionBD.EjecutarConsulta("SELECT bus.idbusiness " +
                                                 "FROM BUSINESS bus;");

            var dtcombo3 = new List<string>();
            foreach (DataRow dr in dt5.Rows)
            {
                dtcombo3.Add(dr[0].ToString());
            }
            
            comboBox3.DataSource = dtcombo3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string id = "";
                string idDireccion = "";
                var dt3 = ConexionBD.EjecutarConsulta(
                    $"SELECT ad.idAddress FROM ADDRESS ad WHERE ad.address = '{comboBox2.Text}'");
                
                foreach (DataRow dr in dt3.Rows)
                {
                    idDireccion = dr[0].ToString();
                }
                
                //id del producto
                var dt4 = ConexionBD.EjecutarConsulta("SELECT pro.idproduct " +
                                                      "FROM PRODUCT pro " +
                                                      $"WHERE pro.name = '{comboBox1.Text}'");
                
                foreach (DataRow dr in dt4.Rows)
                {
                    id = dr[0].ToString();
                }
                
                ConexionBD.EjecutarComando("INSERT INTO APPORDER(createDate, idProduct, idAddress) " +
                $"VALUES('{textBox1.Text}', {id}, {idDireccion});");

                MessageBox.Show("Orden agregada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salio mal");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dt = ConexionBD.EjecutarConsulta("SELECT pro.name " +
                                                 "FROM PRODUCT pro " +
                                                 $"WHERE pro.idbusiness = {comboBox3.Text}");

            var dtcombo = new List<string>();
            
            foreach (DataRow dr in dt.Rows)
            {
                dtcombo.Add(dr[0].ToString());
            }
            
            comboBox1.DataSource = dtcombo;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class ProductoAgregar : UserControl
    {
        public ProductoAgregar()
        {
            InitializeComponent();
            
            var dt = ConexionBD.EjecutarConsulta("SELECT bus.idbusiness " +
            "FROM BUSINESS bus;");

            var dtcombo = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                dtcombo.Add(dr[0].ToString());
            }
            
            comboBox1.DataSource = dtcombo;
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
            else if (textBox1.Text.Length >= 50)
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
                    ConexionBD.EjecutarComando("INSERT INTO PRODUCT(idBusiness, name) " +
                    $"VALUES({comboBox1.Text}, '{textBox1.Text}');");

                    MessageBox.Show("Producto Agregado exitosamente");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrio un problema");
                }
            }
        }
    }
}
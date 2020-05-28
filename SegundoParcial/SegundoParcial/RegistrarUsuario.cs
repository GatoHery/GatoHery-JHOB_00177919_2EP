using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class RegistrarUsuario : UserControl
    {
        public RegistrarUsuario()
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
            else
            {
                try
                {
                    var dt = ConexionBD.EjecutarConsulta("SELECT ap.usertype, ap.iduser " +
                         "FROM APPUSER ap " +
                        $"WHERE ap.username = '{textBox1.Text}' AND ap.password = '{textBox2.Text}';");

                    if (dt.Rows[0][0].Equals(true))
                    {
                        MessageBox.Show($"Bienvenido Administrador {textBox1.Text}");
                        Administrador admin = new Administrador();
                        admin.Show();
                    }
                    else
                    {
                        int id = 0;
                        var dt2 = ConexionBD.EjecutarConsulta("SELECT app.iduser " +
                                                             "FROM APPUSER app " +
                                                             $"WHERE app.username = '{ActualUsuario.Persona}'");
                        foreach (DataRow dr in dt2.Rows)
                        {
                            id = Convert.ToInt32(dr[0].ToString());
                        }
                        
                        MessageBox.Show($"Bienvenido Usuario {textBox1.Text}");
                        ActualUsuario.personaActual(textBox1.Text);
                        ActualUsuario.IdActual(id);
                        UsuarioComun user = new UsuarioComun();
                        user.Show();
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrio un Problema");
                }
            }
        }
    }
}
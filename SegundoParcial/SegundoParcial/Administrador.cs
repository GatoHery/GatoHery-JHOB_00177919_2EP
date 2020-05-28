using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TablaUsuarios user = new TablaUsuarios();
            user.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TablaNegocio neg = new TablaNegocio();
            neg.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TablaProductos pro = new TablaProductos();
            pro.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdministradorHistorial admin = new AdministradorHistorial();
            admin.Show();
            this.Close();
        }
    }
}
using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class TablaNegocio : Form
    {
        private UserControl current;
        
        public TablaNegocio()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();
            admin.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new AgregarNegocio();
            tableLayoutPanel1.Controls.Add(current);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new EliminarNegocio();
            tableLayoutPanel1.Controls.Add(current);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new ListaNegocio();
            tableLayoutPanel1.Controls.Add(current);
        }
    }
}
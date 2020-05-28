using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class AdministradorHistorial : Form
    {
        private UserControl current;
        public AdministradorHistorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new AdminHistorial();
            tableLayoutPanel1.Controls.Add(current);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();
            admin.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new AdminGrafico();
            tableLayoutPanel1.Controls.Add(current);
            
        }
    }
}
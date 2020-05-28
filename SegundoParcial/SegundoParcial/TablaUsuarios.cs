using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class TablaUsuarios : Form
    {
        private UserControl current;
        public TablaUsuarios()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new UsuarioAgregar();
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
            current = new UsuarioLista();
            tableLayoutPanel1.Controls.Add(current);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new UsuarioEliminar();
            tableLayoutPanel1.Controls.Add(current);
        }
    }
}
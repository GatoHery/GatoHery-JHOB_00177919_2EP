using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class TablaOrden : Form
    {
        private UserControl current;
        public TablaOrden()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsuarioComun user = new UsuarioComun();
            user.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new OrdenAgregar();
            tableLayoutPanel1.Controls.Add(current);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new OrdenLista();
            tableLayoutPanel1.Controls.Add(current);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new OrdenEliminar();
            tableLayoutPanel1.Controls.Add(current);
        }
    }
}
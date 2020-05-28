using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class TablaProductos : Form
    {
        private UserControl current;
        
        public TablaProductos()
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
            current = new ProductoAgregar();
            tableLayoutPanel1.Controls.Add(current);    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new ProductoLista();
            tableLayoutPanel1.Controls.Add(current);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new ProductoEliminar();
            tableLayoutPanel1.Controls.Add(current);
        }
    }
}
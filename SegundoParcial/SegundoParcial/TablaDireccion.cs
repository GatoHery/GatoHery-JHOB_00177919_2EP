using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class TablaDireccion : Form
    {
        private UserControl current;
        
        public TablaDireccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new DirrecionAgregar();
            tableLayoutPanel1.Controls.Add(current);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new DireccionesLista();
            tableLayoutPanel1.Controls.Add(current);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new DireccionEliminar();
            tableLayoutPanel1.Controls.Add(current);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsuarioComun user = new UsuarioComun();
            user.Show();
            this.Close();
        }
    }
}
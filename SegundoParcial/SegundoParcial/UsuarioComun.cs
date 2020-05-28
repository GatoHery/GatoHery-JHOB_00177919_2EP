using System;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class UsuarioComun : Form
    {
        public UsuarioComun()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TablaDireccion dir = new TablaDireccion();
            dir.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TablaOrden or = new TablaOrden();
            or.Show();
            this.Close();
        }
    }
}
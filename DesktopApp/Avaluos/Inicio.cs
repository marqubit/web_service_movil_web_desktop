using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Avaluos
{
    public partial class Inicio : MetroForm
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Clientes n = new Clientes();
            n.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Avaluos n = new Avaluos();
            n.Show();
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Concepto n = new Concepto();
            n.Show();
            this.Hide();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Deudas n = new Deudas();
            n.Show();
            this.Hide();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Reportes n = new Reportes();
            n.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

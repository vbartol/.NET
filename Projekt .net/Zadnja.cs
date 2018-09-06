using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt.net
{
    public partial class Zadnja : Form
    {
        public Zadnja()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Od 7 pitanja točno ste odgovorili na njih " + Quiz1.varijabla;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            app3dio app = new app3dio();
            app.ShowDialog();
        }
    }
}

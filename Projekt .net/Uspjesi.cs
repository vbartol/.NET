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
    public partial class Uspjesi : Form
    {
        public Uspjesi()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            app3dio app = new app3dio();
            app.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quiz1 q1 = new Quiz1();
            q1.ShowDialog();
        }

        private void Uspjesi_Load(object sender, EventArgs e)
        {

        }
    }
}

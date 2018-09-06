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
    public partial class Quiz7 : Form
    {
        public Quiz7()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
                Quiz1.varijabla++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zadnja zad = new Zadnja();
            zad.ShowDialog();
        }
    }
}

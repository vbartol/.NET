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
    
    public partial class Quiz1 : Form
    {
        public static int varijabla = 0;

        public Quiz1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quiz2 q2 = new Quiz2();
            q2.ShowDialog();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            varijabla = 0;
            if (radioButton2.Checked == true)
                varijabla++;
                


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            varijabla = 0;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            varijabla = 0;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            varijabla = 0;
        }
    }
}

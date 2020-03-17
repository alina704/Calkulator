using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calkulator
{
    public partial class Calculator : Form
    {
        public int Flag;
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Flag = 2;
            ravno.Text = "*";

        }

        private void ravno_Click(object sender, EventArgs e)
        {
            int a; double b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);


            if (Flag == 0)
            {
                ravno.Text = Convert.ToString(a + b);
            }
            if (Flag == 1)
            {
                ravno.Text = Convert.ToString(a - b);
            }
            if (Flag == 2)
            {
                ravno.Text = Convert.ToString(a * b);
            }
            if (Flag == 3)
            {
                ravno.Text = Convert.ToString(a / b);

            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Flag = 0;
            ravno.Text = "+";

        }

        private void minus_Click(object sender, EventArgs e)
        {
            Flag = 1;
            ravno.Text = "-";

        }

        private void delenie_Click(object sender, EventArgs e)
        {
            Flag = 3;
            ravno.Text = "/";

        }

        private void ochistit_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            ochistit.Text = "";

        }
    }
}

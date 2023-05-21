using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAppYUO
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        void PressNumber(string number)
        {
            if (Display.Text == "0")
                Display.Text = number;
            else
                Display.Text += number;
        }

        private void Number1_Click(object sender, EventArgs e)
        {
            PressNumber(Number1.Text);
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            PressNumber(Number2.Text);
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            PressNumber(Number3.Text);
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            PressNumber(Number0.Text);
        }

        private void Comma_Click(object sender, EventArgs e)
        {
            if (! Display.Text.Contains(","))
            Display.Text += Comma.Text;
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            if (Display.Text != "0")
            {
            if (Display.Text.Contains("-"))
            Display.Text = Display.Text.Substring(1);

            else
            Display.Text = "-" + Display.Text;
            }

        }
    }
}

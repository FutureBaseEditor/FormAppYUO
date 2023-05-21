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
            //if (Display.Text == "0")
            //    Display.Text = number;

            //////////////if (operation == "")
            //////////////{
            //////////////    Display.Text += number;
            //////////////}
            //////////////else if (operation != "" && Display.Text.Length > 0 && firstValue != Display.Text)
            //////////////{
            //////////////    Display.Text += number;
            //////////////}
            //////////////else
            //////////////{
            //////////////    Display.Text = number;
            //////////////}

            //else if(firstValue == Display.Text && operation != "")
            //    Display.Text += number;

            //else if (firstValue == Display.Text)
            //{
            //    Display.Text = number;
            //}

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
        private void C_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }
        private void BackSpace_Click(object sender, EventArgs e)
        {
            string current = Display.Text;
            string removedLast = current.Substring(0, current.Length - 1);
            Display.Text = removedLast;
        }
        private void Display_TextChanged(object sender, EventArgs e)
        {
            if (Display.Text.Length  == 0 )
            {
                Display.Text = "0";
            }
        }

        string firstValue = "0";
        string operation = "";

        private void Sum_Click(object sender, EventArgs e)
        {
            operation = "+";
            firstValue = Display.Text;
            TempDisplay.Text = $"{firstValue} {operation}";

            
        }
    }
}

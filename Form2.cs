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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.YellowGreen)
                button1.BackColor = Color.Brown;
            else if (button1.BackColor == Color.Brown)
            {
                button1.BackColor = Color.YellowGreen;
                if (button2.BackColor == Color.YellowGreen)
                    button3.BackColor = Color.Brown;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.YellowGreen)
                button2.BackColor = Color.Brown;
            else if (button2.BackColor == Color.Brown)
            {
                button2.BackColor = Color.YellowGreen;
                if (button3.BackColor == Color.YellowGreen)
                    button1.BackColor = Color.Brown;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.YellowGreen)
                button3.BackColor = Color.Brown;
            else if (button3.BackColor == Color.Brown)
            {
                button3.BackColor = Color.YellowGreen;
                if (button1.BackColor == Color.YellowGreen)
                    button2.BackColor = Color.Brown;
            }
        }
    }
}

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

        string firstNumber = "";
        string secondNumber = "";
        string result = "0";
        string operation = "";

        bool isClear = true;

        void ClearAll()
        {
            TempDisplay.Text = "";
            Display.Text = "";
            firstNumber = "";
            secondNumber = "";
            result = "0";
            operation = "";
            isClear = true;
        }
        void PressNumber(string number)
        {
            
            if (TempDisplay.Text.Contains("=") )
            {
                ClearAll();
            }

            


            if ( isClear || Display.Text=="0")
                Display.Text = number;
            else
                Display.Text += number;
            isClear = false;
        }
        void PressOperation(string operationValue)
        {
            if (TempDisplay.Text.Contains("=") && operation != "")
            {
                
                firstNumber = Display.Text;
                TempDisplay.Text = $"{firstNumber} {operation}";
                 secondNumber = "";
                 result = "0";
            }
            else
            {
                isClear = true;
                if (operation == "")
                {
                    firstNumber = Display.Text;
                }
                else
                {
                    secondNumber = Display.Text;
                    Calculate(firstNumber, secondNumber);
                    Display.Text = result;
                }
                operation = operationValue;

                if (firstNumber != "" && secondNumber != "")
                {
                    firstNumber = Display.Text;
                    TempDisplay.Text += $"{secondNumber} {operation}";
                }
                else
                {
                    TempDisplay.Text = $"{firstNumber} {operation}";
                }
            }

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
        private void Sum_Click(object sender, EventArgs e)
        {
            PressOperation("+");
        }
        private void Substract_Click(object sender, EventArgs e)
        {
            PressOperation("-");
        }
        private void Multiply_Click(object sender, EventArgs e)
        {
            PressOperation("x");
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            PressOperation("/");
        }
        private void Mod_Click(object sender, EventArgs e)
        {
            PressOperation("%");
        }
        private void Equal_Click(object sender, EventArgs e)
        {
            secondNumber = Display.Text;
            Calculate(firstNumber, secondNumber);
            Display.Text = result;
            TempDisplay.Text = $"{firstNumber} {operation} {secondNumber} =";
            isClear = true;

        }

        void Calculate(string x,string y)
        {
            double first = double.Parse(x);
            double second = double.Parse(y);

            switch (operation)
            {
                case "+":
                    first += second;
                    break;
                case "-":
                    first -= second;
                    break;
                case "x":
                    first *= second;
                    break;
                case "/":
                    first /= second;
                    break;
                case "%":
                    first %= second; ;
                    break;
            }

            result = first.ToString();
        }

        private void TempDisplay_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            PressNumber(Number4.Text);
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            PressNumber(Number5.Text);

        }

        private void Number6_Click(object sender, EventArgs e)
        {
            PressNumber(Number6.Text);

        }

        private void Number7_Click(object sender, EventArgs e)
        {
            PressNumber(Number7.Text);

        }

        private void Number8_Click(object sender, EventArgs e)
        {
            PressNumber(Number8.Text);

        }

        private void Number9_Click(object sender, EventArgs e)
        {
            PressNumber(Number9.Text);

        }
    }
}

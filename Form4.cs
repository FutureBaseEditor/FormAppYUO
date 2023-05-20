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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Hangisinden.SelectedIndex = 0;
            Hangisine.SelectedIndex = 1;

        }
    
        double CtoK(double celcius)
        {
            return celcius + 273.15;
        }
        double KtoC(double kelvin)
        {
            return kelvin - 273.15;
        }
        double FtoC(double fahrenheit)
        {
            return (fahrenheit - 32)* 5 / 9;
        }
        double CtoF(double celcius)
        {
            return celcius*9 / 5 + 32;
        }
        double FtoK(double fahrenheit)
        {
            return (fahrenheit + 459.67)* 5 / 9;
        }
        double KtoF(double kelvin)
        {
            return (kelvin * 9 / 5 - 459.67);
        }
        double CtoR(double celcius)
        {
            return (celcius + 273.15) * 9 / 5;
        }
        double RtoC(double rankine)
        {
            return (rankine - 491.67) * 5 / 9;
        }
        double KtoR(double kelvin)
        {
            return (kelvin * 9 / 5);
        }
        double FtoR(double fahrenheit)
        {
            return fahrenheit + 459.67;
        }

        void Hesapla()
        {
            // C > 0
            // F > 1
            // K > 2
            // R > 3
           
           
            double  deger = double.Parse(Girilen.Text);

            switch (Hangisinden.SelectedIndex)
            {
                case 0 when Hangisine.SelectedIndex == 0:
                    Sonuc.Text = Girilen.Text;
                    break;
                case 0 when Hangisine.SelectedIndex == 1:
                    Sonuc.Text = CtoF(deger).ToString();
                    break;
                case 0 when Hangisine.SelectedIndex == 2:
                    Sonuc.Text = CtoK(deger).ToString();
                    break;
                case 0 when Hangisine.SelectedIndex == 3:
                    Sonuc.Text = CtoR(deger).ToString();
                    break;

                case 1 when Hangisine.SelectedIndex == 1:
                    Sonuc.Text = Girilen.Text;
                    break;
                case 1 when Hangisine.SelectedIndex == 0:
                    Sonuc.Text = FtoC(deger).ToString();
                    break;
                case 1 when Hangisine.SelectedIndex == 2:
                    Sonuc.Text = FtoK(deger).ToString();
                    break;
                case 1 when Hangisine.SelectedIndex == 3:
                    Sonuc.Text = FtoR(deger).ToString();
                    break;

                case 2 when Hangisine.SelectedIndex == 2:
                    Sonuc.Text = Girilen.Text;
                    break;
                case 2 when Hangisine.SelectedIndex == 0:
                    Sonuc.Text = KtoC(deger).ToString();
                    break;
                case 2 when Hangisine.SelectedIndex == 1:
                    Sonuc.Text = KtoF(deger).ToString();
                    break;
                case 2 when Hangisine.SelectedIndex == 3:
                    Sonuc.Text = KtoR(deger).ToString();
                    break;

                case 3 when Hangisine.SelectedIndex == 3:
                    Sonuc.Text = Girilen.Text;
                    break;
                case 3 when Hangisine.SelectedIndex == 0:
                    Sonuc.Text = RtoC(deger).ToString();
                    break;
                case 3 when Hangisine.SelectedIndex == 1:
                    Sonuc.Text = "Bu ay yazılımcının maaşını yatıramdık.";
                    break;
                case 3 when Hangisine.SelectedIndex == 2:
                    Sonuc.Text = "Bu ay yazılımcının maaşını yatıramdık.";
                    break;

                    default:
                    Sonuc.Text = "Lütfen Birim Seçiniz.";
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                Hesapla();
        }
        private void Hangisinden_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void Hangisine_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void Girilen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar);
        }

        private void Girilen_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}

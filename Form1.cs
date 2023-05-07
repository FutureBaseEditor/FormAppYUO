using System.Configuration;

namespace FormAppYUO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Admin" && textBox2.Text != "1234")
            {
                MessageBox.Show("Bilgileri kontrol edip tekrar deneyiniz.");
            }
            else if (textBox1.Text != "Admin")
            {
                MessageBox.Show("Kullanýcý Adý Hatalý");
            }
            else if (textBox2.Text != "1234")
            {
                MessageBox.Show("Þifre Hatalý");
            }
            else
            {
                MessageBox.Show("Giriþ Baþarýlý");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
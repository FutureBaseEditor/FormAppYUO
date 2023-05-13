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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            //int toplam = trackBar1.Value + trackBar2.Value + trackBar3.Value;

            //if (toplam > 200)
            //{
            //    trackBar2.Value = trackBar1.Maximum - trackBar1.Value;
            //}

            if (trackBar3.Value == trackBar3.Maximum && trackBar1.Value == trackBar1.Maximum)
            {
                trackBar2.Value = trackBar2.Minimum;
            }

        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            //int toplam = trackBar1.Value + trackBar2.Value + trackBar3.Value;

            //if (toplam > 200)
            //{
            //    trackBar1.Value = trackBar1.Maximum - trackBar3.Value;
            //}

            if (trackBar1.Value == trackBar1.Maximum && trackBar3.Value == trackBar3.Maximum)
            {
                trackBar1.Value = trackBar1.Minimum;
            }
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            //int toplam = trackBar1.Value + trackBar2.Value + trackBar3.Value;

            //if (toplam > 200)
            //{
            //    trackBar3.Value = trackBar1.Maximum - trackBar2.Value;
            //}
            if (trackBar1.Value == trackBar1.Maximum && trackBar2.Value == trackBar2.Maximum)
            {
                trackBar3.Value = trackBar3.Minimum;
            }
        }
    }
}

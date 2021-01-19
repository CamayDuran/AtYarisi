using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int At1SolaUzaklik, At2SolaUzaklik, At3SolaUzaklik;
        Random rasgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int At1Genislik = pictureBox1.Width;
            int At2Genislik = pictureBox2.Width;
            int At3Genislik = pictureBox3.Width;

            pictureBox1.Left = pictureBox1.Left + rasgele.Next(5, 16);
            pictureBox2.Left = pictureBox2.Left + rasgele.Next(5, 16);
            pictureBox3.Left = pictureBox3.Left + rasgele.Next(5, 16);
            int FinishUzakligi = labelFinish.Left;

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left+5)
            {
                labelBilgi.Text = "1 Numaralı At Öne Geçti.";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                labelBilgi.Text = "2 Numaralı At Öne Geçti.";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                labelBilgi.Text = "3 Numaralı At Öne Geçti.";
            }
            if (At1Genislik + pictureBox1.Left >= FinishUzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 numaralı at kazandı ...");
            }
            if (At2Genislik + pictureBox2.Left >= FinishUzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 numaralı at kazandı ...");
            }
            if (At3Genislik + pictureBox3.Left >= FinishUzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 numaralı at kazandı ...");
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            At1SolaUzaklik = pictureBox1.Left;
            At2SolaUzaklik = pictureBox2.Left;
            At3SolaUzaklik = pictureBox3.Left;

            
        }

    }
}

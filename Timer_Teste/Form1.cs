using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Teste
{
    
    public partial class Form1 : Form
    {
        int num;
        int px, py;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            num = 0;
            px = pictureBox1.Location.X;
            py = pictureBox1.Location.Y;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = num.ToString();
                num++;

            px+=50;
            if(px >= 546)
            {
                px = 12;
            }
            pictureBox1.Location = new Point(px,py);
            px = pictureBox1.Location.X;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            label1.Text = num.ToString();
            px = 12;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}

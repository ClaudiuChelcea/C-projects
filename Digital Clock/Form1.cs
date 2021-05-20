using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        bool big_size = false;
        public Form1()
        {
            InitializeComponent();
            label4.Text = DateTime.Now.Date.ToString("MMM dd yyyy");
            label2.Text = DateTime.Now.DayOfWeek.ToString();
            label1.Text = DateTime.Now.ToString("HH:mm");
            label3.Text = DateTime.Now.ToString("ss");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label4.Text = DateTime.Now.Date.ToString("MMM dd yyyy");
            label2.Text = DateTime.Now.DayOfWeek.ToString();
            label1.Text = DateTime.Now.ToString("HH:mm");
            label3.Text = DateTime.Now.ToString("ss");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (big_size == false)
            {
                big_size = true;
                this.Width = (int) (this.Width * 1.5);
                this.Height = (int) (this.Height * 1.5);
            }
            else
            {
                big_size = false;
                this.Width = (int) (this.Width / 1.5);
                this.Height = (int) (this.Height / 1.5);
            }
        }
    }
}

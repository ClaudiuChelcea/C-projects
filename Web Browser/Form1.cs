using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BingBrowser.Navigate("https://www.bing.com/");
        }

        // Reset button
        private void button4_Click(object sender, EventArgs e)
        {
            BingBrowser.Refresh();
        }

        // Close button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // For  bing browser
        private void SearchButton_Click(object sender, EventArgs e)
        {
            BingBrowser.Navigate("https://www.bing.com/search?q=" + SearchTextBox.Text);
        }

        // Go forward
        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (!BingBrowser.GoForward())
                MessageBox.Show("There is no page to go forward to!", "Can't go forward!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }   

        // Go backward
        private void BackButton_Click(object sender, EventArgs e)
        {
            // Check if we are at the default page
            if (BingBrowser.Url.AbsolutePath == "https://www.bing.com/")
                return;

            if (!BingBrowser.GoBack())
                BingBrowser.Navigate("https://www.bing.com/");

        }

        // Home button
        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (BingBrowser.Url.AbsolutePath != "https://www.bing.com/")
                BingBrowser.Navigate("https://www.bing.com/");
        }
    }
}

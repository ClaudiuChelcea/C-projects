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
        }

        string[] file_path, file_names;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = file_path[Songs.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var obj = new OpenFileDialog();
            obj.Multiselect = true;
            if(obj.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file_names = obj.SafeFileNames;
                file_path = obj.FileNames;

                foreach(var el in file_names)
                {
                    Songs.Items.Add(el);
                }
            }
        }
    }
}

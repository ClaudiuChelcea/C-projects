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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Songs.Items.RemoveAt(Songs.SelectedIndex);
            }
            catch (IndexOutOfRangeException ex)
            {
                // Do nothing
                Console.WriteLine(ex.Message);
            }
            catch
            {
                MessageBox.Show("Invalid index! No file selected!");
            }

            int songs_count = 0;
            foreach (var song in Songs.Items)
            {
                songs_count++;

            }
            if (songs_count == 0)
            {
                axWindowsMediaPlayer1.close();
            }
        }

        private void Songs_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = file_path[Songs.SelectedIndex];
            }
            catch
            {
                try
                {
                    axWindowsMediaPlayer1.URL = file_path[Songs.SelectedIndex - 1];
                }
                catch
                {
                    // Do nothing
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var obj = new OpenFileDialog();
            obj.Multiselect = true;
            if (obj.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file_names = obj.SafeFileNames;
                file_path = obj.FileNames;

                foreach (var el in file_names)
                {
                    if (!Songs.Items.Contains(el))
                    {
                        Songs.Items.Add(el);
                    }
                }
            }
        }
    }
}
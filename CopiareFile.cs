using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppServer
{
    public partial class CopiareFile : Form
    {
        public CopiareFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = openFileDialog1.FileName;
                button2.Visible = true;
                richTextBox2.Visible = true;
                button3.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                richTextBox2.Text = folderBrowserDialog2.SelectedPath;
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(richTextBox1.Text))
            {
                if(richTextBox1.Text!=richTextBox2.Text)
                {
                    try
                    {
                        string fileName = Path.GetFileName(richTextBox1.Text);
                        string destinationFilePath = Path.Combine(richTextBox2.Text, fileName);
                        File.Copy(richTextBox1.Text, destinationFilePath);
                        MessageBox.Show("File Copied");
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("This is the same file");
                }
                
            }
        }
    }
}

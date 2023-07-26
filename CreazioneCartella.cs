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
    public partial class CreazioneCartella : Form
    {
        public CreazioneCartella()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = folderBrowserDialog1.SelectedPath;
                button2.Visible = true;
                button2.Enabled = true;
                label1.Visible = true;
                richTextBox2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(richTextBox1.Text, richTextBox2.Text);

            if (Directory.Exists(path))
            {
                MessageBox.Show("The directory already exists.");
                richTextBox2.Focus();
            }
            else
            {
                try
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("The directory was created successfully.");
                    Close();
                }
                catch (Exception ex)
                {
                    // if some error occurred display the error message
                    MessageBox.Show("Failed to create the directory: " + ex.Message);
                }
            }
        }
    }
}

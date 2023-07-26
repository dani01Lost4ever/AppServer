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
    public partial class SpostareCartella : Form
    {
        public SpostareCartella()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = folderBrowserDialog1.SelectedPath;
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
            string sourceFolderPath = richTextBox1.Text;
            string destinationFolderPath = richTextBox2.Text;
            if (!Directory.Exists(sourceFolderPath))
            {
                MessageBox.Show("Source directory does not exist.");
                return;
            }
            try
            {
                string sourceDirectoryName = new DirectoryInfo(sourceFolderPath).Name;
                string destinationPathWithDirectoryName = Path.Combine(destinationFolderPath, sourceDirectoryName);
                Directory.Move(sourceFolderPath, destinationPathWithDirectoryName);
                MessageBox.Show("Directory moved successfully.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}

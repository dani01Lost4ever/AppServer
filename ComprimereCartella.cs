using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppServer
{
    public partial class ComprimereCartella : Form
    {
        public ComprimereCartella()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = folderBrowserDialog1.SelectedPath;
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
            string folderName = new DirectoryInfo(richTextBox1.Text).Name;
            string zipFileName = folderName + ".zip";
            string destinationFilePath = Path.Combine(richTextBox2.Text, zipFileName);
            CompressFolder(richTextBox1.Text, destinationFilePath);
        }
        private void CompressFolder(string sourceFolderPath, string destinationFilePath)
        {
            try
            {
                if (!Directory.Exists(sourceFolderPath))
                {
                    MessageBox.Show("Source folder does not exist.");
                    return;
                }
                string destinationDirectory = Path.GetDirectoryName(destinationFilePath);
                Directory.CreateDirectory(destinationDirectory);
                ZipFile.CreateFromDirectory(sourceFolderPath, destinationFilePath);
                MessageBox.Show("Folder compressed successfully.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}

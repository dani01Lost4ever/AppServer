using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppServer
{
    public partial class DecompressioneCartella : Form
    {
        public DecompressioneCartella()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox2.Text = folderBrowserDialog1.SelectedPath;
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DecompressZipArchive(richTextBox1.Text, richTextBox2.Text);
        }

        private void DecompressZipArchive(string sourceFilePath, string destinationFolderPath)
        {
            try
            {
                if (!File.Exists(sourceFilePath))
                {
                    MessageBox.Show("Source zip archive does not exist.");
                    return;
                }
                Directory.CreateDirectory(destinationFolderPath);
                string tempExtractPath = Path.Combine(destinationFolderPath, "__TempExtract");
                ZipFile.ExtractToDirectory(sourceFilePath, tempExtractPath);
                string folderName = Path.GetFileNameWithoutExtension(sourceFilePath);
                string finalDestinationPath = Path.Combine(destinationFolderPath, folderName);
                Directory.Move(tempExtractPath, finalDestinationPath);
                MessageBox.Show("Zip archive decompressed successfully.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}

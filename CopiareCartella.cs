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
    public partial class CopiareCartella : Form
    {
        public CopiareCartella()
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
                progressBar1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                richTextBox2.Text = folderBrowserDialog2.SelectedPath;
                button3.Enabled = true;
                progressBar1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(richTextBox1.Text) && Directory.Exists(richTextBox2.Text))
            {
                DirectoryInfo sourceDirInfo = new DirectoryInfo(richTextBox1.Text);
                try
                {
                    CopyDirectory(sourceDirInfo, richTextBox2.Text);
                    MessageBox.Show("Directory copied successfully.");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        private static void CopyDirectory(DirectoryInfo source, string destinationPath)
        {
            string baseFolderName = source.Name;
            destinationPath = Path.Combine(destinationPath, baseFolderName);
            Directory.CreateDirectory(destinationPath);
            foreach (FileInfo file in source.GetFiles())
            {
                string destinationFile = Path.Combine(destinationPath, file.Name);
                file.CopyTo(destinationFile, true);
            }
            foreach (DirectoryInfo subDir in source.GetDirectories())
            {
                string newDestinationPath = Path.Combine(destinationPath, subDir.Name);
                CopyDirectory(subDir, newDestinationPath);
            }
        }

    }
}

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
    public partial class RinominareFile : Form
    {
        public RinominareFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = openFileDialog1.FileName;
                string sourceDirectoryName = new DirectoryInfo(richTextBox1.Text).Name;
                richTextBox2.Text = sourceDirectoryName;
            }
        }

        private void Rinomina_Click(object sender, EventArgs e)
        {
            string sourceFilePath = richTextBox1.Text;
            string newFileName = richTextBox3.Text;
            if (!File.Exists(sourceFilePath))
            {
                MessageBox.Show("The selected file does not exist.");
                return;
            }
            try
            {
                string parentDirectory = Directory.GetParent(sourceFilePath).FullName;
                string fileExtension = Path.GetExtension(sourceFilePath);
                string newFilePath = Path.Combine(parentDirectory, newFileName + fileExtension);
                File.Move(sourceFilePath, newFilePath);
                MessageBox.Show("File renamed successfully.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void OnChange(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox3.Text))
            { Rinomina.Visible = true; }
            else
            {
                Rinomina.Visible = true;
                Rinomina.Enabled = true;
            }
        }
    }
}

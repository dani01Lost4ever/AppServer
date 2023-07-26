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
    public partial class RinominareCartella : Form
    {
        public RinominareCartella()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = folderBrowserDialog1.SelectedPath;
                string sourceDirectoryName = new DirectoryInfo(richTextBox1.Text).Name;
                richTextBox2.Text = sourceDirectoryName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(richTextBox1.Text))
            {
                MessageBox.Show("The selected folder does not exist.");
                return;
            }
            try
            {
                string parentDirectory = Directory.GetParent(richTextBox1.Text).FullName;
                string newFolderPath = Path.Combine(parentDirectory, richTextBox3.Text);
                Directory.Move(richTextBox1.Text, newFolderPath);
                MessageBox.Show("Folder renamed successfully.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void OnChange(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(richTextBox3.Text))
            { Rinomina.Visible = true; }
            else
            {
                Rinomina.Visible = true;
                Rinomina.Enabled = true;
            }
        }
    }
}

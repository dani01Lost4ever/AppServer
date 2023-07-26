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
    public partial class CreazioneFile : Form
    {
        public CreazioneFile()
        {
            InitializeComponent();
        }
        string selectedValue = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = folderBrowserDialog1.SelectedPath;
                button2.Visible = true;
                label1.Visible = true;
                richTextBox2.Visible = true;
                richTextBox3.Visible = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileType = richTextBox2.Text + selectedValue;
            string path = Path.Combine(richTextBox1.Text, fileType);

            if (File.Exists(path))
            {
                MessageBox.Show("The file already exists.");
                richTextBox2.Focus();
            }
            else
            {
                try
                {
                    FileStream fileStream = File.Create(path);

                    using (StreamWriter writer = new StreamWriter(fileStream))
                    {
                        writer.WriteLine(richTextBox3.Text);

                    }
                    fileStream.Close();

                    MessageBox.Show("The file was created successfully.");
                    Close();
                }
                catch (Exception ex)
                {
                    // if some error occurred display the error message
                    MessageBox.Show("Failed to create the file: " + ex.Message);
                }
            }
        }

        private void OnChange(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex != 0)
            {
                selectedValue = comboBox1.SelectedItem.ToString();
                button2.Enabled = true;
            }
        }
    }
}

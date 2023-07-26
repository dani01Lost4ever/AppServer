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
    public partial class CancellareFile : Form
    {
        public CancellareFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = openFileDialog1.FileName;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("sei sicuro di voler cancellare la cartella?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(richTextBox1.Text);
                    MessageBox.Show("Deleted successfully");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}

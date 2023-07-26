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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppServer
{
    public partial class CancellareCartella : Form
    {
        public CancellareCartella()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = folderBrowserDialog1.SelectedPath;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("sei sicuro di voler cancellare la cartella?","Delete", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    Directory.Delete(richTextBox1.Text, true);
                    MessageBox.Show("Deleted successfully");
                    Close();
                }                
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}

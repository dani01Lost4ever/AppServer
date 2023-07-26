using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void creazioneCartellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreazioneCartella creazione= new CreazioneCartella();
            creazione.Show();
        }

        private void creazioneFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreazioneFile creazione= new CreazioneFile();
            creazione.Show();
        }

        private void copiaCartellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopiareCartella copiareCartella= new CopiareCartella();
            copiareCartella.Show();
        }

        private void copiaFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopiareFile copia= new CopiareFile();
            copia.Show();
        }

        private void cancellareCartellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancellareCartella cancellareCartella= new CancellareCartella();
            cancellareCartella.Show();
        }

        private void cancellareFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancellareFile cancellareFile= new CancellareFile();
            cancellareFile.Show();
        }

        private void spostareCartellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpostareCartella spostareCartella= new SpostareCartella();
            spostareCartella.Show();
        }

        private void spostareFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpostareFIle spostareFIle= new SpostareFIle();
            spostareFIle.Show();
        }

        private void rinominareCartellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RinominareCartella rinominareCartella = new RinominareCartella();
            rinominareCartella.Show();
        }

        private void rinominareFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RinominareFile rinominareFile = new RinominareFile();
            rinominareFile.Show();
        }

        private void comprimereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComprimereCartella comprimereCartella = new ComprimereCartella();
            comprimereCartella.Show();
        }

        private void decomprimereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DecompressioneCartella decompression = new DecompressioneCartella();
            decompression.Show();
        }
    }
}

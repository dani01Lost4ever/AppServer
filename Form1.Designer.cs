namespace AppServer
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.copiareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creazioneCartellaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creazioneFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaCartellaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellareCartellaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellareFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spostareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spostareCartellaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spostareFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rinominareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rinominareCartellaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rinominareFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprimereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decomprimereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiareToolStripMenuItem,
            this.copiareToolStripMenuItem1,
            this.cancellareToolStripMenuItem,
            this.spostareToolStripMenuItem,
            this.rinominareToolStripMenuItem,
            this.compressioneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // copiareToolStripMenuItem
            // 
            this.copiareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creazioneCartellaToolStripMenuItem,
            this.creazioneFileToolStripMenuItem});
            this.copiareToolStripMenuItem.Name = "copiareToolStripMenuItem";
            this.copiareToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.copiareToolStripMenuItem.Text = "Creare";
            // 
            // creazioneCartellaToolStripMenuItem
            // 
            this.creazioneCartellaToolStripMenuItem.Name = "creazioneCartellaToolStripMenuItem";
            this.creazioneCartellaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.creazioneCartellaToolStripMenuItem.Text = "Creazione Cartella";
            this.creazioneCartellaToolStripMenuItem.Click += new System.EventHandler(this.creazioneCartellaToolStripMenuItem_Click);
            // 
            // creazioneFileToolStripMenuItem
            // 
            this.creazioneFileToolStripMenuItem.Name = "creazioneFileToolStripMenuItem";
            this.creazioneFileToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.creazioneFileToolStripMenuItem.Text = "Creazione File";
            this.creazioneFileToolStripMenuItem.Click += new System.EventHandler(this.creazioneFileToolStripMenuItem_Click);
            // 
            // copiareToolStripMenuItem1
            // 
            this.copiareToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiaCartellaToolStripMenuItem,
            this.copiaFileToolStripMenuItem});
            this.copiareToolStripMenuItem1.Name = "copiareToolStripMenuItem1";
            this.copiareToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.copiareToolStripMenuItem1.Text = "Copiare";
            // 
            // copiaCartellaToolStripMenuItem
            // 
            this.copiaCartellaToolStripMenuItem.Name = "copiaCartellaToolStripMenuItem";
            this.copiaCartellaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.copiaCartellaToolStripMenuItem.Text = "Copia Cartella";
            this.copiaCartellaToolStripMenuItem.Click += new System.EventHandler(this.copiaCartellaToolStripMenuItem_Click);
            // 
            // copiaFileToolStripMenuItem
            // 
            this.copiaFileToolStripMenuItem.Name = "copiaFileToolStripMenuItem";
            this.copiaFileToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.copiaFileToolStripMenuItem.Text = "Copia File";
            this.copiaFileToolStripMenuItem.Click += new System.EventHandler(this.copiaFileToolStripMenuItem_Click);
            // 
            // cancellareToolStripMenuItem
            // 
            this.cancellareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancellareCartellaToolStripMenuItem,
            this.cancellareFileToolStripMenuItem});
            this.cancellareToolStripMenuItem.Name = "cancellareToolStripMenuItem";
            this.cancellareToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.cancellareToolStripMenuItem.Text = "Cancellare";
            // 
            // cancellareCartellaToolStripMenuItem
            // 
            this.cancellareCartellaToolStripMenuItem.Name = "cancellareCartellaToolStripMenuItem";
            this.cancellareCartellaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cancellareCartellaToolStripMenuItem.Text = "Cancellare Cartella";
            this.cancellareCartellaToolStripMenuItem.Click += new System.EventHandler(this.cancellareCartellaToolStripMenuItem_Click);
            // 
            // cancellareFileToolStripMenuItem
            // 
            this.cancellareFileToolStripMenuItem.Name = "cancellareFileToolStripMenuItem";
            this.cancellareFileToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cancellareFileToolStripMenuItem.Text = "Cancellare File";
            this.cancellareFileToolStripMenuItem.Click += new System.EventHandler(this.cancellareFileToolStripMenuItem_Click);
            // 
            // spostareToolStripMenuItem
            // 
            this.spostareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spostareCartellaToolStripMenuItem,
            this.spostareFileToolStripMenuItem});
            this.spostareToolStripMenuItem.Name = "spostareToolStripMenuItem";
            this.spostareToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.spostareToolStripMenuItem.Text = "Spostare";
            // 
            // spostareCartellaToolStripMenuItem
            // 
            this.spostareCartellaToolStripMenuItem.Name = "spostareCartellaToolStripMenuItem";
            this.spostareCartellaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.spostareCartellaToolStripMenuItem.Text = "Spostare Cartella";
            this.spostareCartellaToolStripMenuItem.Click += new System.EventHandler(this.spostareCartellaToolStripMenuItem_Click);
            // 
            // spostareFileToolStripMenuItem
            // 
            this.spostareFileToolStripMenuItem.Name = "spostareFileToolStripMenuItem";
            this.spostareFileToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.spostareFileToolStripMenuItem.Text = "Spostare File";
            this.spostareFileToolStripMenuItem.Click += new System.EventHandler(this.spostareFileToolStripMenuItem_Click);
            // 
            // rinominareToolStripMenuItem
            // 
            this.rinominareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rinominareCartellaToolStripMenuItem,
            this.rinominareFileToolStripMenuItem});
            this.rinominareToolStripMenuItem.Name = "rinominareToolStripMenuItem";
            this.rinominareToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.rinominareToolStripMenuItem.Text = "Rinominare";
            // 
            // rinominareCartellaToolStripMenuItem
            // 
            this.rinominareCartellaToolStripMenuItem.Name = "rinominareCartellaToolStripMenuItem";
            this.rinominareCartellaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.rinominareCartellaToolStripMenuItem.Text = "Rinominare Cartella";
            this.rinominareCartellaToolStripMenuItem.Click += new System.EventHandler(this.rinominareCartellaToolStripMenuItem_Click);
            // 
            // rinominareFileToolStripMenuItem
            // 
            this.rinominareFileToolStripMenuItem.Name = "rinominareFileToolStripMenuItem";
            this.rinominareFileToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.rinominareFileToolStripMenuItem.Text = "Rinominare File";
            this.rinominareFileToolStripMenuItem.Click += new System.EventHandler(this.rinominareFileToolStripMenuItem_Click);
            // 
            // compressioneToolStripMenuItem
            // 
            this.compressioneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprimereToolStripMenuItem,
            this.decomprimereToolStripMenuItem});
            this.compressioneToolStripMenuItem.Name = "compressioneToolStripMenuItem";
            this.compressioneToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.compressioneToolStripMenuItem.Text = "Compressione";
            // 
            // comprimereToolStripMenuItem
            // 
            this.comprimereToolStripMenuItem.Name = "comprimereToolStripMenuItem";
            this.comprimereToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comprimereToolStripMenuItem.Text = "Comprimere";
            this.comprimereToolStripMenuItem.Click += new System.EventHandler(this.comprimereToolStripMenuItem_Click);
            // 
            // decomprimereToolStripMenuItem
            // 
            this.decomprimereToolStripMenuItem.Name = "decomprimereToolStripMenuItem";
            this.decomprimereToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.decomprimereToolStripMenuItem.Text = "Decomprimere";
            this.decomprimereToolStripMenuItem.Click += new System.EventHandler(this.decomprimereToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Link to the repository, Daniel Busetto";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(404, 426);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(234, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/dani01Lost4ever/AppServer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Orbitron Black", 48F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(91, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(624, 81);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server Manager";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AppServer.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(239, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 299);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copiareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creazioneCartellaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creazioneFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copiaCartellaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiaFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancellareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancellareCartellaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancellareFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spostareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spostareCartellaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spostareFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rinominareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rinominareCartellaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rinominareFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compressioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprimereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decomprimereToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


namespace StorageApp
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.svojstvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITLOLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skladisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izbrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narudzbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prodanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.svojstvaToolStripMenuItem,
            this.skladisteToolStripMenuItem,
            this.narudzbeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // svojstvaToolStripMenuItem
            // 
            this.svojstvaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITLOLToolStripMenuItem});
            this.svojstvaToolStripMenuItem.Name = "svojstvaToolStripMenuItem";
            this.svojstvaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.svojstvaToolStripMenuItem.Text = "Svojstva";
            // 
            // eXITLOLToolStripMenuItem
            // 
            this.eXITLOLToolStripMenuItem.Name = "eXITLOLToolStripMenuItem";
            this.eXITLOLToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.eXITLOLToolStripMenuItem.Text = "EXIT LOL";
            // 
            // skladisteToolStripMenuItem
            // 
            this.skladisteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.izbrisiToolStripMenuItem});
            this.skladisteToolStripMenuItem.Name = "skladisteToolStripMenuItem";
            this.skladisteToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.skladisteToolStripMenuItem.Text = "Skladiste";
            this.skladisteToolStripMenuItem.Click += new System.EventHandler(this.skladisteToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // izbrisiToolStripMenuItem
            // 
            this.izbrisiToolStripMenuItem.Name = "izbrisiToolStripMenuItem";
            this.izbrisiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izbrisiToolStripMenuItem.Text = "Traži";
            this.izbrisiToolStripMenuItem.Click += new System.EventHandler(this.izbrisiToolStripMenuItem_Click);
            // 
            // narudzbeToolStripMenuItem
            // 
            this.narudzbeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noveToolStripMenuItem,
            this.stareToolStripMenuItem,
            this.prodanoToolStripMenuItem});
            this.narudzbeToolStripMenuItem.Name = "narudzbeToolStripMenuItem";
            this.narudzbeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.narudzbeToolStripMenuItem.Text = "Narudzbe";
            // 
            // noveToolStripMenuItem
            // 
            this.noveToolStripMenuItem.Name = "noveToolStripMenuItem";
            this.noveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noveToolStripMenuItem.Text = "Kreiraj";
            this.noveToolStripMenuItem.Click += new System.EventHandler(this.noveToolStripMenuItem_Click);
            // 
            // stareToolStripMenuItem
            // 
            this.stareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem1});
            this.stareToolStripMenuItem.Name = "stareToolStripMenuItem";
            this.stareToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stareToolStripMenuItem.Text = "Kupci";
            // 
            // dodajToolStripMenuItem1
            // 
            this.dodajToolStripMenuItem1.Name = "dodajToolStripMenuItem1";
            this.dodajToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.dodajToolStripMenuItem1.Text = "Pretraga";
            this.dodajToolStripMenuItem1.Click += new System.EventHandler(this.dodajToolStripMenuItem1_Click);
            // 
            // prodanoToolStripMenuItem
            // 
            this.prodanoToolStripMenuItem.Name = "prodanoToolStripMenuItem";
            this.prodanoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.prodanoToolStripMenuItem.Text = "Prodano";
            this.prodanoToolStripMenuItem.Click += new System.EventHandler(this.prodanoToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(560, 374);
            this.MainPanel.TabIndex = 4;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 398);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrame";
            this.Text = "Skladiste";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem skladisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izbrisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narudzbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prodanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem svojstvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITLOLToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
    }
}


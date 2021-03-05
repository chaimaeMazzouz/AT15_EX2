namespace AT15_Ex2
{
    partial class Home
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
            this.impressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeChauffeursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeVoyagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeVoyagesChauffeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeVoyagesVilleDépartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesVoyagesÀVenirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impressionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // impressionToolStripMenuItem
            // 
            this.impressionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeChauffeursToolStripMenuItem,
            this.listeVoyagesToolStripMenuItem,
            this.listeVoyagesChauffeurToolStripMenuItem,
            this.listeVoyagesVilleDépartToolStripMenuItem,
            this.listeDesVoyagesÀVenirToolStripMenuItem});
            this.impressionToolStripMenuItem.Name = "impressionToolStripMenuItem";
            this.impressionToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.impressionToolStripMenuItem.Text = "Impression";
            // 
            // listeChauffeursToolStripMenuItem
            // 
            this.listeChauffeursToolStripMenuItem.Name = "listeChauffeursToolStripMenuItem";
            this.listeChauffeursToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.listeChauffeursToolStripMenuItem.Text = "Liste Chauffeurs";
            this.listeChauffeursToolStripMenuItem.Click += new System.EventHandler(this.listeChauffeursToolStripMenuItem_Click);
            // 
            // listeVoyagesToolStripMenuItem
            // 
            this.listeVoyagesToolStripMenuItem.Name = "listeVoyagesToolStripMenuItem";
            this.listeVoyagesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.listeVoyagesToolStripMenuItem.Text = "Liste Voyages";
            this.listeVoyagesToolStripMenuItem.Click += new System.EventHandler(this.listeVoyagesToolStripMenuItem_Click);
            // 
            // listeVoyagesChauffeurToolStripMenuItem
            // 
            this.listeVoyagesChauffeurToolStripMenuItem.Name = "listeVoyagesChauffeurToolStripMenuItem";
            this.listeVoyagesChauffeurToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.listeVoyagesChauffeurToolStripMenuItem.Text = "liste Voyages Chauffeur";
            this.listeVoyagesChauffeurToolStripMenuItem.Click += new System.EventHandler(this.listeVoyagesChauffeurToolStripMenuItem_Click);
            // 
            // listeVoyagesVilleDépartToolStripMenuItem
            // 
            this.listeVoyagesVilleDépartToolStripMenuItem.Name = "listeVoyagesVilleDépartToolStripMenuItem";
            this.listeVoyagesVilleDépartToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.listeVoyagesVilleDépartToolStripMenuItem.Text = "Liste voyages ville départ";
            this.listeVoyagesVilleDépartToolStripMenuItem.Click += new System.EventHandler(this.listeVoyagesVilleDépartToolStripMenuItem_Click);
            // 
            // listeDesVoyagesÀVenirToolStripMenuItem
            // 
            this.listeDesVoyagesÀVenirToolStripMenuItem.Name = "listeDesVoyagesÀVenirToolStripMenuItem";
            this.listeDesVoyagesÀVenirToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.listeDesVoyagesÀVenirToolStripMenuItem.Text = "Liste des voyages à venir";
            this.listeDesVoyagesÀVenirToolStripMenuItem.Click += new System.EventHandler(this.listeDesVoyagesÀVenirToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem impressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeChauffeursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeVoyagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeVoyagesChauffeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeVoyagesVilleDépartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesVoyagesÀVenirToolStripMenuItem;
    }
}


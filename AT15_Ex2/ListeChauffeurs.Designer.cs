namespace AT15_Ex2
{
    partial class ListeChauffeurs
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
            this.crystalReportViewerChauffeurs = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportChauffeurs1 = new AT15_Ex2.CrystalReportChauffeurs();
            this.SuspendLayout();
            // 
            // crystalReportViewerChauffeurs
            // 
            this.crystalReportViewerChauffeurs.ActiveViewIndex = 0;
            this.crystalReportViewerChauffeurs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerChauffeurs.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerChauffeurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerChauffeurs.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerChauffeurs.Name = "crystalReportViewerChauffeurs";
            this.crystalReportViewerChauffeurs.ReportSource = this.CrystalReportChauffeurs1;
            this.crystalReportViewerChauffeurs.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerChauffeurs.TabIndex = 0;
            // 
            // ListeChauffeurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerChauffeurs);
            this.Name = "ListeChauffeurs";
            this.Text = "ListeChauffeurs";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerChauffeurs;
        private CrystalReportChauffeurs CrystalReportChauffeurs1;
    }
}
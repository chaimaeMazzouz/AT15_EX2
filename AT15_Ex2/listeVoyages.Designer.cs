namespace AT15_Ex2
{
    partial class listeVoyages
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
            this.crystalReportViewerVoyage = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportVoyage1 = new AT15_Ex2.CrystalReportVoyage();
            this.SuspendLayout();
            // 
            // crystalReportViewerVoyage
            // 
            this.crystalReportViewerVoyage.ActiveViewIndex = 0;
            this.crystalReportViewerVoyage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerVoyage.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerVoyage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerVoyage.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerVoyage.Name = "crystalReportViewerVoyage";
            this.crystalReportViewerVoyage.ReportSource = this.CrystalReportVoyage1;
            this.crystalReportViewerVoyage.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerVoyage.TabIndex = 0;
            // 
            // listeVoyages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerVoyage);
            this.Name = "listeVoyages";
            this.Text = "listeVoyages";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerVoyage;
        private CrystalReportVoyage CrystalReportVoyage1;
    }
}
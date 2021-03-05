namespace AT15_Ex2
{
    partial class voyages_par_chauffeur
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
            this.crystalReportViewerVgCh = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportVgCh1 = new AT15_Ex2.CrystalReportVgCh();
            this.SuspendLayout();
            // 
            // crystalReportViewerVgCh
            // 
            this.crystalReportViewerVgCh.ActiveViewIndex = 0;
            this.crystalReportViewerVgCh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerVgCh.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerVgCh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerVgCh.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerVgCh.Name = "crystalReportViewerVgCh";
            this.crystalReportViewerVgCh.ReportSource = this.CrystalReportVgCh1;
            this.crystalReportViewerVgCh.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerVgCh.TabIndex = 0;
            // 
            // voyages_par_chauffeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerVgCh);
            this.Name = "voyages_par_chauffeur";
            this.Text = "voyages_par_chauffeur";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerVgCh;
        private CrystalReportVgCh CrystalReportVgCh1;
    }
}
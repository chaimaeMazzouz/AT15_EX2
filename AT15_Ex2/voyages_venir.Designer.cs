namespace AT15_Ex2
{
    partial class voyages_venir
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
            this.crystalReportViewerVenir = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportVenir1 = new AT15_Ex2.CrystalReportVenir();
            this.SuspendLayout();
            // 
            // crystalReportViewerVenir
            // 
            this.crystalReportViewerVenir.ActiveViewIndex = 0;
            this.crystalReportViewerVenir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerVenir.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerVenir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerVenir.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerVenir.Name = "crystalReportViewerVenir";
            this.crystalReportViewerVenir.ReportSource = this.CrystalReportVenir1;
            this.crystalReportViewerVenir.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerVenir.TabIndex = 0;
            // 
            // voyages_venir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerVenir);
            this.Name = "voyages_venir";
            this.Text = "voyages_venir";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerVenir;
        private CrystalReportVenir CrystalReportVenir1;
    }
}
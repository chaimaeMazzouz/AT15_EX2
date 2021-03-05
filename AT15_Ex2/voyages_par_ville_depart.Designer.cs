namespace AT15_Ex2
{
    partial class voyages_par_ville_depart
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
            this.crystalReportViewerVlDp = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportVlDp1 = new AT15_Ex2.CrystalReportVlDp();
            this.SuspendLayout();
            // 
            // crystalReportViewerVlDp
            // 
            this.crystalReportViewerVlDp.ActiveViewIndex = 0;
            this.crystalReportViewerVlDp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerVlDp.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerVlDp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerVlDp.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerVlDp.Name = "crystalReportViewerVlDp";
            this.crystalReportViewerVlDp.ReportSource = this.CrystalReportVlDp1;
            this.crystalReportViewerVlDp.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerVlDp.TabIndex = 0;
            // 
            // voyages_par_ville_depart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerVlDp);
            this.Name = "voyages_par_ville_depart";
            this.Text = "voyages_par_ville_depart";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerVlDp;
        private CrystalReportVlDp CrystalReportVlDp1;
    }
}
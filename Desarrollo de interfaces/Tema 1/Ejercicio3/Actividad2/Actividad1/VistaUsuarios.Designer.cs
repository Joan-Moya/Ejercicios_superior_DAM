namespace Actividad1.Reports
{
    partial class VistaUsuarios
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportUsuarios1 = new Actividad1.CrystalReportUsuarios();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReportUsuarios1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(2042, 810);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VistaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2042, 810);
            this.Controls.Add(this.crystalReportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VistaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaUsuarios";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReportUsuarios CrystalReportUsuarios1;
    }
}
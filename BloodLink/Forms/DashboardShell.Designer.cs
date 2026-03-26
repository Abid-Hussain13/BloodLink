namespace BloodLink.Forms
{
    partial class DashboardShell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // ── pnlSidebar ─────────────────────────────
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 720);
            this.pnlSidebar.TabIndex = 0;
            this.pnlSidebar.Anchor = System.Windows.Forms.AnchorStyles.Top
                                   | System.Windows.Forms.AnchorStyles.Left
                                   | System.Windows.Forms.AnchorStyles.Bottom;

            // ── pnlHeader ──────────────────────────────
            this.pnlHeader.Location = new System.Drawing.Point(220, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(980, 56);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top
                                  | System.Windows.Forms.AnchorStyles.Left
                                  | System.Windows.Forms.AnchorStyles.Right;

            // ── pnlContent ─────────────────────────────
            this.pnlContent.Location = new System.Drawing.Point(220, 56);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(980, 664);
            this.pnlContent.TabIndex = 2;
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContent.Anchor = System.Windows.Forms.AnchorStyles.Top
                                   | System.Windows.Forms.AnchorStyles.Left
                                   | System.Windows.Forms.AnchorStyles.Bottom
                                   | System.Windows.Forms.AnchorStyles.Right;

            // ── DashboardShell ─────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "DashboardShell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloodLink";
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlContent);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        // ─── Control declarations ──────────────────────
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
    }
}
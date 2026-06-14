namespace BloodLink.Pages
{
    partial class SettingView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpSettingPage = new TableLayoutPanel();
            tlpSession = new TableLayoutPanel();
            pnlSessionHeading = new Panel();
            lblSessionHeading = new Label();
            label1 = new Label();
            lblSessoinFooter = new Label();
            pnlSessionValue = new Panel();
            cbSessionValue = new ComboBox();
            tlpExpiringThreshold = new TableLayoutPanel();
            tlpExpiringThresholdHeading = new Panel();
            lblThresholdHeading = new Label();
            pnlThresholdSubHeading = new Panel();
            lblThresholdSubHeading = new Label();
            pnlThresholdCountHeading = new Panel();
            lblThresholdCountHeading = new Label();
            pnlThresholdCount = new Panel();
            tbThresholdCount = new TextBox();
            tlpSettingPage.SuspendLayout();
            tlpSession.SuspendLayout();
            pnlSessionHeading.SuspendLayout();
            pnlSessionValue.SuspendLayout();
            tlpExpiringThreshold.SuspendLayout();
            tlpExpiringThresholdHeading.SuspendLayout();
            pnlThresholdSubHeading.SuspendLayout();
            pnlThresholdCountHeading.SuspendLayout();
            pnlThresholdCount.SuspendLayout();
            SuspendLayout();
            // 
            // tlpSettingPage
            // 
            tlpSettingPage.ColumnCount = 1;
            tlpSettingPage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSettingPage.Controls.Add(tlpSession, 0, 0);
            tlpSettingPage.Controls.Add(tlpExpiringThreshold, 0, 1);
            tlpSettingPage.Dock = DockStyle.Fill;
            tlpSettingPage.Location = new Point(0, 0);
            tlpSettingPage.Name = "tlpSettingPage";
            tlpSettingPage.RowCount = 3;
            tlpSettingPage.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5939493F));
            tlpSettingPage.RowStyles.Add(new RowStyle(SizeType.Percent, 26.3432236F));
            tlpSettingPage.RowStyles.Add(new RowStyle(SizeType.Percent, 58.0628242F));
            tlpSettingPage.Size = new Size(781, 496);
            tlpSettingPage.TabIndex = 0;
            // 
            // tlpSession
            // 
            tlpSession.ColumnCount = 2;
            tlpSession.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSession.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSession.Controls.Add(pnlSessionHeading, 0, 0);
            tlpSession.Controls.Add(lblSessoinFooter, 0, 1);
            tlpSession.Controls.Add(pnlSessionValue, 1, 0);
            tlpSession.Dock = DockStyle.Fill;
            tlpSession.Location = new Point(3, 3);
            tlpSession.Name = "tlpSession";
            tlpSession.Padding = new Padding(15, 18, 15, 18);
            tlpSession.RowCount = 2;
            tlpSession.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSession.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSession.Size = new Size(775, 71);
            tlpSession.TabIndex = 0;
            // 
            // pnlSessionHeading
            // 
            pnlSessionHeading.Controls.Add(lblSessionHeading);
            pnlSessionHeading.Controls.Add(label1);
            pnlSessionHeading.Dock = DockStyle.Fill;
            pnlSessionHeading.Location = new Point(18, 21);
            pnlSessionHeading.Name = "pnlSessionHeading";
            pnlSessionHeading.Size = new Size(366, 11);
            pnlSessionHeading.TabIndex = 0;
            // 
            // lblSessionHeading
            // 
            lblSessionHeading.Dock = DockStyle.Fill;
            lblSessionHeading.Location = new Point(0, 0);
            lblSessionHeading.Name = "lblSessionHeading";
            lblSessionHeading.Padding = new Padding(0, 0, 0, 2);
            lblSessionHeading.Size = new Size(366, 11);
            lblSessionHeading.TabIndex = 2;
            lblSessionHeading.Text = "Session timeout";
            lblSessionHeading.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 34);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // lblSessoinFooter
            // 
            lblSessoinFooter.AutoSize = true;
            lblSessoinFooter.Location = new Point(18, 35);
            lblSessoinFooter.Name = "lblSessoinFooter";
            lblSessoinFooter.Padding = new Padding(0, 2, 0, 0);
            lblSessoinFooter.Size = new Size(188, 17);
            lblSessoinFooter.TabIndex = 1;
            lblSessoinFooter.Text = "Auto-logout after inactivity period";
            // 
            // pnlSessionValue
            // 
            pnlSessionValue.Controls.Add(cbSessionValue);
            pnlSessionValue.Dock = DockStyle.Fill;
            pnlSessionValue.Location = new Point(390, 21);
            pnlSessionValue.Name = "pnlSessionValue";
            tlpSession.SetRowSpan(pnlSessionValue, 2);
            pnlSessionValue.Size = new Size(367, 29);
            pnlSessionValue.TabIndex = 2;
            // 
            // cbSessionValue
            // 
            cbSessionValue.Anchor = AnchorStyles.Right;
            cbSessionValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSessionValue.FormattingEnabled = true;
            cbSessionValue.Location = new Point(226, 0);
            cbSessionValue.Name = "cbSessionValue";
            cbSessionValue.Size = new Size(138, 28);
            cbSessionValue.TabIndex = 3;
            // 
            // tlpExpiringThreshold
            // 
            tlpExpiringThreshold.ColumnCount = 2;
            tlpExpiringThreshold.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpExpiringThreshold.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpExpiringThreshold.Controls.Add(tlpExpiringThresholdHeading, 0, 0);
            tlpExpiringThreshold.Controls.Add(pnlThresholdSubHeading, 0, 1);
            tlpExpiringThreshold.Controls.Add(pnlThresholdCountHeading, 0, 2);
            tlpExpiringThreshold.Controls.Add(pnlThresholdCount, 0, 3);
            tlpExpiringThreshold.Dock = DockStyle.Fill;
            tlpExpiringThreshold.Location = new Point(6, 80);
            tlpExpiringThreshold.Margin = new Padding(6, 3, 3, 3);
            tlpExpiringThreshold.Name = "tlpExpiringThreshold";
            tlpExpiringThreshold.Padding = new Padding(15, 18, 15, 18);
            tlpExpiringThreshold.RowCount = 4;
            tlpExpiringThreshold.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpExpiringThreshold.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpExpiringThreshold.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpExpiringThreshold.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpExpiringThreshold.Size = new Size(772, 124);
            tlpExpiringThreshold.TabIndex = 1;
            // 
            // tlpExpiringThresholdHeading
            // 
            tlpExpiringThresholdHeading.Controls.Add(lblThresholdHeading);
            tlpExpiringThresholdHeading.Dock = DockStyle.Fill;
            tlpExpiringThresholdHeading.Location = new Point(18, 21);
            tlpExpiringThresholdHeading.Name = "tlpExpiringThresholdHeading";
            tlpExpiringThresholdHeading.Size = new Size(365, 16);
            tlpExpiringThresholdHeading.TabIndex = 0;
            // 
            // lblThresholdHeading
            // 
            lblThresholdHeading.Dock = DockStyle.Fill;
            lblThresholdHeading.Location = new Point(0, 0);
            lblThresholdHeading.Name = "lblThresholdHeading";
            lblThresholdHeading.Size = new Size(365, 16);
            lblThresholdHeading.TabIndex = 0;
            lblThresholdHeading.Text = "Low stock threshold";
            lblThresholdHeading.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlThresholdSubHeading
            // 
            pnlThresholdSubHeading.Controls.Add(lblThresholdSubHeading);
            pnlThresholdSubHeading.Dock = DockStyle.Fill;
            pnlThresholdSubHeading.Location = new Point(18, 43);
            pnlThresholdSubHeading.Name = "pnlThresholdSubHeading";
            pnlThresholdSubHeading.Size = new Size(365, 11);
            pnlThresholdSubHeading.TabIndex = 1;
            // 
            // lblThresholdSubHeading
            // 
            lblThresholdSubHeading.Dock = DockStyle.Fill;
            lblThresholdSubHeading.Location = new Point(0, 0);
            lblThresholdSubHeading.Name = "lblThresholdSubHeading";
            lblThresholdSubHeading.Size = new Size(365, 11);
            lblThresholdSubHeading.TabIndex = 0;
            lblThresholdSubHeading.Text = "Update expiring units stats according to threshold";
            // 
            // pnlThresholdCountHeading
            // 
            pnlThresholdCountHeading.Controls.Add(lblThresholdCountHeading);
            pnlThresholdCountHeading.Dock = DockStyle.Fill;
            pnlThresholdCountHeading.Location = new Point(18, 60);
            pnlThresholdCountHeading.Name = "pnlThresholdCountHeading";
            pnlThresholdCountHeading.Size = new Size(365, 16);
            pnlThresholdCountHeading.TabIndex = 2;
            // 
            // lblThresholdCountHeading
            // 
            lblThresholdCountHeading.Dock = DockStyle.Fill;
            lblThresholdCountHeading.Location = new Point(0, 0);
            lblThresholdCountHeading.Name = "lblThresholdCountHeading";
            lblThresholdCountHeading.Size = new Size(365, 16);
            lblThresholdCountHeading.TabIndex = 0;
            lblThresholdCountHeading.Text = "Minimum Units Threshold";
            lblThresholdCountHeading.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlThresholdCount
            // 
            pnlThresholdCount.Controls.Add(tbThresholdCount);
            pnlThresholdCount.Dock = DockStyle.Fill;
            pnlThresholdCount.Location = new Point(18, 82);
            pnlThresholdCount.Name = "pnlThresholdCount";
            pnlThresholdCount.Size = new Size(365, 21);
            pnlThresholdCount.TabIndex = 3;
            // 
            // tbThresholdCount
            // 
            tbThresholdCount.Dock = DockStyle.Fill;
            tbThresholdCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbThresholdCount.Location = new Point(0, 0);
            tbThresholdCount.Name = "tbThresholdCount";
            tbThresholdCount.Size = new Size(365, 27);
            tbThresholdCount.TabIndex = 0;
            // 
            // SettingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpSettingPage);
            Name = "SettingPage";
            Size = new Size(781, 496);
            tlpSettingPage.ResumeLayout(false);
            tlpSession.ResumeLayout(false);
            tlpSession.PerformLayout();
            pnlSessionHeading.ResumeLayout(false);
            pnlSessionHeading.PerformLayout();
            pnlSessionValue.ResumeLayout(false);
            tlpExpiringThreshold.ResumeLayout(false);
            tlpExpiringThresholdHeading.ResumeLayout(false);
            pnlThresholdSubHeading.ResumeLayout(false);
            pnlThresholdCountHeading.ResumeLayout(false);
            pnlThresholdCount.ResumeLayout(false);
            pnlThresholdCount.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpSettingPage;
        private TableLayoutPanel tlpSession;
        private Panel pnlSessionHeading;
        private Label label1;
        private Label lblSessoinFooter;
        private Panel pnlSessionValue;
        private ComboBox cbSessionValue;
        private Label lblSessionHeading;
        private TableLayoutPanel tlpExpiringThreshold;
        private Panel tlpExpiringThresholdHeading;
        private Label lblThresholdHeading;
        private Panel pnlThresholdSubHeading;
        private Label lblThresholdSubHeading;
        private Panel pnlThresholdCountHeading;
        private Label lblThresholdCountHeading;
        private Panel pnlThresholdCount;
        private TextBox tbThresholdCount;
    }
}

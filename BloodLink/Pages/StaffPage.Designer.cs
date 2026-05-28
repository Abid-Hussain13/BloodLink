namespace BloodLink.Pages
{
    partial class StaffPage
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
            tlpStaffPage = new TableLayoutPanel();
            flpStaffStripe = new FlowLayoutPanel();
            btnAddOperator = new Button();
            tlpStaffPage.SuspendLayout();
            flpStaffStripe.SuspendLayout();
            SuspendLayout();
            // 
            // tlpStaffPage
            // 
            tlpStaffPage.ColumnCount = 1;
            tlpStaffPage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpStaffPage.Controls.Add(flpStaffStripe, 0, 0);
            tlpStaffPage.Dock = DockStyle.Fill;
            tlpStaffPage.Location = new Point(0, 0);
            tlpStaffPage.Name = "tlpStaffPage";
            tlpStaffPage.RowCount = 2;
            tlpStaffPage.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpStaffPage.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tlpStaffPage.Size = new Size(811, 487);
            tlpStaffPage.TabIndex = 0;
            // 
            // flpStaffStripe
            // 
            flpStaffStripe.Controls.Add(btnAddOperator);
            flpStaffStripe.Dock = DockStyle.Fill;
            flpStaffStripe.FlowDirection = FlowDirection.RightToLeft;
            flpStaffStripe.Location = new Point(3, 3);
            flpStaffStripe.Name = "flpStaffStripe";
            flpStaffStripe.Padding = new Padding(0, 5, 0, 0);
            flpStaffStripe.Size = new Size(805, 42);
            flpStaffStripe.TabIndex = 0;
            // 
            // btnAddOperator
            // 
            btnAddOperator.Anchor = AnchorStyles.None;
            btnAddOperator.AutoSize = true;
            btnAddOperator.FlatStyle = FlatStyle.Flat;
            btnAddOperator.Location = new Point(703, 8);
            btnAddOperator.Margin = new Padding(4, 3, 0, 7);
            btnAddOperator.Name = "btnAddOperator";
            btnAddOperator.Size = new Size(102, 27);
            btnAddOperator.TabIndex = 13;
            btnAddOperator.Text = "+ Add Operator";
            btnAddOperator.UseVisualStyleBackColor = false;
            // 
            // StaffPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpStaffPage);
            Name = "StaffPage";
            Size = new Size(811, 487);
            tlpStaffPage.ResumeLayout(false);
            flpStaffStripe.ResumeLayout(false);
            flpStaffStripe.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpStaffPage;
        private FlowLayoutPanel flpStaffStripe;
        private Button btnAddOperator;
    }
}

namespace BloodLink.Forms
{
    partial class UserForm
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
            pnlUserForm = new Panel();
            pnlFormStyling = new Panel();
            tlpUserForm = new TableLayoutPanel();
            pnlConfirmPassword = new Panel();
            tbConfirmPass = new TextBox();
            lblConfirmPass = new Label();
            pnlCreatedAt = new Panel();
            dtpCreatedAt = new DateTimePicker();
            lblCreatedAt = new Label();
            pnlName = new Panel();
            tbName = new TextBox();
            lblName = new Label();
            pnlPassword = new Panel();
            tbPassword = new TextBox();
            lblPassword = new Label();
            pnlRole = new Panel();
            cbRole = new ComboBox();
            lblRole = new Label();
            pnlEmail = new Panel();
            tbEmail = new TextBox();
            lblEmail = new Label();
            pnlUserId = new Panel();
            tbUserId = new TextBox();
            lblUserId = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            pnlFormHeading = new Panel();
            lblUserFormHeading = new Label();
            lblConfirmPassword = new Label();
            tbConfirmPassword = new TextBox();
            pnlUserForm.SuspendLayout();
            pnlFormStyling.SuspendLayout();
            tlpUserForm.SuspendLayout();
            pnlConfirmPassword.SuspendLayout();
            pnlCreatedAt.SuspendLayout();
            pnlName.SuspendLayout();
            pnlPassword.SuspendLayout();
            pnlRole.SuspendLayout();
            pnlEmail.SuspendLayout();
            pnlUserId.SuspendLayout();
            pnlFormHeading.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUserForm
            // 
            pnlUserForm.Controls.Add(pnlFormStyling);
            pnlUserForm.Controls.Add(pnlFormHeading);
            pnlUserForm.Dock = DockStyle.Fill;
            pnlUserForm.Location = new Point(0, 0);
            pnlUserForm.Name = "pnlUserForm";
            pnlUserForm.Padding = new Padding(10);
            pnlUserForm.Size = new Size(712, 388);
            pnlUserForm.TabIndex = 2;
            // 
            // pnlFormStyling
            // 
            pnlFormStyling.Controls.Add(tlpUserForm);
            pnlFormStyling.Dock = DockStyle.Fill;
            pnlFormStyling.Location = new Point(10, 45);
            pnlFormStyling.Name = "pnlFormStyling";
            pnlFormStyling.Padding = new Padding(5);
            pnlFormStyling.Size = new Size(692, 333);
            pnlFormStyling.TabIndex = 1;
            // 
            // tlpUserForm
            // 
            tlpUserForm.ColumnCount = 2;
            tlpUserForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUserForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUserForm.Controls.Add(pnlConfirmPassword, 1, 2);
            tlpUserForm.Controls.Add(pnlCreatedAt, 0, 3);
            tlpUserForm.Controls.Add(pnlName, 1, 0);
            tlpUserForm.Controls.Add(pnlPassword, 0, 2);
            tlpUserForm.Controls.Add(pnlRole, 1, 1);
            tlpUserForm.Controls.Add(pnlEmail, 0, 1);
            tlpUserForm.Controls.Add(pnlUserId, 0, 0);
            tlpUserForm.Controls.Add(btnSave, 1, 4);
            tlpUserForm.Controls.Add(btnCancel, 0, 4);
            tlpUserForm.Dock = DockStyle.Fill;
            tlpUserForm.Location = new Point(5, 5);
            tlpUserForm.Name = "tlpUserForm";
            tlpUserForm.RowCount = 5;
            tlpUserForm.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpUserForm.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9999981F));
            tlpUserForm.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9999981F));
            tlpUserForm.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9999981F));
            tlpUserForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpUserForm.Size = new Size(682, 323);
            tlpUserForm.TabIndex = 2;
            // 
            // pnlConfirmPassword
            // 
            pnlConfirmPassword.Controls.Add(tbConfirmPass);
            pnlConfirmPassword.Controls.Add(lblConfirmPass);
            pnlConfirmPassword.Dock = DockStyle.Fill;
            pnlConfirmPassword.Location = new Point(344, 139);
            pnlConfirmPassword.Margin = new Padding(3, 3, 6, 3);
            pnlConfirmPassword.Name = "pnlConfirmPassword";
            pnlConfirmPassword.Size = new Size(332, 62);
            pnlConfirmPassword.TabIndex = 34;
            // 
            // tbConfirmPass
            // 
            tbConfirmPass.Dock = DockStyle.Top;
            tbConfirmPass.Location = new Point(0, 20);
            tbConfirmPass.Name = "tbConfirmPass";
            tbConfirmPass.Size = new Size(332, 23);
            tbConfirmPass.TabIndex = 4;
            tbConfirmPass.UseSystemPasswordChar = true;
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.Dock = DockStyle.Top;
            lblConfirmPass.Location = new Point(0, 0);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Padding = new Padding(0, 0, 0, 5);
            lblConfirmPass.Size = new Size(104, 20);
            lblConfirmPass.TabIndex = 1;
            lblConfirmPass.Text = "Confirm Password";
            // 
            // pnlCreatedAt
            // 
            pnlCreatedAt.Controls.Add(dtpCreatedAt);
            pnlCreatedAt.Controls.Add(lblCreatedAt);
            pnlCreatedAt.Dock = DockStyle.Fill;
            pnlCreatedAt.Location = new Point(3, 207);
            pnlCreatedAt.Name = "pnlCreatedAt";
            pnlCreatedAt.Size = new Size(335, 62);
            pnlCreatedAt.TabIndex = 33;
            // 
            // dtpCreatedAt
            // 
            dtpCreatedAt.CustomFormat = "dd-MM-yyyy";
            dtpCreatedAt.Dock = DockStyle.Top;
            dtpCreatedAt.Enabled = false;
            dtpCreatedAt.Format = DateTimePickerFormat.Custom;
            dtpCreatedAt.Location = new Point(0, 20);
            dtpCreatedAt.Name = "dtpCreatedAt";
            dtpCreatedAt.Size = new Size(335, 23);
            dtpCreatedAt.TabIndex = 4;
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.AutoSize = true;
            lblCreatedAt.Dock = DockStyle.Top;
            lblCreatedAt.Location = new Point(0, 0);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Padding = new Padding(0, 0, 0, 5);
            lblCreatedAt.Size = new Size(63, 20);
            lblCreatedAt.TabIndex = 3;
            lblCreatedAt.Text = "Created At";
            // 
            // pnlName
            // 
            pnlName.Controls.Add(tbName);
            pnlName.Controls.Add(lblName);
            pnlName.Dock = DockStyle.Fill;
            pnlName.Location = new Point(344, 3);
            pnlName.Margin = new Padding(3, 3, 6, 3);
            pnlName.Name = "pnlName";
            pnlName.Size = new Size(332, 62);
            pnlName.TabIndex = 32;
            // 
            // tbName
            // 
            tbName.Dock = DockStyle.Top;
            tbName.Location = new Point(0, 20);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "Asad Khan";
            tbName.Size = new Size(332, 23);
            tbName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Top;
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Padding = new Padding(0, 0, 0, 5);
            lblName.Size = new Size(61, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Full Name";
            // 
            // pnlPassword
            // 
            pnlPassword.Controls.Add(tbPassword);
            pnlPassword.Controls.Add(lblPassword);
            pnlPassword.Dock = DockStyle.Fill;
            pnlPassword.Location = new Point(3, 139);
            pnlPassword.Margin = new Padding(3, 3, 6, 3);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(332, 62);
            pnlPassword.TabIndex = 24;
            // 
            // tbPassword
            // 
            tbPassword.Dock = DockStyle.Top;
            tbPassword.Location = new Point(0, 20);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "least 6 charaters";
            tbPassword.Size = new Size(332, 23);
            tbPassword.TabIndex = 4;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Dock = DockStyle.Top;
            lblPassword.Location = new Point(0, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Padding = new Padding(0, 0, 0, 5);
            lblPassword.Size = new Size(57, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // pnlRole
            // 
            pnlRole.Controls.Add(cbRole);
            pnlRole.Controls.Add(lblRole);
            pnlRole.Dock = DockStyle.Fill;
            pnlRole.Location = new Point(347, 71);
            pnlRole.Margin = new Padding(6, 3, 3, 3);
            pnlRole.Name = "pnlRole";
            pnlRole.Size = new Size(332, 62);
            pnlRole.TabIndex = 23;
            // 
            // cbRole
            // 
            cbRole.Dock = DockStyle.Top;
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(0, 20);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(332, 23);
            cbRole.TabIndex = 3;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Dock = DockStyle.Top;
            lblRole.Location = new Point(0, 0);
            lblRole.Name = "lblRole";
            lblRole.Padding = new Padding(0, 0, 0, 5);
            lblRole.Size = new Size(30, 20);
            lblRole.TabIndex = 1;
            lblRole.Text = "Role";
            // 
            // pnlEmail
            // 
            pnlEmail.Controls.Add(tbEmail);
            pnlEmail.Controls.Add(lblEmail);
            pnlEmail.Dock = DockStyle.Fill;
            pnlEmail.Location = new Point(3, 71);
            pnlEmail.Margin = new Padding(3, 3, 6, 3);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Size = new Size(332, 62);
            pnlEmail.TabIndex = 22;
            // 
            // tbEmail
            // 
            tbEmail.Dock = DockStyle.Top;
            tbEmail.Location = new Point(0, 20);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "asad@gmail.com";
            tbEmail.Size = new Size(332, 23);
            tbEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Top;
            lblEmail.Location = new Point(0, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Padding = new Padding(0, 0, 0, 5);
            lblEmail.Size = new Size(36, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // pnlUserId
            // 
            pnlUserId.Controls.Add(tbUserId);
            pnlUserId.Controls.Add(lblUserId);
            pnlUserId.Dock = DockStyle.Fill;
            pnlUserId.Location = new Point(3, 3);
            pnlUserId.Margin = new Padding(3, 3, 6, 3);
            pnlUserId.Name = "pnlUserId";
            pnlUserId.Size = new Size(332, 62);
            pnlUserId.TabIndex = 21;
            // 
            // tbUserId
            // 
            tbUserId.Dock = DockStyle.Top;
            tbUserId.Enabled = false;
            tbUserId.Location = new Point(0, 20);
            tbUserId.Name = "tbUserId";
            tbUserId.PlaceholderText = "Auto Generated";
            tbUserId.ReadOnly = true;
            tbUserId.Size = new Size(332, 23);
            tbUserId.TabIndex = 2;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Dock = DockStyle.Top;
            lblUserId.Location = new Point(0, 0);
            lblUserId.Name = "lblUserId";
            lblUserId.Padding = new Padding(0, 0, 0, 5);
            lblUserId.Size = new Size(44, 20);
            lblUserId.TabIndex = 1;
            lblUserId.Text = "User ID";
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(347, 275);
            btnSave.Margin = new Padding(6, 3, 3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(332, 45);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            btnSave.MouseEnter += btnSave_MouseEnter;
            btnSave.MouseLeave += btnSave_MouseLeave;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(3, 275);
            btnCancel.Margin = new Padding(3, 3, 6, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(332, 45);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            btnCancel.MouseEnter += btnCancel_MouseEnter;
            btnCancel.MouseLeave += btnCancel_MouseLeave;
            // 
            // pnlFormHeading
            // 
            pnlFormHeading.Controls.Add(lblUserFormHeading);
            pnlFormHeading.Dock = DockStyle.Top;
            pnlFormHeading.Location = new Point(10, 10);
            pnlFormHeading.Name = "pnlFormHeading";
            pnlFormHeading.Size = new Size(692, 35);
            pnlFormHeading.TabIndex = 0;
            // 
            // lblUserFormHeading
            // 
            lblUserFormHeading.AutoSize = true;
            lblUserFormHeading.Location = new Point(5, 0);
            lblUserFormHeading.Margin = new Padding(3, 0, 3, 5);
            lblUserFormHeading.Name = "lblUserFormHeading";
            lblUserFormHeading.Size = new Size(55, 15);
            lblUserFormHeading.TabIndex = 0;
            lblUserFormHeading.Text = "Add User";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Dock = DockStyle.Top;
            lblConfirmPassword.Location = new Point(0, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Padding = new Padding(0, 0, 0, 5);
            lblConfirmPassword.Size = new Size(104, 20);
            lblConfirmPassword.TabIndex = 1;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Dock = DockStyle.Top;
            tbConfirmPassword.Location = new Point(0, 20);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(332, 23);
            tbConfirmPassword.TabIndex = 4;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 388);
            Controls.Add(pnlUserForm);
            Name = "UserForm";
            Text = "UserForm";
            pnlUserForm.ResumeLayout(false);
            pnlFormStyling.ResumeLayout(false);
            tlpUserForm.ResumeLayout(false);
            pnlConfirmPassword.ResumeLayout(false);
            pnlConfirmPassword.PerformLayout();
            pnlCreatedAt.ResumeLayout(false);
            pnlCreatedAt.PerformLayout();
            pnlName.ResumeLayout(false);
            pnlName.PerformLayout();
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            pnlRole.ResumeLayout(false);
            pnlRole.PerformLayout();
            pnlEmail.ResumeLayout(false);
            pnlEmail.PerformLayout();
            pnlUserId.ResumeLayout(false);
            pnlUserId.PerformLayout();
            pnlFormHeading.ResumeLayout(false);
            pnlFormHeading.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUserForm;
        private Panel pnlFormStyling;
        private TableLayoutPanel tlpUserForm;
        private Panel pnlBloodGroup;
        private ComboBox cbBloodGroup;
        private Label lblConfirmPassword;
        private Panel pnlPassword;
        private Label lblPassword;
        private Panel pnlRole;
        private Label lblRole;
        private Panel pnlUserId;
        private TextBox tbUserId;
        private Label lblUserId;
        private Button btnSave;
        private Button btnCancel;
        private Panel pnlFormHeading;
        private Label lblUserFormHeading;
        private Panel pnlName;
        private TextBox tbName;
        private Label lblName;
        private Panel pnlEmail;
        private TextBox tbEmail;
        private Label lblEmail;
        private ComboBox cbRole;
        private TextBox tbPassword;
        private TextBox tbConfirmPassword;
        private Panel pnlCreatedAt;
        private DateTimePicker dtpCreatedAt;
        private Label lblCreatedAt;
        private Panel pnlConfirmPassword;
        private TextBox tbConfirmPass;
        private Label lblConfirmPass;
    }
}
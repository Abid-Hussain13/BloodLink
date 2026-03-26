namespace BloodLink.Forms
{
    partial class RegisterForm
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblLoginLink = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();

            // ── pnlLeft ────────────────────────────────
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(380, 620);
            this.pnlLeft.TabIndex = 0;
            this.pnlLeft.Controls.Add(this.lblLogo);
            this.pnlLeft.Controls.Add(this.lblTagline);

            // ── lblLogo ────────────────────────────────
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(50, 180);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Text = "🩸 BloodLink";

            // ── lblTagline ─────────────────────────────
            this.lblTagline.AutoSize = true;
            this.lblTagline.BackColor = System.Drawing.Color.Transparent;
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(220, 180, 178);
            this.lblTagline.Location = new System.Drawing.Point(50, 255);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Text = "Join our community.\r\nBe a lifesaver today.";

            // ── pnlRight ───────────────────────────────
            this.pnlRight.Location = new System.Drawing.Point(380, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(520, 620);
            this.pnlRight.TabIndex = 1;
            this.pnlRight.Controls.Add(this.lblWelcome);
            this.pnlRight.Controls.Add(this.lblSubtitle);
            this.pnlRight.Controls.Add(this.lblFullName);
            this.pnlRight.Controls.Add(this.txtFullName);
            this.pnlRight.Controls.Add(this.lblEmail);
            this.pnlRight.Controls.Add(this.txtEmail);
            this.pnlRight.Controls.Add(this.lblPassword);
            this.pnlRight.Controls.Add(this.txtPassword);
            this.pnlRight.Controls.Add(this.lblConfirmPassword);
            this.pnlRight.Controls.Add(this.txtConfirmPassword);
            this.pnlRight.Controls.Add(this.lblRole);
            this.pnlRight.Controls.Add(this.cmbRole);
            this.pnlRight.Controls.Add(this.lblError);
            this.pnlRight.Controls.Add(this.lblSuccess);
            this.pnlRight.Controls.Add(this.btnRegister);
            this.pnlRight.Controls.Add(this.lblLoginLink);

            // ── lblWelcome ─────────────────────────────
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(60, 45);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Text = "Create account";

            // ── lblSubtitle ────────────────────────────
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.Location = new System.Drawing.Point(60, 80);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Join BloodLink and save lives";

            // ── lblFullName ────────────────────────────
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(60, 118);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Text = "Full name";

            // ── txtFullName ────────────────────────────
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFullName.Location = new System.Drawing.Point(60, 140);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PlaceholderText = "Enter your full name";
            this.txtFullName.Size = new System.Drawing.Size(380, 40);
            this.txtFullName.TabIndex = 0;

            // ── lblEmail ───────────────────────────────
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(60, 188);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Text = "Email address";

            // ── txtEmail ───────────────────────────────
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.Location = new System.Drawing.Point(60, 210);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Enter your email";
            this.txtEmail.Size = new System.Drawing.Size(380, 40);
            this.txtEmail.TabIndex = 1;

            // ── lblPassword ────────────────────────────
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(60, 258);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Text = "Password";

            // ── txtPassword ────────────────────────────
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(60, 280);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "Enter your password";
            this.txtPassword.Size = new System.Drawing.Size(380, 40);
            this.txtPassword.TabIndex = 2;

            // ── lblConfirmPassword ─────────────────────
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPassword.Location = new System.Drawing.Point(60, 328);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Text = "Confirm password";

            // ── txtConfirmPassword ─────────────────────
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(60, 350);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.PlaceholderText = "Confirm your password";
            this.txtConfirmPassword.Size = new System.Drawing.Size(380, 40);
            this.txtConfirmPassword.TabIndex = 3;

            // ── lblRole ────────────────────────────────
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRole.Location = new System.Drawing.Point(60, 398);
            this.lblRole.Name = "lblRole";
            this.lblRole.Text = "I am registering as";

            // ── cmbRole ────────────────────────────────
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbRole.Location = new System.Drawing.Point(60, 420);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(380, 40);
            this.cmbRole.TabIndex = 4;

            // ── lblError ───────────────────────────────
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblError.Location = new System.Drawing.Point(60, 468);
            this.lblError.Name = "lblError";
            this.lblError.Text = "";
            this.lblError.Visible = false;

            // ── lblSuccess ─────────────────────────────
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSuccess.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblSuccess.Location = new System.Drawing.Point(60, 468);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Text = "";
            this.lblSuccess.Visible = false;

            // ── btnRegister ────────────────────────────
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(60, 490);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(380, 45);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Create Account";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.RegisterButton_Click);

            // ── lblLoginLink ───────────────────────────
            this.lblLoginLink.AutoSize = true;
            this.lblLoginLink.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoginLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoginLink.Location = new System.Drawing.Point(60, 548);
            this.lblLoginLink.Name = "lblLoginLink";
            this.lblLoginLink.Text = "Already have an account? Login here";
            this.lblLoginLink.Click += new System.EventHandler(this.LoginLink_Click);

            // ── RegisterForm ───────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloodLink — Register";
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        // ─── Control declarations ──────────────────────
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblLoginLink;
    }
}
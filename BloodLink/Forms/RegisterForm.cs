using BloodLink.Helpers;
using BloodLink.Models;
using BloodLink.Services;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BloodLink.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly AuthService _authService;

        public RegisterForm()
        {
            InitializeComponent();
            _authService = new AuthService();
            PopulateRoles();
            ApplyTheme();
        }

        // ─────────────────────────────────────────────────
        // POPULATE — fills ComboBox with role options
        // Done here not in Designer because it uses EnumHelper
        // ─────────────────────────────────────────────────
        private void PopulateRoles()
        {
            foreach (Role role in Enum.GetValues(typeof(Role)))
            {
                cmbRole.Items.Add(EnumHelper.GetDescription(role));
            }
            cmbRole.SelectedIndex = 0;
        }

        // ─────────────────────────────────────────────────
        // THEME — applies colors from AppTheme to controls
        // ─────────────────────────────────────────────────
        private void ApplyTheme()
        {
            // ── Form ───────────────────────────────────
            this.BackColor = AppTheme.Background;

            // ── Left panel — gradient ──────────────────
            pnlLeft.BackColor = AppTheme.GradientStart;
            pnlLeft.Paint -= LeftPanel_Paint;
            pnlLeft.Paint += LeftPanel_Paint;

            // ── Right panel ────────────────────────────
            pnlRight.BackColor = AppTheme.CardBackground;

            // ── Labels ─────────────────────────────────
            lblWelcome.ForeColor = AppTheme.PrimaryText;
            lblSubtitle.ForeColor = AppTheme.MutedText;
            lblFullName.ForeColor = AppTheme.BodyText;
            lblEmail.ForeColor = AppTheme.BodyText;
            lblPassword.ForeColor = AppTheme.BodyText;
            lblConfirmPassword.ForeColor = AppTheme.BodyText;
            lblRole.ForeColor = AppTheme.BodyText;
            lblError.ForeColor = AppTheme.ErrorRed;
            lblSuccess.ForeColor = AppTheme.SuccessGreen;
            lblLoginLink.ForeColor = AppTheme.BloodRed;

            // ── Inputs ─────────────────────────────────
            txtFullName.BackColor = AppTheme.Surface;
            txtFullName.ForeColor = AppTheme.PrimaryText;
            txtEmail.BackColor = AppTheme.Surface;
            txtEmail.ForeColor = AppTheme.PrimaryText;
            txtPassword.BackColor = AppTheme.Surface;
            txtPassword.ForeColor = AppTheme.PrimaryText;
            txtConfirmPassword.BackColor = AppTheme.Surface;
            txtConfirmPassword.ForeColor = AppTheme.PrimaryText;

            // ── ComboBox ───────────────────────────────
            cmbRole.BackColor = AppTheme.Surface;
            cmbRole.ForeColor = AppTheme.PrimaryText;

            // ── Button ─────────────────────────────────
            btnRegister.BackColor = AppTheme.PrimaryRed;
            btnRegister.ForeColor = AppTheme.White;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.MouseEnter -= BtnRegister_MouseEnter;
            btnRegister.MouseLeave -= BtnRegister_MouseLeave;
            btnRegister.MouseEnter += BtnRegister_MouseEnter;
            btnRegister.MouseLeave += BtnRegister_MouseLeave;
        }

        // ─────────────────────────────────────────────────
        // PAINT EVENTS
        // ─────────────────────────────────────────────────
        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {
            using var brush = new LinearGradientBrush(
                pnlLeft.ClientRectangle,
                AppTheme.GradientStart,
                AppTheme.GradientEnd,
                LinearGradientMode.ForwardDiagonal
            );
            e.Graphics.FillRectangle(brush, pnlLeft.ClientRectangle);

            // Decorative circles
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using var pen1 = new Pen(Color.FromArgb(40, 255, 255, 255), 1);
            e.Graphics.DrawEllipse(pen1, 90, 360, 199, 199);
            using var pen2 = new Pen(Color.FromArgb(20, 255, 255, 255), 1);
            e.Graphics.DrawEllipse(pen2, 110, 380, 159, 159);
        }

        // ─────────────────────────────────────────────────
        // EVENT HANDLERS
        // ─────────────────────────────────────────────────
        private void BtnRegister_MouseEnter(object sender, EventArgs e)
            => btnRegister.BackColor = AppTheme.BrightRed;

        private void BtnRegister_MouseLeave(object sender, EventArgs e)
            => btnRegister.BackColor = AppTheme.PrimaryRed;

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            lblSuccess.Visible = false;

            Role selectedRole = EnumHelper.GetValueFromDescription<Role>(
                cmbRole.SelectedItem.ToString()
            );

            var result = _authService.Register(
                txtFullName.Text,
                txtEmail.Text,
                txtPassword.Text,
                txtConfirmPassword.Text,
                selectedRole
            );

            if (!result.success)
            {
                lblError.Text = result.message;
                lblError.Visible = true;
                return;
            }

            lblSuccess.Text = "Account created! Redirecting to login...";
            lblSuccess.Visible = true;
            btnRegister.Enabled = false;

            var timer = new System.Windows.Forms.Timer { Interval = 1500 };
            timer.Tick += (s, ev) =>
            {
                timer.Stop();
                this.Close();
            };
            timer.Start();
        }

        private void LoginLink_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
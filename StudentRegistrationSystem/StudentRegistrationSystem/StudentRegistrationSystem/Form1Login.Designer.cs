//namespace StudentRegistrationSystem
//{
//    partial class Form1Login
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        private System.Windows.Forms.PictureBox pictureBoxLogo;
//        private System.Windows.Forms.Label labelTitle;
//        private System.Windows.Forms.GroupBox groupBoxLogin;
//        private System.Windows.Forms.Label labelUsername;
//        private System.Windows.Forms.Label labelPassword;
//        private System.Windows.Forms.TextBox txtUsername;
//        private System.Windows.Forms.TextBox txtPassword;
//        private System.Windows.Forms.Button btnClear;
//        private System.Windows.Forms.Button btnLogin;
//        private System.Windows.Forms.Button btnExit;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
//            this.labelTitle = new System.Windows.Forms.Label();
//            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
//            this.labelUsername = new System.Windows.Forms.Label();
//            this.labelPassword = new System.Windows.Forms.Label();
//            this.txtUsername = new System.Windows.Forms.TextBox();
//            this.txtPassword = new System.Windows.Forms.TextBox();
//            this.btnClear = new System.Windows.Forms.Button();
//            this.btnLogin = new System.Windows.Forms.Button();
//            this.btnExit = new System.Windows.Forms.Button();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
//            this.groupBoxLogin.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // Form1
//            // 
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(600, 420);
//            this.Text = "Login - Skills International";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            // 
//            // pictureBoxLogo
//            // 
//            this.pictureBoxLogo.Location = new System.Drawing.Point(240, 12);
//            this.pictureBoxLogo.Name = "pictureBoxLogo";
//            this.pictureBoxLogo.Size = new System.Drawing.Size(120, 100);
//            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.pictureBoxLogo.TabIndex = 0;
//            this.pictureBoxLogo.TabStop = false;
//            // Note: Set Image at runtime or via designer; left blank in code-behind
//            // 
//            // labelTitle
//            // 
//            this.labelTitle.AutoSize = true;
//            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.labelTitle.Location = new System.Drawing.Point(170, 120);
//            this.labelTitle.Name = "labelTitle";
//            this.labelTitle.Size = new System.Drawing.Size(260, 37);
//            this.labelTitle.TabIndex = 1;
//            this.labelTitle.Text = "Skills International";
//            // 
//            // groupBoxLogin
//            // 
//            this.groupBoxLogin.Controls.Add(this.labelUsername);
//            this.groupBoxLogin.Controls.Add(this.txtUsername);
//            this.groupBoxLogin.Controls.Add(this.labelPassword);
//            this.groupBoxLogin.Controls.Add(this.txtPassword);
//            this.groupBoxLogin.Controls.Add(this.btnClear);
//            this.groupBoxLogin.Controls.Add(this.btnLogin);
//            this.groupBoxLogin.Location = new System.Drawing.Point(80, 170);
//            this.groupBoxLogin.Name = "groupBoxLogin";
//            this.groupBoxLogin.Size = new System.Drawing.Size(440, 170);
//            this.groupBoxLogin.TabIndex = 2;
//            this.groupBoxLogin.TabStop = false;
//            this.groupBoxLogin.Text = "Login";
//            // 
//            // labelUsername
//            // 
//            this.labelUsername.AutoSize = true;
//            this.labelUsername.Location = new System.Drawing.Point(40, 40);
//            this.labelUsername.Name = "labelUsername";
//            this.labelUsername.Size = new System.Drawing.Size(60, 13);
//            this.labelUsername.TabIndex = 0;
//            this.labelUsername.Text = "Username";
//            // 
//            // txtUsername
//            // 
//            this.txtUsername.Location = new System.Drawing.Point(160, 36);
//            this.txtUsername.Name = "txtUsername";
//            this.txtUsername.Size = new System.Drawing.Size(220, 20);
//            this.txtUsername.TabIndex = 1;
//            // 
//            // labelPassword
//            // 
//            this.labelPassword.AutoSize = true;
//            this.labelPassword.Location = new System.Drawing.Point(40, 80);
//            this.labelPassword.Name = "labelPassword";
//            this.labelPassword.Size = new System.Drawing.Size(56, 13);
//            this.labelPassword.TabIndex = 2;
//            this.labelPassword.Text = "Password";
//            // 
//            // txtPassword
//            // 
//            this.txtPassword.Location = new System.Drawing.Point(160, 76);
//            this.txtPassword.Name = "txtPassword";
//            this.txtPassword.Size = new System.Drawing.Size(220, 20);
//            this.txtPassword.TabIndex = 3;
//            this.txtPassword.UseSystemPasswordChar = true;
//            // 
//            // btnClear
//            // 
//            this.btnClear.Location = new System.Drawing.Point(80, 120);
//            this.btnClear.Name = "btnClear";
//            this.btnClear.Size = new System.Drawing.Size(80, 30);
//            this.btnClear.TabIndex = 4;
//            this.btnClear.Text = "Clear";
//            this.btnClear.UseVisualStyleBackColor = true;
//            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
//            // 
//            // btnLogin
//            // 
//            this.btnLogin.Location = new System.Drawing.Point(280, 120);
//            this.btnLogin.Name = "btnLogin";
//            this.btnLogin.Size = new System.Drawing.Size(80, 30);
//            this.btnLogin.TabIndex = 5;
//            this.btnLogin.Text = "Login";
//            this.btnLogin.UseVisualStyleBackColor = true;
//            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
//            // 
//            // btnExit
//            // 
//            this.btnExit.Location = new System.Drawing.Point(12, 360);
//            this.btnExit.Name = "btnExit";
//            this.btnExit.Size = new System.Drawing.Size(80, 30);
//            this.btnExit.TabIndex = 6;
//            this.btnExit.Text = "Exit";
//            this.btnExit.UseVisualStyleBackColor = true;
//            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
//            // 
//            // Form controls add
//            // 
//            this.Controls.Add(this.pictureBoxLogo);
//            this.Controls.Add(this.labelTitle);
//            this.Controls.Add(this.groupBoxLogin);
//            this.Controls.Add(this.btnExit);
//            // 
//            // finalize
//            // 
//            this.groupBoxLogin.ResumeLayout(false);
//            this.groupBoxLogin.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();
//        }

//        #endregion
//    }
//}



namespace StudentRegistrationSystem
{
    partial class Form1Login
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.PictureBox picSideBanner;
        private System.Windows.Forms.Label lblSideTitle;
        private System.Windows.Forms.Label lblSideSubtitle;
        private System.Windows.Forms.Label lblSideVersion;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubhead;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFooter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.picSideBanner = new System.Windows.Forms.PictureBox();
            this.lblSideTitle = new System.Windows.Forms.Label();
            this.lblSideSubtitle = new System.Windows.Forms.Label();
            this.lblSideVersion = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubhead = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.picSideBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();

            // ── FORM ─────────────────────────────────────────────
            this.Text = "Login — Skills International";
            this.ClientSize = new System.Drawing.Size(760, 460);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(27, 58, 92);

            // ── LEFT PANEL ───────────────────────────────────────
            this.pnlLeft.Size = new System.Drawing.Size(300, 460);
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(27, 58, 92);

            // side_banner.jpg  — put a university/campus photo here (300x200 px)
            // Free images: https://unsplash.com/s/photos/university
            this.picSideBanner.Location = new System.Drawing.Point(0, 0);
            this.picSideBanner.Size = new System.Drawing.Size(300, 210);
            this.picSideBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSideBanner.BackColor = System.Drawing.Color.FromArgb(15, 40, 70);
            ImageUtil.LoadImage(this.picSideBanner, "side_banner.jpg");

            this.lblSideTitle.AutoSize = false;
            this.lblSideTitle.Size = new System.Drawing.Size(270, 44);
            this.lblSideTitle.Location = new System.Drawing.Point(18, 222);
            this.lblSideTitle.Text = "Skills International";
            this.lblSideTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblSideTitle.ForeColor = System.Drawing.Color.White;

            this.lblSideSubtitle.AutoSize = false;
            this.lblSideSubtitle.Size = new System.Drawing.Size(270, 70);
            this.lblSideSubtitle.Location = new System.Drawing.Point(18, 268);
            this.lblSideSubtitle.Text = "Student Registration System\r\nSecure Admin Portal";
            this.lblSideSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSideSubtitle.ForeColor = System.Drawing.Color.FromArgb(160, 200, 240);

            this.lblSideVersion.AutoSize = true;
            this.lblSideVersion.Location = new System.Drawing.Point(18, 434);
            this.lblSideVersion.Text = "v2.0  ·  2025";
            this.lblSideVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSideVersion.ForeColor = System.Drawing.Color.FromArgb(100, 140, 180);

            this.pnlLeft.Controls.Add(this.picSideBanner);
            this.pnlLeft.Controls.Add(this.lblSideTitle);
            this.pnlLeft.Controls.Add(this.lblSideSubtitle);
            this.pnlLeft.Controls.Add(this.lblSideVersion);

            // ── RIGHT PANEL ──────────────────────────────────────
            this.pnlRight.Size = new System.Drawing.Size(460, 460);
            this.pnlRight.Location = new System.Drawing.Point(300, 0);
            this.pnlRight.BackColor = System.Drawing.Color.White;

            // logo.png — your school logo (120x80 transparent PNG)
            this.picLogo.Location = new System.Drawing.Point(170, 26);
            this.picLogo.Size = new System.Drawing.Size(120, 76);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            ImageUtil.LoadImage(this.picLogo, "logo.png");

            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(116, 116);
            this.lblWelcome.Text = "Welcome back";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(27, 58, 92);

            this.lblSubhead.AutoSize = true;
            this.lblSubhead.Location = new System.Drawing.Point(116, 150);
            this.lblSubhead.Text = "Sign in to manage student records";
            this.lblSubhead.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubhead.ForeColor = System.Drawing.Color.FromArgb(110, 120, 140);

            MkLabel(this.lblUser, "USERNAME", 50, 195);
            MkInput(this.txtUsername, 50, 213, 360, false);

            MkLabel(this.lblPass, "PASSWORD", 50, 255);
            MkInput(this.txtPassword, 50, 273, 360, true);

            MkBtn(this.btnLogin, "Sign In  \u2192", 50, 326, 158, 38,
                  System.Drawing.Color.FromArgb(27, 58, 92), System.Drawing.Color.White);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            MkBtn(this.btnClear, "Clear", 222, 326, 86, 38,
                  System.Drawing.Color.FromArgb(235, 238, 242), System.Drawing.Color.FromArgb(80, 92, 115));
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            MkBtn(this.btnExit, "Exit", 322, 326, 86, 38,
                  System.Drawing.Color.FromArgb(235, 238, 242), System.Drawing.Color.FromArgb(80, 92, 115));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            this.lblFooter.AutoSize = false;
            this.lblFooter.Size = new System.Drawing.Size(460, 28);
            this.lblFooter.Location = new System.Drawing.Point(0, 432);
            this.lblFooter.Text = "\u00a9 2025 Skills International. All rights reserved.";
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(160, 170, 185);
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(248, 249, 252);
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlRight.Controls.Add(this.picLogo);
            this.pnlRight.Controls.Add(this.lblWelcome);
            this.pnlRight.Controls.Add(this.lblSubhead);
            this.pnlRight.Controls.Add(this.lblUser);
            this.pnlRight.Controls.Add(this.txtUsername);
            this.pnlRight.Controls.Add(this.lblPass);
            this.pnlRight.Controls.Add(this.txtPassword);
            this.pnlRight.Controls.Add(this.btnLogin);
            this.pnlRight.Controls.Add(this.btnClear);
            this.pnlRight.Controls.Add(this.btnExit);
            this.pnlRight.Controls.Add(this.lblFooter);

            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);

            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSideBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
        }

        // ── Helpers ──────────────────────────────────────────────────
        private static void MkLabel(System.Windows.Forms.Label lbl, string text, int x, int y)
        {
            lbl.AutoSize = true;
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Text = text;
            lbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.FromArgb(110, 120, 140);
        }

        private static void MkInput(System.Windows.Forms.TextBox tb, int x, int y, int w, bool pwd)
        {
            tb.Location = new System.Drawing.Point(x, y);
            tb.Size = new System.Drawing.Size(w, 28);
            tb.Font = new System.Drawing.Font("Segoe UI", 10F);
            tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tb.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            tb.ForeColor = System.Drawing.Color.FromArgb(30, 30, 40);
            if (pwd) tb.UseSystemPasswordChar = true;
        }

        private static void MkBtn(System.Windows.Forms.Button btn, string text,
            int x, int y, int w, int h,
            System.Drawing.Color back, System.Drawing.Color fore)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(w, h);
            btn.BackColor = back;
            btn.ForeColor = fore;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.UseVisualStyleBackColor = false;
        }

        // Images are loaded via ImageUtil.LoadImage to support multiple lookup strategies

        #endregion
    }
}
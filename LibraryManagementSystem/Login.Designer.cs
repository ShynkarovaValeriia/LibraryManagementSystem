namespace LibraryManagementSystem
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblSignIn = new System.Windows.Forms.Label();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblFirstVisit = new System.Windows.Forms.Label();
            this.linkRegister = new System.Windows.Forms.Button();
            this.pictureLine = new System.Windows.Forms.PictureBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnNormal = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.eyeClose = new System.Windows.Forms.PictureBox();
            this.eyeOpen = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLine)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSignIn
            // 
            this.lblSignIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.ForeColor = System.Drawing.Color.Black;
            this.lblSignIn.Location = new System.Drawing.Point(124, 170);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(283, 28);
            this.lblSignIn.TabIndex = 0;
            this.lblSignIn.Text = "Увійти до облікового запису";
            // 
            // pictureIcon
            // 
            this.pictureIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureIcon.Image")));
            this.pictureIcon.Location = new System.Drawing.Point(164, 48);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(157, 135);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIcon.TabIndex = 2;
            this.pictureIcon.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.Location = new System.Drawing.Point(35, 222);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(394, 42);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "Логін";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(35, 302);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(394, 42);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Пароль";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(163, 390);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(138, 47);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "УВІЙТИ";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblFirstVisit
            // 
            this.lblFirstVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFirstVisit.AutoSize = true;
            this.lblFirstVisit.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstVisit.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.lblFirstVisit.ForeColor = System.Drawing.Color.Black;
            this.lblFirstVisit.Location = new System.Drawing.Point(31, 520);
            this.lblFirstVisit.Name = "lblFirstVisit";
            this.lblFirstVisit.Size = new System.Drawing.Size(114, 20);
            this.lblFirstVisit.TabIndex = 6;
            this.lblFirstVisit.Text = "Ви тут уперше?";
            // 
            // linkRegister
            // 
            this.linkRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkRegister.BackColor = System.Drawing.Color.White;
            this.linkRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkRegister.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.linkRegister.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.linkRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkRegister.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegister.ForeColor = System.Drawing.Color.Black;
            this.linkRegister.Location = new System.Drawing.Point(207, 511);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(222, 38);
            this.linkRegister.TabIndex = 7;
            this.linkRegister.Text = "Створити обліковий запис";
            this.linkRegister.UseVisualStyleBackColor = false;
            this.linkRegister.Click += new System.EventHandler(this.linkRegister_Click);
            // 
            // pictureLine
            // 
            this.pictureLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLine.BackColor = System.Drawing.Color.Transparent;
            this.pictureLine.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureLine.Image = ((System.Drawing.Image)(resources.GetObject("pictureLine.Image")));
            this.pictureLine.Location = new System.Drawing.Point(35, 494);
            this.pictureLine.Name = "pictureLine";
            this.pictureLine.Size = new System.Drawing.Size(394, 1);
            this.pictureLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureLine.TabIndex = 9;
            this.pictureLine.TabStop = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.btnMaximize);
            this.pnlLogin.Controls.Add(this.btnNormal);
            this.pnlLogin.Controls.Add(this.btnMinimize);
            this.pnlLogin.Controls.Add(this.btnClose);
            this.pnlLogin.Location = new System.Drawing.Point(2, 2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(460, 46);
            this.pnlLogin.TabIndex = 11;
            this.pnlLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogin_MouseDown);
            this.pnlLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlLogin_MouseMove);
            this.pnlLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlLogin_MouseUp);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(383, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(26, 26);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 14;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.BackColor = System.Drawing.Color.Transparent;
            this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnNormal.Image")));
            this.btnNormal.Location = new System.Drawing.Point(383, 11);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(26, 26);
            this.btnNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNormal.TabIndex = 15;
            this.btnNormal.TabStop = false;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(343, 19);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(26, 26);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(420, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // eyeClose
            // 
            this.eyeClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eyeClose.BackColor = System.Drawing.Color.White;
            this.eyeClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeClose.Image = ((System.Drawing.Image)(resources.GetObject("eyeClose.Image")));
            this.eyeClose.Location = new System.Drawing.Point(362, 303);
            this.eyeClose.Name = "eyeClose";
            this.eyeClose.Size = new System.Drawing.Size(40, 40);
            this.eyeClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyeClose.TabIndex = 12;
            this.eyeClose.TabStop = false;
            this.toolTip1.SetToolTip(this.eyeClose, "Натисніть, щоб відобразити пароль");
            this.eyeClose.Click += new System.EventHandler(this.eyeClose_Click);
            // 
            // eyeOpen
            // 
            this.eyeOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eyeOpen.BackColor = System.Drawing.Color.White;
            this.eyeOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeOpen.Image = ((System.Drawing.Image)(resources.GetObject("eyeOpen.Image")));
            this.eyeOpen.Location = new System.Drawing.Point(362, 303);
            this.eyeOpen.Name = "eyeOpen";
            this.eyeOpen.Size = new System.Drawing.Size(40, 40);
            this.eyeOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyeOpen.TabIndex = 13;
            this.eyeOpen.TabStop = false;
            this.toolTip2.SetToolTip(this.eyeOpen, "Натисніть, щоб приховати пароль");
            this.eyeOpen.Visible = false;
            this.eyeOpen.Click += new System.EventHandler(this.eyeOpen_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            // 
            // toolTip2
            // 
            this.toolTip2.ForeColor = System.Drawing.Color.Black;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(464, 579);
            this.Controls.Add(this.eyeClose);
            this.Controls.Add(this.eyeOpen);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pictureLine);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.lblFirstVisit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.pictureIcon);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(464, 579);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLine)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblFirstVisit;
        private System.Windows.Forms.Button linkRegister;
        private System.Windows.Forms.PictureBox pictureLine;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox eyeClose;
        private System.Windows.Forms.PictureBox eyeOpen;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnNormal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}


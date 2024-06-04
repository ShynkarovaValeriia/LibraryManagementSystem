namespace LibraryManagementSystem
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDataSearch = new System.Windows.Forms.Button();
            this.btnReaders = new System.Windows.Forms.Button();
            this.btnIssueReturnBooks = new System.Windows.Forms.Button();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureLine = new System.Windows.Forms.PictureBox();
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblHomePage = new System.Windows.Forms.Label();
            this.pnlTotalReaders = new System.Windows.Forms.Panel();
            this.countTotalReaders = new System.Windows.Forms.Label();
            this.lblTotalReaders = new System.Windows.Forms.Label();
            this.pictureTotalReaders = new System.Windows.Forms.PictureBox();
            this.pnlBorrows = new System.Windows.Forms.Panel();
            this.countBorrows = new System.Windows.Forms.Label();
            this.lblBorrows = new System.Windows.Forms.Label();
            this.pictureBorrows = new System.Windows.Forms.PictureBox();
            this.pnlTotalBooks = new System.Windows.Forms.Panel();
            this.countTotalBooks = new System.Windows.Forms.Label();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.pictureTotalBooks = new System.Windows.Forms.PictureBox();
            this.pnlIssueBooks = new System.Windows.Forms.Panel();
            this.countIssueBooks = new System.Windows.Forms.Label();
            this.lblIssueBooks = new System.Windows.Forms.Label();
            this.pictureIssueBooks = new System.Windows.Forms.PictureBox();
            this.btnNormal = new System.Windows.Forms.PictureBox();
            this.pnlPopularBooks = new System.Windows.Forms.Panel();
            this.gridViewPopularBooks = new System.Windows.Forms.DataGridView();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_books = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPopularBooks = new System.Windows.Forms.Label();
            this.pnlPopularReaders = new System.Windows.Forms.Panel();
            this.gridViewPopularReaders = new System.Windows.Forms.DataGridView();
            this.reader_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_readers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPopularReaders = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            this.pnlTotalReaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTotalReaders)).BeginInit();
            this.pnlBorrows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBorrows)).BeginInit();
            this.pnlTotalBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTotalBooks)).BeginInit();
            this.pnlIssueBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIssueBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
            this.pnlPopularBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPopularBooks)).BeginInit();
            this.pnlPopularReaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPopularReaders)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlButtons.BackColor = System.Drawing.Color.White;
            this.pnlButtons.Controls.Add(this.btnBooks);
            this.pnlButtons.Controls.Add(this.btnLogout);
            this.pnlButtons.Controls.Add(this.btnDataSearch);
            this.pnlButtons.Controls.Add(this.btnReaders);
            this.pnlButtons.Controls.Add(this.btnIssueReturnBooks);
            this.pnlButtons.Controls.Add(this.pictureIcon);
            this.pnlButtons.ForeColor = System.Drawing.Color.Black;
            this.pnlButtons.Location = new System.Drawing.Point(2, 2);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(198, 496);
            this.pnlButtons.TabIndex = 0;
            this.pnlButtons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseDown);
            this.pnlButtons.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseMove);
            this.pnlButtons.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseUp);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.Color.Black;
            this.btnBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnBooks.Image")));
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.Location = new System.Drawing.Point(-2, 156);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(200, 60);
            this.btnBooks.TabIndex = 40;
            this.btnBooks.Text = "Книги";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-2, 410);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 60);
            this.btnLogout.TabIndex = 44;
            this.btnLogout.Text = "Вийти";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDataSearch
            // 
            this.btnDataSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnDataSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDataSearch.FlatAppearance.BorderSize = 0;
            this.btnDataSearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnDataSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataSearch.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataSearch.ForeColor = System.Drawing.Color.Black;
            this.btnDataSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnDataSearch.Image")));
            this.btnDataSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataSearch.Location = new System.Drawing.Point(-2, 333);
            this.btnDataSearch.Name = "btnDataSearch";
            this.btnDataSearch.Size = new System.Drawing.Size(200, 60);
            this.btnDataSearch.TabIndex = 43;
            this.btnDataSearch.Text = "     Пошук даних";
            this.btnDataSearch.UseVisualStyleBackColor = false;
            this.btnDataSearch.Click += new System.EventHandler(this.btnDataSearch_Click);
            // 
            // btnReaders
            // 
            this.btnReaders.BackColor = System.Drawing.Color.Transparent;
            this.btnReaders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReaders.FlatAppearance.BorderSize = 0;
            this.btnReaders.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnReaders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReaders.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReaders.ForeColor = System.Drawing.Color.Black;
            this.btnReaders.Image = ((System.Drawing.Image)(resources.GetObject("btnReaders.Image")));
            this.btnReaders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReaders.Location = new System.Drawing.Point(-2, 215);
            this.btnReaders.Name = "btnReaders";
            this.btnReaders.Size = new System.Drawing.Size(200, 60);
            this.btnReaders.TabIndex = 41;
            this.btnReaders.Text = "Читачі";
            this.btnReaders.UseVisualStyleBackColor = false;
            this.btnReaders.Click += new System.EventHandler(this.btnReaders_Click);
            // 
            // btnIssueReturnBooks
            // 
            this.btnIssueReturnBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnIssueReturnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssueReturnBooks.FlatAppearance.BorderSize = 0;
            this.btnIssueReturnBooks.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnIssueReturnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueReturnBooks.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueReturnBooks.ForeColor = System.Drawing.Color.Black;
            this.btnIssueReturnBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnIssueReturnBooks.Image")));
            this.btnIssueReturnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueReturnBooks.Location = new System.Drawing.Point(-2, 274);
            this.btnIssueReturnBooks.Name = "btnIssueReturnBooks";
            this.btnIssueReturnBooks.Size = new System.Drawing.Size(200, 60);
            this.btnIssueReturnBooks.TabIndex = 42;
            this.btnIssueReturnBooks.Text = "     Видача та\r\n     повернення\r\n";
            this.btnIssueReturnBooks.UseVisualStyleBackColor = false;
            this.btnIssueReturnBooks.Click += new System.EventHandler(this.btnIssueReturnBooks_Click);
            // 
            // pictureIcon
            // 
            this.pictureIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureIcon.Image")));
            this.pictureIcon.Location = new System.Drawing.Point(26, 11);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(151, 151);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIcon.TabIndex = 3;
            this.pictureIcon.TabStop = false;
            this.pictureIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseDown);
            this.pictureIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseMove);
            this.pictureIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseUp);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1015, 13);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(26, 26);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 17;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(975, 20);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(26, 26);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 16;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1052, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 15;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureLine
            // 
            this.pictureLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLine.BackColor = System.Drawing.Color.Transparent;
            this.pictureLine.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureLine.Image = ((System.Drawing.Image)(resources.GetObject("pictureLine.Image")));
            this.pictureLine.Location = new System.Drawing.Point(210, 47);
            this.pictureLine.Name = "pictureLine";
            this.pictureLine.Size = new System.Drawing.Size(870, 1);
            this.pictureLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureLine.TabIndex = 18;
            this.pictureLine.TabStop = false;
            this.pictureLine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseDown);
            this.pictureLine.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseMove);
            this.pictureLine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseUp);
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pictureAvatar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pictureAvatar.Image")));
            this.pictureAvatar.Location = new System.Drawing.Point(841, 10);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Size = new System.Drawing.Size(32, 32);
            this.pictureAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAvatar.TabIndex = 19;
            this.pictureAvatar.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(875, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 23);
            this.lblUsername.TabIndex = 20;
            this.lblUsername.Text = "Username";
            // 
            // lblHomePage
            // 
            this.lblHomePage.AutoSize = true;
            this.lblHomePage.BackColor = System.Drawing.Color.Transparent;
            this.lblHomePage.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePage.ForeColor = System.Drawing.Color.Black;
            this.lblHomePage.Location = new System.Drawing.Point(207, 12);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(176, 28);
            this.lblHomePage.TabIndex = 21;
            this.lblHomePage.Text = "Головна сторінка";
            // 
            // pnlTotalReaders
            // 
            this.pnlTotalReaders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTotalReaders.BackColor = System.Drawing.Color.White;
            this.pnlTotalReaders.Controls.Add(this.countTotalReaders);
            this.pnlTotalReaders.Controls.Add(this.lblTotalReaders);
            this.pnlTotalReaders.Controls.Add(this.pictureTotalReaders);
            this.pnlTotalReaders.ForeColor = System.Drawing.Color.Black;
            this.pnlTotalReaders.Location = new System.Drawing.Point(651, 61);
            this.pnlTotalReaders.Name = "pnlTotalReaders";
            this.pnlTotalReaders.Size = new System.Drawing.Size(200, 100);
            this.pnlTotalReaders.TabIndex = 22;
            this.pnlTotalReaders.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseDown);
            this.pnlTotalReaders.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseMove);
            this.pnlTotalReaders.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseUp);
            // 
            // countTotalReaders
            // 
            this.countTotalReaders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countTotalReaders.AutoSize = true;
            this.countTotalReaders.BackColor = System.Drawing.Color.Transparent;
            this.countTotalReaders.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.countTotalReaders.ForeColor = System.Drawing.Color.Black;
            this.countTotalReaders.Location = new System.Drawing.Point(74, 30);
            this.countTotalReaders.Name = "countTotalReaders";
            this.countTotalReaders.Size = new System.Drawing.Size(38, 45);
            this.countTotalReaders.TabIndex = 29;
            this.countTotalReaders.Text = "0";
            // 
            // lblTotalReaders
            // 
            this.lblTotalReaders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalReaders.AutoSize = true;
            this.lblTotalReaders.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalReaders.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.lblTotalReaders.ForeColor = System.Drawing.Color.Black;
            this.lblTotalReaders.Location = new System.Drawing.Point(7, 7);
            this.lblTotalReaders.Name = "lblTotalReaders";
            this.lblTotalReaders.Size = new System.Drawing.Size(142, 23);
            this.lblTotalReaders.TabIndex = 28;
            this.lblTotalReaders.Text = "Кількість читачів";
            // 
            // pictureTotalReaders
            // 
            this.pictureTotalReaders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTotalReaders.BackColor = System.Drawing.Color.Transparent;
            this.pictureTotalReaders.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureTotalReaders.Image = ((System.Drawing.Image)(resources.GetObject("pictureTotalReaders.Image")));
            this.pictureTotalReaders.Location = new System.Drawing.Point(152, 30);
            this.pictureTotalReaders.Name = "pictureTotalReaders";
            this.pictureTotalReaders.Size = new System.Drawing.Size(32, 32);
            this.pictureTotalReaders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureTotalReaders.TabIndex = 27;
            this.pictureTotalReaders.TabStop = false;
            // 
            // pnlBorrows
            // 
            this.pnlBorrows.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBorrows.BackColor = System.Drawing.Color.White;
            this.pnlBorrows.Controls.Add(this.countBorrows);
            this.pnlBorrows.Controls.Add(this.lblBorrows);
            this.pnlBorrows.Controls.Add(this.pictureBorrows);
            this.pnlBorrows.ForeColor = System.Drawing.Color.Black;
            this.pnlBorrows.Location = new System.Drawing.Point(870, 61);
            this.pnlBorrows.Name = "pnlBorrows";
            this.pnlBorrows.Size = new System.Drawing.Size(200, 100);
            this.pnlBorrows.TabIndex = 23;
            this.pnlBorrows.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseDown);
            this.pnlBorrows.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseMove);
            this.pnlBorrows.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseUp);
            // 
            // countBorrows
            // 
            this.countBorrows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countBorrows.AutoSize = true;
            this.countBorrows.BackColor = System.Drawing.Color.Transparent;
            this.countBorrows.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.countBorrows.ForeColor = System.Drawing.Color.Black;
            this.countBorrows.Location = new System.Drawing.Point(74, 30);
            this.countBorrows.Name = "countBorrows";
            this.countBorrows.Size = new System.Drawing.Size(38, 45);
            this.countBorrows.TabIndex = 30;
            this.countBorrows.Text = "0";
            // 
            // lblBorrows
            // 
            this.lblBorrows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBorrows.AutoSize = true;
            this.lblBorrows.BackColor = System.Drawing.Color.Transparent;
            this.lblBorrows.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.lblBorrows.ForeColor = System.Drawing.Color.Black;
            this.lblBorrows.Location = new System.Drawing.Point(7, 7);
            this.lblBorrows.Name = "lblBorrows";
            this.lblBorrows.Size = new System.Drawing.Size(91, 23);
            this.lblBorrows.TabIndex = 29;
            this.lblBorrows.Text = "Боржники";
            // 
            // pictureBorrows
            // 
            this.pictureBorrows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBorrows.BackColor = System.Drawing.Color.Transparent;
            this.pictureBorrows.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBorrows.Image = ((System.Drawing.Image)(resources.GetObject("pictureBorrows.Image")));
            this.pictureBorrows.Location = new System.Drawing.Point(152, 30);
            this.pictureBorrows.Name = "pictureBorrows";
            this.pictureBorrows.Size = new System.Drawing.Size(32, 32);
            this.pictureBorrows.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBorrows.TabIndex = 28;
            this.pictureBorrows.TabStop = false;
            // 
            // pnlTotalBooks
            // 
            this.pnlTotalBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTotalBooks.BackColor = System.Drawing.Color.White;
            this.pnlTotalBooks.Controls.Add(this.countTotalBooks);
            this.pnlTotalBooks.Controls.Add(this.lblTotalBooks);
            this.pnlTotalBooks.Controls.Add(this.pictureTotalBooks);
            this.pnlTotalBooks.ForeColor = System.Drawing.Color.Black;
            this.pnlTotalBooks.Location = new System.Drawing.Point(211, 61);
            this.pnlTotalBooks.Name = "pnlTotalBooks";
            this.pnlTotalBooks.Size = new System.Drawing.Size(200, 100);
            this.pnlTotalBooks.TabIndex = 23;
            this.pnlTotalBooks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseDown);
            this.pnlTotalBooks.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseMove);
            this.pnlTotalBooks.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseUp);
            // 
            // countTotalBooks
            // 
            this.countTotalBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countTotalBooks.AutoSize = true;
            this.countTotalBooks.BackColor = System.Drawing.Color.Transparent;
            this.countTotalBooks.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.countTotalBooks.ForeColor = System.Drawing.Color.Black;
            this.countTotalBooks.Location = new System.Drawing.Point(74, 30);
            this.countTotalBooks.Name = "countTotalBooks";
            this.countTotalBooks.Size = new System.Drawing.Size(38, 45);
            this.countTotalBooks.TabIndex = 31;
            this.countTotalBooks.Text = "0";
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBooks.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.lblTotalBooks.ForeColor = System.Drawing.Color.Black;
            this.lblTotalBooks.Location = new System.Drawing.Point(7, 7);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(118, 23);
            this.lblTotalBooks.TabIndex = 30;
            this.lblTotalBooks.Text = "Кількість книг";
            // 
            // pictureTotalBooks
            // 
            this.pictureTotalBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTotalBooks.BackColor = System.Drawing.Color.Transparent;
            this.pictureTotalBooks.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureTotalBooks.Image = ((System.Drawing.Image)(resources.GetObject("pictureTotalBooks.Image")));
            this.pictureTotalBooks.Location = new System.Drawing.Point(152, 30);
            this.pictureTotalBooks.Name = "pictureTotalBooks";
            this.pictureTotalBooks.Size = new System.Drawing.Size(32, 32);
            this.pictureTotalBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureTotalBooks.TabIndex = 29;
            this.pictureTotalBooks.TabStop = false;
            // 
            // pnlIssueBooks
            // 
            this.pnlIssueBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlIssueBooks.BackColor = System.Drawing.Color.White;
            this.pnlIssueBooks.Controls.Add(this.countIssueBooks);
            this.pnlIssueBooks.Controls.Add(this.lblIssueBooks);
            this.pnlIssueBooks.Controls.Add(this.pictureIssueBooks);
            this.pnlIssueBooks.ForeColor = System.Drawing.Color.Black;
            this.pnlIssueBooks.Location = new System.Drawing.Point(430, 61);
            this.pnlIssueBooks.Name = "pnlIssueBooks";
            this.pnlIssueBooks.Size = new System.Drawing.Size(200, 100);
            this.pnlIssueBooks.TabIndex = 23;
            this.pnlIssueBooks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseDown);
            this.pnlIssueBooks.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseMove);
            this.pnlIssueBooks.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseUp);
            // 
            // countIssueBooks
            // 
            this.countIssueBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countIssueBooks.AutoSize = true;
            this.countIssueBooks.BackColor = System.Drawing.Color.Transparent;
            this.countIssueBooks.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.countIssueBooks.ForeColor = System.Drawing.Color.Black;
            this.countIssueBooks.Location = new System.Drawing.Point(74, 30);
            this.countIssueBooks.Name = "countIssueBooks";
            this.countIssueBooks.Size = new System.Drawing.Size(38, 45);
            this.countIssueBooks.TabIndex = 32;
            this.countIssueBooks.Text = "0";
            // 
            // lblIssueBooks
            // 
            this.lblIssueBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIssueBooks.AutoSize = true;
            this.lblIssueBooks.BackColor = System.Drawing.Color.Transparent;
            this.lblIssueBooks.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.lblIssueBooks.ForeColor = System.Drawing.Color.Black;
            this.lblIssueBooks.Location = new System.Drawing.Point(7, 7);
            this.lblIssueBooks.Name = "lblIssueBooks";
            this.lblIssueBooks.Size = new System.Drawing.Size(133, 23);
            this.lblIssueBooks.TabIndex = 31;
            this.lblIssueBooks.Text = "Позичені книги";
            // 
            // pictureIssueBooks
            // 
            this.pictureIssueBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureIssueBooks.BackColor = System.Drawing.Color.Transparent;
            this.pictureIssueBooks.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureIssueBooks.Image = ((System.Drawing.Image)(resources.GetObject("pictureIssueBooks.Image")));
            this.pictureIssueBooks.Location = new System.Drawing.Point(152, 30);
            this.pictureIssueBooks.Name = "pictureIssueBooks";
            this.pictureIssueBooks.Size = new System.Drawing.Size(32, 32);
            this.pictureIssueBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIssueBooks.TabIndex = 30;
            this.pictureIssueBooks.TabStop = false;
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.BackColor = System.Drawing.Color.Transparent;
            this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnNormal.Image")));
            this.btnNormal.Location = new System.Drawing.Point(1015, 13);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(26, 26);
            this.btnNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNormal.TabIndex = 26;
            this.btnNormal.TabStop = false;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // pnlPopularBooks
            // 
            this.pnlPopularBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPopularBooks.BackColor = System.Drawing.Color.White;
            this.pnlPopularBooks.Controls.Add(this.gridViewPopularBooks);
            this.pnlPopularBooks.Controls.Add(this.lblPopularBooks);
            this.pnlPopularBooks.ForeColor = System.Drawing.Color.Black;
            this.pnlPopularBooks.Location = new System.Drawing.Point(211, 175);
            this.pnlPopularBooks.MaximumSize = new System.Drawing.Size(890, 930);
            this.pnlPopularBooks.Name = "pnlPopularBooks";
            this.pnlPopularBooks.Size = new System.Drawing.Size(419, 310);
            this.pnlPopularBooks.TabIndex = 27;
            this.pnlPopularBooks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseDown);
            this.pnlPopularBooks.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseMove);
            this.pnlPopularBooks.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseUp);
            // 
            // gridViewPopularBooks
            // 
            this.gridViewPopularBooks.AllowUserToAddRows = false;
            this.gridViewPopularBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPopularBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Genre,
            this.count_books});
            this.gridViewPopularBooks.Location = new System.Drawing.Point(11, 42);
            this.gridViewPopularBooks.Name = "gridViewPopularBooks";
            this.gridViewPopularBooks.RowHeadersWidth = 51;
            this.gridViewPopularBooks.RowTemplate.Height = 24;
            this.gridViewPopularBooks.Size = new System.Drawing.Size(397, 257);
            this.gridViewPopularBooks.TabIndex = 0;
            // 
            // Genre
            // 
            this.Genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Genre.HeaderText = "Тематика";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            // 
            // count_books
            // 
            this.count_books.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.count_books.FillWeight = 50F;
            this.count_books.HeaderText = "Кількість";
            this.count_books.MinimumWidth = 6;
            this.count_books.Name = "count_books";
            // 
            // lblPopularBooks
            // 
            this.lblPopularBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPopularBooks.AutoSize = true;
            this.lblPopularBooks.BackColor = System.Drawing.Color.Transparent;
            this.lblPopularBooks.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.lblPopularBooks.ForeColor = System.Drawing.Color.Black;
            this.lblPopularBooks.Location = new System.Drawing.Point(7, 7);
            this.lblPopularBooks.Name = "lblPopularBooks";
            this.lblPopularBooks.Size = new System.Drawing.Size(199, 23);
            this.lblPopularBooks.TabIndex = 30;
            this.lblPopularBooks.Text = "Зареєстровані тематики";
            // 
            // pnlPopularReaders
            // 
            this.pnlPopularReaders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPopularReaders.BackColor = System.Drawing.Color.White;
            this.pnlPopularReaders.Controls.Add(this.gridViewPopularReaders);
            this.pnlPopularReaders.Controls.Add(this.lblPopularReaders);
            this.pnlPopularReaders.ForeColor = System.Drawing.Color.Black;
            this.pnlPopularReaders.Location = new System.Drawing.Point(651, 175);
            this.pnlPopularReaders.MaximumSize = new System.Drawing.Size(890, 930);
            this.pnlPopularReaders.Name = "pnlPopularReaders";
            this.pnlPopularReaders.Size = new System.Drawing.Size(419, 310);
            this.pnlPopularReaders.TabIndex = 27;
            this.pnlPopularReaders.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseDown);
            this.pnlPopularReaders.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseMove);
            this.pnlPopularReaders.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseUp);
            // 
            // gridViewPopularReaders
            // 
            this.gridViewPopularReaders.AllowUserToAddRows = false;
            this.gridViewPopularReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPopularReaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reader_name,
            this.count_readers});
            this.gridViewPopularReaders.Location = new System.Drawing.Point(11, 42);
            this.gridViewPopularReaders.Name = "gridViewPopularReaders";
            this.gridViewPopularReaders.RowHeadersWidth = 51;
            this.gridViewPopularReaders.RowTemplate.Height = 24;
            this.gridViewPopularReaders.Size = new System.Drawing.Size(397, 257);
            this.gridViewPopularReaders.TabIndex = 0;
            // 
            // reader_name
            // 
            this.reader_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reader_name.HeaderText = "Ім\'я читача";
            this.reader_name.MinimumWidth = 6;
            this.reader_name.Name = "reader_name";
            // 
            // count_readers
            // 
            this.count_readers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.count_readers.FillWeight = 50F;
            this.count_readers.HeaderText = "Кількість";
            this.count_readers.MinimumWidth = 6;
            this.count_readers.Name = "count_readers";
            // 
            // lblPopularReaders
            // 
            this.lblPopularReaders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPopularReaders.AutoSize = true;
            this.lblPopularReaders.BackColor = System.Drawing.Color.Transparent;
            this.lblPopularReaders.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.lblPopularReaders.ForeColor = System.Drawing.Color.Black;
            this.lblPopularReaders.Location = new System.Drawing.Point(7, 7);
            this.lblPopularReaders.Name = "lblPopularReaders";
            this.lblPopularReaders.Size = new System.Drawing.Size(152, 23);
            this.lblPopularReaders.TabIndex = 30;
            this.lblPopularReaders.Text = "Найчастіші читачі";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1090, 500);
            this.Controls.Add(this.pnlPopularReaders);
            this.Controls.Add(this.pnlPopularBooks);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.pnlTotalBooks);
            this.Controls.Add(this.pnlIssueBooks);
            this.Controls.Add(this.pnlBorrows);
            this.Controls.Add(this.pnlTotalReaders);
            this.Controls.Add(this.lblHomePage);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pictureAvatar);
            this.Controls.Add(this.pictureLine);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1090, 500);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseUp);
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            this.pnlTotalReaders.ResumeLayout(false);
            this.pnlTotalReaders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTotalReaders)).EndInit();
            this.pnlBorrows.ResumeLayout(false);
            this.pnlBorrows.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBorrows)).EndInit();
            this.pnlTotalBooks.ResumeLayout(false);
            this.pnlTotalBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTotalBooks)).EndInit();
            this.pnlIssueBooks.ResumeLayout(false);
            this.pnlIssueBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIssueBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).EndInit();
            this.pnlPopularBooks.ResumeLayout(false);
            this.pnlPopularBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPopularBooks)).EndInit();
            this.pnlPopularReaders.ResumeLayout(false);
            this.pnlPopularReaders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPopularReaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pictureLine;
        private System.Windows.Forms.PictureBox pictureAvatar;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblHomePage;
        private System.Windows.Forms.Panel pnlTotalReaders;
        private System.Windows.Forms.Panel pnlBorrows;
        private System.Windows.Forms.Panel pnlTotalBooks;
        private System.Windows.Forms.Panel pnlIssueBooks;
        private System.Windows.Forms.PictureBox btnNormal;
        private System.Windows.Forms.PictureBox pictureTotalReaders;
        private System.Windows.Forms.PictureBox pictureBorrows;
        private System.Windows.Forms.PictureBox pictureTotalBooks;
        private System.Windows.Forms.PictureBox pictureIssueBooks;
        private System.Windows.Forms.Label lblTotalReaders;
        private System.Windows.Forms.Label lblBorrows;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblIssueBooks;
        private System.Windows.Forms.Label countTotalReaders;
        private System.Windows.Forms.Label countBorrows;
        private System.Windows.Forms.Label countTotalBooks;
        private System.Windows.Forms.Label countIssueBooks;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDataSearch;
        private System.Windows.Forms.Button btnReaders;
        private System.Windows.Forms.Button btnIssueReturnBooks;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Panel pnlPopularBooks;
        private System.Windows.Forms.Panel pnlPopularReaders;
        private System.Windows.Forms.DataGridView gridViewPopularBooks;
        private System.Windows.Forms.Label lblPopularBooks;
        private System.Windows.Forms.Label lblPopularReaders;
        private System.Windows.Forms.DataGridView gridViewPopularReaders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_books;
        private System.Windows.Forms.DataGridViewTextBoxColumn reader_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_readers;
    }
}
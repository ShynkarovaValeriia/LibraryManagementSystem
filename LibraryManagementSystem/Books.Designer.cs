namespace LibraryManagementSystem
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.btnDataSearch = new System.Windows.Forms.Button();
            this.btnReaders = new System.Windows.Forms.Button();
            this.btnIssueReturnBooks = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnNormal = new System.Windows.Forms.PictureBox();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.pictureLine = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.gridViewBooks = new System.Windows.Forms.DataGridView();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlButtons.BackColor = System.Drawing.Color.White;
            this.pnlButtons.Controls.Add(this.btnBooks);
            this.pnlButtons.Controls.Add(this.btnLogout);
            this.pnlButtons.Controls.Add(this.pictureIcon);
            this.pnlButtons.Controls.Add(this.btnDataSearch);
            this.pnlButtons.Controls.Add(this.btnReaders);
            this.pnlButtons.Controls.Add(this.btnIssueReturnBooks);
            this.pnlButtons.ForeColor = System.Drawing.Color.Black;
            this.pnlButtons.Location = new System.Drawing.Point(2, 2);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(198, 496);
            this.pnlButtons.TabIndex = 1;
            this.pnlButtons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Books_MouseDown);
            this.pnlButtons.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Books_MouseMove);
            this.pnlButtons.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Books_MouseUp);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.SystemColors.Menu;
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
            this.btnBooks.TabIndex = 35;
            this.btnBooks.Text = "Книги";
            this.btnBooks.UseVisualStyleBackColor = false;
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
            this.btnLogout.TabIndex = 39;
            this.btnLogout.Text = "Вийти";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureIcon
            // 
            this.pictureIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureIcon.Image")));
            this.pictureIcon.Location = new System.Drawing.Point(23, 11);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(151, 151);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIcon.TabIndex = 3;
            this.pictureIcon.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureIcon, "Натисніть, щоб перейти в головне меню");
            this.pictureIcon.Click += new System.EventHandler(this.btnHomePage_Click);
            this.pictureIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Books_MouseDown);
            this.pictureIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Books_MouseMove);
            this.pictureIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Books_MouseUp);
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
            this.btnDataSearch.TabIndex = 38;
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
            this.btnReaders.TabIndex = 36;
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
            this.btnIssueReturnBooks.TabIndex = 37;
            this.btnIssueReturnBooks.Text = "     Видача та\r\n     повернення\r\n";
            this.btnIssueReturnBooks.UseVisualStyleBackColor = false;
            this.btnIssueReturnBooks.Click += new System.EventHandler(this.btnIssueReturnBooks_Click);
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
            this.btnMaximize.TabIndex = 29;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
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
            this.btnNormal.TabIndex = 34;
            this.btnNormal.TabStop = false;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.BackColor = System.Drawing.Color.Transparent;
            this.lblBooks.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooks.ForeColor = System.Drawing.Color.Black;
            this.lblBooks.Location = new System.Drawing.Point(212, 12);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(68, 28);
            this.lblBooks.TabIndex = 33;
            this.lblBooks.Text = "Книги";
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
            this.lblUsername.TabIndex = 32;
            this.lblUsername.Text = "Username";
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
            this.pictureAvatar.TabIndex = 31;
            this.pictureAvatar.TabStop = false;
            // 
            // pictureLine
            // 
            this.pictureLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLine.BackColor = System.Drawing.Color.Transparent;
            this.pictureLine.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureLine.Image = ((System.Drawing.Image)(resources.GetObject("pictureLine.Image")));
            this.pictureLine.Location = new System.Drawing.Point(214, 47);
            this.pictureLine.Name = "pictureLine";
            this.pictureLine.Size = new System.Drawing.Size(865, 1);
            this.pictureLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureLine.TabIndex = 30;
            this.pictureLine.TabStop = false;
            this.pictureLine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Books_MouseDown);
            this.pictureLine.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Books_MouseMove);
            this.pictureLine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Books_MouseUp);
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
            this.btnMinimize.TabIndex = 28;
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
            this.btnClose.TabIndex = 27;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblBookID
            // 
            this.lblBookID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBookID.AutoSize = true;
            this.lblBookID.BackColor = System.Drawing.Color.Transparent;
            this.lblBookID.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.ForeColor = System.Drawing.Color.Black;
            this.lblBookID.Location = new System.Drawing.Point(240, 69);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(113, 23);
            this.lblBookID.TabIndex = 35;
            this.lblBookID.Text = "Номер книги";
            // 
            // txtBookID
            // 
            this.txtBookID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBookID.BackColor = System.Drawing.Color.White;
            this.txtBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookID.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.ForeColor = System.Drawing.Color.Black;
            this.txtBookID.Location = new System.Drawing.Point(242, 98);
            this.txtBookID.Multiline = true;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(134, 31);
            this.txtBookID.TabIndex = 36;
            // 
            // txtBookName
            // 
            this.txtBookName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBookName.BackColor = System.Drawing.Color.White;
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookName.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.ForeColor = System.Drawing.Color.Black;
            this.txtBookName.Location = new System.Drawing.Point(422, 98);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(134, 31);
            this.txtBookName.TabIndex = 38;
            // 
            // lblBookName
            // 
            this.lblBookName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.Transparent;
            this.lblBookName.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.Color.Black;
            this.lblBookName.Location = new System.Drawing.Point(420, 69);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(107, 23);
            this.lblBookName.TabIndex = 37;
            this.lblBookName.Text = "Назва книги";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAuthor.BackColor = System.Drawing.Color.White;
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthor.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.ForeColor = System.Drawing.Color.Black;
            this.txtAuthor.Location = new System.Drawing.Point(602, 98);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(134, 31);
            this.txtAuthor.TabIndex = 40;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.Black;
            this.lblAuthor.Location = new System.Drawing.Point(600, 69);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(57, 23);
            this.lblAuthor.TabIndex = 39;
            this.lblAuthor.Text = "Автор";
            // 
            // txtGenre
            // 
            this.txtGenre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGenre.BackColor = System.Drawing.Color.White;
            this.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenre.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.ForeColor = System.Drawing.Color.Black;
            this.txtGenre.Location = new System.Drawing.Point(782, 98);
            this.txtGenre.Multiline = true;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(134, 31);
            this.txtGenre.TabIndex = 42;
            // 
            // lblGenre
            // 
            this.lblGenre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGenre.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.Black;
            this.lblGenre.Location = new System.Drawing.Point(780, 69);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(83, 23);
            this.lblGenre.TabIndex = 41;
            this.lblGenre.Text = "Тематика";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(337, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 40);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(522, 142);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 40);
            this.btnEdit.TabIndex = 44;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(707, 142);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 40);
            this.btnRemove.TabIndex = 45;
            this.btnRemove.Text = "Видалити";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveFile.BackColor = System.Drawing.Color.White;
            this.btnSaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSaveFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFile.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFile.ForeColor = System.Drawing.Color.Black;
            this.btnSaveFile.Location = new System.Drawing.Point(277, 439);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(190, 40);
            this.btnSaveFile.TabIndex = 46;
            this.btnSaveFile.Text = "Зберегти як файл";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnClearTable
            // 
            this.btnClearTable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClearTable.BackColor = System.Drawing.Color.White;
            this.btnClearTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClearTable.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnClearTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTable.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTable.ForeColor = System.Drawing.Color.Black;
            this.btnClearTable.Location = new System.Drawing.Point(537, 439);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(190, 40);
            this.btnClearTable.TabIndex = 47;
            this.btnClearTable.Text = "Очистити таблицю";
            this.btnClearTable.UseVisualStyleBackColor = false;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLoadFile.BackColor = System.Drawing.Color.White;
            this.btnLoadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLoadFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFile.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFile.ForeColor = System.Drawing.Color.Black;
            this.btnLoadFile.Location = new System.Drawing.Point(797, 439);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(190, 40);
            this.btnLoadFile.TabIndex = 48;
            this.btnLoadFile.Text = "Завантажити файл";
            this.btnLoadFile.UseVisualStyleBackColor = false;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // gridViewBooks
            // 
            this.gridViewBooks.AllowUserToAddRows = false;
            this.gridViewBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_id,
            this.book_name,
            this.author,
            this.genre});
            this.gridViewBooks.Location = new System.Drawing.Point(222, 188);
            this.gridViewBooks.Name = "gridViewBooks";
            this.gridViewBooks.RowHeadersWidth = 51;
            this.gridViewBooks.RowTemplate.Height = 24;
            this.gridViewBooks.Size = new System.Drawing.Size(820, 245);
            this.gridViewBooks.TabIndex = 49;
            this.gridViewBooks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridViewBooks_MouseClick);
            // 
            // book_id
            // 
            this.book_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.book_id.HeaderText = "Номер книги";
            this.book_id.MinimumWidth = 6;
            this.book_id.Name = "book_id";
            // 
            // book_name
            // 
            this.book_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.book_name.HeaderText = "Назва книги";
            this.book_name.MinimumWidth = 6;
            this.book_name.Name = "book_name";
            // 
            // author
            // 
            this.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.author.HeaderText = "Автор";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            // 
            // genre
            // 
            this.genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genre.HeaderText = "Тематика";
            this.genre.MinimumWidth = 6;
            this.genre.Name = "genre";
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1090, 500);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnClearTable);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pictureAvatar);
            this.Controls.Add(this.pictureLine);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.gridViewBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1090, 500);
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Books_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Books_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Books_MouseUp);
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnNormal;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureAvatar;
        private System.Windows.Forms.PictureBox pictureLine;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDataSearch;
        private System.Windows.Forms.Button btnReaders;
        private System.Windows.Forms.Button btnIssueReturnBooks;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnClearTable;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.DataGridView gridViewBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
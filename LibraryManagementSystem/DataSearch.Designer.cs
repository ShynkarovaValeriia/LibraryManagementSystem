namespace LibraryManagementSystem
{
    partial class DataSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSearch));
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDataSearch = new System.Windows.Forms.Button();
            this.btnReaders = new System.Windows.Forms.Button();
            this.btnIssueReturnBooks = new System.Windows.Forms.Button();
            this.gridViewDataSearch = new System.Windows.Forms.DataGridView();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnNormal = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.pictureLine = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblDataSearch = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.rbGenre = new System.Windows.Forms.RadioButton();
            this.rbReaders = new System.Windows.Forms.RadioButton();
            this.rbBorrows = new System.Windows.Forms.RadioButton();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reader_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reader_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
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
            this.pnlButtons.TabIndex = 102;
            this.pnlButtons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Books_MouseDown);
            this.pnlButtons.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Books_MouseMove);
            this.pnlButtons.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Books_MouseUp);
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
            this.btnDataSearch.BackColor = System.Drawing.SystemColors.Menu;
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
            // gridViewDataSearch
            // 
            this.gridViewDataSearch.AllowUserToAddRows = false;
            this.gridViewDataSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewDataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDataSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.count,
            this.reader_id,
            this.reader_name,
            this.book_name,
            this.genre,
            this.issue_date,
            this.return_date});
            this.gridViewDataSearch.Location = new System.Drawing.Point(529, 61);
            this.gridViewDataSearch.Name = "gridViewDataSearch";
            this.gridViewDataSearch.RowHeadersWidth = 51;
            this.gridViewDataSearch.RowTemplate.Height = 24;
            this.gridViewDataSearch.Size = new System.Drawing.Size(551, 424);
            this.gridViewDataSearch.TabIndex = 122;
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
            this.btnMaximize.TabIndex = 105;
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
            this.btnNormal.TabIndex = 110;
            this.btnNormal.TabStop = false;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
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
            this.lblUsername.TabIndex = 108;
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
            this.pictureAvatar.TabIndex = 107;
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
            this.pictureLine.TabIndex = 106;
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
            this.btnMinimize.TabIndex = 104;
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
            this.btnClose.TabIndex = 103;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDataSearch
            // 
            this.lblDataSearch.AutoSize = true;
            this.lblDataSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblDataSearch.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSearch.ForeColor = System.Drawing.Color.Black;
            this.lblDataSearch.Location = new System.Drawing.Point(212, 12);
            this.lblDataSearch.Name = "lblDataSearch";
            this.lblDataSearch.Size = new System.Drawing.Size(139, 28);
            this.lblDataSearch.TabIndex = 109;
            this.lblDataSearch.Text = "Пошук даних";
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(222, 390);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(284, 40);
            this.btnSearch.TabIndex = 116;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbGenre
            // 
            this.rbGenre.BackColor = System.Drawing.Color.Transparent;
            this.rbGenre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbGenre.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGenre.ForeColor = System.Drawing.Color.Black;
            this.rbGenre.Location = new System.Drawing.Point(214, 61);
            this.rbGenre.Name = "rbGenre";
            this.rbGenre.Size = new System.Drawing.Size(309, 87);
            this.rbGenre.TabIndex = 129;
            this.rbGenre.Text = "Книги якої тематики користуються найбільшим попитом у читачів";
            this.rbGenre.UseVisualStyleBackColor = false;
            // 
            // rbReaders
            // 
            this.rbReaders.BackColor = System.Drawing.Color.Transparent;
            this.rbReaders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbReaders.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReaders.ForeColor = System.Drawing.Color.Black;
            this.rbReaders.Location = new System.Drawing.Point(214, 148);
            this.rbReaders.Name = "rbReaders";
            this.rbReaders.Size = new System.Drawing.Size(309, 69);
            this.rbReaders.TabIndex = 129;
            this.rbReaders.Text = "Читачі, які найчастіше відвідують бібліотеку";
            this.rbReaders.UseVisualStyleBackColor = false;
            // 
            // rbBorrows
            // 
            this.rbBorrows.BackColor = System.Drawing.Color.Transparent;
            this.rbBorrows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbBorrows.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBorrows.ForeColor = System.Drawing.Color.Black;
            this.rbBorrows.Location = new System.Drawing.Point(214, 217);
            this.rbBorrows.Name = "rbBorrows";
            this.rbBorrows.Size = new System.Drawing.Size(309, 54);
            this.rbBorrows.TabIndex = 129;
            this.rbBorrows.Text = "Список боржників бібліотеки";
            this.rbBorrows.UseVisualStyleBackColor = false;
            // 
            // btnClearTable
            // 
            this.btnClearTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearTable.BackColor = System.Drawing.Color.White;
            this.btnClearTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClearTable.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnClearTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTable.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTable.ForeColor = System.Drawing.Color.Black;
            this.btnClearTable.Location = new System.Drawing.Point(222, 445);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(284, 40);
            this.btnClearTable.TabIndex = 130;
            this.btnClearTable.Text = "Очистити таблицю";
            this.btnClearTable.UseVisualStyleBackColor = false;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Black;
            this.lblCount.Location = new System.Drawing.Point(222, 352);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 23);
            this.lblCount.TabIndex = 131;
            // 
            // count
            // 
            this.count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.count.FillWeight = 50F;
            this.count.HeaderText = "Кількість";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            // 
            // reader_id
            // 
            this.reader_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reader_id.FillWeight = 55F;
            this.reader_id.HeaderText = "Номер читача";
            this.reader_id.MinimumWidth = 6;
            this.reader_id.Name = "reader_id";
            // 
            // reader_name
            // 
            this.reader_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reader_name.HeaderText = "ПІБ";
            this.reader_name.MinimumWidth = 6;
            this.reader_name.Name = "reader_name";
            // 
            // book_name
            // 
            this.book_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.book_name.HeaderText = "Назва книги";
            this.book_name.MinimumWidth = 6;
            this.book_name.Name = "book_name";
            // 
            // genre
            // 
            this.genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genre.HeaderText = "Тематика";
            this.genre.MinimumWidth = 6;
            this.genre.Name = "genre";
            // 
            // issue_date
            // 
            this.issue_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.issue_date.FillWeight = 70F;
            this.issue_date.HeaderText = "Дата видачі";
            this.issue_date.MinimumWidth = 6;
            this.issue_date.Name = "issue_date";
            // 
            // return_date
            // 
            this.return_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.return_date.FillWeight = 70F;
            this.return_date.HeaderText = "Дата повернення";
            this.return_date.MinimumWidth = 6;
            this.return_date.Name = "return_date";
            // 
            // DataSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1090, 500);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnClearTable);
            this.Controls.Add(this.rbBorrows);
            this.Controls.Add(this.rbGenre);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.gridViewDataSearch);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pictureAvatar);
            this.Controls.Add(this.pictureLine);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDataSearch);
            this.Controls.Add(this.rbReaders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1090, 500);
            this.Name = "DataSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Books_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Books_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Books_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.DataGridView gridViewDataSearch;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnNormal;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureAvatar;
        private System.Windows.Forms.PictureBox pictureLine;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblDataSearch;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDataSearch;
        private System.Windows.Forms.Button btnReaders;
        private System.Windows.Forms.Button btnIssueReturnBooks;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbGenre;
        private System.Windows.Forms.RadioButton rbReaders;
        private System.Windows.Forms.RadioButton rbBorrows;
        private System.Windows.Forms.Button btnClearTable;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn reader_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn reader_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_date;
    }
}
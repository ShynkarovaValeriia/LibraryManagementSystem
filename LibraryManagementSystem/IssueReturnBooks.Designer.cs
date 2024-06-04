namespace LibraryManagementSystem
{
    partial class IssueReturnBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueReturnBooks));
            this.gridViewIssueReturnBooks = new System.Windows.Forms.DataGridView();
            this.lblBookID = new System.Windows.Forms.Label();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnNormal = new System.Windows.Forms.PictureBox();
            this.lblIssueReturnBooks = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.pictureLine = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.txtReaderID = new System.Windows.Forms.TextBox();
            this.lblReaderID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReturnBooks = new System.Windows.Forms.Button();
            this.btnReaders = new System.Windows.Forms.Button();
            this.btnIssueBooks = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dtPickerIssue = new System.Windows.Forms.DateTimePicker();
            this.dtPickerReturn = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblReturnSign = new System.Windows.Forms.Label();
            this.chkReturnSign = new System.Windows.Forms.CheckBox();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reader_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIssueReturnBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewIssueReturnBooks
            // 
            this.gridViewIssueReturnBooks.AllowUserToAddRows = false;
            this.gridViewIssueReturnBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewIssueReturnBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewIssueReturnBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_id,
            this.reader_id,
            this.issue_date,
            this.return_date,
            this.return_status});
            this.gridViewIssueReturnBooks.Location = new System.Drawing.Point(222, 188);
            this.gridViewIssueReturnBooks.Name = "gridViewIssueReturnBooks";
            this.gridViewIssueReturnBooks.RowHeadersWidth = 51;
            this.gridViewIssueReturnBooks.RowTemplate.Height = 24;
            this.gridViewIssueReturnBooks.Size = new System.Drawing.Size(820, 245);
            this.gridViewIssueReturnBooks.TabIndex = 95;
            this.gridViewIssueReturnBooks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridViewIssueReturnBooks_MouseClick);
            // 
            // lblBookID
            // 
            this.lblBookID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBookID.AutoSize = true;
            this.lblBookID.BackColor = System.Drawing.Color.Transparent;
            this.lblBookID.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.ForeColor = System.Drawing.Color.Black;
            this.lblBookID.Location = new System.Drawing.Point(220, 69);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(113, 23);
            this.lblBookID.TabIndex = 83;
            this.lblBookID.Text = "Номер книги";
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
            this.btnMaximize.TabIndex = 77;
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
            this.btnNormal.TabIndex = 82;
            this.btnNormal.TabStop = false;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // lblIssueReturnBooks
            // 
            this.lblIssueReturnBooks.AutoSize = true;
            this.lblIssueReturnBooks.BackColor = System.Drawing.Color.Transparent;
            this.lblIssueReturnBooks.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueReturnBooks.ForeColor = System.Drawing.Color.Black;
            this.lblIssueReturnBooks.Location = new System.Drawing.Point(212, 12);
            this.lblIssueReturnBooks.Name = "lblIssueReturnBooks";
            this.lblIssueReturnBooks.Size = new System.Drawing.Size(276, 28);
            this.lblIssueReturnBooks.TabIndex = 81;
            this.lblIssueReturnBooks.Text = "Видача та повернення книг";
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
            this.lblUsername.TabIndex = 80;
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
            this.pictureAvatar.TabIndex = 79;
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
            this.pictureLine.TabIndex = 78;
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
            this.btnMinimize.TabIndex = 76;
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
            this.btnClose.TabIndex = 75;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnClearTable.TabIndex = 93;
            this.btnClearTable.Text = "Очистити таблицю";
            this.btnClearTable.UseVisualStyleBackColor = false;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
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
            this.btnSaveFile.TabIndex = 92;
            this.btnSaveFile.Text = "Зберегти як файл";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
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
            this.btnRemove.TabIndex = 91;
            this.btnRemove.Text = "Видалити";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.btnEdit.TabIndex = 90;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnAdd.TabIndex = 89;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.BackColor = System.Drawing.Color.Transparent;
            this.lblIssueDate.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.ForeColor = System.Drawing.Color.Black;
            this.lblIssueDate.Location = new System.Drawing.Point(560, 69);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(103, 23);
            this.lblIssueDate.TabIndex = 87;
            this.lblIssueDate.Text = "Дата видачі";
            // 
            // txtReaderID
            // 
            this.txtReaderID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtReaderID.BackColor = System.Drawing.Color.White;
            this.txtReaderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReaderID.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReaderID.ForeColor = System.Drawing.Color.Black;
            this.txtReaderID.Location = new System.Drawing.Point(392, 98);
            this.txtReaderID.Multiline = true;
            this.txtReaderID.Name = "txtReaderID";
            this.txtReaderID.Size = new System.Drawing.Size(134, 31);
            this.txtReaderID.TabIndex = 86;
            // 
            // lblReaderID
            // 
            this.lblReaderID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReaderID.AutoSize = true;
            this.lblReaderID.BackColor = System.Drawing.Color.Transparent;
            this.lblReaderID.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReaderID.ForeColor = System.Drawing.Color.Black;
            this.lblReaderID.Location = new System.Drawing.Point(390, 69);
            this.lblReaderID.Name = "lblReaderID";
            this.lblReaderID.Size = new System.Drawing.Size(123, 23);
            this.lblReaderID.TabIndex = 85;
            this.lblReaderID.Text = "Номер читача";
            // 
            // txtBookID
            // 
            this.txtBookID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBookID.BackColor = System.Drawing.Color.White;
            this.txtBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookID.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.ForeColor = System.Drawing.Color.Black;
            this.txtBookID.Location = new System.Drawing.Point(222, 98);
            this.txtBookID.Multiline = true;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(134, 31);
            this.txtBookID.TabIndex = 84;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlButtons.BackColor = System.Drawing.Color.White;
            this.pnlButtons.Controls.Add(this.btnBooks);
            this.pnlButtons.Controls.Add(this.btnLogout);
            this.pnlButtons.Controls.Add(this.btnReturnBooks);
            this.pnlButtons.Controls.Add(this.btnReaders);
            this.pnlButtons.Controls.Add(this.btnIssueBooks);
            this.pnlButtons.Controls.Add(this.pictureIcon);
            this.pnlButtons.ForeColor = System.Drawing.Color.Black;
            this.pnlButtons.Location = new System.Drawing.Point(2, 2);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(198, 496);
            this.pnlButtons.TabIndex = 74;
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
            // btnReturnBooks
            // 
            this.btnReturnBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnBooks.FlatAppearance.BorderSize = 0;
            this.btnReturnBooks.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnReturnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBooks.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBooks.ForeColor = System.Drawing.Color.Black;
            this.btnReturnBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnBooks.Image")));
            this.btnReturnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBooks.Location = new System.Drawing.Point(-2, 333);
            this.btnReturnBooks.Name = "btnReturnBooks";
            this.btnReturnBooks.Size = new System.Drawing.Size(200, 60);
            this.btnReturnBooks.TabIndex = 43;
            this.btnReturnBooks.Text = "     Пошук даних";
            this.btnReturnBooks.UseVisualStyleBackColor = false;
            this.btnReturnBooks.Click += new System.EventHandler(this.btnReturnBooks_Click);
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
            // btnIssueBooks
            // 
            this.btnIssueBooks.BackColor = System.Drawing.SystemColors.Menu;
            this.btnIssueBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssueBooks.FlatAppearance.BorderSize = 0;
            this.btnIssueBooks.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnIssueBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBooks.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBooks.ForeColor = System.Drawing.Color.Black;
            this.btnIssueBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnIssueBooks.Image")));
            this.btnIssueBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueBooks.Location = new System.Drawing.Point(-2, 274);
            this.btnIssueBooks.Name = "btnIssueBooks";
            this.btnIssueBooks.Size = new System.Drawing.Size(200, 60);
            this.btnIssueBooks.TabIndex = 42;
            this.btnIssueBooks.Text = "     Видача та\r\n     повернення";
            this.btnIssueBooks.UseVisualStyleBackColor = false;
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
            this.btnLoadFile.TabIndex = 94;
            this.btnLoadFile.Text = "Завантажити файл";
            this.btnLoadFile.UseVisualStyleBackColor = false;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnDate.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.ForeColor = System.Drawing.Color.Black;
            this.lblReturnDate.Location = new System.Drawing.Point(730, 69);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(148, 23);
            this.lblReturnDate.TabIndex = 96;
            this.lblReturnDate.Text = "Дата повернення";
            // 
            // dtPickerIssue
            // 
            this.dtPickerIssue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtPickerIssue.CalendarForeColor = System.Drawing.Color.Black;
            this.dtPickerIssue.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtPickerIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtPickerIssue.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerIssue.Location = new System.Drawing.Point(562, 98);
            this.dtPickerIssue.Name = "dtPickerIssue";
            this.dtPickerIssue.Size = new System.Drawing.Size(134, 30);
            this.dtPickerIssue.TabIndex = 100;
            // 
            // dtPickerReturn
            // 
            this.dtPickerReturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtPickerReturn.CalendarForeColor = System.Drawing.Color.Black;
            this.dtPickerReturn.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtPickerReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtPickerReturn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerReturn.Location = new System.Drawing.Point(732, 98);
            this.dtPickerReturn.Name = "dtPickerReturn";
            this.dtPickerReturn.Size = new System.Drawing.Size(134, 30);
            this.dtPickerReturn.TabIndex = 101;
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            // 
            // lblReturnSign
            // 
            this.lblReturnSign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReturnSign.AutoSize = true;
            this.lblReturnSign.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnSign.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnSign.ForeColor = System.Drawing.Color.Black;
            this.lblReturnSign.Location = new System.Drawing.Point(902, 69);
            this.lblReturnSign.Name = "lblReturnSign";
            this.lblReturnSign.Size = new System.Drawing.Size(168, 23);
            this.lblReturnSign.TabIndex = 96;
            this.lblReturnSign.Text = "Ознака повернення";
            // 
            // chkReturnSign
            // 
            this.chkReturnSign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkReturnSign.AutoSize = true;
            this.chkReturnSign.BackColor = System.Drawing.Color.Transparent;
            this.chkReturnSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkReturnSign.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReturnSign.ForeColor = System.Drawing.Color.Black;
            this.chkReturnSign.Location = new System.Drawing.Point(902, 98);
            this.chkReturnSign.Name = "chkReturnSign";
            this.chkReturnSign.Size = new System.Drawing.Size(121, 27);
            this.chkReturnSign.TabIndex = 102;
            this.chkReturnSign.Text = "Повернено";
            this.chkReturnSign.UseVisualStyleBackColor = false;
            // 
            // book_id
            // 
            this.book_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.book_id.HeaderText = "Номер книги";
            this.book_id.MinimumWidth = 6;
            this.book_id.Name = "book_id";
            // 
            // reader_id
            // 
            this.reader_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reader_id.HeaderText = "Номер читача";
            this.reader_id.MinimumWidth = 6;
            this.reader_id.Name = "reader_id";
            // 
            // issue_date
            // 
            this.issue_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.issue_date.HeaderText = "Дата видачі";
            this.issue_date.MinimumWidth = 6;
            this.issue_date.Name = "issue_date";
            // 
            // return_date
            // 
            this.return_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.return_date.HeaderText = "Дата повернення";
            this.return_date.MinimumWidth = 6;
            this.return_date.Name = "return_date";
            // 
            // return_status
            // 
            this.return_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.return_status.HeaderText = "Ознака повернення";
            this.return_status.MinimumWidth = 6;
            this.return_status.Name = "return_status";
            // 
            // IssueReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1090, 500);
            this.Controls.Add(this.chkReturnSign);
            this.Controls.Add(this.dtPickerReturn);
            this.Controls.Add(this.dtPickerIssue);
            this.Controls.Add(this.lblReturnSign);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.gridViewIssueReturnBooks);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.lblIssueReturnBooks);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pictureAvatar);
            this.Controls.Add(this.pictureLine);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClearTable);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.txtReaderID);
            this.Controls.Add(this.lblReaderID);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.btnLoadFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1090, 500);
            this.Name = "IssueReturnBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueReturnBooks";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Books_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Books_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Books_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIssueReturnBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridViewIssueReturnBooks;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnNormal;
        private System.Windows.Forms.Label lblIssueReturnBooks;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureAvatar;
        private System.Windows.Forms.PictureBox pictureLine;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.Button btnClearTable;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.TextBox txtReaderID;
        private System.Windows.Forms.Label lblReaderID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DateTimePicker dtPickerIssue;
        private System.Windows.Forms.DateTimePicker dtPickerReturn;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReturnBooks;
        private System.Windows.Forms.Button btnReaders;
        private System.Windows.Forms.Button btnIssueBooks;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblReturnSign;
        private System.Windows.Forms.CheckBox chkReturnSign;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn reader_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_status;
    }
}
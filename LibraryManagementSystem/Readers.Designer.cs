namespace LibraryManagementSystem
{
    partial class Readers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Readers));
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtContacts = new System.Windows.Forms.TextBox();
            this.lblContacts = new System.Windows.Forms.Label();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.lblReaderName = new System.Windows.Forms.Label();
            this.txtReaderID = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReturnBooks = new System.Windows.Forms.Button();
            this.btnReaders = new System.Windows.Forms.Button();
            this.btnIssueBooks = new System.Windows.Forms.Button();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.gridViewReaders = new System.Windows.Forms.DataGridView();
            this.reader_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reader_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReaderID = new System.Windows.Forms.Label();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnNormal = new System.Windows.Forms.PictureBox();
            this.lblReaders = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.pictureLine = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReaders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
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
            this.btnLoadFile.Location = new System.Drawing.Point(777, 439);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(190, 40);
            this.btnLoadFile.TabIndex = 72;
            this.btnLoadFile.Text = "Завантажити файл";
            this.btnLoadFile.UseVisualStyleBackColor = false;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
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
            this.btnClearTable.Location = new System.Drawing.Point(517, 439);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(190, 40);
            this.btnClearTable.TabIndex = 71;
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
            this.btnSaveFile.Location = new System.Drawing.Point(257, 439);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(190, 40);
            this.btnSaveFile.TabIndex = 70;
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
            this.btnRemove.Location = new System.Drawing.Point(687, 142);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 40);
            this.btnRemove.TabIndex = 69;
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
            this.btnEdit.Location = new System.Drawing.Point(502, 142);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 40);
            this.btnEdit.TabIndex = 68;
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
            this.btnAdd.Location = new System.Drawing.Point(317, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 40);
            this.btnAdd.TabIndex = 67;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtContacts
            // 
            this.txtContacts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContacts.BackColor = System.Drawing.Color.White;
            this.txtContacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContacts.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContacts.ForeColor = System.Drawing.Color.Black;
            this.txtContacts.Location = new System.Drawing.Point(582, 98);
            this.txtContacts.Multiline = true;
            this.txtContacts.Name = "txtContacts";
            this.txtContacts.Size = new System.Drawing.Size(134, 31);
            this.txtContacts.TabIndex = 64;
            // 
            // lblContacts
            // 
            this.lblContacts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblContacts.AutoSize = true;
            this.lblContacts.BackColor = System.Drawing.Color.Transparent;
            this.lblContacts.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacts.ForeColor = System.Drawing.Color.Black;
            this.lblContacts.Location = new System.Drawing.Point(580, 69);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(122, 23);
            this.lblContacts.TabIndex = 63;
            this.lblContacts.Text = "Контактні дані";
            // 
            // txtReaderName
            // 
            this.txtReaderName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtReaderName.BackColor = System.Drawing.Color.White;
            this.txtReaderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReaderName.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReaderName.ForeColor = System.Drawing.Color.Black;
            this.txtReaderName.Location = new System.Drawing.Point(402, 98);
            this.txtReaderName.Multiline = true;
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.Size = new System.Drawing.Size(134, 31);
            this.txtReaderName.TabIndex = 62;
            // 
            // lblReaderName
            // 
            this.lblReaderName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReaderName.AutoSize = true;
            this.lblReaderName.BackColor = System.Drawing.Color.Transparent;
            this.lblReaderName.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReaderName.ForeColor = System.Drawing.Color.Black;
            this.lblReaderName.Location = new System.Drawing.Point(400, 69);
            this.lblReaderName.Name = "lblReaderName";
            this.lblReaderName.Size = new System.Drawing.Size(37, 23);
            this.lblReaderName.TabIndex = 61;
            this.lblReaderName.Text = "ПІБ";
            // 
            // txtReaderID
            // 
            this.txtReaderID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtReaderID.BackColor = System.Drawing.Color.White;
            this.txtReaderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReaderID.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReaderID.ForeColor = System.Drawing.Color.Black;
            this.txtReaderID.Location = new System.Drawing.Point(222, 98);
            this.txtReaderID.Multiline = true;
            this.txtReaderID.Name = "txtReaderID";
            this.txtReaderID.Size = new System.Drawing.Size(134, 31);
            this.txtReaderID.TabIndex = 60;
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
            this.pnlButtons.TabIndex = 50;
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
            this.btnReturnBooks.Text = "     Повернення \r\n книг";
            this.btnReturnBooks.UseVisualStyleBackColor = false;
            this.btnReturnBooks.Click += new System.EventHandler(this.btnReturnBooks_Click);
            // 
            // btnReaders
            // 
            this.btnReaders.BackColor = System.Drawing.SystemColors.Menu;
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
            // 
            // btnIssueBooks
            // 
            this.btnIssueBooks.BackColor = System.Drawing.Color.Transparent;
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
            this.btnIssueBooks.Text = "     Видача книг";
            this.btnIssueBooks.UseVisualStyleBackColor = false;
            this.btnIssueBooks.Click += new System.EventHandler(this.btnIssueBooks_Click);
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
            // gridViewReaders
            // 
            this.gridViewReaders.AllowUserToAddRows = false;
            this.gridViewReaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewReaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reader_id,
            this.reader_name,
            this.contacts});
            this.gridViewReaders.Location = new System.Drawing.Point(222, 188);
            this.gridViewReaders.Name = "gridViewReaders";
            this.gridViewReaders.RowHeadersWidth = 51;
            this.gridViewReaders.RowTemplate.Height = 24;
            this.gridViewReaders.Size = new System.Drawing.Size(780, 245);
            this.gridViewReaders.TabIndex = 73;
            this.gridViewReaders.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridViewReaders_MouseClick);
            // 
            // reader_id
            // 
            this.reader_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // contacts
            // 
            this.contacts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contacts.HeaderText = "Контактні дані";
            this.contacts.MinimumWidth = 6;
            this.contacts.Name = "contacts";
            // 
            // lblReaderID
            // 
            this.lblReaderID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReaderID.AutoSize = true;
            this.lblReaderID.BackColor = System.Drawing.Color.Transparent;
            this.lblReaderID.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReaderID.ForeColor = System.Drawing.Color.Black;
            this.lblReaderID.Location = new System.Drawing.Point(220, 69);
            this.lblReaderID.Name = "lblReaderID";
            this.lblReaderID.Size = new System.Drawing.Size(123, 23);
            this.lblReaderID.TabIndex = 59;
            this.lblReaderID.Text = "Номер читача";
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(975, 13);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(26, 26);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 53;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.BackColor = System.Drawing.Color.Transparent;
            this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnNormal.Image")));
            this.btnNormal.Location = new System.Drawing.Point(975, 13);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(26, 26);
            this.btnNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNormal.TabIndex = 58;
            this.btnNormal.TabStop = false;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // lblReaders
            // 
            this.lblReaders.AutoSize = true;
            this.lblReaders.BackColor = System.Drawing.Color.Transparent;
            this.lblReaders.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReaders.ForeColor = System.Drawing.Color.Black;
            this.lblReaders.Location = new System.Drawing.Point(212, 12);
            this.lblReaders.Name = "lblReaders";
            this.lblReaders.Size = new System.Drawing.Size(74, 28);
            this.lblReaders.TabIndex = 57;
            this.lblReaders.Text = "Читачі";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(835, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 23);
            this.lblUsername.TabIndex = 56;
            this.lblUsername.Text = "Username";
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pictureAvatar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pictureAvatar.Image")));
            this.pictureAvatar.Location = new System.Drawing.Point(801, 10);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Size = new System.Drawing.Size(32, 32);
            this.pictureAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAvatar.TabIndex = 55;
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
            this.pictureLine.Size = new System.Drawing.Size(825, 1);
            this.pictureLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureLine.TabIndex = 54;
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
            this.btnMinimize.Location = new System.Drawing.Point(935, 20);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(26, 26);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 52;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1012, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 51;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            // 
            // Readers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1050, 500);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnClearTable);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtContacts);
            this.Controls.Add(this.lblContacts);
            this.Controls.Add(this.txtReaderName);
            this.Controls.Add(this.lblReaderName);
            this.Controls.Add(this.txtReaderID);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.gridViewReaders);
            this.Controls.Add(this.lblReaderID);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.lblReaders);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pictureAvatar);
            this.Controls.Add(this.pictureLine);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1050, 500);
            this.Name = "Readers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Readers";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Books_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Books_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Books_MouseUp);
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReaders)).EndInit();
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
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnClearTable;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtContacts;
        private System.Windows.Forms.Label lblContacts;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.Label lblReaderName;
        private System.Windows.Forms.TextBox txtReaderID;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.DataGridView gridViewReaders;
        private System.Windows.Forms.Label lblReaderID;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnNormal;
        private System.Windows.Forms.Label lblReaders;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureAvatar;
        private System.Windows.Forms.PictureBox pictureLine;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn reader_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn reader_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn contacts;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReturnBooks;
        private System.Windows.Forms.Button btnReaders;
        private System.Windows.Forms.Button btnIssueBooks;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
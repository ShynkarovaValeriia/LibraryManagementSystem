using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LibraryManagementSystem
{
    public partial class IssueReturnBooks : Form
    {
        public IssueReturnBooks(string username)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Load += new EventHandler(IssueReturnBooks_Load);
            this.FormClosing += IssueReturnBooks_FormClosing;
            lblUsername.Text = username; // Змінює заголовок форми
        }

        // Кнопка Головна сторінка

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueReturnBooks_FormClosing(sender, e);
            string username = lblUsername.Text;
            HomePage homepageForm = new HomePage(char.ToUpper(username[0]) + username.Substring(1));
            homepageForm.Show();
        }

        // Кнопка Книги

        private void btnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueReturnBooks_FormClosing(sender, e);
            string username = lblUsername.Text;
            Books booksForm = new Books(char.ToUpper(username[0]) + username.Substring(1));
            booksForm.Show();
        }

        // Кнопка Читачі

        private void btnReaders_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueReturnBooks_FormClosing(sender, e);
            string username = lblUsername.Text;
            Readers readersForm = new Readers(char.ToUpper(username[0]) + username.Substring(1));
            readersForm.Show();
        }

        // Кнопка Пошуку даних

        private void btnReturnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueReturnBooks_FormClosing(sender, e);
            string username = lblUsername.Text;
            DataSearch returnBooksForm = new DataSearch(char.ToUpper(username[0]) + username.Substring(1));
            returnBooksForm.Show();
        }

        // Кнопка Вийти із акаунту

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueReturnBooks_FormClosing(sender, e);
            Login loginForm = new Login();
            loginForm.Show();
        }

        // Кнопка Додати

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text == "" || txtReaderID.Text == "")
            {
                MessageBox.Show("Заповніть усі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtPickerIssue.Value.Date > dtPickerReturn.Value.Date)
            {
                MessageBox.Show("Дата видачі не може бути пізніше дати повернення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = gridViewIssueReturnBooks.Rows.Add();
                gridViewIssueReturnBooks.Rows[n].Cells[0].Value = txtBookID.Text;
                gridViewIssueReturnBooks.Rows[n].Cells[1].Value = txtReaderID.Text;
                gridViewIssueReturnBooks.Rows[n].Cells[2].Value = dtPickerIssue.Value.ToString("dd.MM.yyyy");
                gridViewIssueReturnBooks.Rows[n].Cells[3].Value = dtPickerReturn.Value.ToString("dd.MM.yyyy");
                gridViewIssueReturnBooks.Rows[n].Cells[4].Value = chkReturnSign.Checked ? "Повернено" : "Не повернено";
            }
        }

        // Кнопка Редагувати

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridViewIssueReturnBooks.SelectedRows.Count > 0)
            {
                int n = gridViewIssueReturnBooks.SelectedRows[0].Index;
                gridViewIssueReturnBooks.Rows[n].Cells[0].Value = txtBookID.Text;
                gridViewIssueReturnBooks.Rows[n].Cells[1].Value = txtReaderID.Text;
                gridViewIssueReturnBooks.Rows[n].Cells[2].Value = dtPickerIssue.Text;
                gridViewIssueReturnBooks.Rows[n].Cells[3].Value = dtPickerReturn.Text;
                gridViewIssueReturnBooks.Rows[n].Cells[4].Value = chkReturnSign.Checked ? "Повернено" : "Не повернено";
            }
            else
            {
                MessageBox.Show("Оберіть рядок для редагування", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Кнопка Видалення

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gridViewIssueReturnBooks.SelectedRows.Count > 0)
            {
                gridViewIssueReturnBooks.Rows.RemoveAt(gridViewIssueReturnBooks.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Оберіть рядок для видалення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Вибір потрібного рядка для редагування

        private void gridViewIssueReturnBooks_MouseClick(object sender, MouseEventArgs e)
        {
            if (gridViewIssueReturnBooks.SelectedRows.Count > 0)
            {
                txtBookID.Text = gridViewIssueReturnBooks.SelectedRows[0].Cells[0].Value?.ToString();
                txtReaderID.Text = gridViewIssueReturnBooks.SelectedRows[0].Cells[1].Value?.ToString();
                dtPickerIssue.Text = gridViewIssueReturnBooks.SelectedRows[0].Cells[2].Value?.ToString();
                dtPickerReturn.Text = gridViewIssueReturnBooks.SelectedRows[0].Cells[3].Value?.ToString();
                string returnStatus = gridViewIssueReturnBooks.SelectedRows[0].Cells[4].Value?.ToString();
                chkReturnSign.Checked = returnStatus == "Повернено";
            }
        }

        // Кнопка Зберегти як файл

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LibraryManagementSystem");
            string filePath = Path.Combine(folderPath, "Books.xml");

            try
            {
                DataSet ds;

                // Перевіряємо, чи файл існує
                if (File.Exists(filePath))
                {
                    ds = new DataSet();
                    ds.ReadXml(filePath);
                }
                else
                {
                    ds = new DataSet();
                }

                DataTable dt;
                // Перевіряємо, чи таблиця "Видача книг" вже існує
                if (ds.Tables.Contains("IssueReturnBooks"))
                {
                    dt = ds.Tables["IssueReturnBooks"];
                    dt.Rows.Clear();
                }
                else
                {
                    dt = new DataTable();
                    dt.TableName = "IssueReturnBooks";
                    dt.Columns.Add("BookID");
                    dt.Columns.Add("ReaderID");
                    dt.Columns.Add("IssueDate");
                    dt.Columns.Add("ReturnDate");
                    dt.Columns.Add("ReturnStatus");
                    ds.Tables.Add(dt);
                }

                foreach (DataGridViewRow r in gridViewIssueReturnBooks.Rows)
                {
                    DataRow row = dt.NewRow();
                    row["BookID"] = r.Cells[0].Value;
                    row["ReaderID"] = r.Cells[1].Value;
                    row["IssueDate"] = r.Cells[2].Value;
                    row["ReturnDate"] = r.Cells[3].Value;
                    row["ReturnStatus"] = r.Cells[4].Value;
                    dt.Rows.Add(row);
                }

                ds.WriteXml(filePath);
                MessageBox.Show("Файл успішно збережений", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Неможливо зберегти файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Кнопка Завантажити файл

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LibraryManagementSystem");
            string filePath = Path.Combine(folderPath, "Books.xml");

            if (gridViewIssueReturnBooks.Rows.Count > 0)
            {
                MessageBox.Show("Очистіть таблицю перед завантаженням нового файлу", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (File.Exists(filePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(filePath);

                if (ds.Tables.Contains("IssueReturnBooks"))
                {
                    foreach (DataRow item in ds.Tables["IssueReturnBooks"].Rows)
                    {
                        int n = gridViewIssueReturnBooks.Rows.Add();
                        gridViewIssueReturnBooks.Rows[n].Cells[0].Value = item["BookID"];
                        gridViewIssueReturnBooks.Rows[n].Cells[1].Value = item["ReaderID"];
                        gridViewIssueReturnBooks.Rows[n].Cells[2].Value = item["IssueDate"];
                        gridViewIssueReturnBooks.Rows[n].Cells[3].Value = item["ReturnDate"];
                        gridViewIssueReturnBooks.Rows[n].Cells[4].Value = item["ReturnStatus"];
                    }
                }
                else
                {
                    MessageBox.Show("Дані не знайдено у файлі", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Файл не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Кнопка Очистити таблицю

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            if (gridViewIssueReturnBooks.Rows.Count > 0)
            {
                gridViewIssueReturnBooks.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Таблиця порожня", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Завантаження даних

        private void IssueReturnBooks_Load(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LibraryManagementSystem");
            string filePath = Path.Combine(folderPath, "Books.xml");

            if (File.Exists(filePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(filePath);

                if (ds.Tables.Contains("IssueReturnBooks"))
                {
                    foreach (DataRow item in ds.Tables["IssueReturnBooks"].Rows)
                    {
                        int n = gridViewIssueReturnBooks.Rows.Add();
                        gridViewIssueReturnBooks.Rows[n].Cells[0].Value = item["BookID"];
                        gridViewIssueReturnBooks.Rows[n].Cells[1].Value = item["ReaderID"];
                        gridViewIssueReturnBooks.Rows[n].Cells[2].Value = item["IssueDate"];
                        gridViewIssueReturnBooks.Rows[n].Cells[3].Value = item["ReturnDate"];
                        gridViewIssueReturnBooks.Rows[n].Cells[4].Value = item["ReturnStatus"];
                    }
                }
                else
                {
                    MessageBox.Show("Дані не знайдено у файлі", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Файл не знайдено", "Помилка завантаження даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Збереження даних після закриття

        private void IssueReturnBooks_FormClosing(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LibraryManagementSystem");
            string filePath = Path.Combine(folderPath, "Books.xml");

            try
            {
                DataSet ds;

                // Перевіряємо, чи файл існує
                if (File.Exists(filePath))
                {
                    ds = new DataSet();
                    ds.ReadXml(filePath);
                }
                else
                {
                    ds = new DataSet();
                }

                DataTable dt;
                // Перевіряємо, чи таблиця "Видача та повернення книг" вже існує
                if (ds.Tables.Contains("IssueReturnBooks"))
                {
                    dt = ds.Tables["IssueReturnBooks"];
                    dt.Rows.Clear();
                }
                else
                {
                    dt = new DataTable();
                    dt.TableName = "IssueReturnBooks";
                    dt.Columns.Add("BookID");
                    dt.Columns.Add("ReaderID");
                    dt.Columns.Add("IssueDate");
                    dt.Columns.Add("ReturnDate");
                    dt.Columns.Add("ReturnStatus");
                    ds.Tables.Add(dt);
                }

                foreach (DataGridViewRow r in gridViewIssueReturnBooks.Rows)
                {
                    DataRow row = dt.NewRow();
                    row["BookID"] = r.Cells[0].Value;
                    row["ReaderID"] = r.Cells[1].Value;
                    row["IssueDate"] = r.Cells[2].Value;
                    row["ReturnDate"] = r.Cells[3].Value;
                    row["ReturnStatus"] = r.Cells[4].Value;
                    dt.Rows.Add(row);
                }

                ds.WriteXml(filePath);
            }
            catch (Exception ex)
            {
                // Продовжуємо виконання програми, не виводимо повідомлення про помилку
            }
        }

        // Кнопка Закрити

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnNormal.Visible = true;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximize.Visible = true;
            btnNormal.Visible = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Настройка змінювання розміру вікна форми

        private const int cGrip = 16;
        private const int cCaption = 0;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2; // HTCAPTION: Переміщення вікна
                    return;
                }
                // Перевірка, чи натиснуто на границі форми
                if (pos.X <= cGrip && pos.Y <= cGrip)
                {
                    m.Result = (IntPtr)13; // HTTOPLEFT: Зміна ширини та висоти зліва зверху
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y <= cGrip)
                {
                    m.Result = (IntPtr)14; // HTTOPRIGHT: Зміна ширини та висоти справа зверху
                    return;
                }
                if (pos.X <= cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)16; // HTBOTTOMLEFT: Зміна ширини та висоти зліва знизу
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT: Зміна ширини та висоти справа знизу
                    return;
                }
                if (pos.X <= cGrip)
                {
                    m.Result = (IntPtr)10; // HTLEFT: Зміна ширини зліва
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip)
                {
                    m.Result = (IntPtr)11; // HTRIGHT: Зміна ширини справа
                    return;
                }
                if (pos.Y <= cGrip)
                {
                    m.Result = (IntPtr)12; // HTTOP: Зміна висоти зверху
                    return;
                }
                if (pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)15; // HTBOTTOM: Зміна висоти знизу
                    return;
                }
            }
            base.WndProc(ref m);
        }

        // Настройка перетягування вікна форми

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Books_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Books_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Books_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}

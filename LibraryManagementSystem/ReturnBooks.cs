using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LibraryManagementSystem
{
    public partial class ReturnBooks : Form
    {
        public ReturnBooks(string username)
        {
            InitializeComponent();
            this.Load += new EventHandler(ReturnBooks_Load);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            lblUsername.Text = username; // Змінює заголовок форми
        }

        // Кнопка Головна сторінка

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = lblUsername.Text;
            HomePage homepageForm = new HomePage(char.ToUpper(username[0]) + username.Substring(1));
            homepageForm.Show();
        }

        // Кнопка Книги

        private void btnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = lblUsername.Text;
            Books booksForm = new Books(char.ToUpper(username[0]) + username.Substring(1));
            booksForm.Show();
        }

        // Кнопка Читачі

        private void btnReaders_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = lblUsername.Text;
            Readers readersForm = new Readers(char.ToUpper(username[0]) + username.Substring(1));
            readersForm.Show();
        }

        // Кнопка Видача книг

        private void btnIssueBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = lblUsername.Text;
            IssueBooks issuesForm = new IssueBooks(char.ToUpper(username[0]) + username.Substring(1));
            issuesForm.Show();
        }

        // Кнопка Вийти із акаунту

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        // Кнопка Додати

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIssueID.Text == "" || txtBookID.Text == "" || txtReaderID.Text == "")
            {
                MessageBox.Show("Заповніть усі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = gridViewReturnBooks.Rows.Add();
                gridViewReturnBooks.Rows[n].Cells[0].Value = n + 1;
                gridViewReturnBooks.Rows[n].Cells[1].Value = txtIssueID.Text;
                gridViewReturnBooks.Rows[n].Cells[2].Value = dtPickerReturn.Text;
                gridViewReturnBooks.Rows[n].Cells[3].Value = txtBookID.Text;
                gridViewReturnBooks.Rows[n].Cells[4].Value = txtReaderID.Text;
            }
        }

        // Кнопка Редагувати

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridViewReturnBooks.SelectedRows.Count > 0)
            {
                int n = gridViewReturnBooks.SelectedRows[0].Index;
                gridViewReturnBooks.Rows[n].Cells[0].Value = n + 1;
                gridViewReturnBooks.Rows[n].Cells[1].Value = txtIssueID.Text;
                gridViewReturnBooks.Rows[n].Cells[2].Value = dtPickerReturn.Text;
                gridViewReturnBooks.Rows[n].Cells[3].Value = txtBookID.Text;
                gridViewReturnBooks.Rows[n].Cells[4].Value = txtReaderID.Text;
            }
            else
            {
                MessageBox.Show("Оберіть рядок для редагування", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Кнопка Видалення

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gridViewReturnBooks.SelectedRows.Count > 0)
            {
                gridViewReturnBooks.Rows.RemoveAt(gridViewReturnBooks.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Оберіть рядок для видалення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // выбор нужной строки для редактирования

        private void gridViewReturnBooks_MouseClick(object sender, MouseEventArgs e)
        {
            if (gridViewReturnBooks.SelectedRows.Count > 0)
            {
                txtIssueID.Text = gridViewReturnBooks.SelectedRows[0].Cells[1].Value?.ToString();
                dtPickerReturn.Text = gridViewReturnBooks.SelectedRows[0].Cells[2].Value?.ToString();
                txtBookID.Text = gridViewReturnBooks.SelectedRows[0].Cells[3].Value?.ToString();
                txtReaderID.Text = gridViewReturnBooks.SelectedRows[0].Cells[4].Value?.ToString();
            }
        }

        // Кнопка Зберегти як файл

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Books.xml");

            int counter = 1;

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
                // Перевіряємо, чи таблиця "Повернення книг" вже існує
                if (ds.Tables.Contains("ReturnBooks"))
                {
                    dt = ds.Tables["ReturnBooks"];
                    dt.Rows.Clear();
                }
                else
                {
                    dt = new DataTable();
                    dt.TableName = "ReturnBooks";
                    dt.Columns.Add("ReturnID");
                    dt.Columns.Add("IssueID");
                    dt.Columns.Add("ReturnDate");
                    dt.Columns.Add("BookID");
                    dt.Columns.Add("ReaderID");
                    ds.Tables.Add(dt);
                }

                foreach (DataGridViewRow r in gridViewReturnBooks.Rows)
                {
                    DataRow row = dt.NewRow();
                    row["ReturnID"] = counter.ToString();
                    row["IssueID"] = r.Cells[1].Value;
                    row["ReturnDate"] = r.Cells[2].Value;
                    row["BookID"] = r.Cells[3].Value;
                    row["ReaderID"] = r.Cells[4].Value;
                    dt.Rows.Add(row);

                    counter++;
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
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Books.xml");

            if (gridViewReturnBooks.Rows.Count > 0)
            {
                MessageBox.Show("Очистіть таблицю перед завантаженням нового файлу", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (File.Exists(filePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(filePath);

                if (ds.Tables.Contains("ReturnBooks"))
                {
                    foreach (DataRow item in ds.Tables["ReturnBooks"].Rows)
                    {
                        int n = gridViewReturnBooks.Rows.Add();
                        gridViewReturnBooks.Rows[n].Cells[0].Value = item["ReturnID"];
                        gridViewReturnBooks.Rows[n].Cells[1].Value = item["IssueID"];
                        gridViewReturnBooks.Rows[n].Cells[2].Value = item["ReturnDate"];
                        gridViewReturnBooks.Rows[n].Cells[3].Value = item["BookID"];
                        gridViewReturnBooks.Rows[n].Cells[4].Value = item["ReaderID"];
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
            if (gridViewReturnBooks.Rows.Count > 0)
            {
                gridViewReturnBooks.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Таблиця порожня", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Завантаження даних

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Books.xml");

            if (File.Exists(filePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(filePath);

                if (ds.Tables.Contains("ReturnBooks"))
                {
                    foreach (DataRow item in ds.Tables["ReturnBooks"].Rows)
                    {
                        int n = gridViewReturnBooks.Rows.Add();
                        gridViewReturnBooks.Rows[n].Cells[0].Value = item["ReturnID"];
                        gridViewReturnBooks.Rows[n].Cells[1].Value = item["IssueID"];
                        gridViewReturnBooks.Rows[n].Cells[2].Value = item["ReturnDate"];
                        gridViewReturnBooks.Rows[n].Cells[3].Value = item["BookID"];
                        gridViewReturnBooks.Rows[n].Cells[4].Value = item["ReaderID"];
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
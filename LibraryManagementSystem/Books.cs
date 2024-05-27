using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace LibraryManagementSystem
{
    public partial class Books : Form
    {
        public Books(string username)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Load += new EventHandler(Books_Load);
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

        // Кнопка Повернення книг

        private void btnReturnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = lblUsername.Text;
            ReturnBooks returnBooksForm = new ReturnBooks(char.ToUpper(username[0]) + username.Substring(1));
            returnBooksForm.Show();
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
            int countBooks = 0;

            if (txtBookID.Text == "" || txtBookName.Text == "" || txtAuthor.Text == "" || txtGenre.Text == "")
            {
                MessageBox.Show("Заповніть усі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = gridViewBooks.Rows.Add();
                gridViewBooks.Rows[n].Cells[0].Value = txtBookID.Text;
                gridViewBooks.Rows[n].Cells[1].Value = txtBookName.Text;
                gridViewBooks.Rows[n].Cells[2].Value = txtAuthor.Text;
                gridViewBooks.Rows[n].Cells[3].Value = txtGenre.Text;
            }
        }

        // Кнопка Редагувати

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridViewBooks.SelectedRows.Count > 0)
            {
                int n = gridViewBooks.SelectedRows[0].Index;
                gridViewBooks.Rows[n].Cells[0].Value = txtBookID.Text;
                gridViewBooks.Rows[n].Cells[1].Value = txtBookName.Text;
                gridViewBooks.Rows[n].Cells[2].Value = txtAuthor.Text;
                gridViewBooks.Rows[n].Cells[3].Value = txtGenre.Text;
            }
            else
            {
                MessageBox.Show("Оберіть рядок для редагування", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Кнопка Видалити

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gridViewBooks.SelectedRows.Count > 0)
            {
                gridViewBooks.Rows.RemoveAt(gridViewBooks.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Оберіть рядок для видалення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // выбор нужной строки для редактирования

        private void gridViewBooks_MouseClick(object sender, MouseEventArgs e)
        {
            if (gridViewBooks.SelectedRows.Count > 0)
            {
                txtBookID.Text = gridViewBooks.SelectedRows[0].Cells[0].Value?.ToString();
                txtBookName.Text = gridViewBooks.SelectedRows[0].Cells[1].Value?.ToString();
                txtAuthor.Text = gridViewBooks.SelectedRows[0].Cells[2].Value?.ToString();
                txtGenre.Text = gridViewBooks.SelectedRows[0].Cells[3].Value?.ToString();
            }
        }

        // Кнопка Зберегти як файл

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Books.xml");

            try
            {
                DataSet ds;

                // Перевіряємо, чи файл існує
                if (File.Exists(filePath))
                {
                    // Якщо файл існує, завантажуємо його
                    ds = new DataSet();
                    ds.ReadXml(filePath);
                }
                else
                {
                    // Якщо файл не існує, створюємо новий DataSet
                    ds = new DataSet();
                }

                DataTable dt;
                // Перевіряємо, чи таблиця "Books" вже існує
                if (ds.Tables.Contains("Books"))
                {
                    // Якщо таблиця "Books" вже існує, отримуємо посилання на неї
                    dt = ds.Tables["Books"];
                    // Очищуємо дані таблиці
                    dt.Rows.Clear();
                }
                else
                {
                    // Якщо таблиця "Books" не існує, створюємо нову таблицю
                    dt = new DataTable();
                    dt.TableName = "Books";
                    dt.Columns.Add("BookID");
                    dt.Columns.Add("BookName");
                    dt.Columns.Add("Author");
                    dt.Columns.Add("Genre");
                    // Додаємо нову таблицю до DataSet
                    ds.Tables.Add(dt);
                }

                // Записуємо дані з DataGridView до таблиці "Books"
                foreach (DataGridViewRow r in gridViewBooks.Rows)
                {
                    DataRow row = dt.NewRow();
                    row["BookID"] = r.Cells[0].Value;
                    row["BookName"] = r.Cells[1].Value;
                    row["Author"] = r.Cells[2].Value;
                    row["Genre"] = r.Cells[3].Value;
                    dt.Rows.Add(row);
                }

                // Зберігаємо комбінований DataSet у файл
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

            if (gridViewBooks.Rows.Count > 0)
            {
                MessageBox.Show("Очистіть таблицю перед завантаженням нового файлу", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (File.Exists(filePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(filePath);

                if (ds.Tables.Contains("Books"))
                {
                    foreach (DataRow item in ds.Tables["Books"].Rows)
                    {
                        int n = gridViewBooks.Rows.Add();
                        gridViewBooks.Rows[n].Cells[0].Value = item["BookID"];
                        gridViewBooks.Rows[n].Cells[1].Value = item["BookName"];
                        gridViewBooks.Rows[n].Cells[2].Value = item["Author"];
                        gridViewBooks.Rows[n].Cells[3].Value = item["Genre"];
                    }
                }
                else
                {
                    MessageBox.Show("Таблиця 'Книги' не знайдена у файлі", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (gridViewBooks.Rows.Count > 0)
            {
                gridViewBooks.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Таблиця порожня", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Завантаження даних

        private void Books_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Books.xml");

            if (File.Exists(filePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(filePath);

                if (ds.Tables.Contains("Books"))
                {
                    foreach (DataRow item in ds.Tables["Books"].Rows)
                    {
                        int n = gridViewBooks.Rows.Add();
                        gridViewBooks.Rows[n].Cells[0].Value = item["BookID"];
                        gridViewBooks.Rows[n].Cells[1].Value = item["BookName"];
                        gridViewBooks.Rows[n].Cells[2].Value = item["Author"];
                        gridViewBooks.Rows[n].Cells[3].Value = item["Genre"];
                    }
                }
                else
                {
                    MessageBox.Show("Таблиця 'Книги' не знайдена у файлі", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Файл не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
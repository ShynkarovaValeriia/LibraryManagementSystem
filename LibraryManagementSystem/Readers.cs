using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LibraryManagementSystem
{
    public partial class Readers : Form
    {
        public Readers(string username)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Load += new EventHandler(Readers_Load);
            this.FormClosing += Readers_FormClosing;
            lblUsername.Text = username; // Змінює заголовок форми
        }

        // Кнопка Головна сторінка

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Readers_FormClosing(sender, e);
            string username = lblUsername.Text;
            HomePage homepageForm = new HomePage(char.ToUpper(username[0]) + username.Substring(1));
            homepageForm.Show();
        }

        // Кнопка Книги

        private void btnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Readers_FormClosing(sender, e);
            string username = lblUsername.Text;
            Books booksForm = new Books(char.ToUpper(username[0]) + username.Substring(1));
            booksForm.Show();
        }

        // Кнопка Видача та повернення книг

        private void btnIssueReturnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Readers_FormClosing(sender, e);
            string username = lblUsername.Text;
            IssueReturnBooks issueReturnForm = new IssueReturnBooks(char.ToUpper(username[0]) + username.Substring(1));
            issueReturnForm.Show();
        }

        // Кнопка Пошук даних

        private void btnDataSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Readers_FormClosing(sender, e);
            string username = lblUsername.Text;
            DataSearch dataSearchForm = new DataSearch(char.ToUpper(username[0]) + username.Substring(1));
            dataSearchForm.Show();
        }

        // Кнопка Вийти із акаунту

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Readers_FormClosing(sender, e);
            Login loginForm = new Login();
            loginForm.Show();
        }

        // Кнопка Додати

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtReaderID.Text == "" || txtReaderName.Text == "" || txtContacts.Text == "")
            {
                MessageBox.Show("Заповніть усі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Перевірка унікальності ReaderID
                bool unique = true;
                foreach (DataGridViewRow row in gridViewReaders.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtReaderID.Text)
                    {
                        unique = false;
                        break;
                    }
                }

                if (unique)
                {
                    int n = gridViewReaders.Rows.Add();
                    gridViewReaders.Rows[n].Cells[0].Value = txtReaderID.Text;
                    gridViewReaders.Rows[n].Cells[1].Value = txtReaderName.Text;
                    gridViewReaders.Rows[n].Cells[2].Value = txtContacts.Text;
                }
                else
                {
                    MessageBox.Show("Номер читача має бути унікальним значенням", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Кнопка Редагувати

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridViewReaders.SelectedRows.Count > 0)
            {
                int n = gridViewReaders.SelectedRows[0].Index;
                gridViewReaders.Rows[n].Cells[0].Value = txtReaderID.Text;
                gridViewReaders.Rows[n].Cells[1].Value = txtReaderName.Text;
                gridViewReaders.Rows[n].Cells[2].Value = txtContacts.Text;
            }
            else
            {
                MessageBox.Show("Оберіть рядок для редагування", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Кнопка Видалення

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gridViewReaders.SelectedRows.Count > 0)
            {
                gridViewReaders.Rows.RemoveAt(gridViewReaders.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Оберіть рядок для видалення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Вибір потрібного рядка для редагування

        private void gridViewReaders_MouseClick(object sender, MouseEventArgs e)
        {
            if (gridViewReaders.SelectedRows.Count > 0)
            {
                txtReaderID.Text = gridViewReaders.SelectedRows[0].Cells[0].Value?.ToString();
                txtReaderName.Text = gridViewReaders.SelectedRows[0].Cells[1].Value?.ToString();
                txtContacts.Text = gridViewReaders.SelectedRows[0].Cells[2].Value?.ToString();
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
                // Перевіряємо, чи таблиця "Читачі" вже існує
                if (ds.Tables.Contains("Readers"))
                {
                    // Якщо таблиця "Читачі" вже існує, отримуємо посилання на неї
                    dt = ds.Tables["Readers"];
                    // Очищуємо дані таблиці
                    dt.Rows.Clear();
                }
                else
                {
                    // Якщо таблиця "Читачі" не існує, створюємо нову таблицю
                    dt = new DataTable();
                    dt.TableName = "Readers";
                    dt.Columns.Add("ReaderID");
                    dt.Columns.Add("ReaderName");
                    dt.Columns.Add("Contacts");
                    // Додаємо нову таблицю до DataSet
                    ds.Tables.Add(dt);
                }

                // Записуємо дані з DataGridView до таблиці "Читачі"
                foreach (DataGridViewRow r in gridViewReaders.Rows)
                {
                    DataRow row = dt.NewRow();
                    row["ReaderID"] = r.Cells[0].Value;
                    row["ReaderName"] = r.Cells[1].Value;
                    row["Contacts"] = r.Cells[2].Value;
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
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LibraryManagementSystem");
            string filePath = Path.Combine(folderPath, "Books.xml");

            if (gridViewReaders.Rows.Count > 0)
            {
                MessageBox.Show("Очистіть таблицю перед завантаженням нового файлу", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (File.Exists(filePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(filePath);

                if (ds.Tables.Contains("Readers"))
                {
                    foreach (DataRow item in ds.Tables["Readers"].Rows)
                    {
                        int n = gridViewReaders.Rows.Add();
                        gridViewReaders.Rows[n].Cells[0].Value = item["ReaderID"];
                        gridViewReaders.Rows[n].Cells[1].Value = item["ReaderName"];
                        gridViewReaders.Rows[n].Cells[2].Value = item["Contacts"];
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
            if (gridViewReaders.Rows.Count > 0)
            {
                gridViewReaders.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Таблиця порожня", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Завантаження даних

        private void Readers_Load(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LibraryManagementSystem");
            string filePath = Path.Combine(folderPath, "Books.xml");

            if (File.Exists(filePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(filePath);

                if (ds.Tables.Contains("Readers"))
                {
                    foreach (DataRow item in ds.Tables["Readers"].Rows)
                    {
                        int n = gridViewReaders.Rows.Add();
                        gridViewReaders.Rows[n].Cells[0].Value = item["ReaderID"];
                        gridViewReaders.Rows[n].Cells[1].Value = item["ReaderName"];
                        gridViewReaders.Rows[n].Cells[2].Value = item["Contacts"];
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

        private void Readers_FormClosing(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LibraryManagementSystem");
            string filePath = Path.Combine(folderPath, "Books.xml");

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
                // Перевіряємо, чи таблиця "Читачі" вже існує
                if (ds.Tables.Contains("Readers"))
                {
                    // Якщо таблиця "Читачі" вже існує, отримуємо посилання на неї
                    dt = ds.Tables["Readers"];
                    // Очищуємо дані таблиці
                    dt.Rows.Clear();
                }
                else
                {
                    // Якщо таблиця "Читачі" не існує, створюємо нову таблицю
                    dt = new DataTable();
                    dt.TableName = "Readers";
                    dt.Columns.Add("ReaderID");
                    dt.Columns.Add("ReaderName");
                    dt.Columns.Add("Contacts");
                    // Додаємо нову таблицю до DataSet
                    ds.Tables.Add(dt);
                }

                // Записуємо дані з DataGridView до таблиці "Читачі"
                foreach (DataGridViewRow r in gridViewReaders.Rows)
                {
                    DataRow row = dt.NewRow();
                    row["ReaderID"] = r.Cells[0].Value;
                    row["ReaderName"] = r.Cells[1].Value;
                    row["Contacts"] = r.Cells[2].Value;
                    dt.Rows.Add(row);
                }

                // Зберігаємо комбінований DataSet у файл
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class HomePage : Form
    {
        public HomePage(string username)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            lblUsername.Text = username; // Змінює заголовок форми
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

        // Лічильник метрик

        private void HomePage_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Books.xml");

            int countBooks = 0;
            int countIssueBooks = 0;
            int countReaders = 0;
            int countReturnBooks = 0;

            if (File.Exists(filePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(filePath);

                // Перевіряємо наявність таблиці 'Книги' і рахуємо кількість рядків
                if (ds.Tables.Contains("Books"))
                {
                    countBooks = ds.Tables["Books"].Rows.Count;
                    countTotalBooks.Text = countBooks.ToString();
                }
                else
                {
                    countTotalBooks.Text = "0";  // Встановлюємо значення 0, якщо таблиця не існує
                }

                // Перевіряємо наявність таблиці 'Видача книг' і рахуємо кількість рядків
                if (ds.Tables.Contains("IssueBooks"))
                {
                    countIssueBooks = ds.Tables["IssueBooks"].Rows.Count;
                    this.countIssueBooks.Text = countIssueBooks.ToString();
                }
                else
                {
                    this.countIssueBooks.Text = "0";  // Встановлюємо значення 0, якщо таблиця не існує
                }

                // Перевіряємо наявність таблиці 'Читачі' і рахуємо кількість рядків
                if (ds.Tables.Contains("Readers"))
                {
                    countReaders = ds.Tables["Readers"].Rows.Count;
                    countTotalReaders.Text = countReaders.ToString();
                }
                else
                {
                    countTotalReaders.Text = "0";  // Встановлюємо значення 0, якщо таблиця не існує
                }

                // Перевіряємо наявність таблиці 'Повернення книг' і рахуємо кількість рядків
                if (ds.Tables.Contains("ReturnBooks"))
                {
                    if (ds.Tables.Contains("IssueBooks"))
                    {
                        foreach (DataRow returnRow in ds.Tables["ReturnBooks"].Rows)
                        {
                            DateTime actualReturnDate = Convert.ToDateTime(returnRow["ReturnDate"]);
                            string bookId = returnRow["BookID"].ToString();

                            // Знаходимо відповідний рядок у таблиці "IssueBooks"
                            DataRow[] issueRows = ds.Tables["IssueBooks"].Select("BookID = '" + bookId + "'");
                            if (issueRows.Length > 0)
                            {
                                DateTime expectedReturnDate = Convert.ToDateTime(issueRows[0]["ReturnDate"]);
                                if (actualReturnDate > expectedReturnDate)
                                {
                                    countReturnBooks++;
                                }
                            }
                        }
                        countBorrows.Text = countReturnBooks.ToString();
                    }
                    else
                    {
                        countBorrows.Text = "0";  // Встановлюємо значення 0, якщо таблиця не існує
                    }
                }
                else
                {
                    countBorrows.Text = "0";  // Встановлюємо значення 0, якщо таблиця не існує
                }

                // Оновлюємо DataGridView з інформацією про найпопулярніші книги
                UpdatePopularBooks(ds);

                // Оновлюємо інформацію про частих відвідувачів
                UpdatePopularReaders(ds);
            }
            else
            {
                MessageBox.Show("Файл не знайдено", "Помилка завантаження даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePopularBooks(DataSet ds)
        {
            if (ds.Tables.Contains("Books"))
            {
                var bookPopularity = new Dictionary<string, int>();

                // Збираємо дані про популярність книг за жанрами
                foreach (DataRow row in ds.Tables["Books"].Rows)
                {
                    string genre = row["Genre"].ToString();
                    if (bookPopularity.ContainsKey(genre))
                    {
                        bookPopularity[genre]++;
                    }
                    else
                    {
                        bookPopularity[genre] = 1;
                    }
                }

                // Конвертуємо словник у список для сортування
                var popularityList = bookPopularity.ToList();

                // Сортування методом простого вибору
                for (int i = 0; i < popularityList.Count - 1; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < popularityList.Count; j++)
                    {
                        if (popularityList[j].Value > popularityList[minIndex].Value)
                        {
                            minIndex = j;
                        }
                    }
                    if (minIndex != i)
                    {
                        var temp = popularityList[i];
                        popularityList[i] = popularityList[minIndex];
                        popularityList[minIndex] = temp;
                    }
                }

                // Очищуємо попередні дані в DataGridView
                gridViewPopularBooks.Rows.Clear();

                // Додаємо відсортовані дані до DataGridView
                foreach (var item in popularityList)
                {
                    gridViewPopularBooks.Rows.Add(item.Key, item.Value);
                }
            }
            else
            {
                MessageBox.Show("Дані не знайдені у файлі", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePopularReaders(DataSet ds)
        {
            if (ds.Tables.Contains("IssueBooks"))
            {
                var readerVisits = new Dictionary<string, int>();

                // Збираємо дані про відвідування читачів
                foreach (DataRow row in ds.Tables["IssueBooks"].Rows)
                {
                    string readerID = row["ReaderID"].ToString();
                    if (readerVisits.ContainsKey(readerID))
                    {
                        readerVisits[readerID]++;
                    }
                    else
                    {
                        readerVisits[readerID] = 1;
                    }
                }

                // Конвертуємо словник у список для сортування
                var visitsList = readerVisits.ToList();

                // Сортування методом простого вибору
                for (int i = 0; i < visitsList.Count - 1; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < visitsList.Count; j++)
                    {
                        if (visitsList[j].Value > visitsList[minIndex].Value)
                        {
                            minIndex = j;
                        }
                    }
                    if (minIndex != i)
                    {
                        var temp = visitsList[i];
                        visitsList[i] = visitsList[minIndex];
                        visitsList[minIndex] = temp;
                    }
                }

                // Очищуємо попередні дані в DataGridView
                gridViewPopularReaders.Rows.Clear();

                // Додаємо відсортовані дані до DataGridView
                foreach (var item in visitsList)
                {
                    gridViewPopularReaders.Rows.Add(item.Key, item.Value);
                }
            }
            else
            {
                MessageBox.Show("Дані не знайдені у файлі", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void HomePage_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void HomePage_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void HomePage_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
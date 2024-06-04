using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Xml.Linq;

namespace LibraryManagementSystem
{
    public partial class DataSearch : Form
    {
        public DataSearch(string username)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            lblUsername.Text = username; // Змінює заголовок форми
        }

        public DataSet ds;

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

        // Кнопка Видача та повернення книг

        private void btnIssueReturnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = lblUsername.Text;
            IssueReturnBooks issueReturnForm = new IssueReturnBooks(char.ToUpper(username[0]) + username.Substring(1));
            issueReturnForm.Show();
        }

        // Кнопка Вийти із акаунту

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        // Збір даних із XML файлу в списки

        private Dictionary<string, int> GetBookPopularityFromXml(string filePath)
        {
            var bookPopularity = new Dictionary<string, int>();

            if (File.Exists(filePath))
            {
                XDocument doc = XDocument.Load(filePath);

                var books = doc.Descendants("Book");
                foreach (var book in books)
                {
                    string genre = book.Element("Genre").Value;
                    if (bookPopularity.ContainsKey(genre))
                    {
                        bookPopularity[genre]++;
                    }
                    else
                    {
                        bookPopularity[genre] = 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл не знайдено", "Помилка завантаження даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bookPopularity;
        }

        // Сортування методом простого вибору

        private void Sorting(DataGridView dataGridView)
        {
            dataGridView.SuspendLayout();

            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                int maxIndex = i;

                for (int j = i + 1; j < dataGridView.Rows.Count; j++)
                {
                    if (int.Parse(dataGridView.Rows[j].Cells["count"].Value.ToString()) > int.Parse(dataGridView.Rows[maxIndex].Cells["count"].Value.ToString()))
                    {
                        maxIndex = j;
                    }
                }

                if (maxIndex != i)
                {
                    // Обмін рядків місцями
                    var tempRow = (DataGridViewRow)dataGridView.Rows[maxIndex].Clone();
                    for (int k = 0; k < tempRow.Cells.Count; k++)
                    {
                        tempRow.Cells[k].Value = dataGridView.Rows[maxIndex].Cells[k].Value;
                    }

                    dataGridView.Rows.RemoveAt(maxIndex);
                    dataGridView.Rows.Insert(i, tempRow);
                }
            }

            dataGridView.ResumeLayout();
        }

        // Бінарний пошук

        private int BinarySearch(List<KeyValuePair<string, int>> list, string genre)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (list[mid].Key.Equals(genre, StringComparison.OrdinalIgnoreCase))
                {
                    return mid;
                }
                else if (string.Compare(list[mid].Key, genre, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

        // Кнопка Пошук

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LibraryManagementSystem");
            string filePath = Path.Combine(folderPath, "Books.xml");

            if (File.Exists(filePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(filePath);

                if (rbGenre.Checked)
                {
                    lblCount.Text = "";

                    if (ds.Tables.Contains("Books") && ds.Tables.Contains("Readers") && ds.Tables.Contains("IssueReturnBooks"))
                    {
                        var booksTable = ds.Tables["Books"];
                        var readersTable = ds.Tables["Readers"];
                        var issueReturnTable = ds.Tables["IssueReturnBooks"];

                        // Створюємо словник для зберігання популярності жанрів
                        var genrePopularity = new Dictionary<string, int>();

                        // Збираємо дані про популярність книг за жанрами на основі видач
                        foreach (DataRow issueRow in issueReturnTable.Rows)
                        {
                            var bookID = issueRow["BookID"].ToString();
                            var bookRow = booksTable.Select($"BookID = '{bookID}'").FirstOrDefault();

                            if (bookRow != null)
                            {
                                string genre = bookRow["Genre"].ToString();
                                if (genrePopularity.ContainsKey(genre))
                                {
                                    genrePopularity[genre]++;
                                }
                                else
                                {
                                    genrePopularity[genre] = 1;
                                }
                            }
                        }

                        // Очищуємо попередні дані в DataGridView
                        gridViewDataSearch.Rows.Clear();

                        // Проходимо по всіх записах IssueReturnBooks і додаємо інформацію в DataGridView
                        foreach (DataRow issueRow in issueReturnTable.Rows)
                        {
                            var bookID = issueRow["BookID"].ToString();
                            var readerID = issueRow["ReaderID"].ToString();

                            // Знаходимо відповідні записи в таблицях Books і Readers
                            var bookRow = booksTable.Select($"BookID = '{bookID}'").FirstOrDefault();
                            var readerRow = readersTable.Select($"ReaderID = '{readerID}'").FirstOrDefault();

                            if (bookRow != null && readerRow != null)
                            {
                                string genre = bookRow["Genre"].ToString();

                                if (genrePopularity.ContainsKey(genre))
                                {
                                    string readerNumber = readerRow["ReaderID"].ToString();
                                    string readerName = readerRow["ReaderName"].ToString();
                                    string bookName = bookRow["BookName"].ToString();
                                    string issueDate = issueRow["IssueDate"].ToString();
                                    string returnDate = issueRow["ReturnDate"].ToString();
                                    int genreCount = genrePopularity[genre];

                                    // Додаємо рядок до DataGridView
                                    gridViewDataSearch.Rows.Add(genreCount, readerNumber, readerName, bookName, genre, issueDate, returnDate);
                                }
                            }
                        }

                        // Викликаємо метод сортування
                        Sorting(gridViewDataSearch);
                    }
                    else
                    {
                        MessageBox.Show("Популярних тематик не знайдено", "Даних немає", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (rbReaders.Checked)
                {
                    lblCount.Text = "";

                    if (ds.Tables.Contains("Books") && ds.Tables.Contains("Readers") && ds.Tables.Contains("IssueReturnBooks"))
                    {
                        var booksTable = ds.Tables["Books"];
                        var readersTable = ds.Tables["Readers"];
                        var issueReturnTable = ds.Tables["IssueReturnBooks"];

                        // Створюємо словник для зберігання кількості відвідувань читачів
                        var readerVisits = new Dictionary<string, int>();

                        // Збираємо дані про відвідування бібліотеки читачами
                        foreach (DataRow issueRow in issueReturnTable.Rows)
                        {
                            var readerID = issueRow["ReaderID"].ToString();

                            if (readerVisits.ContainsKey(readerID))
                            {
                                readerVisits[readerID]++;
                            }
                            else
                            {
                                readerVisits[readerID] = 1;
                            }
                        }

                        // Очищуємо попередні дані в DataGridView
                        gridViewDataSearch.Rows.Clear();

                        // Проходимо по всіх записах читачів і додаємо інформацію в DataGridView
                        foreach (DataRow issueRow in issueReturnTable.Rows)
                        {
                            var bookID = issueRow["BookID"].ToString();
                            var readerID = issueRow["ReaderID"].ToString();
                            var readerRow = readersTable.Select($"ReaderID = '{readerID}'").FirstOrDefault();
                            var bookRow = booksTable.Select($"BookID = '{bookID}'").FirstOrDefault();

                            if (readerRow != null && bookRow != null && readerVisits.ContainsKey(readerID))
                            {
                                int visitCount = readerVisits[readerID];
                                string readerNumber = readerRow["ReaderID"].ToString();
                                string readerName = readerRow["ReaderName"].ToString();
                                string contacts = readerRow["Contacts"].ToString();
                                string bookName = bookRow["BookName"].ToString();
                                string genre = bookRow["Genre"].ToString();
                                string issueDate = issueRow["IssueDate"].ToString();
                                string returnDate = issueRow["ReturnDate"].ToString();

                                // Додаємо рядок до DataGridView
                                gridViewDataSearch.Rows.Add(visitCount, readerNumber, readerName, bookName, genre, issueDate, returnDate);
                            }
                        }

                        // Викликаємо метод сортування
                        Sorting(gridViewDataSearch);
                    }
                    else
                    {
                        MessageBox.Show("Найчастіших читачів не знайдено", "Даних немає", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (rbBorrows.Checked)
                {
                    if (ds.Tables.Contains("Books") && ds.Tables.Contains("Readers") && ds.Tables.Contains("IssueReturnBooks"))
                    {
                        var booksTable = ds.Tables["Books"];
                        var readersTable = ds.Tables["Readers"];
                        var issueReturnTable = ds.Tables["IssueReturnBooks"];

                        // Очищуємо попередні дані в DataGridView
                        gridViewDataSearch.Rows.Clear();

                        int borrowsCount = 0; // Лічильник боржників

                        // Проходимо по всім записам про видачу книг
                        foreach (DataRow issueRow in issueReturnTable.Rows)
                        {
                            var bookID = issueRow["BookID"].ToString();
                            var readerID = issueRow["ReaderID"].ToString();
                            var returnStatus = issueRow["ReturnStatus"].ToString();

                            // Якщо книга не повернена, додаємо інформацію про видачу до DataGridView
                            if (returnStatus == "Не повернено")
                            {
                                borrowsCount++; // Збільшуємо лічильник боржників

                                var bookRow = booksTable.Select($"BookID = '{bookID}'").FirstOrDefault();
                                var readerRow = readersTable.Select($"ReaderID = '{readerID}'").FirstOrDefault();

                                if (bookRow != null && readerRow != null)
                                {
                                    string readerNumber = readerRow["ReaderID"].ToString();
                                    string readerName = readerRow["ReaderName"].ToString();
                                    string contacts = readerRow["Contacts"].ToString();
                                    string bookName = bookRow["BookName"].ToString();
                                    string genre = bookRow["Genre"].ToString();
                                    string issueDate = issueRow["IssueDate"].ToString();
                                    string returnDate = issueRow["ReturnDate"].ToString();

                                    // Додаємо рядок до DataGridView
                                    gridViewDataSearch.Rows.Add("", readerNumber, readerName, bookName, genre, issueDate, returnDate);
                                }
                            }
                        }

                        // Не потрібно викликати метод сортування, оскільки для боржників це необов'язково

                        lblCount.Text = $"Загальна кількість боржників: {borrowsCount}";
                    }
                    else
                    {
                        MessageBox.Show("Боржників не знайдено", "Даних немає", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Оберіть критерій пошуку", "Помилка пошуку даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Кнопка Очистити таблицю

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            if (gridViewDataSearch.Rows.Count > 0)
            {
                lblCount.Text = "";
                gridViewDataSearch.Rows.Clear();
                rbGenre.Checked = false;
                rbReaders.Checked = false;
                rbBorrows.Checked = false;
            }
            else
            {
                MessageBox.Show("Таблиця порожня", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
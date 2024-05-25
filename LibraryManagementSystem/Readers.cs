using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
    public partial class Readers : Form
    {
        public Readers(string username)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            lblUsername.Text = username; // Змінює заголовок форми
        }

        // Змінювання розміру вікна

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

        // Перетягування вікна

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

        // Написання коду

        // Кнопка Додати

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtReaderID.Text == "")
            {
                MessageBox.Show("Заповніть усі поля.", "Помилка.");
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtReaderID.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtReaderName.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtContacts.Text;
            }
        }

        // Кнопка Редагувати

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int n = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows[n].Cells[0].Value = txtReaderID.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtReaderName.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtContacts.Text;
            }
            else
            {
                MessageBox.Show("Оберіть рядок для редагування.", "Помилка.");
            }
        }

        // Кнопка Видалення

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Оберіть рядок для видалення.", "Помилка.");
            }
        }

        // выбор нужной строки для редактирования

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtReaderID.Text = dataGridView1.SelectedRows[0].Cells[0].Value?.ToString();
                txtReaderName.Text = dataGridView1.SelectedRows[0].Cells[1].Value?.ToString();
                txtContacts.Text = dataGridView1.SelectedRows[0].Cells[2].Value?.ToString();
            }
        }

        // Кнопка Зберегти як файл

        private void btnSaveFile_Click(object sender, EventArgs e)
        {

        }

        // Кнопка Завантажити файл

        private void btnLoadFile_Click(object sender, EventArgs e)
        {

        }

        // Кнопка Очистити таблицю

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Таблиця пуста.", "Помилка.");
            }
        }
    }
}

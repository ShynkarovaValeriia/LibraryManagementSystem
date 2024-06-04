using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            SetPlaceholders();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        // Перехід між Формою реєстрації та авторизації

        private void LinkLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        // Кнопка створити акаунт

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи поля мають лише плейсхолдери
            if (txtUsername.Text == "Логін") txtUsername.Text = "";
            if (txtPassword.Text == "Пароль") txtPassword.Text = "";
            if (txtEmail.Text == "Електронна адреса") txtEmail.Text = "";
            if (txtPhoneNumber.Text == "Контактний номер") txtPhoneNumber.Text = "";

            // Шлях до XML файлу
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LibraryManagementSystem");
            string filePath = Path.Combine(folderPath, "Users.xml");

            DataSet ds = new DataSet();
            DataTable dt;

            // Якщо файл існує, завантажуємо його, якщо ні - створюємо нову таблицю
            if (File.Exists(filePath))
            {
                ds.ReadXml(filePath);
                if (!ds.Tables.Contains("Users"))
                {
                    dt = new DataTable("Users");
                    dt.Columns.Add("UserID");
                    dt.Columns.Add("Username");
                    dt.Columns.Add("Password");
                    dt.Columns.Add("Email");
                    dt.Columns.Add("PhoneNumber");
                    ds.Tables.Add(dt);
                }
                else
                {
                    dt = ds.Tables["Users"];
                }
            }
            else
            {
                dt = new DataTable("Users");
                dt.Columns.Add("UserID");
                dt.Columns.Add("Username");
                dt.Columns.Add("Password");
                dt.Columns.Add("Email");
                dt.Columns.Add("PhoneNumber");
                ds.Tables.Add(dt);
            }

            if (txtUsername.Text == "" || txtPassword.Text == "" || txtEmail.Text == "" || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Заповніть усі поля", "Помилка реєстрації", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Будь ласка, введіть дійсну адресу електронної пошти", "Помилка реєстрації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                txtEmail.Focus();
            }
            else if (!IsPhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Будь ласка, введіть дійсний контактний номер", "Помилка реєстрації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Text = "";
                txtPhoneNumber.Focus();
                return;
            }
            else
            {
                // Додаємо новий рядок до таблиці
                DataRow dr = dt.NewRow();
                dr["UserID"] = Guid.NewGuid().ToString();
                dr["Username"] = txtUsername.Text;
                dr["Password"] = txtPassword.Text;
                dr["Email"] = txtEmail.Text;
                dr["PhoneNumber"] = txtPhoneNumber.Text;
                dt.Rows.Add(dr);

                // Зберігаємо DataSet як XML файл
                ds.WriteXml(filePath);

                MessageBox.Show("Ваш обліковий запис успішно створено", "Успішна реєстрація", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Login loginForm = new Login();
                loginForm.Show();

                // Відновлюємо плейсхолдери після реєстрації
                SetPlaceholders();
            }
        }

        // Функція для перевірки дійсності електронної адреси

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        // Функція для перевірки контактного номера
        private bool IsPhoneNumber(string number)
        {
            return Regex.IsMatch(number, @"^\d+$");
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

        // Кнопка приховати пароль

        private void eyeOpen_Click(object sender, EventArgs e)
        {
            // Перемикання видимості пароля
            txtPassword.PasswordChar = '\0'; // Пароль видно

            // Управління видимістю кнопок
            eyeOpen.Visible = false;
            eyeClose.Visible = true;
        }

        // Кнопка показати пароль

        private void eyeClose_Click(object sender, EventArgs e)
        {
            // Перемикання видимості пароля
            txtPassword.PasswordChar = '*'; // Пароль сховано

            // Управління видимістю кнопок
            eyeOpen.Visible = true;
            eyeClose.Visible = false;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (eyeOpen.Visible == true)
            {
                txtPassword.PasswordChar = '*'; // Пароль сховано
            }
            else
            {
                txtPassword.PasswordChar = '\0'; // Пароль видно
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0'; // Пароль видно
            }
            else if (eyeOpen.Visible == true)
            {
                txtPassword.PasswordChar = '*'; // Пароль сховано
            }
            else
            {
                txtPassword.PasswordChar = '\0'; // Пароль видно
            }
        }

        // Плейсхолдери

        private void SetPlaceholders()
        {
            SetPlaceholder(txtUsername, "Логін");
            SetPlaceholder(txtPassword, "Пароль");
            SetPlaceholder(txtEmail, "Електронна адреса");
            SetPlaceholder(txtPhoneNumber, "Контактний номер");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.Gray;

            textBox.Enter += (s, e) => {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };

            textBox.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };
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

        // Настройка перетягування панелі форми

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void pnlRegistration_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnlRegistration_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlRegistration_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
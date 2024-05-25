using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            SetPlaceholders();
        }

        private void SetPlaceholders()
        {
            SetPlaceholder(txtUsername, "Логін");
            SetPlaceholder(txtPassword, "Пароль");
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

        // Перехід між Формою авторизації та реєстрації

        private void LinkRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration signupForm = new Registration();
            signupForm.Show();
        }

        // Кнопка Увійти

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи поля мають лише плейсхолдери
            if (txtUsername.Text == "Логін") txtUsername.Text = "";
            if (txtPassword.Text == "Пароль") txtPassword.Text = "";

            // Перевірка на порожні поля
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Заповніть усі поля", "Помилка авторизації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Шлях до XML файлу
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Users.xml");

            // Завантажуємо дані з XML файлу
            DataSet ds = new DataSet();
            ds.ReadXml(filePath);

            DataTable dt = ds.Tables["Users"];
            DataRow foundUser = null;

            // Перевіряємо, чи існує користувач з таким логіном
            foreach (DataRow row in dt.Rows)
            {
                if (row["Username"].ToString() == txtUsername.Text)
                {
                    foundUser = row;
                    break;
                }
            }

            if (foundUser != null)
            {
                // Перевіряємо вірність паролю
                if (foundUser["Password"].ToString() == txtPassword.Text)
                {
                    this.Hide();
                    string username = txtUsername.Text;
                    HomePage homepageForm = new HomePage(char.ToUpper(username[0]) + username.Substring(1));
                    homepageForm.Show();
                }
                else
                {
                    MessageBox.Show("Будь ласка, введіть пароль ще раз", "Невірний пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть дійсне ім'я користувача", "Не вдалося знайти обліковий запис", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();

                // Відновлюємо плейсхолдери після реєстрації
                SetPlaceholders();
            }
        }


        // Перетягування панелі

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
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

        // Кнопки приховування паролю

        private void eyeOpen_Click(object sender, EventArgs e)
        {
            // Перемикання видимості пароля
            txtPassword.PasswordChar = '*'; // Пароль сховано

            // Управління видимістю кнопок
            eyeClose.Visible = true;
            eyeOpen.Visible = false;
        }

        private void eyeClose_Click(object sender, EventArgs e)
        {
            // Перемикання видимості пароля
            txtPassword.PasswordChar = '\0'; // Пароль видно

            // Управління видимістю кнопок
            eyeClose.Visible = false;
            eyeOpen.Visible = true;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (eyeClose.Visible == true)
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
            else if (eyeClose.Visible == true)
            {
                txtPassword.PasswordChar = '*'; // Пароль сховано
            }
            else
            {
                txtPassword.PasswordChar = '\0'; // Пароль видно
            }
        }
    }
}

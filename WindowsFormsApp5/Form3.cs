using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        delegate bool LoginComplexity(string s);
        delegate bool CheckPassComplexity(string s);

        delegate bool ComparePasswords(string s1, string s2);

        class SecurityTools
        {
            public static bool CheckLoginComplexity(string s)
            {
                return s.Length < 5;
            }
            public static bool CheckPassComplexity(string s)
            {
                return s.Length < 7;
            }

            public static bool ComparePasswords(string pass1, string pass2)
            {
                return string.Compare(pass1, pass2) == 0 ? true : false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            LoginComplexity loginComplexity = LoginName => SecurityTools.CheckLoginComplexity(LoginName);
            LoginComplexity passComplexity = LoginPass => SecurityTools.CheckLoginComplexity(LoginPass);

            // Используем лямбда выражение
            ComparePasswords CheckPasswords = (s1, s2) => SecurityTools.ComparePasswords(s1, s2);

            string login = textBox1.Text;
            string password1 = textBox2.Text;
            string password2 = textBox3.Text;

            if (loginComplexity(login)) MessageBox.Show("Имя логина слишком короткое!");
            else if (passComplexity(password1)) MessageBox.Show("Введённый пароль слишком короткий!");
            else
            {

                if (CheckPasswords(password1, password2))
                {
                    MessageBox.Show("Пользоватль успешно зарегистрирован!");
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Не удалось зарегистрировать пользователя, т.к. введённые пароли не совпадают!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace каталог
{
    public partial class RegForm: Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void regBut_Click(object sender, EventArgs e)
        {
            

        }

        private void regBut_Click_1(object sender, EventArgs e)
        {
            if (nameText.Text != "" && sureText.Text != "" && logText.Text != "" && passText.Text != "")
            {
                if (passText.Text == pass1Text.Text)
                {
                    System.IO.File.AppendAllText("users.txt", nameText.Text + ", " +
                                                           sureText.Text + ", " +
                                                           logText.Text + ", " +
                                                           passText.Text + ", " + "0" +
                                                           Environment.NewLine);
                    MessageBox.Show("Регистрация прошла успешно");
                    Close();
                }
                else
                {
                    MessageBox.Show("Пароли должны совпадать");
                }
            }
            else
            {
                MessageBox.Show("Все поля обязательны для заполнения");
            }
        }
    }
}

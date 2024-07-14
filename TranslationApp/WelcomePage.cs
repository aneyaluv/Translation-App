using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslationApp
{
    public partial class WelcomePage : Form
    {
        private string usernamePlaceholderText = "Enter your username...";
        private string passwordPlaceholderText = "Enter your password...";
        private bool isUsernamePlaceholder = true;
        private bool isPasswordPlaceholder = true;
        public WelcomePage()
        {
            InitializeComponent();
            InitializePlaceholders();
        }

        private void InitializePlaceholders()
        {
            Username.Text = usernamePlaceholderText;
            Username.ForeColor = Color.DarkGray;
            Username.Font = new Font(Username.Font.FontFamily, 12); 
            Username.Enter += new EventHandler(Username_Enter);
            Username.Leave += new EventHandler(Username_Leave);

            Password.Text = passwordPlaceholderText;
            Password.ForeColor = Color.DarkGray;
            Password.Font = new Font(Password.Font.FontFamily, 12); 
            Password.Enter += new EventHandler(Password_Enter);
            Password.Leave += new EventHandler(Password_Leave);
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if (isUsernamePlaceholder)
            {
                Username.Text = "";
                Username.ForeColor = Color.White;
                isUsernamePlaceholder = false;
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username.Text))
            {
                Username.Text = usernamePlaceholderText;
                Username.ForeColor = Color.Gray;
                isUsernamePlaceholder = true;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (isPasswordPlaceholder)
            {
                Password.Text = "";
                Password.ForeColor = Color.White;
                Password.UseSystemPasswordChar = true; 
                isPasswordPlaceholder = false;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Password.Text))
            {
                Password.UseSystemPasswordChar = false; 
                Password.Text = passwordPlaceholderText;
                Password.ForeColor = Color.Gray;
                isPasswordPlaceholder = true;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            TranslationPage form1 = new TranslationPage();
            form1.Show();
            this.Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.SelectNextControl((Control)sender, true, true, true, true);
        }
    }
}

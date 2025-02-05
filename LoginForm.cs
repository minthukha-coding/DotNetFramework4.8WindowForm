using DotNetFramework4._8WindowForm.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetFramework4._8WindowForm
{
    public partial class LoginForm : Form
    {

        private readonly AdoDotNetService _adoDotNetService;

        public LoginForm()
        {
            InitializeComponent();
            _adoDotNetService = new AdoDotNetService();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_userpassword.Text;

            bool result = _adoDotNetService.Login(username, password);
            if (result)
            {
                MessageBox.Show("Login successfully!");
                MenuForm from2 = new MenuForm();
                from2.Show();
                this.Hide();
            }
            MessageBox.Show("Something was wrong!", "Err" , MessageBoxButtons.OK ,MessageBoxIcon.Error);
            txt_username.Clear();
            txt_userpassword.Clear();
            
            txt_username.Focus();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_userpassword.Clear();

            txt_username.Focus();
        }

        private void button_exit1_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

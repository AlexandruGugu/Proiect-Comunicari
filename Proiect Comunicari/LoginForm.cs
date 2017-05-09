using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Comunicari
{
    public partial class LoginForm : Form
    {
        public LoginInfo info = new LoginInfo();

        public LoginForm()
        {
            InitializeComponent();
            info.info.Add("Admin", "1234");
            info.info.Add("User", "1234");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //KeyValuePair<string, string> input = new KeyValuePair<string, string>(userTxt.Text, passTxt.Text);
            if(info.checkInfo(new KeyValuePair<string, string>(userTxt.Text, passTxt.Text)))
            {
                this.Hide();
                Manager.Authenticated();
            }

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Manager.loginForm = null;
            Manager.CheckActiveForms();
        }

        private void userTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                loginButton.PerformClick();
            }
        }

        private void passTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                loginButton.PerformClick();
            }
        }
    }
}

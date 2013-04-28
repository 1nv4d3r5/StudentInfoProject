using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInfoProject.Logic;
using StudentInfoProject.Data;

namespace StudentInfoProject.View
{
    public partial class LoginForm : Form
    {
        public static User user { get; private set; }
        public User usr;

        public LoginForm()
        {
            InitializeComponent();
            user = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginValidation loginVal = new LoginValidation(tbUsername.Text, tbPassword.Text);
            if (loginVal.ValidateUserInput(out usr))
            {
                this.DialogResult = DialogResult.OK;
                user = usr;
                this.Close();
            }
            else
            {
                MessageBox.Show(loginVal.errText);
            }
        }
    }
}


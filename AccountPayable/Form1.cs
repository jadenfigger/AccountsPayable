using ProgramController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountPayable
{
    public partial class LoginForm : Form
    {
        public static int currentUserId = -1;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            currentUserId = SqlDataAccess.GetUserID(txtUsername.Text, txtPassword.Text);
            if (currentUserId != -1)
            {
                VendorForm vForm = new VendorForm();
                this.Hide();
                vForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect.", "Invalid User", MessageBoxButtons.OK);
                txtUsername.Focus();
                return;
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm rgForm = new RegisterForm();
            this.Hide();
            rgForm.ShowDialog();
            this.Close();
        }


    }
}

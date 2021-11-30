using ProgramController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountPayable
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals("") || txtLastName.Text.Equals("") || txtUsername.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Please fill out all text boxes", "Error", MessageBoxButtons.OK);
                txtFirstName.Focus();
                return;
            }

            SqlDataAccess.AddUser(txtFirstName.Text, txtLastName.Text, txtUsername.Text, txtPassword.Text);

            LoginForm lgForm = new LoginForm();
            this.Hide();
            lgForm.ShowDialog();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Controllers;
using TaskManagement.Models;

namespace TaskManagement.Forms
{
    public partial class ForgetPassForm : Form
    {
        private readonly LoginController _loginController;
        public ForgetPassForm(LoginController loginController)
        {
            InitializeComponent();
            _loginController = loginController;
        }

        private void backLoginLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verifyLabel_Click(object sender, EventArgs e)
        {
            bool isValidUser=_loginController.Validate(verifyUserTextbox.Text.Trim());
            if(isValidUser==false)
            {
                MessageBox.Show("Username not found","Invalid User",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Verified Successfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                newPassTextbox.Enabled = true;
                reNewPassTextbox.Enabled = true;
            }
        }

        private void ForgetPassForm_Load(object sender, EventArgs e)
        {
            newPassTextbox.Enabled=false;
            reNewPassTextbox.Enabled=false;
        }

        private void ResetPassButton_Click(object sender, EventArgs e)
        {
            if(newPassTextbox.Text=="" || reNewPassTextbox.Text == "")
            {
                MessageBox.Show("Enter the Password first", "Empty password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(newPassTextbox.Text!=reNewPassTextbox.Text)
            {
                MessageBox.Show("The passwords don't match","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(newPassTextbox.Text==reNewPassTextbox.Text)
            {
                _loginController.ChangePassword(verifyUserTextbox.Text, newPassTextbox.Text);
                MessageBox.Show("Password Changed Successfully!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void verifyUserTextbox_TextChanged(object sender, EventArgs e)
        {
            newPassTextbox.Enabled = false;
            reNewPassTextbox.Enabled = false;
            newPassTextbox.Clear();
            reNewPassTextbox.Clear();
        }
    }
}
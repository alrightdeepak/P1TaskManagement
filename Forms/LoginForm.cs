using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TaskManagementCore.Models;
using TaskManagement.Controllers;
using TaskManagement.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace TaskManagement
{
    public partial class LoginForm : Form
    {
        private readonly LoginController _loginController;
        private readonly IServiceProvider _serviceProvider;

        public LoginForm(LoginController loginController,IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _loginController = loginController;
            _serviceProvider = serviceProvider;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            var _user= await _loginController.Authenticate(usernameTextBox.Text.Trim(),passwordTextBox.Text.Trim());
            if (_user == null)
            {
                MessageBox.Show("Incorrect username or password", "Invalid Credentials",MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
                return;
            }
            else if (_user.userType=="employee")
            {  
                var employee = _serviceProvider.GetRequiredService<EmployeeDashboard>();
                employee.SetUser(_user);
                employee.Show();
            }
            else if (_user.userType=="admin")
            {
                var admin = _serviceProvider.GetRequiredService<AdminDashboard>();
                admin.SetAdmin(_user);
                admin.Show();
            }
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }
        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void LoginForm_Load(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
            hidePassword.Visible = false;
        }
        private void forgetPasswordLabel_Click(object sender, EventArgs e)
        {
            var forgetPassForm = _serviceProvider.GetRequiredService<ForgetPassForm>();
            forgetPassForm.ShowDialog();
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = false;
            showPassword.Visible = false;
            hidePassword.Visible = true;
        }

        private void hidePassword_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
            showPassword.Visible = true;
            hidePassword.Visible = false;
        }
    }
}
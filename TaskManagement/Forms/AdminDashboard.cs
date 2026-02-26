using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Controllers;
using TaskManagementCore.Models;
using TaskManagementCore.Services.Interfaces;

namespace TaskManagement
{
    public partial class AdminDashboard : Form
    {
        private readonly TaskController _taskController;
        private readonly LoginController _loginController;
        private UserData currentAdmin;
        private BindingList<TaskItems> allTasks;
        public AdminDashboard(TaskController taskController, LoginController loginController)
        {
            InitializeComponent();
            _taskController = taskController;
            _loginController = loginController;
        }

        public void SetAdmin(UserData user)
        {
            currentAdmin = user;
        }

        private async void AdminDashboard_Load(object sender, EventArgs e)
        {
            GreetAdmin.Text = $"Hello\n{currentAdmin.username.ToUpper()}!";
            EmployeeGrid.DataSource = await _loginController.GetAll("employee");
            TaskGrid.Visible = false;
            backLabel.Visible = false;
            comboBox1.Visible = false;
            comboBox1.SelectedIndex = 2;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void EmployeeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && EmployeeGrid.Columns[e.ColumnIndex].Name=="EmployeeTaskColumn")
            {
                EmployeeGrid.Visible = false;
                TaskGrid.Visible = true;
                backLabel.Visible = true;
                int currentEmployeeId = Convert.ToInt32(EmployeeGrid.Rows[e.RowIndex].Cells["EmployeeId"].Value);
                TaskGrid.AutoGenerateColumns = false;
                TaskGrid.DataSource = await _taskController.ShowTasks(currentEmployeeId);
                allTasks = await _taskController.ShowTasks(currentEmployeeId);
                comboBox1.Visible = true;
            }
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            TaskGrid.Visible = false;
            EmployeeGrid.Visible= true;
            backLabel.Visible = false;
            comboBox1.Visible = false;
            comboBox1.SelectedIndex = 2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskGrid.DataSource = allTasks;
            if(comboBox1.SelectedIndex == 0)
            {
                BindingList<TaskItems> completedTasks = new BindingList<TaskItems>();
                foreach (DataGridViewRow row in TaskGrid.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["Status"].Value);

                    if (isChecked)
                    {
                        TaskItems item = row.DataBoundItem as TaskItems;
                        if (item != null)
                        {
                            completedTasks.Add(item);
                        }
                    }
                }
                TaskGrid.DataSource = completedTasks;
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                BindingList<TaskItems> IncompleteTasks = new BindingList<TaskItems>();
                foreach (DataGridViewRow row in TaskGrid.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["Status"].Value);

                    if (!isChecked)
                    {
                        TaskItems item = row.DataBoundItem as TaskItems;
                        if (item != null)
                        {
                            IncompleteTasks.Add(item);
                        }
                    }
                }
                TaskGrid.DataSource = IncompleteTasks;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                TaskGrid.DataSource = allTasks;
            }
        }
    }
}

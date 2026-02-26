using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Controllers;
using TaskManagement.Forms;
using TaskManagementCore.Models;

namespace TaskManagement
{
    public partial class EmployeeDashboard : Form
    {
        private readonly TaskController _taskController;
        private readonly IServiceProvider _serviceProvider;
        private UserData currentUser;
        private BindingList<TaskItems> userTasks = new BindingList<TaskItems>();
        public EmployeeDashboard(TaskController taskController,IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _taskController = taskController;
            _serviceProvider = serviceProvider;
        }
        public void SetUser(UserData user)
        {
            currentUser = user;
        }
        private async void Form2_Load(object sender, EventArgs e)
        {
            greet.Text = $"Hello\n{currentUser.username.ToUpper()}!";
            EditButton.Visible = false;
            DeleteTaskButton.Visible = false;
            userTasks = await _taskController.ShowTasks(currentUser.userId);
            TaskGrid.DataSource = userTasks;
            descriptionTextBox.Focus();
            TaskGrid.ClearSelection();
        }

        private TaskItems GetSelectedTask()
        {
            if (TaskGrid.SelectedRows.Count > 0)
            {
                return TaskGrid.SelectedRows[0].DataBoundItem as TaskItems;
            }
            return null;
        }
        private async void AddButton_Click(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text != "")
            {
                await _taskController.AddTask(currentUser.userId, descriptionTextBox.Text);
                var newTask = new TaskItems
                {
                    userId = currentUser.userId,
                    TaskID = await _taskController.getNextTaskId(currentUser.userId)-1,
                    Description = descriptionTextBox.Text,
                    Status = false
                };

                userTasks.Add(newTask);
                descriptionTextBox.Clear();
                descriptionTextBox.Focus();
                
            }
            else
            {
                MessageBox.Show("Please add the description first!","Empty Description",MessageBoxButtons.OK,MessageBoxIcon.Error);
                descriptionTextBox.Focus();
            }
            TaskGrid.ClearSelection();
        }

        private async void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            var selectedTask = GetSelectedTask();
            if (selectedTask != null)
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete this task?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await _taskController.RemoveTask(selectedTask);
                    userTasks.Remove(selectedTask);
                }
            }
            else
            {
                MessageBox.Show("Please select a task first.","No Task Selected",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            TaskGrid.ClearSelection();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            var selectedTask = GetSelectedTask();
            if (selectedTask != null)
            {
                var editForm=_serviceProvider.GetRequiredService<EditForm>();
                editForm.SetTask(selectedTask);
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a task first.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TaskGrid.Refresh();
            TaskGrid.ClearSelection();
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaskGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditButton.Visible = true;
            DeleteTaskButton.Visible = true;
        }

        private void TaskGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (TaskGrid.IsCurrentCellDirty)
            {
                TaskGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void TaskGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && TaskGrid.Columns[e.ColumnIndex].DataPropertyName == "Status")
            {
                TaskItems task = TaskGrid.Rows[e.RowIndex].DataBoundItem as TaskItems;
                if (task != null)
                {
                    _taskController.EditTask(task);
                }
            }
        }
    }
}
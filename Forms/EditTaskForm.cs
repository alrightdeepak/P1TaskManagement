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
using TaskManagementCore.Models;

namespace TaskManagement.Forms
{
    public partial class EditForm : Form
    {
        private readonly TaskController _taskController;
        private TaskItems _selectedTask;

        public EditForm(TaskController taskController)
        {
            InitializeComponent();
            _taskController = taskController;
        }
        public void SetTask(TaskItems task)
        {
            _selectedTask = task;
        }
        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void updateDescription_Click(object sender, EventArgs e)
        {
            string newDescription = newdescTextBox.Text;
            if (!string.IsNullOrEmpty(newDescription))
            {
                try
                {
                    var newTask = new TaskItems
                    {
                        userId = _selectedTask.userId,
                        TaskID = _selectedTask.TaskID,
                        Description = newDescription,
                        Status = false
                    };
                    await _taskController.EditTask(newTask);
                    _selectedTask.Description = newDescription;
                    MessageBox.Show("Task edited successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch( Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    newdescTextBox.Focus();
                }

            }
            this.Close();
        }

        private async void EditForm_Load(object sender, EventArgs e)
        {
            newdescTextBox.Text = _selectedTask.Description;
        }
        private void EditForm_Shown(object sender, EventArgs e)
        {
            newdescTextBox.SelectionStart = newdescTextBox.TextLength;
            newdescTextBox.SelectionLength = 0;
        }

    }
}

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

        private void updateDescription_Click(object sender, EventArgs e)
        {
            string newDescription = newdescTextBox.Text;
            if (!string.IsNullOrEmpty(newDescription))
            {
                try
                {
                    _taskController.EditTask(_selectedTask.userId, _selectedTask.TaskID, newDescription, false);
                    _selectedTask.Description = newDescription;
                    MessageBox.Show("Task edited successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch( Exception ex)
                {
                    MessageBox.Show("Description should be less than 50 characters", " Character Limit Crossed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    newdescTextBox.Focus();
                }

            }
            this.Close();
        }

        private void EditForm_Load(object sender, EventArgs e)
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

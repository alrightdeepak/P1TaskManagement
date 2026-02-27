namespace TaskManagement
{
    partial class EmployeeDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboard));
            greet = new Label();
            label2 = new Label();
            AddButton = new Button();
            DeleteTaskButton = new Button();
            EditButton = new Button();
            LogoutButton = new Button();
            TaskGrid = new DataGridView();
            userId = new DataGridViewTextBoxColumn();
            TaskID = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            descriptionTextBox = new TextBox();
            AddTaskLabel = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)TaskGrid).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // greet
            // 
            greet.AutoSize = true;
            greet.BackColor = Color.Transparent;
            greet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            greet.Location = new Point(41, 142);
            greet.Margin = new Padding(4, 0, 4, 0);
            greet.Name = "greet";
            greet.Size = new Size(14, 21);
            greet.TabIndex = 0;
            greet.Text = ".";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 46);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 1;
            label2.Text = "Your Tasks:";
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.SlateGray;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(467, 84);
            AddButton.Margin = new Padding(4, 3, 4, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(66, 27);
            AddButton.TabIndex = 21;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteTaskButton
            // 
            DeleteTaskButton.BackColor = Color.SlateGray;
            DeleteTaskButton.FlatAppearance.BorderSize = 0;
            DeleteTaskButton.FlatStyle = FlatStyle.Flat;
            DeleteTaskButton.ForeColor = Color.White;
            DeleteTaskButton.Location = new Point(306, 392);
            DeleteTaskButton.Margin = new Padding(4, 3, 4, 3);
            DeleteTaskButton.Name = "DeleteTaskButton";
            DeleteTaskButton.Size = new Size(66, 27);
            DeleteTaskButton.TabIndex = 4;
            DeleteTaskButton.Text = "Delete";
            DeleteTaskButton.UseVisualStyleBackColor = false;
            DeleteTaskButton.Click += DeleteTaskButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.SlateGray;
            EditButton.FlatAppearance.BorderSize = 0;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(220, 392);
            EditButton.Margin = new Padding(4, 3, 4, 3);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(66, 27);
            EditButton.TabIndex = 5;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.SlateGray;
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.ForeColor = Color.White;
            LogoutButton.Location = new Point(445, 40);
            LogoutButton.Margin = new Padding(4, 3, 4, 3);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(88, 27);
            LogoutButton.TabIndex = 9;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // TaskGrid
            // 
            TaskGrid.AllowUserToAddRows = false;
            TaskGrid.AllowUserToDeleteRows = false;
            TaskGrid.AllowUserToResizeColumns = false;
            TaskGrid.AllowUserToResizeRows = false;
            TaskGrid.BackgroundColor = SystemColors.Control;
            TaskGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SlateGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TaskGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TaskGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TaskGrid.Columns.AddRange(new DataGridViewColumn[] { userId, TaskID, Description, Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            TaskGrid.DefaultCellStyle = dataGridViewCellStyle2;
            TaskGrid.EnableHeadersVisualStyles = false;
            TaskGrid.GridColor = Color.Black;
            TaskGrid.Location = new Point(40, 119);
            TaskGrid.Margin = new Padding(4, 3, 4, 3);
            TaskGrid.MultiSelect = false;
            TaskGrid.Name = "TaskGrid";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            TaskGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            TaskGrid.RowHeadersVisible = false;
            TaskGrid.ScrollBars = ScrollBars.Vertical;
            TaskGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TaskGrid.ShowEditingIcon = false;
            TaskGrid.Size = new Size(493, 267);
            TaskGrid.TabIndex = 17;
            TaskGrid.CellContentClick += TaskGrid_CellContentClick;
            TaskGrid.CellValueChanged += TaskGrid_CellValueChanged;
            TaskGrid.CurrentCellDirtyStateChanged += TaskGrid_CurrentCellDirtyStateChanged;
            // 
            // userId
            // 
            userId.DataPropertyName = "userId";
            userId.HeaderText = "UserID";
            userId.Name = "userId";
            userId.ReadOnly = true;
            userId.Resizable = DataGridViewTriState.False;
            userId.Visible = false;
            // 
            // TaskID
            // 
            TaskID.DataPropertyName = "TaskID";
            TaskID.HeaderText = "Task ID";
            TaskID.Name = "TaskID";
            TaskID.ReadOnly = true;
            TaskID.Resizable = DataGridViewTriState.False;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Resizable = DataGridViewTriState.False;
            Description.Width = 300;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.Resizable = DataGridViewTriState.False;
            Status.SortMode = DataGridViewColumnSortMode.Automatic;
            Status.Width = 90;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(greet);
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(-1, -3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 483);
            panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(113, 85);
            descriptionTextBox.Margin = new Padding(4, 3, 4, 3);
            descriptionTextBox.MaxLength = 50;
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(346, 26);
            descriptionTextBox.TabIndex = 0;
            // 
            // AddTaskLabel
            // 
            AddTaskLabel.AutoSize = true;
            AddTaskLabel.BackColor = Color.Transparent;
            AddTaskLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddTaskLabel.ForeColor = Color.Black;
            AddTaskLabel.Location = new Point(36, 88);
            AddTaskLabel.Margin = new Padding(4, 0, 4, 0);
            AddTaskLabel.Name = "AddTaskLabel";
            AddTaskLabel.Size = new Size(64, 17);
            AddTaskLabel.TabIndex = 22;
            AddTaskLabel.Text = "Add Task:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(DeleteTaskButton);
            panel2.Controls.Add(AddButton);
            panel2.Controls.Add(LogoutButton);
            panel2.Controls.Add(EditButton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(TaskGrid);
            panel2.Controls.Add(descriptionTextBox);
            panel2.Controls.Add(AddTaskLabel);
            panel2.Location = new Point(226, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(574, 477);
            panel2.TabIndex = 25;
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(798, 474);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmployeeDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)TaskGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label greet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteTaskButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.DataGridView TaskGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label AddTaskLabel;
        private System.Windows.Forms.Panel panel2;
        private DataGridViewTextBoxColumn userId;
        private DataGridViewTextBoxColumn TaskID;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewCheckBoxColumn Status;
        private PictureBox pictureBox1;
    }
}
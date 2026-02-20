namespace TaskManagement
{
    partial class AdminDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            LogoutButton = new Button();
            GreetAdmin = new Label();
            EmployeeGrid = new DataGridView();
            EmployeeID = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            EmployeeTaskColumn = new DataGridViewButtonColumn();
            EmployeeLabel = new Label();
            TaskGrid = new DataGridView();
            userId = new DataGridViewTextBoxColumn();
            TaskID = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            panel1 = new Panel();
            backLabel = new Label();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)EmployeeGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TaskGrid).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.SlateGray;
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.ForeColor = Color.White;
            LogoutButton.Location = new Point(450, 58);
            LogoutButton.Margin = new Padding(4, 3, 4, 3);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(88, 27);
            LogoutButton.TabIndex = 11;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // GreetAdmin
            // 
            GreetAdmin.AutoSize = true;
            GreetAdmin.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GreetAdmin.ForeColor = SystemColors.ControlLight;
            GreetAdmin.Location = new Point(48, 51);
            GreetAdmin.Margin = new Padding(4, 0, 4, 0);
            GreetAdmin.Name = "GreetAdmin";
            GreetAdmin.Size = new Size(122, 32);
            GreetAdmin.TabIndex = 10;
            GreetAdmin.Text = "Hi Admin";
            // 
            // EmployeeGrid
            // 
            EmployeeGrid.AllowUserToAddRows = false;
            EmployeeGrid.AllowUserToDeleteRows = false;
            EmployeeGrid.AllowUserToResizeColumns = false;
            EmployeeGrid.AllowUserToResizeRows = false;
            EmployeeGrid.BackgroundColor = SystemColors.Control;
            EmployeeGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SlateGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            EmployeeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            EmployeeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeGrid.Columns.AddRange(new DataGridViewColumn[] { EmployeeID, EmployeeName, EmployeeTaskColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            EmployeeGrid.DefaultCellStyle = dataGridViewCellStyle2;
            EmployeeGrid.EnableHeadersVisualStyles = false;
            EmployeeGrid.GridColor = Color.Black;
            EmployeeGrid.Location = new Point(36, 127);
            EmployeeGrid.Margin = new Padding(4, 3, 4, 3);
            EmployeeGrid.MultiSelect = false;
            EmployeeGrid.Name = "EmployeeGrid";
            EmployeeGrid.ReadOnly = true;
            EmployeeGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            EmployeeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            EmployeeGrid.RowHeadersVisible = false;
            EmployeeGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            EmployeeGrid.ScrollBars = ScrollBars.Vertical;
            EmployeeGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeGrid.Size = new Size(501, 282);
            EmployeeGrid.TabIndex = 12;
            EmployeeGrid.CellContentClick += EmployeeGrid_CellContentClick;
            // 
            // EmployeeID
            // 
            EmployeeID.DataPropertyName = "userId";
            EmployeeID.HeaderText = "Employee ID";
            EmployeeID.MinimumWidth = 10;
            EmployeeID.Name = "EmployeeID";
            EmployeeID.ReadOnly = true;
            EmployeeID.Width = 120;
            // 
            // EmployeeName
            // 
            EmployeeName.DataPropertyName = "username";
            EmployeeName.HeaderText = "Name";
            EmployeeName.Name = "EmployeeName";
            EmployeeName.ReadOnly = true;
            EmployeeName.Width = 280;
            // 
            // EmployeeTaskColumn
            // 
            EmployeeTaskColumn.FlatStyle = FlatStyle.Popup;
            EmployeeTaskColumn.HeaderText = "Tasks";
            EmployeeTaskColumn.MinimumWidth = 80;
            EmployeeTaskColumn.Name = "EmployeeTaskColumn";
            EmployeeTaskColumn.ReadOnly = true;
            EmployeeTaskColumn.Resizable = DataGridViewTriState.False;
            EmployeeTaskColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            EmployeeTaskColumn.Text = "View Tasks";
            EmployeeTaskColumn.UseColumnTextForButtonValue = true;
            // 
            // EmployeeLabel
            // 
            EmployeeLabel.AutoSize = true;
            EmployeeLabel.BackColor = Color.Transparent;
            EmployeeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeLabel.ForeColor = SystemColors.ActiveCaptionText;
            EmployeeLabel.Location = new Point(33, 60);
            EmployeeLabel.Margin = new Padding(4, 0, 4, 0);
            EmployeeLabel.Name = "EmployeeLabel";
            EmployeeLabel.Size = new Size(97, 21);
            EmployeeLabel.TabIndex = 14;
            EmployeeLabel.Text = "Employees:";
            // 
            // TaskGrid
            // 
            TaskGrid.AllowUserToAddRows = false;
            TaskGrid.AllowUserToDeleteRows = false;
            TaskGrid.AllowUserToResizeColumns = false;
            TaskGrid.AllowUserToResizeRows = false;
            TaskGrid.BackgroundColor = SystemColors.Control;
            TaskGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SlateGray;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            TaskGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            TaskGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TaskGrid.Columns.AddRange(new DataGridViewColumn[] { userId, TaskID, Description, Status });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            TaskGrid.DefaultCellStyle = dataGridViewCellStyle5;
            TaskGrid.EnableHeadersVisualStyles = false;
            TaskGrid.GridColor = Color.Black;
            TaskGrid.Location = new Point(36, 127);
            TaskGrid.Margin = new Padding(4, 3, 4, 3);
            TaskGrid.MultiSelect = false;
            TaskGrid.Name = "TaskGrid";
            TaskGrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            TaskGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            TaskGrid.RowHeadersVisible = false;
            TaskGrid.ScrollBars = ScrollBars.Vertical;
            TaskGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TaskGrid.ShowEditingIcon = false;
            TaskGrid.Size = new Size(502, 282);
            TaskGrid.TabIndex = 20;
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
            Status.ReadOnly = true;
            Status.Resizable = DataGridViewTriState.False;
            Status.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(GreetAdmin);
            panel1.Location = new Point(-4, -5);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 483);
            panel1.TabIndex = 21;
            // 
            // backLabel
            // 
            backLabel.AutoSize = true;
            backLabel.BackColor = Color.Transparent;
            backLabel.Location = new Point(405, 106);
            backLabel.Margin = new Padding(4, 0, 4, 0);
            backLabel.Name = "backLabel";
            backLabel.Size = new Size(132, 15);
            backLabel.TabIndex = 22;
            backLabel.Text = "←Back to Employee List";
            backLabel.Click += backLabel_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.SlateGray;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 15;
            comboBox1.Items.AddRange(new object[] { "Completed", "Incomplete", "All Tasks" });
            comboBox1.Location = new Point(37, 98);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 23);
            comboBox1.TabIndex = 11;
            comboBox1.TabStop = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(backLabel);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(EmployeeLabel);
            panel2.Controls.Add(LogoutButton);
            panel2.Controls.Add(EmployeeGrid);
            panel2.Controls.Add(TaskGrid);
            panel2.Location = new Point(222, -5);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 483);
            panel2.TabIndex = 23;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(798, 473);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AdminDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeeGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)TaskGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label GreetAdmin;
        private System.Windows.Forms.DataGridView EmployeeGrid;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.DataGridView TaskGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private DataGridViewTextBoxColumn userId;
        private DataGridViewTextBoxColumn TaskID;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewButtonColumn EmployeeTaskColumn;
    }
}
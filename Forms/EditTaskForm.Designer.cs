namespace TaskManagement.Forms
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelEditButton = new System.Windows.Forms.Button();
            this.updateDescription = new System.Windows.Forms.Button();
            this.NewDescriptionLabel = new System.Windows.Forms.Label();
            this.newdescTextBox = new System.Windows.Forms.TextBox();
            this.editTaskLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelEditButton);
            this.panel1.Controls.Add(this.updateDescription);
            this.panel1.Controls.Add(this.NewDescriptionLabel);
            this.panel1.Controls.Add(this.newdescTextBox);
            this.panel1.Controls.Add(this.editTaskLabel);
            this.panel1.Location = new System.Drawing.Point(97, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 176);
            this.panel1.TabIndex = 0;
            // 
            // CancelEditButton
            // 
            this.CancelEditButton.BackColor = System.Drawing.Color.SlateGray;
            this.CancelEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelEditButton.ForeColor = System.Drawing.Color.White;
            this.CancelEditButton.Location = new System.Drawing.Point(229, 125);
            this.CancelEditButton.Name = "CancelEditButton";
            this.CancelEditButton.Size = new System.Drawing.Size(57, 23);
            this.CancelEditButton.TabIndex = 26;
            this.CancelEditButton.Text = "Cancel";
            this.CancelEditButton.UseVisualStyleBackColor = false;
            this.CancelEditButton.Click += new System.EventHandler(this.CancelEditButton_Click);
            // 
            // updateDescription
            // 
            this.updateDescription.BackColor = System.Drawing.Color.SlateGray;
            this.updateDescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateDescription.ForeColor = System.Drawing.Color.White;
            this.updateDescription.Location = new System.Drawing.Point(166, 125);
            this.updateDescription.Name = "updateDescription";
            this.updateDescription.Size = new System.Drawing.Size(57, 23);
            this.updateDescription.TabIndex = 25;
            this.updateDescription.Text = "Update";
            this.updateDescription.UseVisualStyleBackColor = false;
            this.updateDescription.Click += new System.EventHandler(this.updateDescription_Click);
            // 
            // NewDescriptionLabel
            // 
            this.NewDescriptionLabel.AutoSize = true;
            this.NewDescriptionLabel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDescriptionLabel.Location = new System.Drawing.Point(44, 66);
            this.NewDescriptionLabel.Name = "NewDescriptionLabel";
            this.NewDescriptionLabel.Size = new System.Drawing.Size(131, 21);
            this.NewDescriptionLabel.TabIndex = 2;
            this.NewDescriptionLabel.Text = "New description:";
            // 
            // newdescTextBox
            // 
            this.newdescTextBox.Location = new System.Drawing.Point(48, 90);
            this.newdescTextBox.MaxLength = 50;
            this.newdescTextBox.Name = "newdescTextBox";
            this.newdescTextBox.Size = new System.Drawing.Size(238, 20);
            this.newdescTextBox.TabIndex = 1;
            // 
            // editTaskLabel
            // 
            this.editTaskLabel.AutoSize = true;
            this.editTaskLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTaskLabel.Location = new System.Drawing.Point(37, 26);
            this.editTaskLabel.Name = "editTaskLabel";
            this.editTaskLabel.Size = new System.Drawing.Size(138, 21);
            this.editTaskLabel.TabIndex = 0;
            this.editTaskLabel.Text = "Edit Current Task";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-3, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 176);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 173);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.Shown += EditForm_Shown;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label editTaskLabel;
        private System.Windows.Forms.TextBox newdescTextBox;
        private System.Windows.Forms.Label NewDescriptionLabel;
        private System.Windows.Forms.Button CancelEditButton;
        private System.Windows.Forms.Button updateDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
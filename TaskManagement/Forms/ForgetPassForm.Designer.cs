namespace TaskManagement.Forms
{
    partial class ForgetPassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.verifyLabel = new System.Windows.Forms.Label();
            this.backLoginLabel = new System.Windows.Forms.Label();
            this.ResetPassButton = new System.Windows.Forms.Button();
            this.reNewPassTextbox = new System.Windows.Forms.TextBox();
            this.newPassTextbox = new System.Windows.Forms.TextBox();
            this.verifyUserTextbox = new System.Windows.Forms.TextBox();
            this.reNewPassLabel = new System.Windows.Forms.Label();
            this.newPassLabel = new System.Windows.Forms.Label();
            this.usernameVerifyLabel = new System.Windows.Forms.Label();
            this.ForgetPassLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.verifyLabel);
            this.panel1.Controls.Add(this.backLoginLabel);
            this.panel1.Controls.Add(this.ResetPassButton);
            this.panel1.Controls.Add(this.reNewPassTextbox);
            this.panel1.Controls.Add(this.newPassTextbox);
            this.panel1.Controls.Add(this.verifyUserTextbox);
            this.panel1.Controls.Add(this.reNewPassLabel);
            this.panel1.Controls.Add(this.newPassLabel);
            this.panel1.Controls.Add(this.usernameVerifyLabel);
            this.panel1.Controls.Add(this.ForgetPassLabel);
            this.panel1.Location = new System.Drawing.Point(126, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 282);
            this.panel1.TabIndex = 0;
            // 
            // verifyLabel
            // 
            this.verifyLabel.AutoSize = true;
            this.verifyLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.verifyLabel.Location = new System.Drawing.Point(238, 102);
            this.verifyLabel.Name = "verifyLabel";
            this.verifyLabel.Size = new System.Drawing.Size(71, 13);
            this.verifyLabel.TabIndex = 24;
            this.verifyLabel.Text = "Click to Verify";
            this.verifyLabel.Click += new System.EventHandler(this.verifyLabel_Click);
            // 
            // backLoginLabel
            // 
            this.backLoginLabel.AutoSize = true;
            this.backLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.backLoginLabel.Location = new System.Drawing.Point(297, 11);
            this.backLoginLabel.Name = "backLoginLabel";
            this.backLoginLabel.Size = new System.Drawing.Size(43, 13);
            this.backLoginLabel.TabIndex = 23;
            this.backLoginLabel.Text = "←Back";
            this.backLoginLabel.Click += new System.EventHandler(this.backLoginLabel_Click);
            // 
            // ResetPassButton
            // 
            this.ResetPassButton.BackColor = System.Drawing.Color.SlateGray;
            this.ResetPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetPassButton.ForeColor = System.Drawing.Color.White;
            this.ResetPassButton.Location = new System.Drawing.Point(139, 211);
            this.ResetPassButton.Name = "ResetPassButton";
            this.ResetPassButton.Size = new System.Drawing.Size(75, 23);
            this.ResetPassButton.TabIndex = 7;
            this.ResetPassButton.Text = "Reset";
            this.ResetPassButton.UseVisualStyleBackColor = false;
            this.ResetPassButton.Click += new System.EventHandler(this.ResetPassButton_Click);
            // 
            // reNewPassTextbox
            // 
            this.reNewPassTextbox.Location = new System.Drawing.Point(186, 168);
            this.reNewPassTextbox.Name = "reNewPassTextbox";
            this.reNewPassTextbox.Size = new System.Drawing.Size(121, 20);
            this.reNewPassTextbox.TabIndex = 6;
            // 
            // newPassTextbox
            // 
            this.newPassTextbox.Location = new System.Drawing.Point(186, 133);
            this.newPassTextbox.Name = "newPassTextbox";
            this.newPassTextbox.Size = new System.Drawing.Size(121, 20);
            this.newPassTextbox.TabIndex = 5;
            this.newPassTextbox.UseSystemPasswordChar = true;
            // 
            // verifyUserTextbox
            // 
            this.verifyUserTextbox.Location = new System.Drawing.Point(186, 79);
            this.verifyUserTextbox.Name = "verifyUserTextbox";
            this.verifyUserTextbox.Size = new System.Drawing.Size(121, 20);
            this.verifyUserTextbox.TabIndex = 4;
            this.verifyUserTextbox.TextChanged += new System.EventHandler(this.verifyUserTextbox_TextChanged);
            // 
            // reNewPassLabel
            // 
            this.reNewPassLabel.AutoSize = true;
            this.reNewPassLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reNewPassLabel.Location = new System.Drawing.Point(30, 171);
            this.reNewPassLabel.Name = "reNewPassLabel";
            this.reNewPassLabel.Size = new System.Drawing.Size(140, 17);
            this.reNewPassLabel.TabIndex = 3;
            this.reNewPassLabel.Text = "Re-enter new Password";
            // 
            // newPassLabel
            // 
            this.newPassLabel.AutoSize = true;
            this.newPassLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassLabel.Location = new System.Drawing.Point(30, 133);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(121, 17);
            this.newPassLabel.TabIndex = 2;
            this.newPassLabel.Text = "Enter new Password";
            // 
            // usernameVerifyLabel
            // 
            this.usernameVerifyLabel.AutoSize = true;
            this.usernameVerifyLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameVerifyLabel.Location = new System.Drawing.Point(30, 79);
            this.usernameVerifyLabel.Name = "usernameVerifyLabel";
            this.usernameVerifyLabel.Size = new System.Drawing.Size(104, 17);
            this.usernameVerifyLabel.TabIndex = 1;
            this.usernameVerifyLabel.Text = "Verify Username";
            // 
            // ForgetPassLabel
            // 
            this.ForgetPassLabel.AutoSize = true;
            this.ForgetPassLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ForgetPassLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPassLabel.Location = new System.Drawing.Point(98, 39);
            this.ForgetPassLabel.Name = "ForgetPassLabel";
            this.ForgetPassLabel.Size = new System.Drawing.Size(159, 17);
            this.ForgetPassLabel.TabIndex = 0;
            this.ForgetPassLabel.Text = "RESET YOUR PASSWORD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 281);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ForgetPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 278);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ForgetPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ForgetPassForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ForgetPassLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ResetPassButton;
        private System.Windows.Forms.TextBox reNewPassTextbox;
        private System.Windows.Forms.TextBox newPassTextbox;
        private System.Windows.Forms.TextBox verifyUserTextbox;
        private System.Windows.Forms.Label reNewPassLabel;
        private System.Windows.Forms.Label newPassLabel;
        private System.Windows.Forms.Label usernameVerifyLabel;
        private System.Windows.Forms.Label backLoginLabel;
        private System.Windows.Forms.Label verifyLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
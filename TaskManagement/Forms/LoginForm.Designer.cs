namespace TaskManagement
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            button1 = new Button();
            forgetPasswordLabel = new Label();
            showPassword = new PictureBox();
            hidePassword = new PictureBox();
            panel2 = new Panel();
            passwordTextBox = new TaskManagement.Controls.ModernTextBox();
            usernameTextBox = new TaskManagement.Controls.ModernTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)showPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hidePassword).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(132, 100);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 50);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.Cursor = Cursors.Hand;
            button1.DialogResult = DialogResult.Cancel;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.ImageKey = "(none)";
            button1.Location = new Point(82, 291);
            button1.Name = "button1";
            button1.Size = new Size(203, 33);
            button1.TabIndex = 2;
            button1.TabStop = false;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // forgetPasswordLabel
            // 
            forgetPasswordLabel.AutoSize = true;
            forgetPasswordLabel.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgetPasswordLabel.ForeColor = Color.DarkSlateGray;
            forgetPasswordLabel.Location = new Point(82, 248);
            forgetPasswordLabel.Name = "forgetPasswordLabel";
            forgetPasswordLabel.Size = new Size(108, 17);
            forgetPasswordLabel.TabIndex = 20;
            forgetPasswordLabel.Text = "Forgot Password?";
            forgetPasswordLabel.Click += forgetPasswordLabel_Click;
            // 
            // showPassword
            // 
            showPassword.Image = (Image)resources.GetObject("showPassword.Image");
            showPassword.Location = new Point(300, 215);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(28, 30);
            showPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            showPassword.TabIndex = 21;
            showPassword.TabStop = false;
            showPassword.Click += showPassword_Click;
            // 
            // hidePassword
            // 
            hidePassword.Image = (Image)resources.GetObject("hidePassword.Image");
            hidePassword.Location = new Point(300, 215);
            hidePassword.Name = "hidePassword";
            hidePassword.Size = new Size(28, 30);
            hidePassword.SizeMode = PictureBoxSizeMode.StretchImage;
            hidePassword.TabIndex = 22;
            hidePassword.TabStop = false;
            hidePassword.Click += hidePassword_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(passwordTextBox);
            panel2.Controls.Add(usernameTextBox);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(forgetPasswordLabel);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(showPassword);
            panel2.Controls.Add(hidePassword);
            panel2.Location = new Point(3, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 372);
            panel2.TabIndex = 25;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.BorderColor = Color.Silver;
            passwordTextBox.BorderSize = 2;
            passwordTextBox.FocusColor = Color.DodgerBlue;
            passwordTextBox.Font = new Font("Cascadia Code SemiBold", 8.25F, FontStyle.Bold);
            passwordTextBox.Location = new Point(82, 215);
            passwordTextBox.MaxLength = 20;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Padding = new Padding(0, 0, 0, 5);
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(203, 30);
            passwordTextBox.TabIndex = 27;
            passwordTextBox.TabStop = false;
            passwordTextBox.UseSystemPasswordChar = false;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.White;
            usernameTextBox.BorderColor = Color.Silver;
            usernameTextBox.BorderSize = 2;
            usernameTextBox.FocusColor = Color.DodgerBlue;
            usernameTextBox.Font = new Font("Cascadia Code SemiBold", 8.25F, FontStyle.Bold);
            usernameTextBox.Location = new Point(82, 167);
            usernameTextBox.MaxLength = 20;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Padding = new Padding(0, 0, 0, 5);
            usernameTextBox.PlaceholderText = "Username";
            usernameTextBox.Size = new Size(203, 30);
            usernameTextBox.TabIndex = 26;
            usernameTextBox.TabStop = false;
            usernameTextBox.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(141, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(376, 371);
            Controls.Add(panel2);
            Font = new Font("Sylfaen", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)showPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)hidePassword).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label forgetPasswordLabel;
        private System.Windows.Forms.PictureBox showPassword;
        private System.Windows.Forms.PictureBox hidePassword;
        private System.Windows.Forms.Panel panel2;
        private PictureBox pictureBox1;
        private Controls.ModernTextBox usernameTextBox;
        private Controls.ModernTextBox passwordTextBox;
    }
}


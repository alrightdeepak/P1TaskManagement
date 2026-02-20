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
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            button1 = new Button();
            closeLabel = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            greet = new Label();
            forgetPasswordLabel = new Label();
            showPassword = new PictureBox();
            hidePassword = new PictureBox();
            panel2 = new Panel();
            PasswordLabel = new Label();
            usernameLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hidePassword).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(55, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(387, 50);
            label1.TabIndex = 0;
            label1.Text = "Login to your Account";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = SystemColors.Control;
            usernameTextBox.Cursor = Cursors.IBeam;
            usernameTextBox.Font = new Font("Cascadia Code SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameTextBox.Location = new Point(137, 170);
            usernameTextBox.MaxLength = 20;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Enter username";
            usernameTextBox.Size = new Size(203, 20);
            usernameTextBox.TabIndex = 0;
            usernameTextBox.TabStop = false;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.Control;
            passwordTextBox.Cursor = Cursors.IBeam;
            passwordTextBox.Font = new Font("Cascadia Code SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(137, 223);
            passwordTextBox.MaxLength = 20;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Enter Password";
            passwordTextBox.Size = new Size(203, 20);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.TabStop = false;
            passwordTextBox.UseSystemPasswordChar = true;
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
            button1.Location = new Point(137, 289);
            button1.Name = "button1";
            button1.Size = new Size(203, 33);
            button1.TabIndex = 2;
            button1.TabStop = false;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // closeLabel
            // 
            closeLabel.AutoSize = true;
            closeLabel.BackColor = Color.Transparent;
            closeLabel.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeLabel.ForeColor = SystemColors.ActiveCaptionText;
            closeLabel.Location = new Point(427, 10);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new Size(34, 25);
            closeLabel.TabIndex = 6;
            closeLabel.Text = "✖";
            closeLabel.Click += closeLabel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(greet);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 415);
            panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // greet
            // 
            greet.AutoSize = true;
            greet.BackColor = Color.Transparent;
            greet.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            greet.ForeColor = SystemColors.ControlLight;
            greet.Location = new Point(39, 46);
            greet.Name = "greet";
            greet.Size = new Size(144, 32);
            greet.TabIndex = 1;
            greet.Text = "WELCOME";
            // 
            // forgetPasswordLabel
            // 
            forgetPasswordLabel.AutoSize = true;
            forgetPasswordLabel.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgetPasswordLabel.ForeColor = Color.DarkSlateGray;
            forgetPasswordLabel.Location = new Point(137, 246);
            forgetPasswordLabel.Name = "forgetPasswordLabel";
            forgetPasswordLabel.Size = new Size(108, 17);
            forgetPasswordLabel.TabIndex = 20;
            forgetPasswordLabel.Text = "Forgot Password?";
            forgetPasswordLabel.Click += forgetPasswordLabel_Click;
            // 
            // showPassword
            // 
            showPassword.Image = (Image)resources.GetObject("showPassword.Image");
            showPassword.Location = new Point(346, 223);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(17, 20);
            showPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            showPassword.TabIndex = 21;
            showPassword.TabStop = false;
            showPassword.Click += showPassword_Click;
            // 
            // hidePassword
            // 
            hidePassword.Image = (Image)resources.GetObject("hidePassword.Image");
            hidePassword.Location = new Point(346, 223);
            hidePassword.Name = "hidePassword";
            hidePassword.Size = new Size(17, 20);
            hidePassword.SizeMode = PictureBoxSizeMode.StretchImage;
            hidePassword.TabIndex = 22;
            hidePassword.TabStop = false;
            hidePassword.Click += hidePassword_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(PasswordLabel);
            panel2.Controls.Add(usernameLabel);
            panel2.Controls.Add(closeLabel);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(usernameTextBox);
            panel2.Controls.Add(passwordTextBox);
            panel2.Controls.Add(showPassword);
            panel2.Controls.Add(hidePassword);
            panel2.Controls.Add(forgetPasswordLabel);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(210, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(475, 412);
            panel2.TabIndex = 25;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            PasswordLabel.Location = new Point(137, 203);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(66, 17);
            PasswordLabel.TabIndex = 24;
            PasswordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(137, 150);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(69, 17);
            usernameLabel.TabIndex = 23;
            usernameLabel.Text = "Username";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(684, 411);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Sylfaen", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)showPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)hidePassword).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label greet;
        private System.Windows.Forms.Label forgetPasswordLabel;
        private System.Windows.Forms.PictureBox showPassword;
        private System.Windows.Forms.PictureBox hidePassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Label PasswordLabel;
        private Label usernameLabel;
    }
}


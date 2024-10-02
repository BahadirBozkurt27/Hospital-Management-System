
namespace HospitalManagement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.forgetPassword = new System.Windows.Forms.LinkLabel();
            this.rememberMe = new System.Windows.Forms.CheckBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.isVisible = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // forgetPassword
            // 
            this.forgetPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(77)))));
            this.forgetPassword.AutoSize = true;
            this.forgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.forgetPassword.LinkColor = System.Drawing.Color.Black;
            this.forgetPassword.Location = new System.Drawing.Point(328, 275);
            this.forgetPassword.Name = "forgetPassword";
            this.forgetPassword.Size = new System.Drawing.Size(131, 18);
            this.forgetPassword.TabIndex = 31;
            this.forgetPassword.TabStop = true;
            this.forgetPassword.Text = "Forgot Password?";
            // 
            // rememberMe
            // 
            this.rememberMe.AutoSize = true;
            this.rememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rememberMe.Location = new System.Drawing.Point(25, 275);
            this.rememberMe.Name = "rememberMe";
            this.rememberMe.Size = new System.Drawing.Size(129, 22);
            this.rememberMe.TabIndex = 29;
            this.rememberMe.Text = "Remember Me";
            this.rememberMe.UseVisualStyleBackColor = true;
            this.rememberMe.CheckedChanged += new System.EventHandler(this.rememberMe_CheckedChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox.Location = new System.Drawing.Point(86, 214);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(317, 20);
            this.passwordTextBox.TabIndex = 27;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IDTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IDTextBox.Location = new System.Drawing.Point(86, 131);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(317, 20);
            this.IDTextBox.TabIndex = 28;
            this.IDTextBox.Text = "ID Number";
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            this.IDTextBox.Enter += new System.EventHandler(this.IDTextBox_Enter);
            this.IDTextBox.Leave += new System.EventHandler(this.IDTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(179, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Not register yet?";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.White;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.registerButton.Location = new System.Drawing.Point(97, 463);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(291, 53);
            this.registerButton.TabIndex = 25;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(77)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(33, 325);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(426, 69);
            this.loginButton.TabIndex = 24;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(25, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 1);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(25, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 1);
            this.panel1.TabIndex = 22;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.headerLabel.Location = new System.Drawing.Point(211, 77);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(101, 38);
            this.headerLabel.TabIndex = 19;
            this.headerLabel.Text = "Login";
            // 
            // isVisible
            // 
            this.isVisible.Appearance = System.Windows.Forms.Appearance.Button;
            this.isVisible.BackgroundImage = global::HospitalManagement.Properties.Resources.visibility;
            this.isVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.isVisible.FlatAppearance.BorderSize = 0;
            this.isVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isVisible.Location = new System.Drawing.Point(409, 204);
            this.isVisible.Name = "isVisible";
            this.isVisible.Size = new System.Drawing.Size(50, 32);
            this.isVisible.TabIndex = 32;
            this.isVisible.UseVisualStyleBackColor = true;
            this.isVisible.CheckedChanged += new System.EventHandler(this.isVisible_CheckedChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelButton.Location = new System.Drawing.Point(426, 1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(58, 44);
            this.cancelButton.TabIndex = 30;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::HospitalManagement.Properties.Resources.indir;
            this.pictureBox2.Location = new System.Drawing.Point(25, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::HospitalManagement.Properties.Resources._4_42641_mail_logo_png_transparent_png;
            this.pictureBox1.Location = new System.Drawing.Point(25, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 522);
            this.Controls.Add(this.isVisible);
            this.Controls.Add(this.forgetPassword);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.rememberMe);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox isVisible;
        private System.Windows.Forms.LinkLabel forgetPassword;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox rememberMe;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label headerLabel;
    }
}


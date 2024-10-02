
namespace HospitalManagement
{
    partial class MyProfile
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addPatient = new System.Windows.Forms.Button();
            this.branchLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.initInfo = new System.Windows.Forms.Label();
            this.myProfileButton = new System.Windows.Forms.Button();
            this.addDiagnosis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.branchTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isVisible = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addPatient);
            this.groupBox1.Controls.Add(this.branchLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.initInfo);
            this.groupBox1.Controls.Add(this.myProfileButton);
            this.groupBox1.Controls.Add(this.addDiagnosis);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(27, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 482);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RUBA";
            // 
            // addPatient
            // 
            this.addPatient.Location = new System.Drawing.Point(23, 362);
            this.addPatient.Name = "addPatient";
            this.addPatient.Size = new System.Drawing.Size(196, 49);
            this.addPatient.TabIndex = 95;
            this.addPatient.Text = "Add Patient";
            this.addPatient.UseVisualStyleBackColor = true;
            this.addPatient.Click += new System.EventHandler(this.addPatient_Click_1);
            // 
            // branchLabel
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.Location = new System.Drawing.Point(123, 136);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(17, 25);
            this.branchLabel.TabIndex = 94;
            this.branchLabel.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 93;
            this.label1.Text = "Branch:";
            // 
            // initInfo
            // 
            this.initInfo.AutoSize = true;
            this.initInfo.Location = new System.Drawing.Point(41, 92);
            this.initInfo.Name = "initInfo";
            this.initInfo.Size = new System.Drawing.Size(17, 25);
            this.initInfo.TabIndex = 92;
            this.initInfo.Text = ".";
            // 
            // myProfileButton
            // 
            this.myProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(77)))));
            this.myProfileButton.Enabled = false;
            this.myProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.myProfileButton.Location = new System.Drawing.Point(23, 178);
            this.myProfileButton.Name = "myProfileButton";
            this.myProfileButton.Size = new System.Drawing.Size(196, 49);
            this.myProfileButton.TabIndex = 0;
            this.myProfileButton.Text = "My Profile";
            this.myProfileButton.UseVisualStyleBackColor = false;
            // 
            // addDiagnosis
            // 
            this.addDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addDiagnosis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addDiagnosis.Location = new System.Drawing.Point(23, 278);
            this.addDiagnosis.Name = "addDiagnosis";
            this.addDiagnosis.Size = new System.Drawing.Size(196, 49);
            this.addDiagnosis.TabIndex = 0;
            this.addDiagnosis.Text = "Add Diagnosis";
            this.addDiagnosis.UseVisualStyleBackColor = true;
            this.addDiagnosis.Click += new System.EventHandler(this.addDiagnosis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(347, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 1);
            this.panel1.TabIndex = 72;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(347, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 1);
            this.panel2.TabIndex = 73;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTextBox.Location = new System.Drawing.Point(454, 124);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(273, 28);
            this.nameTextBox.TabIndex = 82;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SurnameTextBox.Location = new System.Drawing.Point(454, 183);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(273, 28);
            this.SurnameTextBox.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(373, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 87;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(360, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 88;
            this.label4.Text = "Surname";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(77)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(350, 438);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(379, 61);
            this.updateButton.TabIndex = 74;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(346, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 24);
            this.label8.TabIndex = 91;
            this.label8.Text = "Password";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(347, 285);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 1);
            this.panel4.TabIndex = 77;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(347, 344);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 1);
            this.panel5.TabIndex = 78;
            // 
            // mailTextBox
            // 
            this.mailTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.mailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailTextBox.Location = new System.Drawing.Point(454, 242);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(273, 28);
            this.mailTextBox.TabIndex = 83;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox.Location = new System.Drawing.Point(454, 301);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(273, 28);
            this.passwordTextBox.TabIndex = 84;
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(360, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
            this.label7.TabIndex = 90;
            this.label7.Text = "Email";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(347, 403);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 1);
            this.panel3.TabIndex = 78;
            // 
            // branchTextBox
            // 
            this.branchTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.branchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.branchTextBox.Location = new System.Drawing.Point(454, 360);
            this.branchTextBox.Name = "branchTextBox";
            this.branchTextBox.Size = new System.Drawing.Size(273, 28);
            this.branchTextBox.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(313, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 91;
            this.label3.Text = "Specialization";
            // 
            // isVisible
            // 
            this.isVisible.Appearance = System.Windows.Forms.Appearance.Button;
            this.isVisible.BackgroundImage = global::HospitalManagement.Properties.Resources.visibility;
            this.isVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.isVisible.FlatAppearance.BorderSize = 0;
            this.isVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isVisible.Location = new System.Drawing.Point(686, 304);
            this.isVisible.Name = "isVisible";
            this.isVisible.Size = new System.Drawing.Size(39, 21);
            this.isVisible.TabIndex = 93;
            this.isVisible.UseVisualStyleBackColor = true;
            this.isVisible.CheckedChanged += new System.EventHandler(this.isVisible_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.Control;
            this.exitButton.BackgroundImage = global::HospitalManagement.Properties.Resources._1649079743320;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(705, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(57, 54);
            this.exitButton.TabIndex = 92;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::HospitalManagement.Properties.Resources.icons8_undo_961;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.Transparent;
            this.backButton.Location = new System.Drawing.Point(656, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(58, 54);
            this.backButton.TabIndex = 94;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // MyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 531);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.isVisible);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.branchTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyProfile";
            this.Load += new System.EventHandler(this.MyProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button myProfileButton;
        private System.Windows.Forms.Button addDiagnosis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox branchTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label branchLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label initInfo;
        private System.Windows.Forms.Button addPatient;
        private System.Windows.Forms.CheckBox isVisible;
        private System.Windows.Forms.Button backButton;
    }
}
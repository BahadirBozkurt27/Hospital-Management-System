
namespace HospitalManagement
{
    partial class Doctor
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
            this.addPatient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.branchLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.initInfo = new System.Windows.Forms.Label();
            this.myProfileButton = new System.Windows.Forms.Button();
            this.addDiagnosis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addPatient
            // 
            this.addPatient.Location = new System.Drawing.Point(23, 370);
            this.addPatient.Name = "addPatient";
            this.addPatient.Size = new System.Drawing.Size(196, 49);
            this.addPatient.TabIndex = 0;
            this.addPatient.Text = "Add Patient";
            this.addPatient.UseVisualStyleBackColor = true;
            this.addPatient.Click += new System.EventHandler(this.addPatient_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.branchLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.initInfo);
            this.groupBox1.Controls.Add(this.myProfileButton);
            this.groupBox1.Controls.Add(this.addDiagnosis);
            this.groupBox1.Controls.Add(this.addPatient);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 482);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RUBA";
            // 
            // branchLabel
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.Location = new System.Drawing.Point(109, 126);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(17, 25);
            this.branchLabel.TabIndex = 91;
            this.branchLabel.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 90;
            this.label2.Text = "Branch:";
            // 
            // initInfo
            // 
            this.initInfo.AutoSize = true;
            this.initInfo.Location = new System.Drawing.Point(27, 85);
            this.initInfo.Name = "initInfo";
            this.initInfo.Size = new System.Drawing.Size(17, 25);
            this.initInfo.TabIndex = 1;
            this.initInfo.Text = ".";
            // 
            // myProfileButton
            // 
            this.myProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.myProfileButton.Location = new System.Drawing.Point(23, 178);
            this.myProfileButton.Name = "myProfileButton";
            this.myProfileButton.Size = new System.Drawing.Size(196, 49);
            this.myProfileButton.TabIndex = 0;
            this.myProfileButton.Text = "My Profile";
            this.myProfileButton.UseVisualStyleBackColor = true;
            this.myProfileButton.Click += new System.EventHandler(this.myProfileButton_Click);
            // 
            // addDiagnosis
            // 
            this.addDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addDiagnosis.Location = new System.Drawing.Point(23, 278);
            this.addDiagnosis.Name = "addDiagnosis";
            this.addDiagnosis.Size = new System.Drawing.Size(196, 49);
            this.addDiagnosis.TabIndex = 0;
            this.addDiagnosis.Text = "Add Diagnosis";
            this.addDiagnosis.UseVisualStyleBackColor = true;
            this.addDiagnosis.Click += new System.EventHandler(this.addDiagnosis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagement.Properties.Resources.Doctors;
            this.pictureBox1.Location = new System.Drawing.Point(276, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.BackgroundImage = global::HospitalManagement.Properties.Resources._1649079743320;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(715, 9);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(57, 54);
            this.exitButton.TabIndex = 94;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 515);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addPatient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label initInfo;
        private System.Windows.Forms.Button myProfileButton;
        private System.Windows.Forms.Button addDiagnosis;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label branchLabel;
    }
}
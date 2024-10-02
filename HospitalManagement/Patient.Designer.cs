
namespace HospitalManagement
{
    partial class Patient
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.initInfo = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.list_showforpatients = new System.Windows.Forms.ListView();
            this.Disease = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Describtion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiseaseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_control = new System.Windows.Forms.DateTimePicker();
            this.btn_results = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.initInfo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 372);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RUBA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagement.Properties.Resources.Phisiotherapy;
            this.pictureBox1.Location = new System.Drawing.Point(6, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.BackgroundImage = global::HospitalManagement.Properties.Resources._1649079743320;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(898, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(57, 54);
            this.exitButton.TabIndex = 90;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // list_showforpatients
            // 
            this.list_showforpatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Disease,
            this.Describtion,
            this.DiseaseDate});
            this.list_showforpatients.HideSelection = false;
            this.list_showforpatients.Location = new System.Drawing.Point(300, 143);
            this.list_showforpatients.Name = "list_showforpatients";
            this.list_showforpatients.Size = new System.Drawing.Size(629, 339);
            this.list_showforpatients.TabIndex = 91;
            this.list_showforpatients.UseCompatibleStateImageBehavior = false;
            this.list_showforpatients.View = System.Windows.Forms.View.Details;
            // 
            // Disease
            // 
            this.Disease.Text = "Disease Name";
            this.Disease.Width = 174;
            // 
            // Describtion
            // 
            this.Describtion.Text = "Describtion";
            this.Describtion.Width = 247;
            // 
            // DiseaseDate
            // 
            this.DiseaseDate.Text = "Disease Date";
            this.DiseaseDate.Width = 196;
            // 
            // date_control
            // 
            this.date_control.Location = new System.Drawing.Point(371, 77);
            this.date_control.Name = "date_control";
            this.date_control.Size = new System.Drawing.Size(200, 22);
            this.date_control.TabIndex = 92;
            // 
            // btn_results
            // 
            this.btn_results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(77)))));
            this.btn_results.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_results.Location = new System.Drawing.Point(706, 66);
            this.btn_results.Name = "btn_results";
            this.btn_results.Size = new System.Drawing.Size(147, 49);
            this.btn_results.TabIndex = 93;
            this.btn_results.Text = "Result";
            this.btn_results.UseVisualStyleBackColor = false;
            this.btn_results.Click += new System.EventHandler(this.btn_results_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(967, 515);
            this.Controls.Add(this.btn_results);
            this.Controls.Add(this.date_control);
            this.Controls.Add(this.list_showforpatients);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "a";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label initInfo;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView list_showforpatients;
        private System.Windows.Forms.DateTimePicker date_control;
        private System.Windows.Forms.Button btn_results;
        private System.Windows.Forms.ColumnHeader Disease;
        private System.Windows.Forms.ColumnHeader Describtion;
        private System.Windows.Forms.ColumnHeader DiseaseDate;
    }
}

namespace HospitalManagement
{
    partial class Diagnosis
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.branchLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.initInfo = new System.Windows.Forms.Label();
            this.myProfileButton = new System.Windows.Forms.Button();
            this.addDiagnosis = new System.Windows.Forms.Button();
            this.addPatient = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.patientListView = new System.Windows.Forms.ListView();
            this.diseaseCombobox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.lbl_dateBirth = new System.Windows.Forms.Label();
            this.txt_identification = new System.Windows.Forms.TextBox();
            this.lbl_identification_num = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.txt_birthday = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_description = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.branchLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.initInfo);
            this.groupBox1.Controls.Add(this.myProfileButton);
            this.groupBox1.Controls.Add(this.addDiagnosis);
            this.groupBox1.Controls.Add(this.addPatient);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 482);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RUBA";
            // 
            // branchLabel
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.Location = new System.Drawing.Point(120, 139);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(17, 25);
            this.branchLabel.TabIndex = 94;
            this.branchLabel.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 93;
            this.label1.Text = "Branch:";
            // 
            // initInfo
            // 
            this.initInfo.AutoSize = true;
            this.initInfo.Location = new System.Drawing.Point(38, 95);
            this.initInfo.Name = "initInfo";
            this.initInfo.Size = new System.Drawing.Size(17, 25);
            this.initInfo.TabIndex = 92;
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
            this.addDiagnosis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(77)))));
            this.addDiagnosis.Enabled = false;
            this.addDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addDiagnosis.Location = new System.Drawing.Point(23, 278);
            this.addDiagnosis.Name = "addDiagnosis";
            this.addDiagnosis.Size = new System.Drawing.Size(196, 49);
            this.addDiagnosis.TabIndex = 0;
            this.addDiagnosis.Text = "Add Diagnosis";
            this.addDiagnosis.UseVisualStyleBackColor = false;
            // 
            // addPatient
            // 
            this.addPatient.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addPatient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addPatient.Location = new System.Drawing.Point(23, 370);
            this.addPatient.Name = "addPatient";
            this.addPatient.Size = new System.Drawing.Size(196, 49);
            this.addPatient.TabIndex = 0;
            this.addPatient.Text = "Add Patient";
            this.addPatient.UseVisualStyleBackColor = false;
            this.addPatient.Click += new System.EventHandler(this.addPatient_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.Control;
            this.exitButton.BackgroundImage = global::HospitalManagement.Properties.Resources._1649079743320;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(962, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(57, 54);
            this.exitButton.TabIndex = 70;
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
            this.backButton.Location = new System.Drawing.Point(898, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(58, 54);
            this.backButton.TabIndex = 89;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // patientListView
            // 
            this.patientListView.HideSelection = false;
            this.patientListView.Location = new System.Drawing.Point(286, 190);
            this.patientListView.Name = "patientListView";
            this.patientListView.Size = new System.Drawing.Size(528, 269);
            this.patientListView.TabIndex = 90;
            this.patientListView.UseCompatibleStateImageBehavior = false;
            this.patientListView.SelectedIndexChanged += new System.EventHandler(this.patientListView_SelectedIndexChanged);
            // 
            // diseaseCombobox
            // 
            this.diseaseCombobox.FormattingEnabled = true;
            this.diseaseCombobox.Location = new System.Drawing.Point(286, 494);
            this.diseaseCombobox.Name = "diseaseCombobox";
            this.diseaseCombobox.Size = new System.Drawing.Size(181, 24);
            this.diseaseCombobox.TabIndex = 91;
            this.diseaseCombobox.SelectedIndexChanged += new System.EventHandler(this.diseaseCombobox_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(77)))));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Location = new System.Drawing.Point(616, 480);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(198, 73);
            this.saveButton.TabIndex = 92;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // lbl_dateBirth
            // 
            this.lbl_dateBirth.AutoSize = true;
            this.lbl_dateBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dateBirth.Location = new System.Drawing.Point(609, 142);
            this.lbl_dateBirth.Name = "lbl_dateBirth";
            this.lbl_dateBirth.Size = new System.Drawing.Size(117, 22);
            this.lbl_dateBirth.TabIndex = 103;
            this.lbl_dateBirth.Text = "Date Of Birth";
            // 
            // txt_identification
            // 
            this.txt_identification.Enabled = false;
            this.txt_identification.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_identification.Location = new System.Drawing.Point(798, 88);
            this.txt_identification.Name = "txt_identification";
            this.txt_identification.Size = new System.Drawing.Size(186, 30);
            this.txt_identification.TabIndex = 102;
            // 
            // lbl_identification_num
            // 
            this.lbl_identification_num.AutoSize = true;
            this.lbl_identification_num.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_identification_num.Location = new System.Drawing.Point(609, 91);
            this.lbl_identification_num.Name = "lbl_identification_num";
            this.lbl_identification_num.Size = new System.Drawing.Size(183, 22);
            this.lbl_identification_num.TabIndex = 101;
            this.lbl_identification_num.Text = "Identification Number";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Enabled = false;
            this.txt_lastname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_lastname.Location = new System.Drawing.Point(387, 139);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(151, 30);
            this.txt_lastname.TabIndex = 100;
            // 
            // txt_firstname
            // 
            this.txt_firstname.Enabled = false;
            this.txt_firstname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_firstname.Location = new System.Drawing.Point(387, 79);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(151, 30);
            this.txt_firstname.TabIndex = 99;
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_lastname.Location = new System.Drawing.Point(282, 138);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(94, 22);
            this.lbl_lastname.TabIndex = 94;
            this.lbl_lastname.Text = "Last Name";
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_firstname.Location = new System.Drawing.Point(278, 88);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(98, 22);
            this.lbl_firstname.TabIndex = 93;
            this.lbl_firstname.Text = "First Name";
            // 
            // txt_birthday
            // 
            this.txt_birthday.Enabled = false;
            this.txt_birthday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_birthday.Location = new System.Drawing.Point(798, 139);
            this.txt_birthday.Name = "txt_birthday";
            this.txt_birthday.Size = new System.Drawing.Size(186, 30);
            this.txt_birthday.TabIndex = 102;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(839, 259);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(196, 199);
            this.txt_description.TabIndex = 104;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_description.Location = new System.Drawing.Point(881, 217);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(103, 22);
            this.lbl_description.TabIndex = 106;
            this.lbl_description.Text = "Description";
            // 
            // Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 643);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.lbl_dateBirth);
            this.Controls.Add(this.txt_birthday);
            this.Controls.Add(this.txt_identification);
            this.Controls.Add(this.lbl_identification_num);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_firstname);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.diseaseCombobox);
            this.Controls.Add(this.patientListView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnosis";
            this.Load += new System.EventHandler(this.Diagnosis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button myProfileButton;
        private System.Windows.Forms.Button addDiagnosis;
        private System.Windows.Forms.Button addPatient;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label branchLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label initInfo;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListView patientListView;
        private System.Windows.Forms.ComboBox diseaseCombobox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label lbl_dateBirth;
        private System.Windows.Forms.TextBox txt_identification;
        private System.Windows.Forms.Label lbl_identification_num;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.TextBox txt_birthday;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl_description;
    }
}
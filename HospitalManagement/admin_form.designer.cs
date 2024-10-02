
namespace HospitalManagement
{
    partial class admin_form
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
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_job = new System.Windows.Forms.Label();
            this.combo_job = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_deleteidentification = new System.Windows.Forms.TextBox();
            this.lbl_deleteidentification = new System.Windows.Forms.Label();
            this.txt_updateidentification = new System.Windows.Forms.TextBox();
            this.lbl_updateidentification = new System.Windows.Forms.Label();
            this.txt_identification = new System.Windows.Forms.TextBox();
            this.lbl_identification_num = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_listALL = new System.Windows.Forms.Button();
            this.lbl_dateBirth = new System.Windows.Forms.Label();
            this.dt_dateBirth = new System.Windows.Forms.DateTimePicker();
            this.list_show = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_clear = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.adminbackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_firstname.Location = new System.Drawing.Point(48, 23);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(98, 22);
            this.lbl_firstname.TabIndex = 1;
            this.lbl_firstname.Text = "First Name";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_lastname.Location = new System.Drawing.Point(48, 82);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(94, 22);
            this.lbl_lastname.TabIndex = 2;
            this.lbl_lastname.Text = "Last Name";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_email.Location = new System.Drawing.Point(354, 27);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(67, 22);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "E-Mail";
            // 
            // lbl_job
            // 
            this.lbl_job.AutoSize = true;
            this.lbl_job.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_job.Location = new System.Drawing.Point(354, 87);
            this.lbl_job.Name = "lbl_job";
            this.lbl_job.Size = new System.Drawing.Size(38, 22);
            this.lbl_job.TabIndex = 4;
            this.lbl_job.Text = "Job";
            // 
            // combo_job
            // 
            this.combo_job.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_job.FormattingEnabled = true;
            this.combo_job.Location = new System.Drawing.Point(452, 79);
            this.combo_job.Name = "combo_job";
            this.combo_job.Size = new System.Drawing.Size(165, 30);
            this.combo_job.TabIndex = 5;
            this.combo_job.SelectedIndexChanged += new System.EventHandler(this.combo_job_SelectedIndexChanged);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_email.Location = new System.Drawing.Point(452, 24);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(186, 30);
            this.txt_email.TabIndex = 6;
            // 
            // txt_firstname
            // 
            this.txt_firstname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_firstname.Location = new System.Drawing.Point(153, 23);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(151, 30);
            this.txt_firstname.TabIndex = 7;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_lastname.Location = new System.Drawing.Point(153, 83);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(151, 30);
            this.txt_lastname.TabIndex = 8;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(77)))));
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_add.Location = new System.Drawing.Point(1073, 79);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 64);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(77)))));
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_delete.Location = new System.Drawing.Point(452, 504);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 64);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(77)))));
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update.Location = new System.Drawing.Point(452, 595);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 64);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_list
            // 
            this.btn_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(77)))));
            this.btn_list.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_list.Location = new System.Drawing.Point(1026, 548);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(100, 64);
            this.btn_list.TabIndex = 12;
            this.btn_list.Text = "List";
            this.btn_list.UseVisualStyleBackColor = false;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_search.Location = new System.Drawing.Point(567, 569);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(148, 22);
            this.lbl_search.TabIndex = 14;
            this.lbl_search.Text = "Search For Name";
            // 
            // txt_deleteidentification
            // 
            this.txt_deleteidentification.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_deleteidentification.Location = new System.Drawing.Point(294, 522);
            this.txt_deleteidentification.Name = "txt_deleteidentification";
            this.txt_deleteidentification.Size = new System.Drawing.Size(151, 30);
            this.txt_deleteidentification.TabIndex = 16;
            // 
            // lbl_deleteidentification
            // 
            this.lbl_deleteidentification.AutoSize = true;
            this.lbl_deleteidentification.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_deleteidentification.Location = new System.Drawing.Point(48, 525);
            this.lbl_deleteidentification.Name = "lbl_deleteidentification";
            this.lbl_deleteidentification.Size = new System.Drawing.Size(240, 22);
            this.lbl_deleteidentification.TabIndex = 15;
            this.lbl_deleteidentification.Text = "Delete Identification Number";
            // 
            // txt_updateidentification
            // 
            this.txt_updateidentification.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_updateidentification.Location = new System.Drawing.Point(294, 618);
            this.txt_updateidentification.Name = "txt_updateidentification";
            this.txt_updateidentification.Size = new System.Drawing.Size(151, 30);
            this.txt_updateidentification.TabIndex = 18;
            // 
            // lbl_updateidentification
            // 
            this.lbl_updateidentification.AutoSize = true;
            this.lbl_updateidentification.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_updateidentification.Location = new System.Drawing.Point(48, 621);
            this.lbl_updateidentification.Name = "lbl_updateidentification";
            this.lbl_updateidentification.Size = new System.Drawing.Size(244, 22);
            this.lbl_updateidentification.TabIndex = 17;
            this.lbl_updateidentification.Text = "Update Identification Number";
            // 
            // txt_identification
            // 
            this.txt_identification.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_identification.Location = new System.Drawing.Point(865, 29);
            this.txt_identification.Name = "txt_identification";
            this.txt_identification.Size = new System.Drawing.Size(186, 30);
            this.txt_identification.TabIndex = 20;
            // 
            // lbl_identification_num
            // 
            this.lbl_identification_num.AutoSize = true;
            this.lbl_identification_num.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_identification_num.Location = new System.Drawing.Point(676, 32);
            this.lbl_identification_num.Name = "lbl_identification_num";
            this.lbl_identification_num.Size = new System.Drawing.Size(183, 22);
            this.lbl_identification_num.TabIndex = 19;
            this.lbl_identification_num.Text = "Identification Number";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_search.Location = new System.Drawing.Point(721, 566);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(287, 30);
            this.txt_search.TabIndex = 21;
            // 
            // btn_listALL
            // 
            this.btn_listALL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(77)))));
            this.btn_listALL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listALL.Location = new System.Drawing.Point(1026, 218);
            this.btn_listALL.Name = "btn_listALL";
            this.btn_listALL.Size = new System.Drawing.Size(168, 64);
            this.btn_listALL.TabIndex = 22;
            this.btn_listALL.Text = "List All User";
            this.btn_listALL.UseVisualStyleBackColor = false;
            this.btn_listALL.Click += new System.EventHandler(this.btn_listALL_Click);
            // 
            // lbl_dateBirth
            // 
            this.lbl_dateBirth.AutoSize = true;
            this.lbl_dateBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dateBirth.Location = new System.Drawing.Point(699, 90);
            this.lbl_dateBirth.Name = "lbl_dateBirth";
            this.lbl_dateBirth.Size = new System.Drawing.Size(117, 22);
            this.lbl_dateBirth.TabIndex = 23;
            this.lbl_dateBirth.Text = "Date Of Birth";
            // 
            // dt_dateBirth
            // 
            this.dt_dateBirth.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_dateBirth.Location = new System.Drawing.Point(822, 89);
            this.dt_dateBirth.Name = "dt_dateBirth";
            this.dt_dateBirth.Size = new System.Drawing.Size(199, 22);
            this.dt_dateBirth.TabIndex = 24;
            // 
            // list_show
            // 
            this.list_show.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.list_show.HideSelection = false;
            this.list_show.Location = new System.Drawing.Point(72, 146);
            this.list_show.Name = "list_show";
            this.list_show.Size = new System.Drawing.Size(922, 329);
            this.list_show.TabIndex = 25;
            this.list_show.UseCompatibleStateImageBehavior = false;
            this.list_show.View = System.Windows.Forms.View.Details;
            this.list_show.SelectedIndexChanged += new System.EventHandler(this.list_show_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TC";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FirstName";
            this.columnHeader3.Width = 136;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "LastName";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Job";
            this.columnHeader5.Width = 106;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "DateOfBirth";
            this.columnHeader6.Width = 170;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "EMail";
            this.columnHeader7.Width = 162;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(77)))));
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clear.Location = new System.Drawing.Point(1056, 333);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 64);
            this.btn_clear.TabIndex = 26;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.Control;
            this.exitButton.BackgroundImage = global::HospitalManagement.Properties.Resources._1649079743320;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(1137, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(57, 54);
            this.exitButton.TabIndex = 93;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // adminbackButton
            // 
            this.adminbackButton.BackColor = System.Drawing.Color.Transparent;
            this.adminbackButton.BackgroundImage = global::HospitalManagement.Properties.Resources.icons8_undo_961;
            this.adminbackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminbackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminbackButton.ForeColor = System.Drawing.Color.Transparent;
            this.adminbackButton.Location = new System.Drawing.Point(1073, 5);
            this.adminbackButton.Name = "adminbackButton";
            this.adminbackButton.Size = new System.Drawing.Size(58, 54);
            this.adminbackButton.TabIndex = 98;
            this.adminbackButton.UseVisualStyleBackColor = false;
            this.adminbackButton.Click += new System.EventHandler(this.adminbackButton_Click);
            // 
            // admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 694);
            this.Controls.Add(this.adminbackButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.list_show);
            this.Controls.Add(this.dt_dateBirth);
            this.Controls.Add(this.lbl_dateBirth);
            this.Controls.Add(this.btn_listALL);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_identification);
            this.Controls.Add(this.lbl_identification_num);
            this.Controls.Add(this.txt_updateidentification);
            this.Controls.Add(this.lbl_updateidentification);
            this.Controls.Add(this.txt_deleteidentification);
            this.Controls.Add(this.lbl_deleteidentification);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.combo_job);
            this.Controls.Add(this.lbl_job);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_firstname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_form";
            this.Load += new System.EventHandler(this.admin_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_job;
        private System.Windows.Forms.ComboBox combo_job;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_deleteidentification;
        private System.Windows.Forms.Label lbl_deleteidentification;
        private System.Windows.Forms.TextBox txt_updateidentification;
        private System.Windows.Forms.Label lbl_updateidentification;
        private System.Windows.Forms.TextBox txt_identification;
        private System.Windows.Forms.Label lbl_identification_num;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_listALL;
        private System.Windows.Forms.Label lbl_dateBirth;
        private System.Windows.Forms.DateTimePicker dt_dateBirth;
        private System.Windows.Forms.ListView list_show;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button adminbackButton;
    }
}
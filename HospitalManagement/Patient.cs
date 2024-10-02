using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HospitalManagement
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            initInfo.Text = User.FirstName + " " + User.LastName;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void show_data()
        {
            SqlConnection connection = new SqlConnection(SQLConnection.connectionString);

            connection.Open();

            string query = "SELECT * FROM Users " +
               "JOIN Patients ON Users.UserId = Patients.UserId " +
               "JOIN PatientDiseases ON Patients.PatientId = PatientDiseases.PatientId " +
               "JOIN Diseases ON PatientDiseases.DiseaseId = Diseases.DiseaseId";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                string selected_date = date_control.Value.ToLongDateString();
                command.Parameters.AddWithValue("diseasedate", selected_date);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    list_showforpatients.Items.Clear();
                    while (reader.Read())
                    {
                        DateTime selected_Date = Convert.ToDateTime(selected_date);
                        DateTime database_date = Convert.ToDateTime(reader["DateOfDisease"].ToString());
                        if (selected_Date >= database_date)
                        {
                            if(User.UserId == Convert.ToInt32(reader["UserId"].ToString()))
                            {
                                ListViewItem add = new ListViewItem();
                                add.Text = reader["DiseaseName"].ToString();
                                add.SubItems.Add(reader["Description"].ToString());
                                add.SubItems.Add(reader["DateOfDisease"].ToString());
                                list_showforpatients.Items.Add(add);
                            }
                        }
                        
                    }
                }
            }
            connection.Close();
        }

        private void btn_results_Click(object sender, EventArgs e)
        {
            show_data();
        }
    }
}

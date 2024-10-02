using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class Diagnosis : Form
    {
        SqlConnection connection = new SqlConnection(SQLConnection.connectionString);
        public Diagnosis()
        {
            InitializeComponent();
        }

        private void addPatient_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            this.Hide();
            addPatient.Show();
        }

        private void myProfileButton_Click(object sender, EventArgs e)
        {
            MyProfile my = new MyProfile();
            this.Hide();
            my.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clear_evrything()
        {
            txt_birthday.Clear();
            txt_description.Clear();
            txt_firstname.Clear();
            txt_identification.Clear();
            txt_lastname.Clear();
            diseaseCombobox.SelectedItem = null;
        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            initInfo.Text = User.FirstName + " " + User.LastName;
            try
            {

                connection.Open();
                string query = "SELECT Specialization " +
                    "FROM Doctors " +
                    "WHERE UserId = @UserId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", User.UserId);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    branchLabel.Text = reader["Specialization"].ToString();
                }
                reader.Close();
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {

                connection.Close();
            }

           

            try
            {
                string query = "SELECT DiseaseName FROM Diseases";
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();
                        
                            // Check if the reader has rows
                            if (reader.HasRows)
                            {
                                // Clear existing items in the ComboBox
                                diseaseCombobox.Items.Clear();

                                // Loop through the rows and add them to the ComboBox
                                while (reader.Read())
                                {
                                    diseaseCombobox.Items.Add(reader["DiseaseName"].ToString());
                                }
                            }
                reader.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                connection.Close();
            }


            try
            {
                connection.Open();
                string queryPatient = "SELECT * FROM Users JOIN Patients on Users.UserId = Patients.UserId" +
                   " WHERE UserTypeId = @UserTypeId";

                SqlCommand commandPatient = new SqlCommand(queryPatient, connection);

               commandPatient.Parameters.AddWithValue("@UserTypeId",2);
              
                SqlDataReader reader2 = commandPatient.ExecuteReader();

                patientListView.View = View.Details;
                patientListView.GridLines = true;
                patientListView.FullRowSelect = true;

                patientListView.Columns.Add("PatientId");
                patientListView.Columns.Add("First Name");
                patientListView.Columns.Add("Last Name");
                patientListView.Columns.Add("Identification Number");
                patientListView.Columns.Add("Date Of Birth");

                foreach (ColumnHeader column in patientListView.Columns)
                {
                    column.Width = 80;
                }

                if (reader2.HasRows)
                {

                    patientListView.Items.Clear();

                    while (reader2.Read())
                    {
                        ListViewItem item = new ListViewItem(reader2["PatientId"].ToString());
                        item.SubItems.Add(reader2["FirstName"].ToString());
                        item.SubItems.Add(reader2["LastName"].ToString());
                        item.SubItems.Add(reader2["IdentificationNum"].ToString());
                        item.SubItems.Add(reader2["DateOfBirth"].ToString());

                        patientListView.Items.Add(item);
                    }
                }
                reader2.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            this.Hide();
            doctor.Show();
        }

        int patientId=-1;
        private void patientListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (patientListView.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedPatient = patientListView.SelectedItems[0];

                // Access sub-items (columns) and retrieve data
               txt_firstname.Text = selectedPatient.SubItems[1].Text;
                txt_lastname.Text = selectedPatient.SubItems[2].Text;
                txt_identification.Text = selectedPatient.SubItems[3].Text;
                txt_birthday.Text = selectedPatient.SubItems[4].Text;

                patientId= Convert.ToInt32( selectedPatient.SubItems[0].Text);

            }
        }

        int selected =-1;
        private void diseaseCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (diseaseCombobox.SelectedItem == null)
            {
                selected = selected + 0;
            }
            else
            {
                selected = takeDiseaseId(diseaseCombobox.SelectedItem.ToString());
            }
        }
        private int takeDiseaseId(string disease)
        {
            string a = "-1";
            connection.Open();
            string query2 = "Select * from Diseases where DiseaseName = @DiseaseName";

            SqlCommand command1 = new SqlCommand(query2, connection);
            command1.Parameters.AddWithValue("@DiseaseName", disease);

            SqlDataReader read = command1.ExecuteReader();
            while (read.Read())
            {
                a = read["DiseaseId"].ToString();
            }
            int b = int.Parse(a);
            connection.Close();
            return b;
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            if (patientId != -1)
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO PatientDiseases(PatientId,DiseaseId,Description,DateOfDisease) VALUES(@PatientID,@DiseaseID,@Description,@DateOfDisease)", connection);
                    command.Parameters.AddWithValue("@PatientID",patientId);
                    command.Parameters.AddWithValue("@DiseaseID", selected);
                    command.Parameters.AddWithValue("@Description", txt_description.Text);
                    command.Parameters.AddWithValue("@DateOfDisease", DateTime.Now);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfull added!");
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    Console.WriteLine(error);
                }
                finally
                {
                    connection.Close();
                }
                clear_evrything();
            }
           
        }
    }
}

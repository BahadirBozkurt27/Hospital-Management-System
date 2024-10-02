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
using System.Text.RegularExpressions;


namespace HospitalManagement
{
    public partial class AddPatient : Form
    {
        SqlConnection connection = new SqlConnection(SQLConnection.connectionString);
        public AddPatient()
        {
            InitializeComponent();
        }

        private void addDiagnosis_Click(object sender, EventArgs e)
        {
            Diagnosis diagnosis = new Diagnosis();
            this.Hide();
            diagnosis.Show();
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

        private void initInfo_Click(object sender, EventArgs e)
        {

        }

        private void clear_evrything()
        {
            nameTextBox.Clear();
            SurnameTextBox.Clear();
            IDTextBox.Clear();
            birthDateTimePicker.Value = DateTime.Now;
            femaleRadioButton.Checked = false;
            maleradiobutton.Checked = false;
        }

        private void AddPatient_Load(object sender, EventArgs e)
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

        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[0-9]{11}$");
            Match match1 = regex.Match(IDTextBox.Text);

            if (match1.Success)
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Users(FirstName,LastName,Gender,Password,DateOfBirth,IdentificationNum,UserTypeId) VALUES(@FirstName, @LastName,@Gender,@Password, @DateOfBirth, @IdentificationNum,@UserTypeId)", connection);
                    command.Parameters.AddWithValue("@FirstName", nameTextBox.Text);
                    command.Parameters.AddWithValue("@LastName", SurnameTextBox.Text);
                    command.Parameters.AddWithValue("@DateOfBirth", birthDateTimePicker.Value);
                    command.Parameters.AddWithValue("@IdentificationNum", IDTextBox.Text);
                    command.Parameters.AddWithValue("@UserTypeId", 2);
                    command.Parameters.AddWithValue("@Password", IDTextBox.Text.Substring(0, 5));

                    if (femaleRadioButton.Checked)
                    {
                        command.Parameters.AddWithValue("@Gender", "female");
                    }
                    else if (maleradiobutton.Checked)
                    {
                        command.Parameters.AddWithValue("@Gender", "male");
                    }
                    command.ExecuteNonQuery();

                    MessageBox.Show("Successfull registered!");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Same Person");
                }
                finally
                {
                    connection.Close();
                }

                try
                {
                    connection.Open();
                    string query = "SELECT UserId FROM Users " +
                        "WHERE IdentificationNum = @IdentificationNum";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdentificationNum", IDTextBox.Text);
                    SqlDataReader reader = command.ExecuteReader();

                    int idNum = 0;
                    if (reader.Read())
                    {
                        idNum = Convert.ToInt32(reader["UserId"]);

                    }
                    reader.Close();

                    SqlCommand command1 = new SqlCommand("INSERT INTO Patients(UserId) VALUES(@PatientId)", connection);
                    command1.Parameters.AddWithValue("@PatientId", idNum);

                    command1.ExecuteNonQuery();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Same Person");
                }
                finally
                {
                    connection.Close();
                }
                clear_evrything();
            }
            else
            {
                MessageBox.Show("Enter an valid ID");
            }
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            this.Hide();
            doctor.Show();
        }
    }
}


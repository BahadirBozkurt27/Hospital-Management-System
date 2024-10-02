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
    public partial class MyProfile : Form
    {
        SqlConnection connection = new SqlConnection(SQLConnection.connectionString);
        public MyProfile()
        {
            InitializeComponent();
        }

        private void addPatient_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            this.Hide();
            addPatient.Show();
        }

        private void addDiagnosis_Click(object sender, EventArgs e)
        {
            Diagnosis diagnosis = new Diagnosis();
            this.Hide();
            diagnosis.Show();
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = User.FirstName;
            SurnameTextBox.Text = User.LastName;
            mailTextBox.Text = User.Email;
            passwordTextBox.Text = User.Password;
            

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
                    branchTextBox.Text = reader["Specialization"].ToString();
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "UPDATE Users SET FirstName=@FirstName, LastName=@LastName,Email=@Email,Password=@Password " +
                    "WHERE UserId = @UserId ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", User.UserId);
                command.Parameters.AddWithValue("@FirstName", nameTextBox.Text);
                command.Parameters.AddWithValue("@LastName", SurnameTextBox.Text);
                command.Parameters.AddWithValue("@Email", mailTextBox.Text);
                command.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                command.ExecuteNonQuery();
                


                string nonQuery = "UPDATE Doctors SET Specialization=@Specialization " +
                    "WHERE UserId = @UserId ";
                SqlCommand command2 = new SqlCommand(nonQuery, connection);
                command2.Parameters.AddWithValue("@UserId", User.UserId);
                command2.Parameters.AddWithValue("@Specialization", branchTextBox.Text);
                command2.ExecuteNonQuery();



                User.FirstName = nameTextBox.Text;
                User.LastName = SurnameTextBox.Text;
                User.Email = mailTextBox.Text;
                User.Password = passwordTextBox.Text;
                Doctor.branch = branchTextBox.Text;

                MessageBox.Show("Update successfully");

                
                branchLabel.Text = branchTextBox.Text;
                initInfo.Text = nameTextBox.Text + " " + SurnameTextBox.Text;


            }
            catch (Exception error)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        char? none = null;
        private void isVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (isVisible.Checked)
            {

                passwordTextBox.PasswordChar = Convert.ToChar(none);
            }
            else
            {

                passwordTextBox.PasswordChar = '*';
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != null)
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.PasswordChar = '*';

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            this.Hide();
            doctor.Show();
        }

        private void addPatient_Click_1(object sender, EventArgs e)
        {
            AddPatient patient = new AddPatient();
            this.Hide();
            patient.Show();
        }
    }
}

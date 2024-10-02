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
    public partial class Doctor : Form
    {
        public static string branch = "";
        SqlConnection connection = new SqlConnection(SQLConnection.connectionString);
        public Doctor()
        {
            InitializeComponent();
        }

        private void myProfileButton_Click(object sender, EventArgs e)
        {
            MyProfile my = new MyProfile();
            this.Hide();
            my.Show();

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

        private void Doctor_Load(object sender, EventArgs e)
        {
            initInfo.Text = User.FirstName + " "+ User.LastName;
            try
            {

                connection.Open();
                string query = "SELECT Specialization " +
                    "FROM Doctors "+
                    "WHERE UserId = @UserId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", User.UserId);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    
                    branch = reader["Specialization"].ToString();
                    branchLabel.Text = branch;
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
    }
}

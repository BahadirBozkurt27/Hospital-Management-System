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
    public partial class Register : Form
    {
        SqlConnection connection = new SqlConnection(SQLConnection.connectionString);

        public Register()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void genderGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[0-9]{11}$");
            Match match1 = regex.Match(IDTextBox.Text);

            if (match1.Success)
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Users(FirstName,LastName,Email,Password,DateOfBirth,IdentificationNum,UserTypeId,Gender) VALUES(@FirstName, @LastName, @Email,@Password, @DateOfBirth, @IdentificationNum,@UserTypeId,@Gender)", connection);
                    command.Parameters.AddWithValue("@FirstName", nameTextBox.Text);
                    command.Parameters.AddWithValue("@LastName", SurnameTextBox.Text);
                    command.Parameters.AddWithValue("@Email", mailTextBox.Text);
                    command.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                    command.Parameters.AddWithValue("@DateOfBirth", birthDateTimePicker.Value);
                    command.Parameters.AddWithValue("@IdentificationNum", IDTextBox.Text);
                    command.Parameters.AddWithValue("@UserTypeId", 2);

                    if (femaleRadioButton.Checked)
                    {
                        command.Parameters.AddWithValue("@Gender", "female");
                    }
                    else
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
                    Login login = new Login();
                    this.Hide();
                    login.Show();
                }
            }
            else
            {
                MessageBox.Show("Enter an valid ID value");
            }
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Register_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

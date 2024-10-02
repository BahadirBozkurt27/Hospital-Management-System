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
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection(SQLConnection.connectionString);
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // remember me için kaydedilen veriyi geçir:
            if (Properties.Settings.Default.Email != string.Empty)
            {
                //checkbox'u işaretleme kodu
                IDTextBox.Text = Properties.Settings.Default.Email;
                passwordTextBox.Text = Properties.Settings.Default.Password;

            }
            passwordTextBox.PasswordChar = '*';

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (rememberMe.Checked == true)
            {
                Properties.Settings.Default.Email = IDTextBox.Text;
                Properties.Settings.Default.Password = passwordTextBox.Text;
                Properties.Settings.Default.Save(); 
                //ayar olarak tut kodları(kaydet)
            }
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;

        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

       // bool isThere;
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string id = IDTextBox.Text;
                string pass = passwordTextBox.Text;

                string query = "SELECT Users.*, UserTypes.UserType " +
                       "FROM Users " +
                       "JOIN UserTypes ON Users.UserTypeId = UserTypes.UserTypeId " +
                       "WHERE Users.IdentificationNum = @IdentificationNum AND Users.Password = @Password";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdentificationNum", id);
                command.Parameters.AddWithValue("@Password", pass);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    User.Email = reader["Email"].ToString();
                    User.FirstName = reader["FirstName"].ToString();
                    User.LastName = reader["LastName"].ToString();
                    User.UserId = Convert.ToInt32(reader["UserId"]);
                    User.UserType = reader["UserType"].ToString();
                    User.Gender = reader["Gender"].ToString();
                    User.UserTypeId = Convert.ToInt32(reader["UserTypeId"]);
                    User.Password = reader["Password"].ToString();

                    if (User.UserTypeId == 1)
                    {
                        admin_form admin = new admin_form();
                        this.Hide();
                        admin.Show();
                    }

                    else if (User.UserTypeId == 2)
                    {
                        Patient patient = new Patient();
                        this.Hide();
                        patient.Show();
                    }
                    else if (User.UserTypeId == 3)
                    {
                        Doctor doc = new Doctor();
                        this.Hide();
                        doc.Show();
                    }
                    else if(User.UserTypeId !=1 || User.UserTypeId !=2 || User.UserTypeId != 3)
                    {
                        MessageBox.Show("You can't enter the system. Only Doctor, Admin, Patient");
                    }
                }
                else
                {
                    MessageBox.Show("Logged failed. \nCheck your email and password!");
                }
                reader.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error occured  " + error);
                Console.WriteLine(error.Message);
                
            }
            finally
            {
                connection.Close();
               
            }

        }
        char? none = null;
        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.ForeColor = Color.Silver;
                passwordTextBox.PasswordChar = Convert.ToChar(none);
            }
        }

        private void isVisible_CheckedChanged(object sender, EventArgs e)
        {
            if(isVisible.Checked)
            {

                passwordTextBox.PasswordChar = Convert.ToChar(none);
            }
            else
            {

                passwordTextBox.PasswordChar = '*';
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.PasswordChar = '*';

            }
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDTextBox_Enter(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "ID Number")
            {
                IDTextBox.Text = "";
                IDTextBox.ForeColor = Color.Black;

            }
        }

        private void IDTextBox_Leave(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "")
            {
                IDTextBox.Text = "ID Number";
                IDTextBox.ForeColor = Color.Silver;
            }
        }
    }
}

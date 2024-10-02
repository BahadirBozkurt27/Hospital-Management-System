using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class admin_form : Form
    {
        public int selected;
        public admin_form()
        {
            InitializeComponent();
        }

        //For fill combo box, we use this method
        private void admin_form_Load(object sender, EventArgs e)
        {
            fill_combo();
        }

        //open database connection in there.
        public static string connectionString = "Data Source=DESKTOP-IL5O1BA;Initial Catalog=HospitalManagementSystem;Integrated Security=true";
        SqlConnection connection = new SqlConnection(connectionString);

        //For filling combo box, method goes to usertypes table and take ol user type in there.
        //After that fill combobox with this types
        private void fill_combo()
        {
            connection.Open();

            string query1 = "Select * from UserTypes where UserType NOT IN('ADMIN', 'PATIENT')";
            SqlCommand command = new SqlCommand(query1, connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                combo_job.Items.Add(read["UserType"].ToString());
            }

            connection.Close();
        }

        //Delete and refresh for all tools.
        private void delete_everything()
        {
            txt_firstname.Clear();
            txt_lastname.Clear();
            txt_email.Clear();
            txt_identification.Clear();
            txt_search.Clear();
            txt_updateidentification.Clear();
            txt_deleteidentification.Clear();
            dt_dateBirth.Value = DateTime.Now;
            combo_job.SelectedItem = null;
        }

        //Method that fills the other tools with the values in the list view when the ID in the list view is clicked.
        private void list_show_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_show.SelectedItems.Count > 0)
            {
                ListViewItem item = list_show.SelectedItems[0];

                txt_identification.Text = item.SubItems[1].Text;
                txt_firstname.Text = item.SubItems[2].Text;
                txt_lastname.Text = item.SubItems[3].Text;
                combo_job.SelectedItem = item.SubItems[4].Text;
                DateTime.TryParse(item.SubItems[5].Text, out DateTime result);
                dt_dateBirth.Value = result;
                txt_email.Text = item.SubItems[6].Text;
            }
        }

        //Showing all data in "Users Database" according to list view
        private void show_data()
        {
            int user_type;
            list_show.GridLines = true;
            list_show.FullRowSelect = true;
            list_show.Items.Clear();
            delete_everything();
            try
            {
                connection.Open();
                string query = "Select * FROM Users JOIN UserTypes on Users.UserTypeId = UserTypes.UserTypeId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user_type = Convert.ToInt32(reader["UserTypeId"].ToString());
                            if (user_type != 1)
                            {
                                ListViewItem add = new ListViewItem();
                                add.Text = reader["UserID"].ToString();
                                add.SubItems.Add(reader["IdentificationNum"].ToString());
                                add.SubItems.Add(reader["FirstName"].ToString());
                                add.SubItems.Add(reader["LastName"].ToString());
                                add.SubItems.Add(reader["UserType"].ToString());
                                add.SubItems.Add(reader["DateOfBirth"].ToString());
                                add.SubItems.Add(reader["Email"].ToString());
                                list_show.Items.Add(add);
                            }
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ErrorSHOW {ex.Message}");
            }
        }

        //Listing all values button
        private void btn_listALL_Click(object sender, EventArgs e)
        {
            show_data();
        }

        //Delete every tools button
        private void btn_clear_Click(object sender, EventArgs e)
        {
            delete_everything();
        }

        //Retrieve the UserTypeId value corresponding to the selected UserType from the UserTypes database. In this part we use comboBOX
        //Next 2 method doing this expression
        private void combo_job_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combo_job.SelectedItem == null)
            {
                selected = selected + 0;
            }
            else
            {

                selected = take_typeid(combo_job.SelectedItem.ToString());
            }
        }

        private int take_typeid(string job)
        {
            string a = "-1";
            connection.Open();
            string query2 = "Select * from UserTypes where UserType = @usertype";

            SqlCommand command1 = new SqlCommand(query2, connection);
            command1.Parameters.AddWithValue("@usertype", job);

            SqlDataReader read = command1.ExecuteReader();
            while (read.Read())
            {
                a = read["UserTypeId"].ToString();
            }
            int b = int.Parse(a);
            connection.Close();
            return b;
        }

        //ADD Operation and control all values
        private void btn_add_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[0-9]{11}$");
            Match match1 = regex.Match(txt_identification.Text);

            Regex regex1 = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            Match match2 = regex1.Match(txt_email.Text);


            DateTime birthday = DateTime.Parse(dt_dateBirth.Text);
            try
            {
                connection.Open();
                if (match1.Success)
                {
                    if (match2.Success)
                    {
                        if (txt_identification.Text != "")
                        {
                            if (txt_firstname.Text != "")
                            {
                                if (txt_lastname.Text != "")
                                {
                                    if (combo_job.SelectedItem != null)
                                    {
                                        if (birthday != DateTime.Now)
                                        {
                                            try
                                            {
                                                string query = "INSERT INTO Users(UserTypeId, Password, FirstName, LastName, Email, IdentificationNum, DateOfBirth) " +
                                                    "values (@usertypeid,  @password, @Firstname, @Lastname, @email, @identificationNum, @birthdate) ";
                                                using (SqlCommand command = new SqlCommand(query, connection))
                                                {
                                                    string name = txt_firstname.Text.ToString();
                                                    command.Parameters.AddWithValue("@Firstname", name);

                                                    string surname = txt_lastname.Text.ToString();
                                                    command.Parameters.AddWithValue("@Lastname", surname);

                                                    string identification = txt_identification.Text.ToString();
                                                    command.Parameters.AddWithValue("@identificationNum", identification);

                                                    //Selected is an global variable. We use
                                                    command.Parameters.AddWithValue("usertypeid", selected);

                                                    command.Parameters.Add("@birthdate", SqlDbType.Date).Value = dt_dateBirth.Value.Date;

                                                    string e_mail = txt_email.Text.ToString();
                                                    command.Parameters.AddWithValue("@email", e_mail);

                                                    string password = identification.Substring(0, Math.Min(5, identification.Length));
                                                    command.Parameters.AddWithValue("@password", password);

                                                    command.ExecuteNonQuery();
                                                    MessageBox.Show("New Record!");
                                                    delete_everything();


                                                    if (selected == 3)
                                                    {
                                                        string queryDoc = "SELECT UserId FROM Users " +
                                                          "WHERE IdentificationNum = @IdentificationNum";

                                                        SqlCommand commandDoc = new SqlCommand(queryDoc, connection);
                                                        commandDoc.Parameters.AddWithValue("@IdentificationNum", identification);

                                                        SqlDataReader reader = commandDoc.ExecuteReader();

                                                        int idNum = 0;
                                                        if (reader.Read())
                                                        {
                                                            idNum = Convert.ToInt32(reader["UserId"]);

                                                        }
                                                        reader.Close();

                                                        SqlCommand command1 = new SqlCommand("INSERT INTO Doctors(UserId) VALUES(@DoctorId)", connection);
                                                        command1.Parameters.AddWithValue("@DoctorId", idNum);

                                                        command1.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine(ex.ToString());

                                                MessageBox.Show("SAME PERSON", "WARNING");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Enter the Birth Day", "WARNING");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Select Employee's JOB", "WARNING");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Enter the Last Name", "WARNING");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Enter the First Name", "WARNING");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter the Identification Number", "WARNING");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter an valid e_mail", "WARNING");
                    }
                }
                else
                {
                    MessageBox.Show("Enter an valid Identification Number", "WARNING");
                }
                connection.Close();
                show_data();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        //delete operation
        private void btn_delete_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[0-9]{11}$");
            Match match = regex.Match(txt_deleteidentification.Text);

            if (match.Success)
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Users WHERE IdentificationNum = @identificationNum";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@identificationNum", txt_deleteidentification.Text.ToString());
                        int rowsaffected = command.ExecuteNonQuery();

                        if (rowsaffected > 0)
                        {
                            MessageBox.Show("Deletion Operation Succesful");
                        }
                        else
                        {
                            MessageBox.Show("Not FOUND");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                MessageBox.Show("Enter an valid TC");
            }
            connection.Close();
            show_data();
        }

        //update operation
        private void btn_update_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[0-9]{11}$");
            Match match = regex.Match(txt_updateidentification.Text);

            try
            {
                connection.Open();
                if (match.Success)
                {
                    string query = "UPDATE Users SET FirstName = @Firstname, LastName = @Lastname, DateOfBirth = @birthdate, Email = @email, " +
                        "UserTypeId = @usertypeid WHERE IdentificationNum = @identificationNum ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        string name = txt_firstname.Text.ToString();
                        command.Parameters.AddWithValue("@Firstname", name);

                        string surname = txt_lastname.Text.ToString();
                        command.Parameters.AddWithValue("@Lastname", surname);

                        command.Parameters.Add("@birthdate", SqlDbType.Date).Value = dt_dateBirth.Value.Date;

                        string e_mail = txt_email.Text.ToString();
                        command.Parameters.AddWithValue("@email", e_mail);

                        string identification = txt_updateidentification.Text.ToString();
                        command.Parameters.AddWithValue("@identificationNum", identification);

                        command.Parameters.AddWithValue("@usertypeid", selected);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Update Operation Succesful");

                        connection.Close();
                        show_data();
                    }
                }
                else
                {
                    MessageBox.Show("Enter an valid Identification Number", "WARNING");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UPDATE CATCH");
                Console.WriteLine(ex);
            }
        }

        //search operation
        private void btn_list_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                string query = "Select * From Users JOIN  UserTypes on Users.UserTypeId = UserTypes.UserTypeId where FirstName like @firstname";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("firstname", "%" + txt_search.Text + "%");
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        list_show.Items.Clear();
                        while (reader.Read())
                        {
                            ListViewItem add = new ListViewItem();
                            add.Text = reader["UserID"].ToString();
                            add.SubItems.Add(reader["IdentificationNum"].ToString());
                            add.SubItems.Add(reader["FirstName"].ToString());
                            add.SubItems.Add(reader["LastName"].ToString());
                            add.SubItems.Add(reader["UserType"].ToString());
                            add.SubItems.Add(reader["DateOfBirth"].ToString());
                            add.SubItems.Add(reader["Email"].ToString());
                            list_show.Items.Add(add);
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminbackButton_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            back.Show();
            this.Hide();
        }
    }
}



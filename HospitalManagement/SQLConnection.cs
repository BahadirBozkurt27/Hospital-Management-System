using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace HospitalManagement
{
    public class SQLConnection
    {
      public static string connectionString = "Data Source=DESKTOP-IL5O1BA;Initial Catalog=HospitalManagementSystem;Integrated Security=true";

        public static void Create()
        {


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                   
                    connection.Open();

                    // Create UserTypes Table
                    ExecuteSqlCommand(connection, @"
                    CREATE TABLE UserTypes (
                        UserTypeId INT PRIMARY KEY,
                        UserType VARCHAR(50) NOT NULL
                    )");

                    // Insert User Types
                    ExecuteSqlCommand(connection, @"
                    INSERT INTO UserTypes (UserTypeId, UserType)
                    VALUES (1, 'ADMIN'),
                           (2, 'PATIENT'),
                           (3, 'DOCTOR'),
                           (4, 'NURSE'),
                           (5, 'TECHNICIANS'),
                           (6, 'CLEANER'),
                           (7, 'SUPPORT')");

                    // Create Users Table
                    ExecuteSqlCommand(connection, @"
                    CREATE TABLE Users (
                        UserId INT PRIMARY KEY IDENTITY(1,1),
                        UserTypeId INT,
                        Password VARCHAR(50) NOT NULL,
                        FirstName VARCHAR(50) NOT NULL,
                        LastName VARCHAR(50) NOT NULL,
                        Email VARCHAR(100),
                        Gender VARCHAR(10),
                        IdentificationNum VARCHAR(50) NOT NULL UNIQUE,
                        DateOfBirth DATE,
                        CONSTRAINT FK_UserTypes FOREIGN KEY (UserTypeId) REFERENCES UserTypes(UserTypeId)
                    )");

                    // Create Admins Table
                    ExecuteSqlCommand(connection, @"
                    CREATE TABLE Admins (
                        AdminId INT PRIMARY KEY IDENTITY(1,1),
                        UserId INT,
                        CONSTRAINT FK_Admins_Users FOREIGN KEY (UserId) REFERENCES Users(UserId)
                    )");

                    // Create Patients Table
                    ExecuteSqlCommand(connection, @"
                    CREATE TABLE Patients (
                        PatientId INT PRIMARY KEY IDENTITY(1,1),
                        UserId INT,
                        CONSTRAINT FK_Patients_Users FOREIGN KEY (UserId) REFERENCES Users(UserId)
                    )");

                    // Create Doctors Table
                    ExecuteSqlCommand(connection, @"
                    CREATE TABLE Doctors (
                        DoctorId INT PRIMARY KEY IDENTITY(1,1),
                        UserId INT,
                        Specialization VARCHAR(50),
                        CONSTRAINT FK_Doctors_Users FOREIGN KEY (UserId) REFERENCES Users(UserId)
                    )");

                    // Create Disease Table
                    ExecuteSqlCommand(connection, @"
                    CREATE TABLE Diseases (
                        DiseaseId INT PRIMARY KEY IDENTITY(1,1),
                        DiseaseName NVARCHAR(50)
                    )");

                    // Link Between Patients and Disease Table
                    ExecuteSqlCommand(connection, @"
                    CREATE TABLE PatientDiseases (
                        LinkID INT PRIMARY KEY IDENTITY(1,1),
                        PatientId INT,
                        DiseaseId INT,
                        Description VARCHAR(100),
                        DateOfDisease DATE,

                        CONSTRAINT FK_Diseases_PatientDiseases FOREIGN KEY (DiseaseId) REFERENCES Diseases(DiseaseId),
                        CONSTRAINT FK_Patients_PatientDiseases FOREIGN KEY (PatientId) REFERENCES Patients(PatientId)
                    )");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void ExecuteSqlCommand(SqlConnection connection, string commandText)
        {
            using (SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}

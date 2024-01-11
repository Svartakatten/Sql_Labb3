using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Data;
using System.Data.SqlClient;
using Sql_Labb3.Data;
using Sql_Labb3.Models;

namespace Sql_Labb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Getting connection...");

            //string connectionString = "Data Source=(localdb)\\TestDatabase;Database=SchoolDatabase;Trusted_Connection=True;";

            //using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            //{
            //try
            //{
            SchoolDatabaseContext context = new();


            //sqlConnection.Open();

            Console.WriteLine("Please, choose one of the options");

            Console.WriteLine("1. Get info on Personel");

            Console.WriteLine("2. Get info on Students");

            Console.WriteLine("3. Get info on Students by class");

            Console.WriteLine("4. Get info on Grades");

            Console.WriteLine("5. Get info on Subjects");

            Console.WriteLine("6. Add new students");

            Console.WriteLine("7. Add new Personel");

            int input = Int32.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Do you wish to see all or a specific role inside Personal? write a 1 for all and 2 for teachers");

                    int categoryinput = Int32.Parse(Console.ReadLine());

                    if (categoryinput == 1)
                    {

                        var persons = context.People
                                            .Where(p => p.PersonId > 0)
                                            .OrderBy(p => p.FirstName);
                        foreach (Person p in persons)
                        {
                            Console.WriteLine($"Persons ID:     {p.PersonId}");
                            Console.WriteLine($"Firstname:     {p.FirstName}");
                            Console.WriteLine($"Lastname:     {p.LastName}");
                            Console.WriteLine($"Hire date:     {p.HireDate}");
                            Console.WriteLine($"Phone:     {p.Phone}");
                            Console.WriteLine($"Discriminator:     {p.Discriminator}");

                        }

                        //SqlCommand cmd = new SqlCommand("SELECT * FROM Person", sqlConnection);

                        //SqlDataReader myReader = cmd.ExecuteReader();
                        //do
                        //{
                        //    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}", myReader.GetName(1), myReader.GetName(2), myReader.GetName(3), myReader.GetName(4), myReader.GetName(5));
                        //    while (myReader.Read()) Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}", myReader.GetString(1), myReader.GetString(2), myReader?.GetDateTime(3), myReader?.GetString(4), myReader.GetString(5));
                        //}
                        //while (myReader.NextResult());
                        //myReader.Close();
                    }
                    else if (categoryinput == 2)
                    {

                        var persons = context.People
                                        .Where(p => p.Discriminator == "Teacher");

                        foreach (Person p in persons)
                        {
                            Console.WriteLine($"Persons ID:     {p.PersonId}");
                            Console.WriteLine($"Firstname:     {p.FirstName}");
                            Console.WriteLine($"Lastname:     {p.LastName}");
                            Console.WriteLine($"Hire date:     {p.HireDate}");
                            Console.WriteLine($"Phone:     {p.Phone}");
                            Console.WriteLine($"Discriminator:     {p.Discriminator}");
                        }

                        //SqlCommand cmd2 = new SqlCommand("SELECT * FROM Person WHERE Discriminator = 'Teacher'", sqlConnection);

                        //SqlDataReader myReader = cmd2.ExecuteReader();
                        //do
                        //{
                        //    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", myReader.GetName(1), myReader.GetName(2), myReader.GetName(3), myReader.GetName(5));
                        //    while (myReader.Read()) Console.WriteLine("\t{0}\t\t{1}\t{2}\t\t{3}", myReader.GetString(1), myReader.GetString(2), myReader.GetSqlDateTime(3), myReader.GetString(5));
                        //}
                        //while (myReader.NextResult());
                        //myReader.Close();
                    }
                    else
                    {
                        Console.WriteLine("Please choose one of the options");
                    }

                    break;
                case 2:

                    Console.WriteLine("Do you wish to see Students based on firstname,lastname,descending or ascending. Please type 1,2,3 or 4");

                    int answer = Int32.Parse(Console.ReadLine());
                    if (answer == 1)
                    {
                        var students = context.Students
                                            .Where(p => p.StudentsId > 0)
                                            .OrderBy(p => p.FirstName);
                        foreach (Student p in students)
                        {
                            Console.WriteLine($"Students ID:     {p.StudentsId}");
                            Console.WriteLine($"Firstname:     {p.FirstName}");
                            Console.WriteLine($"Lastname:     {p.LastName}");
                            Console.WriteLine($"EnrollmentDate:     {p.EnrollmentDate}");
                            Console.WriteLine($"Adress:     {p.Adress}");
                            Console.WriteLine($"Phone:     {p.Phone}");
                            Console.WriteLine($"Email:     {p.Email}");
                            Console.WriteLine($"Class:     {p.Class}");
                        }
                    }
                    else if (answer == 2)
                    {
                        var students1 = context.Students
                                            .Where(p => p.StudentsId > 0)
                                            .OrderBy(p => p.LastName);
                        foreach (Student p in students1)
                        {
                            Console.WriteLine($"Students ID:     {p.StudentsId}");
                            Console.WriteLine($"Firstname:     {p.FirstName}");
                            Console.WriteLine($"Lastname:     {p.LastName}");
                            Console.WriteLine($"EnrollmentDate:     {p.EnrollmentDate}");
                            Console.WriteLine($"Adress:     {p.Adress}");
                            Console.WriteLine($"Phone:     {p.Phone}");
                            Console.WriteLine($"Email:     {p.Email}");
                            Console.WriteLine($"Class:     {p.Class}");
                        }
                    }
                    else if (answer == 3)
                    {
                        var students2 = context.Students
                                            .Where(p => p.StudentsId > 0)
                                            .OrderByDescending(p => p.StudentsId);
                        foreach (Student p in students2)
                        {
                            Console.WriteLine($"Students ID:     {p.StudentsId}");
                            Console.WriteLine($"Firstname:     {p.FirstName}");
                            Console.WriteLine($"Lastname:     {p.LastName}");
                            Console.WriteLine($"EnrollmentDate:     {p.EnrollmentDate}");
                            Console.WriteLine($"Adress:     {p.Adress}");
                            Console.WriteLine($"Phone:     {p.Phone}");
                            Console.WriteLine($"Email:     {p.Email}");
                            Console.WriteLine($"Class:     {p.Class}");
                        }
                    }
                    else if (answer == 4)
                    {
                        var students3 = context.Students
                                            .Where(p => p.StudentsId > 0)
                                            .OrderBy(p => p.StudentsId);
                        foreach (Student p in students3)
                        {
                            Console.WriteLine($"Students ID:     {p.StudentsId}");
                            Console.WriteLine($"Firstname:     {p.FirstName}");
                            Console.WriteLine($"Lastname:     {p.LastName}");
                            Console.WriteLine($"EnrollmentDate:     {p.EnrollmentDate}");
                            Console.WriteLine($"Adress:     {p.Adress}");
                            Console.WriteLine($"Phone:     {p.Phone}");
                            Console.WriteLine($"Email:     {p.Email}");
                            Console.WriteLine($"Class:     {p.Class}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please choose one of the options");
                    }
                    break;
                case 3:

                    var students4 = context.Students
                                            .Where(p => p.StudentsId > 0)
                                            .OrderBy(p => p.Class);
                    foreach (Student p in students4)
                    {
                        Console.WriteLine($"Email:     {p.Class}");
                    }
                    Console.WriteLine("Choose a class to filter students on");

                    string filter = Console.ReadLine();

                    Func<dynamic, dynamic> orderingFunction = p =>
                        filter == "Class" ? p.Class : "";

                    var students5 = context.Students
                                            .Where(p => p.Class.Contains(filter))
                                            .OrderBy(orderingFunction);

                    foreach (Student p in students5)
                    {
                        Console.WriteLine($"Students ID:     {p.StudentsId}");
                        Console.WriteLine($"Firstname:     {p.FirstName}");
                        Console.WriteLine($"Lastname:     {p.LastName}");
                        Console.WriteLine($"EnrollmentDate:     {p.EnrollmentDate}");
                        Console.WriteLine($"Adress:     {p.Adress}");
                        Console.WriteLine($"Phone:     {p.Phone}");
                        Console.WriteLine($"Email:     {p.Email}");
                        Console.WriteLine($"Class:     {p.Class}");
                    }

                    break;
                case 4:

                    var grades = context.StudentGrades
                                        .Where(p => p.EnrollmentId > 0)
                                        .OrderBy(p => p.Grade);
                    foreach (StudentGrade p in grades)
                    {
                        Console.WriteLine($"Enrollment ID:     {p.EnrollmentId}");
                        Console.WriteLine($"Course ID:     {p.CourseId}");
                        Console.WriteLine($"Student ID:     {p.StudentId}");
                        Console.WriteLine($"Grade:     {p.Grade}");


                    }

                    //SqlCommand cmd7 = new SqlCommand("SELECT * FROM StudentGrade", sqlConnection);

                    //SqlDataReader Grades = cmd7.ExecuteReader();
                    //do
                    //{
                    //    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", Grades.GetName(0), Grades.GetName(1), Grades.GetName(2), Grades.GetName(3));
                    //    while (Grades.Read()) Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t\t{3}", Grades.GetInt32(0), Grades.GetInt32(1), Grades.GetInt32(2), Grades.GetDecimal(3));
                    //}
                    //while (Grades.NextResult());
                    //Grades.Close();
                    break;
                case 5:


                    var courses = context.Courses
                                            .Where(p => p.CourseId != null)
                                            .OrderBy(p => p.CourseId)
                                            .ToList();

                    foreach (Course p in courses)
                    {
                        Console.WriteLine("Courses");
                        Console.WriteLine($"Course ID:     {p.CourseId}");
                        Console.WriteLine($"Title:     {p.Title}");
                        Console.WriteLine($"Points:     {p.Points}");
                        Console.WriteLine($"DepartmentId:     {p.DepartmentId}");
                    }

                    var avg = context.StudentGrades
                              .Where(p => p.CourseId > 0)
                            .Average(p => p.Grade);

                    Console.WriteLine($"Average Grade:     {avg}");

                    var grades1 = context.StudentGrades
                                            .Where(p => p.CourseId != null)
                                            .OrderBy(p => p.Grade);


                    foreach (StudentGrade p in grades1)
                    {
                        Console.WriteLine($"EnrollmentID:     {p.EnrollmentId}");
                        Console.WriteLine($"Course ID:     {p.CourseId}");
                        Console.WriteLine($"Student ID:     {p.StudentId}");
                        Console.WriteLine($"Grade:     {p.Grade}");
                    }

                    break;
                case 6:
                    Console.WriteLine("Already existing people");

                    var students6 = context.Students
                                            .Where(p => p.StudentsId > 0);

                    foreach (Student p in students6)
                    {
                        Console.WriteLine($"Students ID:     {p.StudentsId}");
                        Console.WriteLine($"Firstname:     {p.FirstName}");
                        Console.WriteLine($"Lastname:     {p.LastName}");
                        Console.WriteLine($"EnrollmentDate:     {p.EnrollmentDate}");
                        Console.WriteLine($"Adress:     {p.Adress}");
                        Console.WriteLine($"Phone:     {p.Phone}");
                        Console.WriteLine($"Email:     {p.Email}");
                        Console.WriteLine($"Class:     {p.Class}");
                    }

                    //SqlCommand cmd3 = new SqlCommand("SELECT * FROM Person", sqlConnection);

                    //SqlDataReader checker = cmd3.ExecuteReader();
                    //do
                    //{
                    //    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", checker.GetName(0), checker.GetName(1), checker.GetName(2), checker.GetName(4), checker.GetName(5));
                    //    while (checker.Read()) Console.WriteLine("\t{0}\t\t{1}\t{2}\t\t{3}", checker.GetInt32(0), checker.GetString(1), checker.GetString(2), checker.GetSqlDateTime(4), checker.GetString(5));
                    //}
                    //while (checker.NextResult());
                    //checker.Close();

                    Console.WriteLine("FirstName");

                    string firstname = Console.ReadLine();

                    Console.WriteLine("LastName");

                    string lastname = Console.ReadLine();

                    Console.WriteLine("EnrollmentDate");

                    DateTime enrollmentDate = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Adress");

                    string adress = Console.ReadLine();

                    Console.WriteLine("Phone");

                    string phone = Console.ReadLine();

                    Console.WriteLine("Email");

                    string email = Console.ReadLine();

                    Console.WriteLine("Class");

                    string studentClass = Console.ReadLine();

                    Student student = new Student { FirstName = firstname, LastName = lastname, EnrollmentDate = enrollmentDate, Adress = adress, Phone = phone, Email = email, Class = studentClass };

                    context.Add(student);

                    context.SaveChanges();


                    //string str = "INSERT INTO dbo.Students (PersonID, FirstName, LastName, EnrollmentDate, Adress, Phone, Email, Class)\r\nVALUES ('" + studentsID + "','" + firstname + "', '" + lastname + "', '" + enrollmentDate + "', '" + adress + "', '" + phone + "','" + email + "','" + studentClass + "')";

                    //SqlCommand cmd4 = new SqlCommand(str, sqlConnection);

                    //cmd4.ExecuteNonQuery();

                    break;
                case 7:


                    Console.WriteLine("FirstName");

                    string firstname1 = Console.ReadLine();

                    Console.WriteLine("LastName");

                    string lastname1 = Console.ReadLine();

                    Console.WriteLine("Hire Date");

                    DateTime hiredate = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Phone");

                    string phone1 = Console.ReadLine();

                    Console.WriteLine("Discriminator");

                    string discriminator = Console.ReadLine();

                    Person person = new Person { FirstName = firstname1, LastName = lastname1, HireDate = hiredate, Phone = phone1, Discriminator = discriminator };

                    context.Add(person);

                    context.SaveChanges();

                    break;
            }

        }

        //}
        //catch (Exception ex)
        //{
        // Console.WriteLine("Det fungerar inte bra");
        // Console.WriteLine(ex.Message);
        // }


    }
}




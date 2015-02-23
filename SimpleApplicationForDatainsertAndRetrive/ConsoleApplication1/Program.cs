using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Configuration;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StudentConsoleApp student = new StudentConsoleApp();
            Console.WriteLine("Name:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Email");
            student.Email = Console.ReadLine();
            Console.WriteLine("Address");
            student.Address = Console.ReadLine();

            string url = @"server=faruk\SQLEXPRESS;database=student;integrated security=true";
            SqlConnection connection = new SqlConnection(url);
            connection.Open();

            string query = string.Format("insert into t_student values('{0}','{1}','{2}')", student.Name, student.Email,student.Address);

            SqlCommand command = new SqlCommand(query, connection);

           int affectedRow = command.ExecuteNonQuery();

            if (affectedRow > 0)
            {
                Console.WriteLine("Data saved");
            }
            else
            {
                Console.WriteLine("some problems");
            }

            Console.WriteLine("please press n to show data");
            string n = Console.ReadLine();
            if (n == "n")
            {
                String q = "select * from t_student";

                SqlCommand command1 = new SqlCommand(q, connection);
                SqlDataReader aReader = command1.ExecuteReader();

                List<StudentConsoleApp> students = new List<StudentConsoleApp>();

                string msg = "\nName\tEmail\tAddres\n";

                if (aReader.HasRows)
                {
                    while (aReader.Read())
                    {
                        student.Name = aReader[0].ToString();
                        student.Email = aReader[1].ToString();
                        student.Address = aReader[2].ToString();
                        msg += student.Name + "\t" + student.Email + "\t" + student.Address + "\n";
                    }
                    Console.WriteLine(msg);
                    Console.ReadLine();
                }
            }
        }
    }
}
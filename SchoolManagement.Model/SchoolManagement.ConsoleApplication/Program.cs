using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.Manager;
using SchoolManagement.Model;

namespace SchoolManagement.ConsoleApplication
{
    class Program
    {
        private static string userInput;

        static void Main(string[] args)
        {
            Student aStudent=new Student();

            Console.WriteLine("************please give your input************");
            Console.WriteLine("Name: ");
            aStudent.Name = Console.ReadLine();
            Console.WriteLine("Phone : ");
            aStudent.Phone = Console.ReadLine();
            Console.WriteLine("Address : ");
            aStudent.Address = Console.ReadLine();


            StudentManager manager=new StudentManager();
            manager.Add(aStudent);
            Console.WriteLine("data Saved");

            Console.WriteLine("Please input s to show data");
            userInput = Console.ReadLine();

            if (userInput == "s")
            {
                string msg = "\nId :\tName :\tPhone :\tAddress\n";
                List<Student> students = manager.GetStudent();

                if (students != null)
                foreach (Student s in students)
                {
                    msg += s.Id + "\t" + s.Name + " \t" + s.Phone + "\t" + s.Address + "\n";
                   
                }
                Console.WriteLine(msg);
            }

            Console.WriteLine("give a Id number to delete a entry");
            userInput = Console.ReadLine();
            manager.Delete(Convert.ToInt32(userInput));
            Console.WriteLine("Entry deleted");

            Console.ReadLine();
        }
    }
}

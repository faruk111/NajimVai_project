using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.Model;

namespace SchoolManagement.Manager
{
   public class StudentManager
   {
       private SchoolManagementDbEntities1 Db;

       public StudentManager()
       {
            Db=new SchoolManagementDbEntities1();
       }

       public void Add(Student student)
       {
           DbSet<Student> students = Db.Students;

           students.Add(student);
           Db.SaveChanges();
       }

       public void Delete(int id)
       {
           Student s = Db.Students.FirstOrDefault(student => student.Id == id);
           if (s != null)
           {
               Db.Students.Remove(s);
           }
           Db.SaveChanges();
       }

       public List<Student> GetStudent()
       {
           return Db.Students.ToList();
       } 
    }
}

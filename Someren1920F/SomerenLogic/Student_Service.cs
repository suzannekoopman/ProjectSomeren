using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Student_Service
    {
        Student_DAO student_db = new Student_DAO();

        public List<Student> GetStudents()
        {
            try
            {
                List<Student> student = student_db.Db_Get_All_Students();
                return student;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Student> student = new List<Student>();
                Student a = new Student();
                a.StudentNumber = 639567;
                a.FirstName = "FirstName";
                a.LastName = "LastName";
                a.Class = "A";
                a.Address = "IJmuiden";
                a.PhoneNumber = 06;
                student.Add(a);

                return student;
                //    a. = DateTime.Parse("1990-07-04");
                //throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}

using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Lecturer_Service
    {
        Lecturer_DAO lecturer_db = new Lecturer_DAO();

        public List<Teacher> GetLecturers()
        {
            try
            {
                List<Teacher> lecturer = lecturer_db.Db_Get_All_Lecturers();
                return lecturer;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Teacher> lecturer = new List<Teacher>();
                Teacher a = new Teacher();
                a.FirstName = "Mr. Test Lecturer";
                a.LecturerNumber = 1234;
                lecturer.Add(a);

                Teacher b = new Teacher();
                b.FirstName = "Mrs. Test Lecturer";
                b.LecturerNumber = 5678;
                lecturer.Add(b);
                return lecturer;
                //throw new Exception("Someren couldn't connect to the database");
            }
        }
    }
}


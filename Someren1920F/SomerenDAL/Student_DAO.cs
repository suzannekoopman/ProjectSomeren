using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class Student_DAO : Base
    {

        public List<Student> Db_Get_All_Students()
        {
            string query = "SELECT StudentId, Class, First_Name, Last_Name, RoomId, Address, City FROM [Students]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    StudentNumber = (int)dr["StudentId"],
                    Class = (String)dr["Class"].ToString(),
                    FirstName = (String)(dr["First_Name"].ToString()),
                    LastName = (String)(dr["Last_Name"].ToString()),
                    RoomNumber = (int)dr["RoomId"],
                    Address = (String)(dr["Address"].ToString()),
                    City = (String)(dr["City"].ToString())
                };
                students.Add(student);
            }
            return students;
        }

    }
}

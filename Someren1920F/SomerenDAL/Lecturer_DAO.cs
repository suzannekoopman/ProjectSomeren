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
    public class Lecturer_DAO : Base
    {
        public List<Teacher> Db_Get_All_Lecturers()
        {
            string query = "SELECT LecturerId, First_Name, Last_Name, Address, City, RoomId  FROM Lecturers";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    LecturerNumber = (int)dr["LecturerId"],
                    FirstName = (String)(dr["First_Name"].ToString()),
                    LastName = (String)(dr["Last_Name"].ToString()),
                    Address = (String)(dr["Address"].ToString()),
                    City = (String)(dr["City"].ToString()),
                    RoomNumber = (int)(dr["RoomId"])
                };
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}

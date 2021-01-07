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
    public class KamerIndeling_DAO : Base
    {

        public List<KamerIndeling> Db_Get_All_KamerIndelings_Students()
        {
            string query = "SELECT S.RoomId, S.First_Name, S.Last_Name, R.Capacity " +
                           "FROM Students AS S " +
                           "JOIN Rooms AS R ON S.RoomId = R.RoomId " +
                           "ORDER BY RoomId, Capacity";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<KamerIndeling> Db_Get_All_KamerIndelings_Lecturers()
        {
            string query = "SELECT S.RoomId, S.First_Name, S.Last_Name, R.Capacity " +
                           "FROM Lecturers AS S " +
                           "JOIN Rooms AS R ON S.RoomId = R.RoomId " +
                           "ORDER BY RoomId, Capacity";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<KamerIndeling> ReadTables(DataTable dataTable)
        {
            List<KamerIndeling> kamerindelings = new List<KamerIndeling>();

            foreach (DataRow dr in dataTable.Rows)
            {
                KamerIndeling Kamerindelings = new KamerIndeling()
                {
                    RoomNumber = (int)dr["RoomId"],
                    FirstName = (String)dr["First_Name"],
                    LastName = (String)dr["Last_Name"],
                    Capacity = (int)dr["Capacity"]
                };
                kamerindelings.Add(Kamerindelings);
            }
            return kamerindelings;
        }
    }
}

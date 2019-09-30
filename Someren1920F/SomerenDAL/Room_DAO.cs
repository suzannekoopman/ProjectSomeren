using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
    public class Room_DAO : Base
    {

        public List<Room> Db_Get_All_Rooms()
        {
            string query = "SELECT RoomId, Capacity, Type FROM Rooms";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room()
                {
                    RoomNumber = (int)dr["RoomId"],
                    Capacity = (int)dr["Capacity"],
                    Type = (bool)(dr["Type"])
                };
                rooms.Add(room);
            }
            return rooms;
        }
    }
}

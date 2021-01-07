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
    public class WeekRooster_DAO : Base
    {

        public List<RoosterItem> Db_Get_All_RoosterItems()
        {
            string query = "SELECT [Description], l.First_Name, l.Last_Name, s.startTime, s.endTime, s.[Date]" +
                            "FROM [Activity] AS a " +
                            "join [Schedule] AS s ON s.Activity = a.Id " +
                            "join SuperVisor AS sv ON sv.SuperVisorId = s.SuperVisor " +
                            "join Lecturers as l ON l.LecturerId = sv.LecturerId";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<RoosterItem> ReadTables(DataTable dataTable)
        {
            List<RoosterItem> roosterItems = new List<RoosterItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                RoosterItem roosterItem = new RoosterItem()
                {
                    Description = (String)dr["Description"].ToString(),
                    First_Name = (String)dr["First_Name"].ToString(),
                    Last_Name = (String)dr["Last_Name"].ToString(),
                    StartTime = (TimeSpan)dr["startTime"],
                    EndTime = (TimeSpan)dr["endTime"],
                    Date = (DateTime)dr["Date"]

                };
                roosterItems.Add(roosterItem);
            }
            return roosterItems;
        }

    }
}

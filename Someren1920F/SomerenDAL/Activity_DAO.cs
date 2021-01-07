using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;
using System.Configuration;

namespace SomerenDAL
{
    public class Activity_DAO : Base
    {
        public List<Activity> Db_Get_All_Activity()
        {
            string query = "SELECT Id, Description, AantalStudenten, AantalBegeleider FROM [Activity]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    Id = (int)dr["Id"],
                    Description = (String)dr["Description"].ToString(),
                    AantalStudenten = (int)(dr["AantalStudenten"]),
                    AantalBegeleider = (int)(dr["AantalBegeleider"]),
                };
                activities.Add(activity);
            }
            return activities;
        }

        public List<ActivityFromTeacher> Db_Get_Teacher_SuperVisorId(int docentenNumber)
        {
            string query = $"SELECT LecturerId, a.[Description] FROM SuperVisor AS s join Activity AS a ON s.SuperVisorId = a.Id WHERE LecturerId = {docentenNumber}; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesSuperVisorId(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<ActivityFromTeacher> ReadTablesSuperVisorId(DataTable dataTable)
        {
            List<ActivityFromTeacher> activiteiten = new List<ActivityFromTeacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                ActivityFromTeacher Teachers_Activity = new ActivityFromTeacher()
                {
                    LecturerId = (int)dr["LecturerId"],
                    Description = (String)dr["Description"]
                };
                activiteiten.Add(Teachers_Activity);
            }
            return activiteiten;
        }

        public void wijzigBegeleier(Activity a, Activity b)
        {
            String wijzigQuery = $"DELETE FROM Schedule " +
                                 $"WHERE Activity = {a.Id} " +
                                 
                                 $"INSERT INTO Schedule(Activity, SuperVisor, Date, startTime, endTime) " +
                                 $"VALUES({b.Id}, {b.Schedule.SuperVisor}, '2017-04-10', '10:00:00', '11:00:00')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            ExecuteEditQuery(wijzigQuery, sqlParameters);
        }


        public void WijzigActiviteit(Activity activity)
        {
            String wijzigQuery = $"UPDATE Activity SET Description = '{activity.Description}', AantalStudenten = {activity.AantalStudenten}, AantalBegeleider = {activity.AantalBegeleider} WHERE Id = {activity.Id}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            ExecuteEditQuery(wijzigQuery, sqlParameters);
        }

        public void VerwijderActiviteit(int ActivityId)
        {
            String verwijderQuery = $"DELETE FROM Activity WHERE Id = {ActivityId}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            ExecuteEditQuery(verwijderQuery, sqlParameters);
        }

        public void ToevoegenActiviteit(Activity activity)
        {
            String toevoegenQuery = $"INSERT INTO Activity ( Id, Description, AantalStudenten, AantalBegeleider ) VALUES ( {activity.Id}, '{activity.Description}', {activity.AantalStudenten}, {activity.AantalBegeleider})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            ExecuteEditQuery(toevoegenQuery, sqlParameters);
        }
    }
}

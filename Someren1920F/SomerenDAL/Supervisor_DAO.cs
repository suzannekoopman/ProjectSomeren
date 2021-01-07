using System;
using SomerenModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;

namespace SomerenDAL
{
    public class Supervisor_DAO : Base
    {
        public List<Supervisor> Db_Get_All_Supervisors()
        {
            string query = "SELECT LecturerId, SuperVisorId FROM SuperVisor";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Supervisor> ReadTables(DataTable dataTable)
        {
            List<Supervisor> supervisors = new List<Supervisor>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Supervisor supervisor = new Supervisor()
                {
                    LecturerNumber = (int)dr["LecturerId"],
                    SupervisorNumber = (int)dr["SuperVisorId"]
                };
                supervisors.Add(supervisor);
            }
            return supervisors;
        }

        public void VerwijderSupervisor(int LecturerId)
        {
            String verwijderQuery = $"DELETE FROM SuperVisor WHERE Id = {LecturerId}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            ExecuteEditQuery(verwijderQuery, sqlParameters);
        }

        public void ToevoegenSupervisor(Supervisor supervisor)
        {
            String toevoegenQuery = $"INSERT INTO SuperVisor ( SuperVisorId, LecturerId ) VALUES ( {supervisor.SupervisorNumber}, '{supervisor.LecturerNumber}')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            ExecuteEditQuery(toevoegenQuery, sqlParameters);
        }
    }
}


using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Supervisors_Service
    {
        Supervisor_DAO SuperVisor_db = new Supervisor_DAO();

        public List<Supervisor> GetSupervisors()
        {
            try
            {
                List<Supervisor> supervisors = SuperVisor_db.Db_Get_All_Supervisors();
                return supervisors;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake supervisor to the list to make sure the rest of the application continues working!
                List<Supervisor> supervisors = new List<Supervisor>();
                Supervisor s = new Supervisor();
                s.SupervisorNumber = 56489;
                s.LecturerNumber = 1234;
                supervisors.Add(s);

                return supervisors;
                //throw new Exception("Someren couldn't connect to the database");
            }
        }

        public void DeleteSupervisor(int Id)
        {
            SuperVisor_db.VerwijderSupervisor(Id);
        }

        public void AddActivity(Supervisor supervisor)
        {
            SuperVisor_db.ToevoegenSupervisor(supervisor);
        }
    }
}

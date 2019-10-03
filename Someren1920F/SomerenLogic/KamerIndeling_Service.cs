using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;
using SomerenDAL;

namespace SomerenLogic
{
    
    public class KamerIndeling_Service
    {
        KamerIndeling_DAO kamerIndeling_db = new KamerIndeling_DAO();

        public List<KamerIndeling> GetKamerIndelings()
        {
            try
            {
                List<KamerIndeling> kamerindeling = kamerIndeling_db.Db_Get_All_KamerIndelings();
                return kamerindeling;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<KamerIndeling> kamerindeling = new List<KamerIndeling>();
                KamerIndeling a = new KamerIndeling();
                a.FirstName = "Mr. Test Lecturer";
                a.LastName = "Mr. Test KamerIndeling";
                a.RoomNumber = 63;
                kamerindeling.Add(a);

                KamerIndeling b = new KamerIndeling();
                b.FirstName = "Ms. Test Lecturer";
                b.LastName = "Ms. Test KamerIndeling";
                b.RoomNumber = 64;
                kamerindeling.Add(b);
                return kamerindeling;
                //throw new Exception("Someren couldn't connect to the database");
            }
        }
    }
}

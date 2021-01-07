using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class WeekRooster_Service
    {
        WeekRooster_DAO activity_db = new WeekRooster_DAO();

        public List<RoosterItem> GetRoosterItems()
        {
            try
            {
                List<RoosterItem> roosterItems = activity_db.Db_Get_All_RoosterItems();
                return roosterItems;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<RoosterItem> roosterItems = new List<RoosterItem>();
                RoosterItem a = new RoosterItem();
                a.Description = "Fout";
                a.First_Name = "Fout";
                a.Last_Name = "Fout";
                a.StartTime = TimeSpan.MinValue;
                a.EndTime = TimeSpan.MinValue;
                a.Date = DateTime.Now;

                return roosterItems;

            }

        }
    }
}

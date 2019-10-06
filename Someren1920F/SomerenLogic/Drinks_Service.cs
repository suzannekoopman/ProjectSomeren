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
    public class Drinks_Service
    {
        Drinks_DAO drinks_db = new Drinks_DAO();

        public List<Drinks> GetDrinks()
        {
            try
            {
                List<Drinks> drinks = drinks_db.Db_Get_All_Drinks();
                return drinks;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Drinks> drinks = new List<Drinks>();
                Drinks d = new Drinks();
                d.Name = "Oepsie";
                d.Price = 1.69f;
                d.Stock = 0;
                d.BTW = 0;
                drinks.Add(d);

                return drinks;
                //throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}

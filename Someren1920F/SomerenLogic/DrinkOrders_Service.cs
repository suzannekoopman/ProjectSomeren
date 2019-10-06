using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class DrinkOrders_Service
    {
            DrinkOrders_DAO drinkorders_db = new DrinkOrders_DAO();

            public List<DrinkOrders> GetDrinkOrders()
            {
                try
                {
                    List<DrinkOrders> drinkorders = drinkorders_db.Db_Get_All_DrinkOrders();
                    return drinkorders;
                }
                catch (Exception)
                {
                    // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                    List<DrinkOrders> drinkorders = new List<DrinkOrders>();
                    DrinkOrders a = new DrinkOrders();

                    return drinkorders;
                }
            }
    }
}

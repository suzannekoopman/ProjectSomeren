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
    public class DrinkOrders_DAO : Base
    {
        public List<DrinkOrders> Db_Get_All_DrinkOrders()
        {
            string query = "SELECT DrinkName, StudentId, Amount, DateTime FROM DrinkOrders";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<DrinkOrders> ReadTables(DataTable dataTable)
        {
            List<DrinkOrders> drinkorders = new List<DrinkOrders>();

            foreach (DataRow dr in dataTable.Rows)
            {
                DrinkOrders order = new DrinkOrders()
                {
                    DrinkName = (String)dr["DrinkName"],
                    StudentId = (int)dr["StudentId"],
                    Amount = (int)dr["Amount"],
                    dateTime = (DateTime)dr["DateTime"]
                };
                drinkorders.Add(order);
            }
            return drinkorders;
        }

        public void OrderDrink(String drinkName, int studentId, int amount)
        {
            String orderQuery = $"INSERT INTO DrinkOrders VALUES ('{drinkName}', {studentId}, {amount}, '{DateTime.Today}')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            ExecuteEditQuery(orderQuery, sqlParameters);

            String updateDrinks = $"UPDATE Drinks SET Stock = Stock - {amount} WHERE Name = '{drinkName}'";
            OpenConnection();
            ExecuteEditQuery(updateDrinks, sqlParameters);
        }
    }
}
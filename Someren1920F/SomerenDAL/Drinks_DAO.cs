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
    public class Drinks_DAO : Base
    {

        public List<Drinks> Db_Get_All_Drinks()
        {
            string query = "SELECT Name, Stock, Price, BTW FROM Drinks";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        }

        private List<Drinks> ReadTables(DataTable dataTable)
        {
            List<Drinks> drinks = new List<Drinks>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drinks drink = new Drinks()
                {
                    Name = (String)dr["Name"],
                    Stock = (int)dr["Stock"],
                    Price = (float)dr["Price"],
                    BTW = (int)dr["BTW"],
                };
                drinks.Add(drink);
            }
            return drinks;
        }

    }
}

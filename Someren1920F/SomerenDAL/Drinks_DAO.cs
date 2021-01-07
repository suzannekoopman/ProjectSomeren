using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class Drinks_DAO : Base
    {

        public List<Drinks> Db_Get_All_Drinks()
        {
            string query = "SELECT Name, Stock, Price, BTW FROM Drinks WHERE Stock > 0 AND Price > 1 ORDER BY Stock, Price";
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
                    Naam = (String)dr["Name"],
                    Voorraad = (int)dr["Stock"],
                    Prijs = (int)dr["Price"],
                    BTW = (int)dr["BTW"],
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}

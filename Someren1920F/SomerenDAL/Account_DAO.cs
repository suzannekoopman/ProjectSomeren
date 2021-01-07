using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class Account_DAO : Base
    {
        public List<Account> Db_Get_All_Accounts()
        {
            string query = "SELECT Gebruikersnaam, Hash, AdminStatus, Vraag, Antwoord FROM Account";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Account> ReadTables(DataTable dataTable)
        {
            List<Account> accounts = new List<Account>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Account account = new Account()
                {
                    Gebruikersnaam = (String)dr["Gebruikersnaam"],
                    Wachtwoord = (String)dr["Hash"],
                    AdminStatus = (String)dr["AdminStatus"],
                    Vraag = (String)dr["Vraag"],
                    Antwoord = (String)dr["Antwoord"]
                };
                accounts.Add(account);
            }
            return accounts;
        }

        public void AddAccount(Account account)
        {

            String toevoegenQuery = $"INSERT INTO Account ( Gebruikersnaam, Hash, AdminStatus, Vraag, Antwoord, Salt ) VALUES ( '{account.Gebruikersnaam}', '{account.Wachtwoord}', '{account.AdminStatus}', '{account.Vraag}', '{account.Antwoord}', '{account.Salt}')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            ExecuteEditQuery(toevoegenQuery, sqlParameters);
        }

        public string AdminStatus(string username)
        {
            string query = $"SELECT AdminStatus FROM Account WHERE Gebruikersnaam = '{username}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            Account currentAccount = new Account();
            DataTable table = ExecuteSelectQuery(query, sqlParameters);
            foreach (DataRow dr in table.Rows)
            {
                currentAccount.AdminStatus = (String)dr["AdminStatus"];
            }
            return currentAccount.AdminStatus;
        }

        public void DeleteAccount(string gebruikersnaam)
        {
            String query = $"DELETE FROM Account WHERE Gebruikersnaam = '{gebruikersnaam}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            ExecuteEditQuery(query, sqlParameters);
        }

        public void AlterAccount(string gebruikersnaam, string toChange, string newValue)
        {
            String query = $"UPDATE Account SET {toChange} = '{newValue}' WHERE Gebruikersnaam = '{gebruikersnaam}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            ExecuteEditQuery(query, sqlParameters);
        }

        public void AlterPassword(string gebruikersnaam, string hash, string salt)
        {
            String query = $"UPDATE Account SET Hash = '{hash}' WHERE Gebruikersnaam = '{gebruikersnaam}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            ExecuteEditQuery(query, sqlParameters);

            String query2 = $"UPDATE Account SET Salt = '{salt}' WHERE Gebruikersnaam = '{gebruikersnaam}'";
            SqlParameter[] sqlParameters2 = new SqlParameter[0];
            OpenConnection();
            ExecuteEditQuery(query2, sqlParameters2);
        }

        public string Antwoord(Account account)
        {
            String AntwoordQuery = $"select Antwoord from Account where Gebruikersnaam = '{account.gebruikersnaam}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            DataTable readAntwoord = ExecuteSelectQuery(AntwoordQuery, sqlParameters);
            foreach (DataRow dr in readAntwoord.Rows)
            {
                account.Antwoord = (String)dr["Antwoord"];
            }
            return account.Antwoord;
        }

        public string Vraag(Account account)
        {
            String VraagQuery = $"select Vraag from Account where Gebruikersnaam = '{account.gebruikersnaam}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            DataTable readVraag = ExecuteSelectQuery(VraagQuery, sqlParameters);
            foreach (DataRow dr in readVraag.Rows)
            {
                account.Vraag = (String)dr["Vraag"];
            }
            return account.Vraag;
        }

        public string GetSalt(Account account)
        {
            String query = $"SELECT Salt From Account WHERE Gebruikersnaam = '{account.Gebruikersnaam}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            DataTable acc = ExecuteSelectQuery(query, sqlParameters);
            foreach (DataRow dr in acc.Rows)
            {
                account.Salt = (String)dr["Salt"];
            }
            return account.Salt;
        }


    }
}

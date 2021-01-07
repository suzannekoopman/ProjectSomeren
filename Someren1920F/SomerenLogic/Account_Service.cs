using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Account_Service
    {
        Account_DAO account_db = new Account_DAO();

        public List<Account> GetAccounts()
        {
            try
            {
                List<Account> account = account_db.Db_Get_All_Accounts();
                return account;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Account> account = new List<Account>();
                Account a = new Account();
                a.Gebruikersnaam = "Pieter";
                a.Wachtwoord = "Welkom01";
                account.Add(a);

                return account;
                //throw new Exception("Someren couldn't connect to the database");
            }

        }

        public bool CheckAccounts(Account account)
        {
            if (GetAccounts().Contains(account))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void AccountToevoegen(Account account)
        {
            account_db.AddAccount(account);
        }

        public bool CheckAdmin(string username)
        {
            return (account_db.AdminStatus(username) == "admin");
        }

        public void DeleteAccount(string gebruikersnaam)
        {
            account_db.DeleteAccount(gebruikersnaam);
        }

        public void AlterAccount(string gebruikersnaam, string toChange, string newValue)
        {
            account_db.AlterAccount(gebruikersnaam, toChange, newValue);
        }

        public void AlterPassword(string gebruikersnaam, string hash, string salt)
        {
            account_db.AlterPassword(gebruikersnaam, hash, salt);
        }

        public string ForgotPassword_vraag(Account account)
        {
            return account_db.Vraag(account);
        }

        public string ForgotPassword_antwoord(Account account)
        {
            return account_db.Antwoord(account);
        }

        public string GetSalt(Account account)
        {
            return account_db.GetSalt(account);
        }


    }
}

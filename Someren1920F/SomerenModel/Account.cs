using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Account
    {
        public string gebruikersnaam;
        public string wachtwoord;
        
        public String AdminStatus { get; set; }
        public String Vraag { get; set; }
        public String Antwoord { get; set; }
        public String Salt { get; set; }

        public Account()
        {
        }

        public Account(string txt_gebruikersnaam, string txt_wachtwoord)
        {
            Gebruikersnaam = txt_gebruikersnaam;
            Wachtwoord = txt_wachtwoord;
        }

        public string Wachtwoord
        {
            set { wachtwoord = value; }
            get { return wachtwoord; } 
        }

        public string Gebruikersnaam
        {
            get { return gebruikersnaam; }
            set
            {
                if (Gebruikersnaam != "")
                {
                    gebruikersnaam = value;
                }
                else
                {
                    throw new Exception($"Fout {value}.. Probeer opnieuw:");
                }
            }
        }

        public string PrintError()
        {
            return "Foute combinatie van de gebruikersnaam en/of wachtwoord";
        }


    }

}

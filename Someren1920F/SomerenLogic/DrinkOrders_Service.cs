using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenLogic
{
    public class DrinkOrders_Service
    {
        DrinkOrders_DAO drinkorders_db = new DrinkOrders_DAO();
        public List<DrinkOrders> DrinkOrders;
        public int afzet;
        public double omzet;
        public List<string> AantalKlantenDuplicateNamesOut = new List<string>();
        public int aantalklanten;

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

        public void BestelDrank(String drinkName, int studentId, int amount)
        {
            drinkorders_db.OrderDrink(drinkName, studentId, amount);



        }

        public List<DrinkOrders> GetDrinkOrdersDate(SelectionRange sr)
        {
            try
            {
                List<DrinkOrders> drinkorders = drinkorders_db.Db_Get_All_DrinkOrders();
                List<DrinkOrders> drinkorders_DateTimeMatch = new List<DrinkOrders>();

                foreach (DrinkOrders drinks in drinkorders)
                {
                    if ((drinks.dateTime >= sr.Start) && (drinks.dateTime <= sr.End))
                    {
                        drinkorders_DateTimeMatch.Add(drinks);
                        Afzet(drinks);
                        Omzet(drinks);
                        AantalKlanten(drinks);
                    }
                }

                return drinkorders_DateTimeMatch;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<DrinkOrders> drinkorders = new List<DrinkOrders>();
                DrinkOrders a = new DrinkOrders();
                a.DrinkName = "ColaCatch";
                a.StudentId = 6666;
                a.Amount = 8;
                a.dateTime = DateTime.Now;
                drinkorders.Add(a);

                return drinkorders;
            }
        }

        public void Afzet(DrinkOrders drink)
        {
            afzet += drink.Amount;
        }

        public void Omzet(DrinkOrders drink)
        {
            //  omzet += afzet * drink.Price; /// ?? Price toevoegen aan database
        }

        public void AantalKlanten(DrinkOrders drink)
        {
            if (AantalKlantenDuplicateNamesOut.Contains(drink.StudentId.ToString()))
            {
            }
            else
            {
                aantalklanten++;
                AantalKlantenDuplicateNamesOut.Add(drink.StudentId.ToString());
            }
        }
        public double BerekenBTWLaag(DateTime beginDatum, DateTime eindDatum)
        {
            List<DrinkOrders> alleOrders = GetDrinkOrders();
            Drinks_Service d = new Drinks_Service();
            List<Drinks> alleDranken = d.GetDrinks();
            //Drinks dranken = new Drinks();


            double totaalprijs = 0;
            double totaalBtwLaag = 0;
            foreach (DrinkOrders order in alleOrders)
            {
                if (order.dateTime >= beginDatum && order.dateTime < eindDatum)
                {
                    string drankNaam = order.DrinkName;
                    double hoeveel = order.Amount;
                    int btw = 6;
                    double prijs = 0;
                    double orderprijs;

                    foreach (Drinks drink in alleDranken)
                    {
                        if (drink.Naam == drankNaam && drink.BTW == 6)
                        {

                            prijs += drink.Prijs;

                            orderprijs = hoeveel * prijs;
                            totaalprijs += orderprijs;
                            totaalBtwLaag = totaalBtwLaag + (btw * 0.01 * orderprijs);
                        }

                    }

                }
            }
            return totaalBtwLaag;

        }
        public double BerekenBTWHoog(DateTime beginDatum, DateTime eindDatum)
        {
            List<DrinkOrders> alleOrders = GetDrinkOrders();
            Drinks_Service d = new Drinks_Service();
            List<Drinks> alleDranken = d.GetDrinks();
            //Drinks dranken = new Drinks();


            double totaalprijs = 0;

            double totaalBtwHoog = 0;
            foreach (DrinkOrders order in alleOrders)
            {
                if (order.dateTime >= beginDatum && order.dateTime < eindDatum)
                {
                    string drankNaam = order.DrinkName;
                    double hoeveel = order.Amount;
                    int btw = 21;
                    double prijs = 0;
                    double orderprijs;

                    foreach (Drinks drink in alleDranken)
                    {
                        if (drink.Naam == drankNaam && drink.BTW == 21)
                        {
  
                            prijs += drink.Prijs;

                            orderprijs = hoeveel * prijs;
                            totaalprijs += orderprijs;
                            totaalBtwHoog = totaalBtwHoog + (btw * 0.01 * orderprijs);
                        }


                    }
                }
            }
            return totaalBtwHoog;
        }
    }
}
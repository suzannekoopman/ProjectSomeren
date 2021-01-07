using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public int docentNumber = 0;
        public bool loginComplete = false;

        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {
            if (panelName == "Dashboard")
            {
                // hide all other panels
                pnl_Students.Hide();
                pnl_Drinks.Hide();
                pnl_Rooms.Hide();
                pnl_Lecturers.Hide();
                pnl_KamerIndeling.Hide();
                pnl_omzetrapportage.Hide();
                pnl_DrankVoorraad.Hide();
                pnl_btwBerekening.Hide();
                pnl_weekRooster.Hide();
                pnl_Begeleiders.Hide();
                pnl_Activiteitenlijst.Hide();
                pnl_Activities_SubMenuItem_Docenten.Hide();
                pnl_AdminTrue.Hide();
                pnl_AdminFalse.Hide();

                // show dashboard
                pnl_Dashboard.Show();
                //img_Dashboard.Show();
            }
            else if (panelName == "Studenten")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                //img_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_Lecturers.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Drinks.Hide();
                pnl_omzetrapportage.Hide();
                pnl_DrankVoorraad.Hide();
                pnl_btwBerekening.Hide();
                pnl_weekRooster.Hide();
                pnl_Begeleiders.Hide();
                pnl_Activiteitenlijst.Hide();
                pnl_Activities_SubMenuItem_Docenten.Hide();
                pnl_AdminTrue.Hide();
                pnl_AdminFalse.Hide();

                // show students
                pnl_Students.Show();



                // fill the students listview within the students panel with a list of students
                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.GetStudents();

                // clear the listview before filling it again
                listViewStudents.Clear();

                foreach (SomerenModel.Student s in studentList)
                {

                    ListViewItem li = new ListViewItem(s.StudentNumber.ToString());
                    li.SubItems.Add(s.Class);
                    li.SubItems.Add(s.FirstName);
                    li.SubItems.Add(s.LastName);
                    li.SubItems.Add(s.RoomNumber.ToString());
                    li.SubItems.Add(s.Address.ToString());
                    li.SubItems.Add(s.City.ToString());
                    listViewStudents.Items.Add(li);
                }
            }
            else if (panelName == "Kamers")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                //img_Dashboard.Hide();
                pnl_Students.Hide();
                pnl_Lecturers.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Drinks.Hide();
                pnl_omzetrapportage.Hide();
                pnl_DrankVoorraad.Hide();
                pnl_btwBerekening.Hide();
                pnl_weekRooster.Hide();
                pnl_Begeleiders.Hide();
                pnl_Activiteitenlijst.Hide();
                pnl_Activities_SubMenuItem_Docenten.Hide();
                pnl_AdminTrue.Hide();
                pnl_AdminFalse.Hide();

                // show rooms
                pnl_Rooms.Show();

                // fill the students listview within the students panel with a list of students
                SomerenLogic.Room_Service roomService = new SomerenLogic.Room_Service();
                List<Room> RoomList = roomService.GetRooms();

                // clear the listview before filling it again
                listViewRooms.Clear();

                foreach (SomerenModel.Room r in RoomList)
                {
                    ListViewItem li = new ListViewItem(r.RoomNumber.ToString());
                    li.SubItems.Add(r.Capacity.ToString());

                    if (r.Type == false)
                    { li.SubItems.Add("Student"); }
                    else 
                    { li.SubItems.Add("Docent"); }
                    listViewRooms.Items.Add(li);
                }
            }
            else if (panelName == "Docenten")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                pnl_Students.Hide();
                ////img_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Drinks.Hide();
                pnl_omzetrapportage.Hide();
                pnl_DrankVoorraad.Hide();
                pnl_btwBerekening.Hide();
                pnl_weekRooster.Hide();
                pnl_Begeleiders.Hide();
                pnl_Activiteitenlijst.Hide();
                pnl_Activities_SubMenuItem_Docenten.Hide();
                pnl_AdminTrue.Hide();
                pnl_AdminFalse.Hide();

                // show lecturers
                pnl_Lecturers.Show();

                // fill the lecturers listview within the lecturers panel with a list of lecturers
                SomerenLogic.Lecturer_Service lectService = new SomerenLogic.Lecturer_Service();
                List<Teacher> lecturerList = lectService.GetLecturers();

                // clear the listview before filling it again
                listViewLecturers.Clear();
                foreach (SomerenModel.Teacher s in lecturerList)
                {

                    ListViewItem li = new ListViewItem(s.LecturerNumber.ToString());
                    li.SubItems.Add(s.FirstName);
                    li.SubItems.Add(s.LastName);
                    li.SubItems.Add(s.Address);
                    li.SubItems.Add(s.City);
                    li.SubItems.Add(s.RoomNumber.ToString());
                    listViewLecturers.Items.Add(li);
                }

            }
            else if (panelName == "Kamerindeling")
            {
                pnl_Dashboard.Hide();
                pnl_Students.Hide();
                //img_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_Lecturers.Hide();
                pnl_Drinks.Hide();
                pnl_omzetrapportage.Hide();
                pnl_DrankVoorraad.Hide();
                pnl_btwBerekening.Hide();
                pnl_weekRooster.Hide();
                pnl_Begeleiders.Hide();
                pnl_Activiteitenlijst.Hide();
                pnl_Activities_SubMenuItem_Docenten.Hide();
                pnl_AdminTrue.Hide();
                pnl_AdminFalse.Hide();

                // show KamerIndeling

                pnl_KamerIndeling.Show();

                SomerenLogic.KamerIndeling_Service kamerIndelingService = new SomerenLogic.KamerIndeling_Service();
                List<KamerIndeling> KamerIndelingList = kamerIndelingService.GetKamerIndelings();
                
                // clear the listview before filling it again

                foreach (SomerenModel.KamerIndeling k in KamerIndelingList)
                {
                    
                    ListViewItem li = new ListViewItem(k.RoomNumber.ToString());
                    li.SubItems.Add(k.FirstName);
                    li.SubItems.Add(k.LastName);
                    li.SubItems.Add(k.Capacity.ToString());
                    listViewKamerIndeling.Items.Add(li);
                    
                }
            }
            else if (panelName == "Kassa")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                //img_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_Lecturers.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Students.Hide();
                pnl_omzetrapportage.Hide();
                pnl_DrankVoorraad.Hide();
                pnl_btwBerekening.Hide();
                pnl_weekRooster.Hide();
                pnl_Begeleiders.Hide();
                pnl_Activiteitenlijst.Hide();
                pnl_Activities_SubMenuItem_Docenten.Hide();
                pnl_AdminTrue.Hide();
                pnl_AdminFalse.Hide();

                // show drinks
                pnl_Drinks.Show();

                // fill the students listview within the students panel with a list of students
                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.GetStudents();

                // clear the listview before filling it again
                listViewStudentDrinks.Clear();

                foreach (SomerenModel.Student s in studentList)
                {

                    ListViewItem li = new ListViewItem(s.StudentNumber.ToString());
                    li.SubItems.Add(s.FirstName);
                    li.SubItems.Add(s.LastName);
                    listViewStudentDrinks.Items.Add(li);
                }

                // fill the drinks listview within the drinks panel with a list of drinks
                SomerenLogic.Drinks_Service drinksService = new SomerenLogic.Drinks_Service();
                List<Drinks> drinkList = drinksService.GetDrinks();

                // clear the listview before filling it again
                listViewDrinks.Clear();

                foreach (SomerenModel.Drinks d in drinkList)
                {
                    ListViewItem li = new ListViewItem(d.Naam);
                    li.SubItems.Add(d.Voorraad.ToString());
                    li.SubItems.Add(d.Prijs.ToString());
                    li.SubItems.Add(d.BTW.ToString());
                    listViewDrinks.Items.Add(li);
                }

            }
            else if (panelName == "Drankvoorraad")
            {
                pnl_Dashboard.Hide();
                //img_Dashboard.Hide();
                pnl_Students.Hide();
                pnl_Lecturers.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Drinks.Hide();
                pnl_Rooms.Hide();
                pnl_omzetrapportage.Hide();
                pnl_btwBerekening.Hide();
                pnl_weekRooster.Hide();
                pnl_Begeleiders.Hide();
                pnl_Activiteitenlijst.Hide();
                pnl_Activities_SubMenuItem_Docenten.Hide();
                pnl_AdminTrue.Hide();
                pnl_AdminFalse.Hide();

                pnl_DrankVoorraad.Show();

                SomerenLogic.Drinks_Service drinksService = new SomerenLogic.Drinks_Service();
                List<Drinks> drankVoorraadList = drinksService.GetDrinks();

                foreach (SomerenModel.Drinks d in drankVoorraadList)
                {
                    ListViewItem li = new ListViewItem(d.Naam);
                    li.SubItems.Add(d.Voorraad.ToString());
                    li.SubItems.Add(d.Prijs.ToString());
                    li.SubItems.Add(d.BTW.ToString());
                    listViewDrankVoorraad.Items.Add(li);
                }
            }
            else if (panelName == "Omzetrapportage")
            {
                pnl_Dashboard.Hide();
                //img_Dashboard.Hide();
                pnl_Students.Hide();
                pnl_Lecturers.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Drinks.Hide();
                pnl_Rooms.Hide();
                pnl_btwBerekening.Hide();
                pnl_omzetrapportage.Show();
                pnl_weekRooster.Hide();
                pnl_Begeleiders.Hide();
                pnl_Activiteitenlijst.Hide();
                pnl_Activities_SubMenuItem_Docenten.Hide();
                pnl_AdminTrue.Hide();
                pnl_AdminFalse.Hide();

                SomerenLogic.DrinkOrders_Service drinkOrdersService;
                List<DrinkOrders> drinkOrderList;

                if (!DrinkOrderListEmpty)
                {
                    drinkOrdersService = new SomerenLogic.DrinkOrders_Service();
                    drinkOrderList = drinkOrdersService.GetDrinkOrders();
                }
                else
                {
                    drinkOrdersService = new SomerenLogic.DrinkOrders_Service();
                    drinkOrderList = drinkOrdersService.GetDrinkOrdersDate(OrderDrinks_RangeData);
                }


                listViewomzetrapportage.Clear();

                foreach (SomerenModel.DrinkOrders Drinkorder in drinkOrderList)
                {
                    ListViewItem li = new ListViewItem(Drinkorder.DrinkName);
                    li.SubItems.Add(Drinkorder.StudentId.ToString());
                    li.SubItems.Add(Drinkorder.Amount.ToString());
                    li.SubItems.Add(Drinkorder.dateTime.ToString());
                    listViewomzetrapportage.Items.Add(li);
                }

                lbl_omzetrapportageAfzet.Text = ($"{drinkOrdersService.afzet}");
                lbl_omzetrapportageOmzet.Text = ($"{drinkOrdersService.omzet}");
                lbl_omzetrapportageAantalKlanten.Text = ($"{drinkOrdersService.aantalklanten}");
            }
            else if (panelName == "BTW Berekening")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                //img_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_Lecturers.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Students.Hide();
                pnl_Drinks.Hide();
                pnl_omzetrapportage.Hide();
                pnl_weekRooster.Hide();
                pnl_Begeleiders.Hide();
                pnl_Activiteitenlijst.Hide();
                pnl_Activities_SubMenuItem_Docenten.Hide();
                pnl_AdminTrue.Hide();
                pnl_AdminFalse.Hide();

                // show drinks
                pnl_btwBerekening.Show();


            }
            else if (panelName == "Begeleiders")
            {
                pnl_Dashboard.Hide();
                //img_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_Lecturers.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Students.Hide();
                pnl_Drinks.Hide();
                pnl_omzetrapportage.Hide();
                pnl_btwBerekening.Hide();
                pnl_weekRooster.Hide();
                pnl_Activiteitenlijst.Hide();
                pnl_Activities_SubMenuItem_Docenten.Hide();
                pnl_AdminTrue.Hide();
                pnl_AdminFalse.Hide();

                pnl_Begeleiders.Show();

                SomerenLogic.Supervisors_Service superService = new SomerenLogic.Supervisors_Service();
                List<Supervisor> supervisorList = superService.GetSupervisors();

                // clear the listview before filling it again
                listviewSupervisors.Clear();
                foreach (SomerenModel.Supervisor s in supervisorList)
                {

                    ListViewItem li = new ListViewItem(s.LecturerNumber.ToString());
                    li.SubItems.Add(s.SupervisorNumber.ToString());

                    listviewSupervisors.Items.Add(li);
                }
            }
            else if (panelName == "Activiteitenlijst")
            {
                pnl_Dashboard.Hide();
                //img_Dashboard.Hide();
                pnl_Students.Hide();
                pnl_Lecturers.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Drinks.Hide();
                pnl_Rooms.Hide();
                pnl_omzetrapportage.Hide();
                pnl_btwBerekening.Hide();
                pnl_DrankVoorraad.Hide();
                pnl_weekRooster.Hide();
                pnl_Activities_SubMenuItem_Docenten.Hide();
                pnl_AdminTrue.Hide();
                pnl_AdminFalse.Hide();

                pnl_Activiteitenlijst.Show();

                SomerenLogic.Activity_Service activityService = new SomerenLogic.Activity_Service();
                List<Activity> activitiesList = activityService.GetActivities();

                // clear the listview
                listViewActivities.Clear();

                foreach (SomerenModel.Activity a in activitiesList)
                {
                    ListViewItem li = new ListViewItem(a.Id.ToString());
                    li.SubItems.Add(a.Description);
                    li.SubItems.Add(a.AantalStudenten.ToString());
                    li.SubItems.Add(a.AantalBegeleider.ToString());
                    listViewActivities.Items.Add(li);
                }
            }
            else if (panelName == "WeekRooster")
            {
                pnl_Dashboard.Hide();
                //img_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_Lecturers.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Students.Hide();
                pnl_Drinks.Hide();
                pnl_omzetrapportage.Hide();
                pnl_btwBerekening.Hide();
                pnl_Activiteitenlijst.Hide();
                pnl_Activities_SubMenuItem_Docenten.Hide();
                pnl_AdminTrue.Hide();
                pnl_AdminFalse.Hide();
                pnl_Begeleiders.Hide();


                // expand cells
                dataGrid_weekRooster.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                for (int i = 7; i < 25; i++)
                {
                    dataGrid_weekRooster.Rows.Add(i + ":00");
                }

                pnl_weekRooster.Show();

                SomerenLogic.WeekRooster_Service studService = new SomerenLogic.WeekRooster_Service();
                List<RoosterItem> roosterItems = studService.GetRoosterItems();

                foreach (SomerenModel.RoosterItem a in roosterItems)
                {
                    int tijd = a.StartTime.Hours;
                    int day = (int)a.Date.DayOfWeek;

                    dataGrid_weekRooster.Rows[tijd - 7].Cells[day].Value = a.Description + System.Environment.NewLine + a.First_Name.Replace(" ", String.Empty) + " " + a.Last_Name;
                }
            }
            else if (panelName == "Docentenrooster")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                pnl_Students.Hide();
                ////img_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Drinks.Hide();
                pnl_omzetrapportage.Hide();
                pnl_DrankVoorraad.Hide();
                pnl_btwBerekening.Hide();
                pnl_Lecturers.Hide();
                listView_VervangendeDocent.Hide();
                lbl_VervangDocent.Hide();
                pnl_AdminTrue.Hide();
                pnl_AdminFalse.Hide();

                // show Docentenrooster
                pnl_Activities_SubMenuItem_Docenten.Show();

                // fill the lecturers listview within the lecturers panel with a list of lecturers
                SomerenLogic.Lecturer_Service lectService = new SomerenLogic.Lecturer_Service();
                List<Teacher> lecturerList = lectService.GetLecturers();

                // clear the listview before filling it again
                listViewDocentenSelecteren.Clear();
                foreach (SomerenModel.Teacher s in lecturerList)
                {
                    ListViewItem li = new ListViewItem(s.LecturerNumber.ToString());
                    li.SubItems.Add(s.FirstName);
                    li.SubItems.Add(s.LastName);
                    li.SubItems.Add(s.Address);
                    li.SubItems.Add(s.City);
                    li.SubItems.Add(s.RoomNumber.ToString());
                    listViewDocentenSelecteren.Items.Add(li);
                }
            }
            else if (panelName == "ActiviteitenLijstDocenten")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                pnl_Students.Hide();
                ////img_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Drinks.Hide();
                pnl_omzetrapportage.Hide();
                pnl_DrankVoorraad.Hide();
                pnl_btwBerekening.Hide();
                pnl_Lecturers.Hide();
                pnl_AdminTrue.Hide();
                pnl_AdminFalse.Hide();

                // show Docentenrooster
                pnl_Activities_SubMenuItem_Docenten.Show();

                if (docentNumber == 0)
                {
                    List<Activity> teacherActiviteitenLijst;
                    SomerenLogic.Activity_Service activiteitService = new SomerenLogic.Activity_Service();
                    teacherActiviteitenLijst = activiteitService.GetActivities();

                    listViewDocentenActiviteiten.Clear();
                    foreach (SomerenModel.Activity a in teacherActiviteitenLijst)
                    {
                        ListViewItem li = new ListViewItem(a.Id.ToString());
                        li.SubItems.Add(a.Description.ToString());

                        listViewDocentenActiviteiten.Items.Add(li);
                    }
                }
                else
                {
                    List<ActivityFromTeacher> teacherActiviteitenLijst;
                    SomerenLogic.Activity_Service activiteitService = new SomerenLogic.Activity_Service();
                    teacherActiviteitenLijst = activiteitService.Get_Teacher_SuperVisorId(docentNumber);

                    listViewDocentenActiviteiten.Clear();
                    foreach (SomerenModel.ActivityFromTeacher a in teacherActiviteitenLijst)
                    {
                        ListViewItem li = new ListViewItem(a.LecturerId.ToString());
                        li.SubItems.Add(a.Description.ToString());

                        listViewDocentenActiviteiten.Items.Add(li);
                    }
                }

            }
            else if (panelName == "DocentenNaamSelectie")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                pnl_Students.Hide();
                ////img_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Drinks.Hide();
                pnl_omzetrapportage.Hide();
                pnl_DrankVoorraad.Hide();
                pnl_btwBerekening.Hide();
                pnl_Lecturers.Hide();
                pnl_AdminTrue.Hide();
                pnl_AdminFalse.Hide();

                // show Docentenrooster
                pnl_Activities_SubMenuItem_Docenten.Show();

                // fill the lecturers listview within the lecturers panel with a list of lecturers
                SomerenLogic.Lecturer_Service lectService = new SomerenLogic.Lecturer_Service();
                List<Teacher> lecturerList = lectService.GetLecturers();

                // clear the listview before filling it again
                listView_VervangendeDocent.Clear();
                foreach (SomerenModel.Teacher s in lecturerList)
                {
                    ListViewItem li = new ListViewItem(s.LecturerNumber.ToString());
                    li.SubItems.Add(s.FirstName);
                    li.SubItems.Add(s.LastName);
                    listView_VervangendeDocent.Items.Add(li);
                }
            }
            else if (panelName == "ActiviteitenIndexVerandering")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                pnl_Students.Hide();
                ////img_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Drinks.Hide();
                pnl_omzetrapportage.Hide();
                pnl_DrankVoorraad.Hide();
                pnl_btwBerekening.Hide();
                pnl_Lecturers.Hide();
                pnl_AdminTrue.Hide();
                pnl_AdminFalse.Hide();


                // show Docentenrooster
                pnl_Activities_SubMenuItem_Docenten.Show();

                List<ActivityFromTeacher> Activities_Changed;
                SomerenLogic.Activity_Service activiteitService = new SomerenLogic.Activity_Service();
                Activities_Changed = activiteitService.Change_Activities(docentNumber, VervangendeDocentIndex);

                listViewDocentenActiviteiten.Clear();

                foreach (SomerenModel.ActivityFromTeacher a in Activities_Changed)
                {
                    ListViewItem li_A = new ListViewItem(a.LecturerId.ToString());
                    li_A.SubItems.Add(a.Description.ToString());

                    listViewDocentenActiviteiten.Items.Add(li_A);
                }
            }
            else if (panelName == "AdminFalse")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                pnl_Students.Hide();
                ////img_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Drinks.Hide();
                pnl_omzetrapportage.Hide();
                pnl_DrankVoorraad.Hide();
                pnl_btwBerekening.Hide();
                pnl_Lecturers.Hide();
                pnl_Activities_SubMenuItem_Docenten.Hide();
                pnl_AdminTrue.Hide();
                pnl_Activiteitenlijst.Hide();
                pnl_Begeleiders.Hide();
                pnl_weekRooster.Hide();


                pnl_AdminFalse.Show();

            }
            else if (panelName == "AdminTrue")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                pnl_Students.Hide();
                ////img_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Drinks.Hide();
                pnl_omzetrapportage.Hide();
                pnl_DrankVoorraad.Hide();
                pnl_btwBerekening.Hide();
                pnl_Lecturers.Hide();
                pnl_Activities_SubMenuItem_Docenten.Hide();
                pnl_AdminFalse.Hide();
                pnl_Activiteitenlijst.Hide();
                pnl_Begeleiders.Hide();
                pnl_weekRooster.Hide();

                pnl_AdminTrue.Show();


                SomerenLogic.Account_Service accountsService = new SomerenLogic.Account_Service();
                List<Account> accounts = accountsService.GetAccounts();

                // clear the listview before filling it again
                listView_Accounts.Clear();

                foreach (SomerenModel.Account a in accounts)
                {
                    ListViewItem li = new ListViewItem(a.Gebruikersnaam);
                    li.SubItems.Add(a.Wachtwoord);
                    li.SubItems.Add(a.AdminStatus);
                    li.SubItems.Add(a.Vraag);
                    li.SubItems.Add(a.Antwoord);
                    listView_Accounts.Items.Add(li);
                }
            }
        }
    

            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                showPanel("Dashboard");
            }

            private void img_Dashboard_Click(object sender, EventArgs e)
            {
                MessageBox.Show("What happens in Someren, stays in Someren!");
            }

            private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
            {
                showPanel("Studenten");
                listViewStudents.View = View.Details;

                listViewStudents.Columns.Add("Studentennummer", -2, HorizontalAlignment.Left);
                listViewStudents.Columns.Add("Klas", -2, HorizontalAlignment.Left);
                listViewStudents.Columns.Add("Voornaam", -2, HorizontalAlignment.Left);
                listViewStudents.Columns.Add("Achternaam", -2, HorizontalAlignment.Left);
                listViewStudents.Columns.Add("Kamernummer", -2, HorizontalAlignment.Left);
                listViewStudents.Columns.Add("Adres", -2, HorizontalAlignment.Left);
                listViewStudents.Columns.Add("Stad", -2, HorizontalAlignment.Left);

                listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
            {
                

            }

            private void lecturersToolStripMenuItem_Click_1(object sender, EventArgs e)
            {
                showPanel("Docenten");
                listViewLecturers.View = View.Details;
                listViewLecturers.Columns.Add("Docentennummer", -2, HorizontalAlignment.Left);
                listViewLecturers.Columns.Add("Voornaam", -2, HorizontalAlignment.Left);
                listViewLecturers.Columns.Add("Achternaam", -2, HorizontalAlignment.Left);
                listViewLecturers.Columns.Add("Adres", -2, HorizontalAlignment.Left);
                listViewLecturers.Columns.Add("Stad", -2, HorizontalAlignment.Left);
                listViewLecturers.Columns.Add("Kamernummer", -2, HorizontalAlignment.Left);

                listViewLecturers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listViewLecturers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        private void kassaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Kassa");

            listViewStudentDrinks.View = View.Details;

            listViewStudentDrinks.Columns.Add("Studentnummer", -2, HorizontalAlignment.Left);
            listViewStudentDrinks.Columns.Add("Voornaam", -2, HorizontalAlignment.Left);
            listViewStudentDrinks.Columns.Add("Achternaam", -2, HorizontalAlignment.Left);
            listViewStudentDrinks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewStudentDrinks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            listViewDrinks.View = View.Details;
            listViewDrinks.Columns.Add("Naam", -2, HorizontalAlignment.Left);
            listViewDrinks.Columns.Add("Voorraad", -2, HorizontalAlignment.Left);
            listViewDrinks.Columns.Add("Prijs", -2, HorizontalAlignment.Left);
            listViewDrinks.Columns.Add("BTW", -2, HorizontalAlignment.Left);
            listViewDrinks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewDrinks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnBestelDrinks_Click(object sender, EventArgs e)
        {
            int drinkAmount = (int)numericAmount.Value;
            DrinkOrders_Service newOrder = new DrinkOrders_Service();

            newOrder.BestelDrank(drankNaam, studentNumber, drinkAmount);

            kassaToolStripMenuItem_Click(sender, e);
        }

        public SelectionRange OrderDrinks_RangeData = new SelectionRange();
        public bool DrinkOrderListEmpty = false;

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DrinkOrderListEmpty = true;

            monthCalendar.SelectionRange.Start = DateTime.Parse(e.Start.ToShortDateString());
            OrderDrinks_RangeData.Start = monthCalendar.SelectionRange.Start;
            lbl_StartDate.Text = ($"{OrderDrinks_RangeData.Start}");

            monthCalendar.SelectionRange.End = DateTime.Parse(e.End.ToShortDateString());
            OrderDrinks_RangeData.End = monthCalendar.SelectionRange.End;
            lbl_EndDate.Text = ($"{OrderDrinks_RangeData.End}");

            showPanel("Omzetrapportage");
            listViewomzetrapportage.View = View.Details;
            listViewomzetrapportage.Columns.Add("Drankje", -2, HorizontalAlignment.Left);
            listViewomzetrapportage.Columns.Add("Studentnummer", -2, HorizontalAlignment.Left);
            listViewomzetrapportage.Columns.Add("Aantal", -2, HorizontalAlignment.Left);
            listViewomzetrapportage.Columns.Add("Data", -2, HorizontalAlignment.Left);

            listViewomzetrapportage.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewomzetrapportage.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void omzetrapportageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Omzetrapportage");

            listViewomzetrapportage.View = View.Details;

            listViewomzetrapportage.Columns.Add("Drankje", -2, HorizontalAlignment.Left);
            listViewomzetrapportage.Columns.Add("Studentnummer", -2, HorizontalAlignment.Left);
            listViewomzetrapportage.Columns.Add("Aantal", -2, HorizontalAlignment.Left);
            listViewomzetrapportage.Columns.Add("Data", -2, HorizontalAlignment.Left);

            listViewomzetrapportage.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewomzetrapportage.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        
        private void drankvoorraadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Drankvoorraad");

            listViewDrankVoorraad.View = View.Details;

            listViewDrankVoorraad.Columns.Add("Naam", -2, HorizontalAlignment.Left);
            listViewDrankVoorraad.Columns.Add("Voorraad", -2, HorizontalAlignment.Left);
            listViewDrankVoorraad.Columns.Add("Prijs", -2, HorizontalAlignment.Left);
            listViewDrankVoorraad.Columns.Add("BTW", -2, HorizontalAlignment.Left);

            listViewDrankVoorraad.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewDrankVoorraad.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        string drankNaam;

        private void listViewStudentDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            string student = listViewStudentDrinks.SelectedItems[0].Text;
            studentNumber = int.Parse(student);
        }

        int studentNumber;

        private void listViewDrinks_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            drankNaam = listViewDrinks.SelectedItems[0].Text;
            
        }

        private void begeleidersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Begeleiders");

            listviewSupervisors.View = View.Details;

            listviewSupervisors.Columns.Add("Docentennummer", -2, HorizontalAlignment.Left);
            listviewSupervisors.Columns.Add("Begeleidersnummer", -2, HorizontalAlignment.Left);

            listviewSupervisors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listviewSupervisors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void bTWBerekeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("BTW Berekening");
        }

        private void q1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_datum.Text = (" 01-01-2019 tot 01-04-2019 ");
            DrinkOrders_Service serv = new DrinkOrders_Service();
            double totaalBtwLaag = serv.BerekenBTWLaag(DateTime.Parse("01-01-2019 00:00:00"), DateTime.Parse("01-04-2019"));
            double totaalBtwHoog = serv.BerekenBTWHoog(DateTime.Parse("01-01-2019 00:00:00"), DateTime.Parse("01-04-2019"));
            lbl_btwLaag.Text = totaalBtwLaag.ToString("€0.00");
            lbl_btwHoog.Text = totaalBtwHoog.ToString("€0.00");

            double totaal = totaalBtwHoog + totaalBtwLaag;
            lbl_totaal.Text = totaal.ToString("€0.00");

        }

        private void q2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_datum.Text = (" 01-04-2019 tot 01-07-2019 ");
            DrinkOrders_Service serv = new DrinkOrders_Service();
            double totaalBtwLaag = serv.BerekenBTWLaag(DateTime.Parse("01-04-2019 00:00:00"), DateTime.Parse("01-07-2019"));
            double totaalBtwHoog = serv.BerekenBTWHoog(DateTime.Parse("01-04-2019 00:00:00"), DateTime.Parse("01-07-2019"));
            lbl_btwLaag.Text = totaalBtwLaag.ToString("€0.00");
            lbl_btwHoog.Text = totaalBtwHoog.ToString("€0.00");

            double totaal = totaalBtwHoog + totaalBtwLaag;
            lbl_totaal.Text = totaal.ToString("€0.00");
        }

        private void q3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_datum.Text = (" 01-07-2019 tot 01-10-2019 ");
            DrinkOrders_Service serv = new DrinkOrders_Service();
            double totaalBtwLaag = serv.BerekenBTWLaag(DateTime.Parse("01-07-2019 00:00:00"), DateTime.Parse("01-10-2019"));
            double totaalBtwHoog = serv.BerekenBTWHoog(DateTime.Parse("01-07-2019 00:00:00"), DateTime.Parse("01-10-2019"));
            lbl_btwLaag.Text = totaalBtwLaag.ToString("€0.00");
            lbl_btwHoog.Text = totaalBtwHoog.ToString("€0.00");

            double totaal = totaalBtwHoog + totaalBtwLaag;
            lbl_totaal.Text = totaal.ToString("€0.00");
        }

        private void q4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_datum.Text = (" 01-10-2019 tot 01-01-2020 ");
            DrinkOrders_Service serv = new DrinkOrders_Service();
            double totaalBtwLaag = serv.BerekenBTWLaag(DateTime.Parse("01-10-2019 00:00:00"), DateTime.Parse("01-01-2020"));
            double totaalBtwHoog = serv.BerekenBTWHoog(DateTime.Parse("01-10-2019 00:00:00"), DateTime.Parse("01-01-2020"));
            lbl_btwLaag.Text = totaalBtwLaag.ToString("€0.00");
            lbl_btwHoog.Text = totaalBtwHoog.ToString("€0.00");

            double totaal= totaalBtwHoog + totaalBtwLaag;
            lbl_totaal.Text = totaal.ToString("€0.00");
        }


        private void weekroosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("WeekRooster");
        }


        private void activiteitenlijstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activiteitenlijst");

            listViewActivities.View = View.Details;

            listViewActivities.Columns.Add("Activiteitennummer", -2, HorizontalAlignment.Left);
            listViewActivities.Columns.Add("Beschrijving", -2, HorizontalAlignment.Left);
            listViewActivities.Columns.Add("Aantal studenten", -2, HorizontalAlignment.Left);
            listViewActivities.Columns.Add("Aantal begeleiders", -2, HorizontalAlignment.Left);

            listViewActivities.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewActivities.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btn_Wijzigen_Click(object sender, EventArgs e)
        {
            SomerenLogic.Activity_Service actWijzigen = new SomerenLogic.Activity_Service();
            Activity huidigeActivity = new Activity();
            huidigeActivity.Id = int.Parse(tb_Id.Text);
            huidigeActivity.Description = tb_Description.Text;
            huidigeActivity.AantalStudenten = int.Parse(tb_AantalStudenten.Text);
            huidigeActivity.AantalBegeleider = int.Parse(tb_AantalBegeleiders.Text);

            actWijzigen.UpdateActivity(huidigeActivity);
            activiteitenlijstToolStripMenuItem_Click(sender, e);
        }

        private void btn_Verwijderen_Click(object sender, EventArgs e)
        {
            var selectedItem = listViewActivities.SelectedItems[0];

            DialogResult d = MessageBox.Show("Weet u zeker dat u deze activiteit wilt verwijderen?", "Removing activity", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                Activity_Service actVerwijderen = new Activity_Service();
                actVerwijderen.DeleteActivity(int.Parse(selectedItem.Text));

            }
            activiteitenlijstToolStripMenuItem_Click(sender, e);
        }

        private void btn_Toevoegen_Click(object sender, EventArgs e)
        {
            SomerenLogic.Activity_Service actToevoegen = new SomerenLogic.Activity_Service();
            Activity huidigeActivity = new Activity();

            huidigeActivity.Id = int.Parse(tb_Id.Text);
            huidigeActivity.Description = tb_Description.Text;
            huidigeActivity.AantalStudenten = int.Parse(tb_AantalStudenten.Text);
            huidigeActivity.AantalBegeleider = int.Parse(tb_AantalBegeleiders.Text);

            actToevoegen.AddActivity(huidigeActivity);
            activiteitenlijstToolStripMenuItem_Click(sender, e);
        }
       

        private void bt_VerwijderBegeleider_Click(object sender, EventArgs e)
        {
            var selectedItem = listviewSupervisors.SelectedItems[0];

            DialogResult d = MessageBox.Show("Weet u zeker dat u deze begeleider wilt verwijderen?", "Removing activity", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                Supervisors_Service actVerwijderen = new Supervisors_Service();
                actVerwijderen.DeleteSupervisor(int.Parse(selectedItem.Text));

            }
            begeleidersToolStripMenuItem_Click(sender, e);
        }

        private void bt_begeleiderToevoegen_Click(object sender, EventArgs e)
        {
            SomerenLogic.Supervisors_Service begeleiderToevoegen = new SomerenLogic.Supervisors_Service();
            Supervisor nieuweSupervisor = new Supervisor();

            nieuweSupervisor.SupervisorNumber = int.Parse(txtbox_BegeleidersNummer.Text);
            nieuweSupervisor.LecturerNumber = int.Parse(txtbox_docentenNummer.Text);


            begeleiderToevoegen.AddActivity(nieuweSupervisor);
            begeleidersToolStripMenuItem_Click(sender, e);
        }

        private void listViewDocentenSelecteren_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewDocentenSelecteren.SelectedItems.Count > 0)
            {
                string docent = listViewDocentenSelecteren.SelectedItems[0].Text;
                docentNumber = int.Parse(docent);
            }            
            showPanel("ActiviteitenLijstDocenten");
            listViewDocentenActiviteiten.View = View.Details;
            listViewDocentenActiviteiten.Columns.Add("Activiteitennummer", -2, HorizontalAlignment.Left);
            listViewDocentenActiviteiten.Columns.Add("Beschrijving", -2, HorizontalAlignment.Left);

            listViewDocentenActiviteiten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewDocentenActiviteiten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void docentenroosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Docentenrooster");
            listViewDocentenSelecteren.View = View.Details;
            listViewDocentenSelecteren.Columns.Add("Docentennummer", -2, HorizontalAlignment.Left);
            listViewDocentenSelecteren.Columns.Add("Voornaam", -2, HorizontalAlignment.Left);
            listViewDocentenSelecteren.Columns.Add("Achternaam", -2, HorizontalAlignment.Left);
            listViewDocentenSelecteren.Columns.Add("Stad", -2, HorizontalAlignment.Left);
            listViewDocentenSelecteren.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewDocentenSelecteren.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public int VervangendeDocentIndex;
        private void listView_VervangendeDocent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string VervangendeDocent = listView_VervangendeDocent.SelectedItems[0].Text;
            VervangendeDocentIndex = int.Parse(VervangendeDocent);

            showPanel("ActiviteitenIndexVerandering");
            listViewDocentenActiviteiten.View = View.Details;
            listViewDocentenActiviteiten.Columns.Add("Activiteitennummer", -2, HorizontalAlignment.Left);
            listViewDocentenActiviteiten.Columns.Add("Beschrijving", -2, HorizontalAlignment.Left);

            listViewDocentenActiviteiten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewDocentenActiviteiten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btn_vervangDocent_Click(object sender, EventArgs e)
        {
            lbl_VervangDocent.Show();
            listView_VervangendeDocent.Show();
            showPanel("DocentenNaamSelectie");
            listView_VervangendeDocent.View = View.Details;
            listView_VervangendeDocent.Columns.Add("Docentennummer", -2, HorizontalAlignment.Left);
            listView_VervangendeDocent.Columns.Add("Voornaam", -2, HorizontalAlignment.Left);
            listView_VervangendeDocent.Columns.Add("Achternaam", -2, HorizontalAlignment.Left);
            listView_VervangendeDocent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView_VervangendeDocent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void txtbox_Gebruikersnaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewDocentenActiviteiten_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account_Service service = new Account_Service();
            if (service.CheckAdmin(username))
            {
                showPanel("AdminTrue");

                listView_Accounts.View = View.Details;
                listView_Accounts.Columns.Add("Gebruikersnaam", -2, HorizontalAlignment.Left);
                listView_Accounts.Columns.Add("Wachtwoord", -2, HorizontalAlignment.Left);
                listView_Accounts.Columns.Add("Admin Status", -2, HorizontalAlignment.Left);
                listView_Accounts.Columns.Add("Vraag", -2, HorizontalAlignment.Left);
                listView_Accounts.Columns.Add("Antwoord", -2, HorizontalAlignment.Left);
                listView_Accounts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView_Accounts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                showPanel("AdminFalse");
            }
        }

        string username;
        public void GetUserName(string name)
        {
            username = name;
        }

        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            Account newUser = new Account();
            HashAndSalt hashPassword = new HashAndSalt();
            string salt = hashPassword.CreateSalt(64);
            string hashedWachtwoord = hashPassword.GenerateHash(textBox_Wachtwoord.Text, salt);

            HashAndSalt retrieve = new HashAndSalt();
            string hash = retrieve.GenerateHash(textBox_Wachtwoord.Text, salt);

            newUser.Gebruikersnaam = textBox_Gebruikersnaam.Text;
            newUser.Wachtwoord = hash;
            if (comboBox_AdminStatus.Text == "admin")
            {
                newUser.AdminStatus = "admin";
            }
            else
            {
                newUser.AdminStatus = "user";
            }
            newUser.Vraag = textBox_Vraag.Text;
            newUser.Antwoord = textBox_Antwoord.Text;
            newUser.Salt = salt;

            Account_Service addAccount = new Account_Service();
            addAccount.AccountToevoegen(newUser);

            adminToolStripMenuItem_Click(sender, e);
        }

        private void btn_DeleteAccount_Click(object sender, EventArgs e)
        {
            Account_Service deleteAccount = new Account_Service();
            deleteAccount.DeleteAccount(selectedUsername);

            adminToolStripMenuItem_Click(sender, e);
        }

        string selectedUsername;
        private void listView_Accounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUsername = listView_Accounts.SelectedItems[0].Text;
        }

        private void btn_ChangeValue_Click(object sender, EventArgs e)
        {
            Account_Service service = new Account_Service();
            string toChange = comboBox_ChangeValue.Text;
            if (toChange == "Wachtwoord")
            {
                Account nieuwAccount = new Account();
                HashAndSalt hashPassword = new HashAndSalt();
                string salt = hashPassword.CreateSalt(64);
                string hashedWachtwoord = hashPassword.GenerateHash(textBox_ChangeValue.Text, salt);

                service.AlterPassword(selectedUsername, hashedWachtwoord, salt);
            }
            else
            {
                string newValue = textBox_ChangeValue.Text;
                service.AlterAccount(selectedUsername, toChange, newValue);
            }
            adminToolStripMenuItem_Click(sender, e);
        }

        private void kamerindelingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Kamers");
            listViewRooms.View = View.Details;
            listViewRooms.Columns.Add("Kamernummer", -2, HorizontalAlignment.Left);
            listViewRooms.Columns.Add("Kamergrootte", -2, HorizontalAlignment.Left);
            listViewRooms.Columns.Add("Kamertype", -2, HorizontalAlignment.Left);

            listViewRooms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewRooms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void kamerindelingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Kamerindeling");
            listViewKamerIndeling.View = View.Details;
            listViewKamerIndeling.Columns.Add("Kamernummer", -2, HorizontalAlignment.Left);
            listViewKamerIndeling.Columns.Add("Voornaam", -2, HorizontalAlignment.Left);
            listViewKamerIndeling.Columns.Add("Achternaam", -2, HorizontalAlignment.Left);
            listViewKamerIndeling.Columns.Add("Capaciteit", -2, HorizontalAlignment.Left);

            listViewKamerIndeling.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewKamerIndeling.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void pnl_Dashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Drinks_Click(object sender, EventArgs e)
        {

        }

        private void listViewKamerIndeling_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SomerenUI_Load_1(object sender, EventArgs e)
        {

        }
    }
}


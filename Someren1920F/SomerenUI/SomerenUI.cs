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

                // show dashboard
                pnl_Dashboard.Show();
                img_Dashboard.Show();
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_Lecturers.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Drinks.Hide();


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
            else if (panelName == "Rooms")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Students.Hide();
                pnl_Lecturers.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Drinks.Hide();

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
                    {
                        li.SubItems.Add("Student");
                    }
                    else { li.SubItems.Add("Teacher"); }
                    listViewRooms.Items.Add(li);
                }
            }
            else if (panelName == "Lecturers")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                pnl_Students.Hide();
                img_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Drinks.Hide();

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
            else if (panelName == "Kamer Indeling")
            {
                pnl_Dashboard.Hide();
                pnl_Students.Hide();
                img_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_Lecturers.Hide();
                pnl_Drinks.Hide();

                // show KamerIndeling

                pnl_KamerIndeling.Show();
                SomerenLogic.KamerIndeling_Service kamerIndelingService = new SomerenLogic.KamerIndeling_Service();
                List<KamerIndeling> KamerIndelingList = kamerIndelingService.GetKamerIndelings();

                // clear the listview before filling it again

                foreach (SomerenModel.KamerIndeling k in KamerIndelingList)
                {
                    //foreach (SomerenModel.Room r in KamerIndeling.)
                    {
                        roomDivision1.Text = "Kamer " + k.RoomNumber +
                        k.FirstName + k.LastName;

                    }

                }

            }
            else if (panelName == "Kassa")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_Lecturers.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Students.Hide();


                // show drinks
                pnl_Drinks.Show();

                // fill the drinks listview within the drinks panel with a list of drinks
                SomerenLogic.Drinks_Service drinksService = new SomerenLogic.Drinks_Service();
                List<Drinks> drinkList = drinksService.GetDrinks();

                // clear the listview before filling it again
                listViewDrinks.Clear();

                foreach (SomerenModel.Drinks d in drinkList)
                {
                    ListViewItem li = new ListViewItem(d.Name);
                    li.SubItems.Add(d.Stock.ToString());
                    li.SubItems.Add(d.Price.ToString());
                    li.SubItems.Add(d.BTW.ToString());
                    listViewDrinks.Items.Add(li);
                }
            }
            else if (panelName == "Omzetrapportage")
            {
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Students.Hide();
                pnl_Lecturers.Hide();
                pnl_KamerIndeling.Hide();
                pnl_Drinks.Hide();
                pnl_Rooms.Hide();

                pnl_omzetrapportage.Show();

                SomerenLogic.DrinkOrders_Service drinkOrdersService = new SomerenLogic.DrinkOrders_Service();
                List<DrinkOrders> drinkOrderList = drinkOrdersService.GetDrinkOrders();

                foreach (SomerenModel.DrinkOrders Drinkorder in drinkOrderList)
                {
                    ListViewItem li = new ListViewItem(Drinkorder.DrinkName);
                    li.SubItems.Add(Drinkorder.StudentId.ToString());
                    li.SubItems.Add(Drinkorder.Amount.ToString());
                    li.SubItems.Add(Drinkorder.dateTime.ToString());
                    listViewomzetrapportage.Items.Add(li);
                }
            }

        }
    
            private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
            {
               //
            }

            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                showPanel("Dashboard");
            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void img_Dashboard_Click(object sender, EventArgs e)
            {
                MessageBox.Show("What happens in Someren, stays in Someren!");
            }

            private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
            {
                showPanel("Students");
                listViewStudents.View = View.Details;

                listViewStudents.Columns.Add("StudentId", -2, HorizontalAlignment.Left);
                listViewStudents.Columns.Add("Class", -2, HorizontalAlignment.Left);
                listViewStudents.Columns.Add("First Name", -2, HorizontalAlignment.Left);
                listViewStudents.Columns.Add("Last Name", -2, HorizontalAlignment.Left);
                listViewStudents.Columns.Add("Room Number", -2, HorizontalAlignment.Left);
                listViewStudents.Columns.Add("Address", -2, HorizontalAlignment.Left);
                listViewStudents.Columns.Add("City", -2, HorizontalAlignment.Left);

                listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
            {
                showPanel("Rooms");
                listViewRooms.View = View.Details;
                listViewRooms.Columns.Add("RoomNumber", -2, HorizontalAlignment.Left);
                listViewRooms.Columns.Add("Capacity", -2, HorizontalAlignment.Left);
                listViewRooms.Columns.Add("Type", -2, HorizontalAlignment.Left);

                listViewRooms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listViewRooms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            }

            private void lecturersToolStripMenuItem_Click_1(object sender, EventArgs e)
            {
                showPanel("Lecturers");
                listViewLecturers.View = View.Details;
                listViewLecturers.Columns.Add("LecturerNumber", -2, HorizontalAlignment.Left);
                listViewLecturers.Columns.Add("First Name", -2, HorizontalAlignment.Left);
                listViewLecturers.Columns.Add("Last Name", -2, HorizontalAlignment.Left);
                listViewLecturers.Columns.Add("Address", -2, HorizontalAlignment.Left);
                listViewLecturers.Columns.Add("City", -2, HorizontalAlignment.Left);
                listViewLecturers.Columns.Add("Room Number", -2, HorizontalAlignment.Left);

                listViewLecturers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listViewLecturers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            private void lbl_Rooms_Click(object sender, EventArgs e)
            {

            }

            private void listViewRooms_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void toolStripMenuItem1_Click(object sender, EventArgs e)
            {
 



        }

        private void roomDivision1_Click(object sender, EventArgs e)
        {
            //foreach(SomerenModel.Student s in RoomNumber)
            //{

            //}
        }

        private void kassaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Kassa");

            listViewDrinks.View = View.Details;
            listViewDrinks.Columns.Add("Name", -2, HorizontalAlignment.Left);
            listViewDrinks.Columns.Add("Stock", -2, HorizontalAlignment.Left);
            listViewDrinks.Columns.Add("Price", -2, HorizontalAlignment.Left);
            listViewDrinks.Columns.Add("BTW", -2, HorizontalAlignment.Left);

            listViewLecturers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewLecturers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnBestelDrinks_Click(object sender, EventArgs e)
        {

        }


        public int numberOfClicks = 0;
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {


            SelectionRange sr = new SelectionRange();

            if (DateTime.Parse(sender.ToString()) > DateTime.Today)
            {
                throw new Exception("Invoer in de toekomst!");
            }
            if (numberOfClicks < 1)
            {
                monthCalendar.SelectionRange.Start = DateTime.Parse(e.Start.ToShortDateString());
                sr.Start = monthCalendar.SelectionRange.Start;
                lbl_StartDate.Text = ($"{sr.Start}");
                numberOfClicks++;
            }
            else
            {
                monthCalendar.SelectionRange.End = DateTime.Parse(e.End.ToShortDateString());
                sr.End = monthCalendar.SelectionRange.End;
                lbl_EndDate.Text = ($"{sr.End}");
            }
        }

        private void omzetrapportageToolStripMenuItem_Click(object sender, EventArgs e)
        {


            showPanel("Omzetrapportage");

            listViewomzetrapportage.View = View.Details;
            listViewomzetrapportage.Columns.Add("Name", -2, HorizontalAlignment.Left);
            listViewomzetrapportage.Columns.Add("Stock", -2, HorizontalAlignment.Left);
            listViewomzetrapportage.Columns.Add("Price", -2, HorizontalAlignment.Left);
            listViewomzetrapportage.Columns.Add("BTW", -2, HorizontalAlignment.Left);

            listViewLecturers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewLecturers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void bardienstToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pnl_omzetrapportage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listViewomzetrapportage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


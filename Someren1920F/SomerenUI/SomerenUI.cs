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
                    li.SubItems.Add(r.Type.ToString());
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

        private void listViewLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewLecturers_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void pnl_Lecturers_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

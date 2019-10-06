namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            this.img_Dashboard = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bardienstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drankvoorraadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kassaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omzetrapportageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bTWBerekeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnl_Students = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Students = new System.Windows.Forms.Label();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Rooms = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.roomNUM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roomCAP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roomTYP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Rooms = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pnl_Lecturers = new System.Windows.Forms.Panel();
            this.listViewLecturers = new System.Windows.Forms.ListView();
            this.lbl_Lecturers = new System.Windows.Forms.Label();
            this.pnl_KamerIndeling = new System.Windows.Forms.Panel();
            this.roomDivision1 = new System.Windows.Forms.Label();
            this.lbl_KamerIndeling = new System.Windows.Forms.Label();
            this.pnl_Drinks = new System.Windows.Forms.Panel();
            this.btnBestelDrinks = new System.Windows.Forms.Button();
            this.listViewDrinks = new System.Windows.Forms.ListView();
            this.listViewStudentDrinks = new System.Windows.Forms.ListView();
            this.lbl_Drinks = new System.Windows.Forms.Label();
            this.pnl_omzetrapportage = new System.Windows.Forms.Panel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lbl_omzetrapportage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.listViewomzetrapportage = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            this.pnl_Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Rooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_Lecturers.SuspendLayout();
            this.pnl_KamerIndeling.SuspendLayout();
            this.pnl_Drinks.SuspendLayout();
            this.pnl_omzetrapportage.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_Dashboard
            // 
            this.img_Dashboard.Location = new System.Drawing.Point(836, 0);
            this.img_Dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.img_Dashboard.Name = "img_Dashboard";
            this.img_Dashboard.Size = new System.Drawing.Size(415, 332);
            this.img_Dashboard.TabIndex = 0;
            this.img_Dashboard.TabStop = false;
            this.img_Dashboard.Click += new System.EventHandler(this.img_Dashboard_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.bardienstToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1283, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.dashboardToolStripMenuItem.Text = "Application";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(157, 26);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.lecturersToolStripMenuItem_Click_1);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 24);
            this.toolStripMenuItem1.Text = "Kamer Indeling";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // bardienstToolStripMenuItem
            // 
            this.bardienstToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drankvoorraadToolStripMenuItem,
            this.kassaToolStripMenuItem,
            this.omzetrapportageToolStripMenuItem,
            this.bTWBerekeningToolStripMenuItem});
            this.bardienstToolStripMenuItem.Name = "bardienstToolStripMenuItem";
            this.bardienstToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.bardienstToolStripMenuItem.Text = "Bardienst";
            this.bardienstToolStripMenuItem.Click += new System.EventHandler(this.bardienstToolStripMenuItem_Click);
            // 
            // drankvoorraadToolStripMenuItem
            // 
            this.drankvoorraadToolStripMenuItem.Name = "drankvoorraadToolStripMenuItem";
            this.drankvoorraadToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.drankvoorraadToolStripMenuItem.Text = "Drankvoorraad";
            // 
            // kassaToolStripMenuItem
            // 
            this.kassaToolStripMenuItem.Name = "kassaToolStripMenuItem";
            this.kassaToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.kassaToolStripMenuItem.Text = "Kassa";
            this.kassaToolStripMenuItem.Click += new System.EventHandler(this.kassaToolStripMenuItem_Click);
            // 
            // omzetrapportageToolStripMenuItem
            // 
            this.omzetrapportageToolStripMenuItem.Name = "omzetrapportageToolStripMenuItem";
            this.omzetrapportageToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.omzetrapportageToolStripMenuItem.Text = "Omzetrapportage";
            this.omzetrapportageToolStripMenuItem.Click += new System.EventHandler(this.omzetrapportageToolStripMenuItem_Click);
            // 
            // bTWBerekeningToolStripMenuItem
            // 
            this.bTWBerekeningToolStripMenuItem.Name = "bTWBerekeningToolStripMenuItem";
            this.bTWBerekeningToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.bTWBerekeningToolStripMenuItem.Text = "BTW Berekening";
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.lbl_Dashboard);
            this.pnl_Dashboard.Controls.Add(this.img_Dashboard);
            this.pnl_Dashboard.Location = new System.Drawing.Point(16, 33);
            this.pnl_Dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(1251, 574);
            this.pnl_Dashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(17, 16);
            this.lbl_Dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(243, 17);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            this.lbl_Dashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl_Students
            // 
            this.pnl_Students.Controls.Add(this.pictureBox1);
            this.pnl_Students.Controls.Add(this.lbl_Students);
            this.pnl_Students.Controls.Add(this.listViewStudents);
            this.pnl_Students.Location = new System.Drawing.Point(16, 30);
            this.pnl_Students.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(1251, 574);
            this.pnl_Students.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1073, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(13, 12);
            this.lbl_Students.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(129, 33);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB});
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(21, 52);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(4);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(1020, 377);
            this.listViewStudents.TabIndex = 5;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // studentID
            // 
            this.studentID.Text = "ID";
            // 
            // studentName
            // 
            this.studentName.Text = "Name";
            // 
            // studentDOB
            // 
            this.studentDOB.Text = "Date of Birth";
            // 
            // pnl_Rooms
            // 
            this.pnl_Rooms.Controls.Add(this.pictureBox2);
            this.pnl_Rooms.Controls.Add(this.listViewRooms);
            this.pnl_Rooms.Controls.Add(this.lbl_Rooms);
            this.pnl_Rooms.Location = new System.Drawing.Point(19, 30);
            this.pnl_Rooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Rooms.Name = "pnl_Rooms";
            this.pnl_Rooms.Size = new System.Drawing.Size(1203, 527);
            this.pnl_Rooms.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1005, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 145);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // listViewRooms
            // 
            this.listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.roomNUM,
            this.roomCAP,
            this.roomTYP});
            this.listViewRooms.HideSelection = false;
            this.listViewRooms.Location = new System.Drawing.Point(72, 71);
            this.listViewRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(801, 395);
            this.listViewRooms.TabIndex = 2;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            this.listViewRooms.SelectedIndexChanged += new System.EventHandler(this.listViewRooms_SelectedIndexChanged);
            // 
            // roomNUM
            // 
            this.roomNUM.Text = "Number";
            // 
            // roomCAP
            // 
            this.roomCAP.Text = "Capacity";
            // 
            // roomTYP
            // 
            this.roomTYP.Text = "Type";
            // 
            // lbl_Rooms
            // 
            this.lbl_Rooms.AutoSize = true;
            this.lbl_Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rooms.Location = new System.Drawing.Point(23, 18);
            this.lbl_Rooms.Name = "lbl_Rooms";
            this.lbl_Rooms.Size = new System.Drawing.Size(100, 31);
            this.lbl_Rooms.TabIndex = 0;
            this.lbl_Rooms.Text = "Rooms";
            this.lbl_Rooms.Click += new System.EventHandler(this.lbl_Rooms_Click);
            // 
            // pnl_Lecturers
            // 
            this.pnl_Lecturers.Controls.Add(this.listViewLecturers);
            this.pnl_Lecturers.Controls.Add(this.lbl_Lecturers);
            this.pnl_Lecturers.Location = new System.Drawing.Point(16, 33);
            this.pnl_Lecturers.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Lecturers.Name = "pnl_Lecturers";
            this.pnl_Lecturers.Size = new System.Drawing.Size(1251, 574);
            this.pnl_Lecturers.TabIndex = 7;
            // 
            // listViewLecturers
            // 
            this.listViewLecturers.HideSelection = false;
            this.listViewLecturers.Location = new System.Drawing.Point(81, 73);
            this.listViewLecturers.Margin = new System.Windows.Forms.Padding(4);
            this.listViewLecturers.Name = "listViewLecturers";
            this.listViewLecturers.Size = new System.Drawing.Size(919, 446);
            this.listViewLecturers.TabIndex = 1;
            this.listViewLecturers.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Lecturers
            // 
            this.lbl_Lecturers.AutoSize = true;
            this.lbl_Lecturers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lecturers.Location = new System.Drawing.Point(75, 37);
            this.lbl_Lecturers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lecturers.Name = "lbl_Lecturers";
            this.lbl_Lecturers.Size = new System.Drawing.Size(128, 31);
            this.lbl_Lecturers.TabIndex = 0;
            this.lbl_Lecturers.Text = "Lecturers";
            // 
            // pnl_KamerIndeling
            // 
            this.pnl_KamerIndeling.Controls.Add(this.roomDivision1);
            this.pnl_KamerIndeling.Controls.Add(this.lbl_KamerIndeling);
            this.pnl_KamerIndeling.Location = new System.Drawing.Point(16, 30);
            this.pnl_KamerIndeling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_KamerIndeling.Name = "pnl_KamerIndeling";
            this.pnl_KamerIndeling.Size = new System.Drawing.Size(1252, 561);
            this.pnl_KamerIndeling.TabIndex = 8;
            // 
            // roomDivision1
            // 
            this.roomDivision1.AutoSize = true;
            this.roomDivision1.Location = new System.Drawing.Point(44, 135);
            this.roomDivision1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomDivision1.Name = "roomDivision1";
            this.roomDivision1.Size = new System.Drawing.Size(46, 17);
            this.roomDivision1.TabIndex = 1;
            this.roomDivision1.Text = "label1";
            this.roomDivision1.Click += new System.EventHandler(this.roomDivision1_Click);
            // 
            // lbl_KamerIndeling
            // 
            this.lbl_KamerIndeling.AutoSize = true;
            this.lbl_KamerIndeling.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KamerIndeling.Location = new System.Drawing.Point(41, 52);
            this.lbl_KamerIndeling.Name = "lbl_KamerIndeling";
            this.lbl_KamerIndeling.Size = new System.Drawing.Size(188, 31);
            this.lbl_KamerIndeling.TabIndex = 0;
            this.lbl_KamerIndeling.Text = "KamerIndeling";
            // 
            // pnl_Drinks
            // 
            this.pnl_Drinks.Controls.Add(this.btnBestelDrinks);
            this.pnl_Drinks.Controls.Add(this.listViewDrinks);
            this.pnl_Drinks.Controls.Add(this.listViewStudentDrinks);
            this.pnl_Drinks.Controls.Add(this.lbl_Drinks);
            this.pnl_Drinks.Location = new System.Drawing.Point(6, 37);
            this.pnl_Drinks.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Drinks.Name = "pnl_Drinks";
            this.pnl_Drinks.Size = new System.Drawing.Size(1251, 577);
            this.pnl_Drinks.TabIndex = 2;
            // 
            // btnBestelDrinks
            // 
            this.btnBestelDrinks.Location = new System.Drawing.Point(1008, 241);
            this.btnBestelDrinks.Margin = new System.Windows.Forms.Padding(4);
            this.btnBestelDrinks.Name = "btnBestelDrinks";
            this.btnBestelDrinks.Size = new System.Drawing.Size(213, 102);
            this.btnBestelDrinks.TabIndex = 3;
            this.btnBestelDrinks.Text = "Afrekenen";
            this.btnBestelDrinks.UseVisualStyleBackColor = true;
            this.btnBestelDrinks.Click += new System.EventHandler(this.btnBestelDrinks_Click);
            // 
            // listViewDrinks
            // 
            this.listViewDrinks.HideSelection = false;
            this.listViewDrinks.Location = new System.Drawing.Point(511, 111);
            this.listViewDrinks.Margin = new System.Windows.Forms.Padding(4);
            this.listViewDrinks.Name = "listViewDrinks";
            this.listViewDrinks.Size = new System.Drawing.Size(465, 429);
            this.listViewDrinks.TabIndex = 2;
            this.listViewDrinks.UseCompatibleStateImageBehavior = false;
            // 
            // listViewStudentDrinks
            // 
            this.listViewStudentDrinks.HideSelection = false;
            this.listViewStudentDrinks.Location = new System.Drawing.Point(52, 111);
            this.listViewStudentDrinks.Margin = new System.Windows.Forms.Padding(4);
            this.listViewStudentDrinks.Name = "listViewStudentDrinks";
            this.listViewStudentDrinks.Size = new System.Drawing.Size(403, 429);
            this.listViewStudentDrinks.TabIndex = 1;
            this.listViewStudentDrinks.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Drinks
            // 
            this.lbl_Drinks.AutoSize = true;
            this.lbl_Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Drinks.Location = new System.Drawing.Point(44, 36);
            this.lbl_Drinks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Drinks.Name = "lbl_Drinks";
            this.lbl_Drinks.Size = new System.Drawing.Size(120, 39);
            this.lbl_Drinks.TabIndex = 0;
            this.lbl_Drinks.Text = "Drinks";
            // 
            // pnl_omzetrapportage
            // 
            this.pnl_omzetrapportage.Controls.Add(this.listViewomzetrapportage);
            this.pnl_omzetrapportage.Controls.Add(this.lbl_EndDate);
            this.pnl_omzetrapportage.Controls.Add(this.lbl_StartDate);
            this.pnl_omzetrapportage.Controls.Add(this.label2);
            this.pnl_omzetrapportage.Controls.Add(this.label1);
            this.pnl_omzetrapportage.Controls.Add(this.monthCalendar);
            this.pnl_omzetrapportage.Controls.Add(this.lbl_omzetrapportage);
            this.pnl_omzetrapportage.Location = new System.Drawing.Point(12, 33);
            this.pnl_omzetrapportage.Name = "pnl_omzetrapportage";
            this.pnl_omzetrapportage.Size = new System.Drawing.Size(1249, 570);
            this.pnl_omzetrapportage.TabIndex = 9;
            this.pnl_omzetrapportage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_omzetrapportage_Paint);
            // 
            // monthCalendar
            // 
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar.Location = new System.Drawing.Point(68, 111);
            this.monthCalendar.MaxSelectionCount = 15;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.ShowWeekNumbers = true;
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // lbl_omzetrapportage
            // 
            this.lbl_omzetrapportage.AutoSize = true;
            this.lbl_omzetrapportage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_omzetrapportage.Location = new System.Drawing.Point(42, 31);
            this.lbl_omzetrapportage.Name = "lbl_omzetrapportage";
            this.lbl_omzetrapportage.Size = new System.Drawing.Size(225, 31);
            this.lbl_omzetrapportage.TabIndex = 0;
            this.lbl_omzetrapportage.Text = "Omzetrapportage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected End Date:";
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Location = new System.Drawing.Point(505, 111);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(0, 17);
            this.lbl_StartDate.TabIndex = 4;
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Location = new System.Drawing.Point(505, 132);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(0, 17);
            this.lbl_EndDate.TabIndex = 5;
            // 
            // listViewomzetrapportage
            // 
            this.listViewomzetrapportage.HideSelection = false;
            this.listViewomzetrapportage.Location = new System.Drawing.Point(685, 89);
            this.listViewomzetrapportage.Name = "listViewomzetrapportage";
            this.listViewomzetrapportage.Size = new System.Drawing.Size(385, 243);
            this.listViewomzetrapportage.TabIndex = 6;
            this.listViewomzetrapportage.UseCompatibleStateImageBehavior = false;
            this.listViewomzetrapportage.SelectedIndexChanged += new System.EventHandler(this.listViewomzetrapportage_SelectedIndexChanged);
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 622);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_omzetrapportage);
            this.Controls.Add(this.pnl_KamerIndeling);
            this.Controls.Add(this.pnl_Drinks);
            this.Controls.Add(this.pnl_Lecturers);
            this.Controls.Add(this.pnl_Dashboard);
            this.Controls.Add(this.pnl_Rooms);
            this.Controls.Add(this.pnl_Students);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            this.pnl_Students.ResumeLayout(false);
            this.pnl_Students.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Rooms.ResumeLayout(false);
            this.pnl_Rooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_Lecturers.ResumeLayout(false);
            this.pnl_Lecturers.PerformLayout();
            this.pnl_KamerIndeling.ResumeLayout(false);
            this.pnl_KamerIndeling.PerformLayout();
            this.pnl_Drinks.ResumeLayout(false);
            this.pnl_Drinks.PerformLayout();
            this.pnl_omzetrapportage.ResumeLayout(false);
            this.pnl_omzetrapportage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_Dashboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Students;
        private System.Windows.Forms.Label lbl_Students;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentDOB;

        private System.Windows.Forms.Panel pnl_Rooms;
        private System.Windows.Forms.Label lbl_Rooms;
        private System.Windows.Forms.ListView listViewRooms;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ColumnHeader roomNUM;
        private System.Windows.Forms.ColumnHeader roomCAP;
        private System.Windows.Forms.ColumnHeader roomTYP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnl_Lecturers;
        private System.Windows.Forms.ListView listViewLecturers;
        private System.Windows.Forms.Label lbl_Lecturers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel pnl_KamerIndeling;
        private System.Windows.Forms.Label lbl_KamerIndeling;
        private System.Windows.Forms.Label roomDivision1;
        private System.Windows.Forms.ToolStripMenuItem bardienstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drankvoorraadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kassaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omzetrapportageToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Drinks;
        private System.Windows.Forms.Button btnBestelDrinks;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.ListView listViewStudentDrinks;
        private System.Windows.Forms.Label lbl_Drinks;
        private System.Windows.Forms.ToolStripMenuItem bTWBerekeningToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_omzetrapportage;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label lbl_omzetrapportage;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewomzetrapportage;
    }
}


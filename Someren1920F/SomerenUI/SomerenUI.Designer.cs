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
            this.SuspendLayout();
            // 
            // SomerenUI
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "SomerenUI";
            this.Load += new System.EventHandler(this.SomerenUI_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
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
        private System.Windows.Forms.Panel pnl_Lecturers;
        private System.Windows.Forms.ListView listViewLecturers;
        private System.Windows.Forms.Label lbl_Lecturers;
        private System.Windows.Forms.Panel pnl_KamerIndeling;
        private System.Windows.Forms.Label lbl_KamerIndeling;
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
        private System.Windows.Forms.Panel pnl_DrankVoorraad;
        private System.Windows.Forms.ListView listViewDrankVoorraad;
        private System.Windows.Forms.Label lbl_DrankVoorraad;
        private System.Windows.Forms.NumericUpDown numericAmount;
        private System.Windows.Forms.Label lbl_aantal;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.Label lbl_omzetrapportageAantalKlanten;
        private System.Windows.Forms.Label lbl_omzetrapportageOmzet;
        private System.Windows.Forms.Label lbl_omzetrapportageAfzet;
        private System.Windows.Forms.Label lbl_aantalKlanten;
        private System.Windows.Forms.Label lbl_omzet;
        private System.Windows.Forms.Label lbl_afzet;
        private System.Windows.Forms.Panel pnl_btwBerekening;
        private System.Windows.Forms.Label lbl_totaal;
        private System.Windows.Forms.Label lbl_btwHoog;
        private System.Windows.Forms.Label lbl_btwLaag;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem selectieKwartaalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem q1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem q2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem q3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem q4ToolStripMenuItem;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_keuzeKwartaal;
        private System.Windows.Forms.ToolStripMenuItem activiteitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activiteitenlijstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem begeleidersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weekroosterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docentenroosterToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_weekRooster;
        private System.Windows.Forms.DataGridView dataGrid_weekRooster;
        private System.Windows.Forms.Panel pnl_Begeleiders;
        private System.Windows.Forms.ListView listviewSupervisors;
        private System.Windows.Forms.Label lbl_begeleiders;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_ActiviteitToevoegen;
        private System.Windows.Forms.Button btn_Toevoegen;
        private System.Windows.Forms.Button btn_Verwijderen;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.Label lbl_Activiteiten;
        private System.Windows.Forms.TextBox tb_AantalBegeleiders;
        private System.Windows.Forms.TextBox tb_AantalStudenten;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.Label lbl_AantalBegeleiders;
        private System.Windows.Forms.Label lbl_AantalStudenten;
        private System.Windows.Forms.Panel pnl_Activiteitenlijst;
        private System.Windows.Forms.Button bt_Wijzigen;
        private System.Windows.Forms.Button bt_VerwijderBegeleider;
        private System.Windows.Forms.Label lbl_begeleiderToevoegen;
        private System.Windows.Forms.Label lbl_begeleiderId;
        private System.Windows.Forms.Panel pnl_Activities_SubMenuItem_Docenten;
        private System.Windows.Forms.ListView listViewDocentenActiviteiten;
        private System.Windows.Forms.ListView listViewDocentenSelecteren;
        private System.Windows.Forms.Label lbl_activiteitenDocenten;
        private System.Windows.Forms.Label lbl_selecteerDocent;
        private System.Windows.Forms.Label lbl_Docentenrooster;
        private System.Windows.Forms.ListView listView_VervangendeDocent;
        private System.Windows.Forms.Label lbl_VervangDocent;
        private System.Windows.Forms.Button btn_vervangDocent;
        private System.Windows.Forms.Button bt_begeleiderToevoegen;
        private System.Windows.Forms.TextBox txtbox_docentenNummer;
        private System.Windows.Forms.TextBox txtbox_BegeleidersNummer;
        private System.Windows.Forms.Label lbl_docentenNummer;
        private System.Windows.Forms.Panel pnl_AdminFalse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private SomerenLogic.pdb1920f6DataSet pdb1920f6DataSet1;
        private System.Windows.Forms.Panel pnl_AdminTrue;
        private System.Windows.Forms.ListView listView_Accounts;
        private System.Windows.Forms.GroupBox groupBox_Alter;
        private System.Windows.Forms.GroupBox groupBox_Wachtwoord;
        private System.Windows.Forms.Button btn_DeleteAccount;
        private System.Windows.Forms.Label lbl_Accounts;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_Wachtwoord;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Gebruikersnaam;
        private System.Windows.Forms.Button btn_AddAccount;
        private System.Windows.Forms.TextBox textBox_Antwoord;
        private System.Windows.Forms.TextBox textBox_Vraag;
        private System.Windows.Forms.ComboBox comboBox_AdminStatus;
        private System.Windows.Forms.Button btn_ChangeValue;
        private System.Windows.Forms.TextBox textBox_ChangeValue;
        private System.Windows.Forms.Label lbl_Waarde;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_ChangeValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maandag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dinsdag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Woensdag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donderdag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijdag;
        private System.Windows.Forms.ToolStripMenuItem kamerindelingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kamerindelingToolStripMenuItem1;
        private System.Windows.Forms.Label lbl_rooster;
        private System.Windows.Forms.ListView listViewKamerIndeling;
    }
}


using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Activity_Service
    {
        Activity_DAO activity_db = new Activity_DAO();

        public List<Activity> GetActivities()
        {
            try
            {
                List<Activity> activity = activity_db.Db_Get_All_Activity();
                return activity;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Activity> activities = new List<Activity>();
                Activity a = new Activity();
                a.Id = 00;
                a.Description = "oepsie";
                a.AantalStudenten = 0;
                a.AantalBegeleider = 0;
                activities.Add(a);

                return activities;
                //throw new Exception("Someren couldn't connect to the database");
            }

        }

        public List<ActivityFromTeacher> Get_Teacher_SuperVisorId(int docentenNumber)
        {
            try
            {
                List<ActivityFromTeacher> activiteitDocenten = activity_db.Db_Get_Teacher_SuperVisorId(docentenNumber);
                return activiteitDocenten;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<ActivityFromTeacher> activiteiten = new List<ActivityFromTeacher>();

                ActivityFromTeacher a = new ActivityFromTeacher();
                a.LecturerId = 1;
                a.Description = "Bla";
                activiteiten.Add(a);

                return activiteiten;
                //throw new Exception("Someren couldn't connect to the database");
            }
        }

        public List<ActivityFromTeacher> Change_Activities(int docentNumber, int VerangendeDocentIndex)
        {
            List<ActivityFromTeacher> Activiteiten_PersoonA = new List<ActivityFromTeacher>();
            List<ActivityFromTeacher> Activiteiten_PersoonB = new List<ActivityFromTeacher>();
            List<ActivityFromTeacher> Activiteiten_PersoonNew = new List<ActivityFromTeacher>();

            SomerenLogic.Activity_Service activiteitServiceA = new SomerenLogic.Activity_Service();
            Activiteiten_PersoonA = activiteitServiceA.Get_Teacher_SuperVisorId(docentNumber);

            SomerenLogic.Activity_Service activiteitServiceB = new SomerenLogic.Activity_Service();
            Activiteiten_PersoonB = activiteitServiceB.Get_Teacher_SuperVisorId(VerangendeDocentIndex);

            ActivityFromTeacher CopyPersoon_A = new ActivityFromTeacher();

            foreach (SomerenModel.ActivityFromTeacher a in Activiteiten_PersoonA)
            {
                ActivityFromTeacher li_A = new ActivityFromTeacher();
                li_A.LecturerId = a.LecturerId;
                li_A.Description = a.Description;

                CopyPersoon_A.LecturerId = a.LecturerId;
                CopyPersoon_A.Description = a.Description;

                a.Description = "";
            }

            foreach (SomerenModel.ActivityFromTeacher b in Activiteiten_PersoonB)
            {
                ActivityFromTeacher li_B = new ActivityFromTeacher();
                li_B.LecturerId = b.LecturerId;
                li_B.Description = b.Description;

                ActivityFromTeacher TeacherBActivity2 = new ActivityFromTeacher();
                TeacherBActivity2.LecturerId = b.LecturerId;
                TeacherBActivity2.Description = CopyPersoon_A.Description;

                ActivityFromTeacher li_B2 = new ActivityFromTeacher();
                li_B2.LecturerId = b.LecturerId;
                li_B2.Description = CopyPersoon_A.Description;


                Activiteiten_PersoonNew.Add(li_B);
                Activiteiten_PersoonNew.Add(li_B2);
            }

            return Activiteiten_PersoonNew;
        }

        public void UpdateActivity(Activity activity)
        {
            activity_db.WijzigActiviteit(activity);
        }

        public void DeleteActivity(int Id)
        {
            activity_db.VerwijderActiviteit(Id);
        }

        public void AddActivity(Activity activity)
        {
            activity_db.ToevoegenActiviteit(activity);
        }
    }
}

using SomerenDAL;
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
    public partial class ForgotPasswordScreen : Form
    {
        public ForgotPasswordScreen()
        {
            InitializeComponent();
            lbl_antwoordVraag.Hide();
            lbl_Vraag.Hide();
            btn_enter2.Hide();
            tb_Answer.Hide();
            btn_enter3.Hide();
            tb_NewPassword.Hide();
            lbl_nieuwWachtwoord.Hide();
            lbl_MaakNieuwWachtwoord.Hide();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_GebruiksN.Text))
            {
                SomerenLogic.Account_Service AccountVraag = new SomerenLogic.Account_Service();
                Account acc = new Account();

                acc.gebruikersnaam = tb_GebruiksN.Text;


                lbl_Vraag.Text = "Vraag is: " + AccountVraag.ForgotPassword_vraag(acc);
                if (lbl_Vraag.Text == "Vraag is: ")
                {
                    MessageBox.Show("Foute Gebruiksnaam...");
                }
                else
                {
                    lbl_Vraag.Show();
                    lbl_antwoordVraag.Show();
                    tb_Answer.Show();
                    btn_enter2.Show();
                }

            }
        }

        private void btn_enter2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Answer.Text))
            {
                SomerenLogic.Account_Service AccountAntwoord = new SomerenLogic.Account_Service();
                Account acc = new Account();

                acc.gebruikersnaam = tb_GebruiksN.Text;

                string Answer = AccountAntwoord.ForgotPassword_antwoord(acc);

                if (tb_Answer.Text.ToLower() == Answer.ToLower())
                {
                    lbl_nieuwWachtwoord.Show();
                    lbl_MaakNieuwWachtwoord.Show();
                    tb_NewPassword.Show();
                    btn_enter3.Show();
                }
                else
                {
                    MessageBox.Show("Foute Antwoord op vraag..");
                }

            }
        }

        private void btn_enter3_Click(object sender, EventArgs e)
        {
            SomerenLogic.Account_Service AccountNewPassword = new SomerenLogic.Account_Service();
            Account acc = new Account();

            HashAndSalt hashPassword = new HashAndSalt();
            string salt = hashPassword.CreateSalt(64);
            string hashedWachtwoord = hashPassword.GenerateHash(tb_NewPassword.Text, salt);

            AccountNewPassword.AlterPassword(tb_NewPassword.Text, hashedWachtwoord, salt);

            string gebruikersnaam = tb_GebruiksN.Text;
            string wachtwoord = tb_NewPassword.Text;

            AccountNewPassword.AlterPassword(gebruikersnaam, hashedWachtwoord, salt);

            MessageBox.Show("Wachtwoord is veranderd");
            LoginScreen login = new LoginScreen();
            login.Show();
            this.Close();
        }
    }
}

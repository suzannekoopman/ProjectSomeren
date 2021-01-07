using SomerenLogic;
using SomerenModel;
using System;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class RegistrationScreen : Form
    {
        public RegistrationScreen()
        {
            InitializeComponent();
        }

        private void btn_registreren_Click(object sender, EventArgs e)
        {
            SomerenLogic.Account_Service accountToevoegen = new SomerenLogic.Account_Service();
            Account nieuwAccount = new Account();
            HashAndSalt hashPassword = new HashAndSalt();
            string salt = hashPassword.CreateSalt(64);
            string hashedWachtwoord = hashPassword.GenerateHash(txtbox_nieuwePassword.Text, salt);

            nieuwAccount.Gebruikersnaam = txtbox_nieuweUser.Text;
            nieuwAccount.Wachtwoord = hashedWachtwoord;
            nieuwAccount.AdminStatus = "user";
            nieuwAccount.Vraag = txtBox_geheimeVraag.Text;
            nieuwAccount.Antwoord = txtBox_geheimAntwoord.Text;
            nieuwAccount.Salt = salt;

            if (txtbox_licentieSleutel.Text == "XsZAb-tgz3PsD-qYh69un-WQCEx")
            {
                accountToevoegen.AccountToevoegen(nieuwAccount);
                this.Hide();
                LoginScreen loginScreen = new LoginScreen();
                loginScreen.Show();
            }
            else
            {
                MessageBox.Show("Foute licentieSleutel..");
            }
        }
    }
}

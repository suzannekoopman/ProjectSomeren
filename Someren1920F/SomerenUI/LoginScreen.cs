using SomerenDAL;
using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            Account_Service service = new Account_Service();
            Account currentUser = new Account();
            currentUser.Gebruikersnaam = txtbox_Gebruikersnaam.Text;
            string salt = service.GetSalt(currentUser);

            HashAndSalt retrieve = new HashAndSalt();
            string hash = retrieve.GenerateHash(txtbox_Wachtwoord.Text, salt);

            SqlConnection con = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Initial Catalog=pdb1920f6;Persist Security Info=True;User ID=pdb1920f6;Password=Lc9e~P-O3L2d");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM ACCOUNT WHERE Gebruikersnaam ='" + txtbox_Gebruikersnaam.Text + "' AND Hash ='" + hash + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                SomerenUI UI = new SomerenUI();
                UI.Show();

                UI.GetUserName(txtbox_Gebruikersnaam.Text);
            }
            else
            {
                MessageBox.Show("Foute gebruikersnaam en/of wachtwoord..");
            }
        }

        private void btn_registreren_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationScreen registrationScreen = new RegistrationScreen();
            registrationScreen.Show();
        }

        private void btn_wachtwoordVergeten_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPasswordScreen forgotPasswordScreen = new ForgotPasswordScreen();
            forgotPasswordScreen.Show();
        }
    }
}

namespace SomerenUI
{
    partial class LoginScreen
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_wachtwoord = new System.Windows.Forms.Label();
            this.lbl_Gebruikersnaam = new System.Windows.Forms.Label();
            this.txtbox_Wachtwoord = new System.Windows.Forms.TextBox();
            this.txtbox_Gebruikersnaam = new System.Windows.Forms.TextBox();
            this.btn_registreren = new System.Windows.Forms.Button();
            this.btn_wachtwoordVergeten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(199, 278);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(135, 54);
            this.btn_Login.TabIndex = 33;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click_1);
            // 
            // lbl_wachtwoord
            // 
            this.lbl_wachtwoord.AutoSize = true;
            this.lbl_wachtwoord.Location = new System.Drawing.Point(295, 193);
            this.lbl_wachtwoord.Name = "lbl_wachtwoord";
            this.lbl_wachtwoord.Size = new System.Drawing.Size(90, 17);
            this.lbl_wachtwoord.TabIndex = 32;
            this.lbl_wachtwoord.Text = "Wachtwoord:";
            // 
            // lbl_Gebruikersnaam
            // 
            this.lbl_Gebruikersnaam.AutoSize = true;
            this.lbl_Gebruikersnaam.Location = new System.Drawing.Point(282, 119);
            this.lbl_Gebruikersnaam.Name = "lbl_Gebruikersnaam";
            this.lbl_Gebruikersnaam.Size = new System.Drawing.Size(117, 17);
            this.lbl_Gebruikersnaam.TabIndex = 31;
            this.lbl_Gebruikersnaam.Text = "Gebruikersnaam:";
            // 
            // txtbox_Wachtwoord
            // 
            this.txtbox_Wachtwoord.Location = new System.Drawing.Point(174, 219);
            this.txtbox_Wachtwoord.Name = "txtbox_Wachtwoord";
            this.txtbox_Wachtwoord.Size = new System.Drawing.Size(332, 22);
            this.txtbox_Wachtwoord.TabIndex = 30;
            // 
            // txtbox_Gebruikersnaam
            // 
            this.txtbox_Gebruikersnaam.Location = new System.Drawing.Point(174, 148);
            this.txtbox_Gebruikersnaam.Name = "txtbox_Gebruikersnaam";
            this.txtbox_Gebruikersnaam.Size = new System.Drawing.Size(332, 22);
            this.txtbox_Gebruikersnaam.TabIndex = 29;
            // 
            // btn_registreren
            // 
            this.btn_registreren.Location = new System.Drawing.Point(264, 338);
            this.btn_registreren.Name = "btn_registreren";
            this.btn_registreren.Size = new System.Drawing.Size(135, 54);
            this.btn_registreren.TabIndex = 34;
            this.btn_registreren.Text = "Registreren";
            this.btn_registreren.UseVisualStyleBackColor = true;
            this.btn_registreren.Click += new System.EventHandler(this.btn_registreren_Click);
            // 
            // btn_wachtwoordVergeten
            // 
            this.btn_wachtwoordVergeten.Location = new System.Drawing.Point(340, 278);
            this.btn_wachtwoordVergeten.Name = "btn_wachtwoordVergeten";
            this.btn_wachtwoordVergeten.Size = new System.Drawing.Size(135, 54);
            this.btn_wachtwoordVergeten.TabIndex = 36;
            this.btn_wachtwoordVergeten.Text = "Wachtwoord vergeten?";
            this.btn_wachtwoordVergeten.UseVisualStyleBackColor = true;
            this.btn_wachtwoordVergeten.Click += new System.EventHandler(this.btn_wachtwoordVergeten_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 467);
            this.Controls.Add(this.btn_wachtwoordVergeten);
            this.Controls.Add(this.btn_registreren);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_wachtwoord);
            this.Controls.Add(this.lbl_Gebruikersnaam);
            this.Controls.Add(this.txtbox_Wachtwoord);
            this.Controls.Add(this.txtbox_Gebruikersnaam);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_wachtwoord;
        private System.Windows.Forms.Label lbl_Gebruikersnaam;
        private System.Windows.Forms.TextBox txtbox_Wachtwoord;
        private System.Windows.Forms.TextBox txtbox_Gebruikersnaam;
        private System.Windows.Forms.Button btn_registreren;
        private System.Windows.Forms.Button btn_wachtwoordVergeten;
    }
}
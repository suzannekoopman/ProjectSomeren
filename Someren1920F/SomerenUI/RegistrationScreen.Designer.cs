namespace SomerenUI
{
    partial class RegistrationScreen
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
            this.lbl_registreren = new System.Windows.Forms.Label();
            this.lbl_nieuweUser = new System.Windows.Forms.Label();
            this.txtbox_nieuweUser = new System.Windows.Forms.TextBox();
            this.lbl_nieuwePassword = new System.Windows.Forms.Label();
            this.txtbox_nieuwePassword = new System.Windows.Forms.TextBox();
            this.lbl_licentieSleutel = new System.Windows.Forms.Label();
            this.txtbox_licentieSleutel = new System.Windows.Forms.TextBox();
            this.btn_registreren = new System.Windows.Forms.Button();
            this.lbl_Vraag = new System.Windows.Forms.Label();
            this.lbl_Antwoord = new System.Windows.Forms.Label();
            this.txtBox_geheimeVraag = new System.Windows.Forms.TextBox();
            this.txtBox_geheimAntwoord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_registreren
            // 
            this.lbl_registreren.AutoSize = true;
            this.lbl_registreren.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registreren.Location = new System.Drawing.Point(40, 44);
            this.lbl_registreren.Name = "lbl_registreren";
            this.lbl_registreren.Size = new System.Drawing.Size(139, 29);
            this.lbl_registreren.TabIndex = 0;
            this.lbl_registreren.Text = "Registreren";
            // 
            // lbl_nieuweUser
            // 
            this.lbl_nieuweUser.AutoSize = true;
            this.lbl_nieuweUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nieuweUser.Location = new System.Drawing.Point(42, 116);
            this.lbl_nieuweUser.Name = "lbl_nieuweUser";
            this.lbl_nieuweUser.Size = new System.Drawing.Size(193, 20);
            this.lbl_nieuweUser.TabIndex = 1;
            this.lbl_nieuweUser.Text = "Nieuwe gebruikersnaam:";
            // 
            // txtbox_nieuweUser
            // 
            this.txtbox_nieuweUser.Location = new System.Drawing.Point(46, 144);
            this.txtbox_nieuweUser.Name = "txtbox_nieuweUser";
            this.txtbox_nieuweUser.Size = new System.Drawing.Size(290, 22);
            this.txtbox_nieuweUser.TabIndex = 2;
            // 
            // lbl_nieuwePassword
            // 
            this.lbl_nieuwePassword.AutoSize = true;
            this.lbl_nieuwePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nieuwePassword.Location = new System.Drawing.Point(43, 192);
            this.lbl_nieuwePassword.Name = "lbl_nieuwePassword";
            this.lbl_nieuwePassword.Size = new System.Drawing.Size(154, 20);
            this.lbl_nieuwePassword.TabIndex = 3;
            this.lbl_nieuwePassword.Text = "Nieuw wachtwoord:";
            // 
            // txtbox_nieuwePassword
            // 
            this.txtbox_nieuwePassword.Location = new System.Drawing.Point(47, 220);
            this.txtbox_nieuwePassword.Name = "txtbox_nieuwePassword";
            this.txtbox_nieuwePassword.Size = new System.Drawing.Size(289, 22);
            this.txtbox_nieuwePassword.TabIndex = 4;
            // 
            // lbl_licentieSleutel
            // 
            this.lbl_licentieSleutel.AutoSize = true;
            this.lbl_licentieSleutel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_licentieSleutel.Location = new System.Drawing.Point(44, 390);
            this.lbl_licentieSleutel.Name = "lbl_licentieSleutel";
            this.lbl_licentieSleutel.Size = new System.Drawing.Size(122, 20);
            this.lbl_licentieSleutel.TabIndex = 5;
            this.lbl_licentieSleutel.Text = "Licentiesleutel:";
            // 
            // txtbox_licentieSleutel
            // 
            this.txtbox_licentieSleutel.Location = new System.Drawing.Point(48, 423);
            this.txtbox_licentieSleutel.Name = "txtbox_licentieSleutel";
            this.txtbox_licentieSleutel.Size = new System.Drawing.Size(288, 22);
            this.txtbox_licentieSleutel.TabIndex = 6;
            // 
            // btn_registreren
            // 
            this.btn_registreren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registreren.Location = new System.Drawing.Point(47, 480);
            this.btn_registreren.Name = "btn_registreren";
            this.btn_registreren.Size = new System.Drawing.Size(288, 46);
            this.btn_registreren.TabIndex = 7;
            this.btn_registreren.Text = "Registreren";
            this.btn_registreren.UseVisualStyleBackColor = true;
            this.btn_registreren.Click += new System.EventHandler(this.btn_registreren_Click);
            // 
            // lbl_Vraag
            // 
            this.lbl_Vraag.AutoSize = true;
            this.lbl_Vraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vraag.Location = new System.Drawing.Point(44, 258);
            this.lbl_Vraag.Name = "lbl_Vraag";
            this.lbl_Vraag.Size = new System.Drawing.Size(127, 20);
            this.lbl_Vraag.TabIndex = 8;
            this.lbl_Vraag.Text = "Geheime vraag:";
            // 
            // lbl_Antwoord
            // 
            this.lbl_Antwoord.AutoSize = true;
            this.lbl_Antwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Antwoord.Location = new System.Drawing.Point(44, 321);
            this.lbl_Antwoord.Name = "lbl_Antwoord";
            this.lbl_Antwoord.Size = new System.Drawing.Size(145, 20);
            this.lbl_Antwoord.TabIndex = 9;
            this.lbl_Antwoord.Text = "Geheim antwoord:";
            // 
            // txtBox_geheimeVraag
            // 
            this.txtBox_geheimeVraag.Location = new System.Drawing.Point(47, 281);
            this.txtBox_geheimeVraag.Name = "txtBox_geheimeVraag";
            this.txtBox_geheimeVraag.Size = new System.Drawing.Size(289, 22);
            this.txtBox_geheimeVraag.TabIndex = 10;
            // 
            // txtBox_geheimAntwoord
            // 
            this.txtBox_geheimAntwoord.Location = new System.Drawing.Point(45, 344);
            this.txtBox_geheimAntwoord.Name = "txtBox_geheimAntwoord";
            this.txtBox_geheimAntwoord.Size = new System.Drawing.Size(289, 22);
            this.txtBox_geheimAntwoord.TabIndex = 11;
            // 
            // RegistrationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 551);
            this.Controls.Add(this.txtBox_geheimAntwoord);
            this.Controls.Add(this.txtBox_geheimeVraag);
            this.Controls.Add(this.lbl_Antwoord);
            this.Controls.Add(this.lbl_Vraag);
            this.Controls.Add(this.btn_registreren);
            this.Controls.Add(this.txtbox_licentieSleutel);
            this.Controls.Add(this.lbl_licentieSleutel);
            this.Controls.Add(this.txtbox_nieuwePassword);
            this.Controls.Add(this.lbl_nieuwePassword);
            this.Controls.Add(this.txtbox_nieuweUser);
            this.Controls.Add(this.lbl_nieuweUser);
            this.Controls.Add(this.lbl_registreren);
            this.Name = "RegistrationScreen";
            this.Text = "RegistrationScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_registreren;
        private System.Windows.Forms.Label lbl_nieuweUser;
        private System.Windows.Forms.TextBox txtbox_nieuweUser;
        private System.Windows.Forms.Label lbl_nieuwePassword;
        private System.Windows.Forms.TextBox txtbox_nieuwePassword;
        private System.Windows.Forms.Label lbl_licentieSleutel;
        private System.Windows.Forms.TextBox txtbox_licentieSleutel;
        private System.Windows.Forms.Button btn_registreren;
        private System.Windows.Forms.Label lbl_Vraag;
        private System.Windows.Forms.Label lbl_Antwoord;
        private System.Windows.Forms.TextBox txtBox_geheimeVraag;
        private System.Windows.Forms.TextBox txtBox_geheimAntwoord;
    }
}
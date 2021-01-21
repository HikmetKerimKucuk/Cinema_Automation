
namespace Gumele_Cinema_Automation
{
    partial class CreateAdminAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.position_comboBox = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.surname_textBox = new System.Windows.Forms.TextBox();
            this.sex_label = new System.Windows.Forms.Label();
            this.verification_checkBox = new System.Windows.Forms.CheckBox();
            this.dob_label = new System.Windows.Forms.Label();
            this.create_admin_button = new System.Windows.Forms.Button();
            this.sex_comboBox = new System.Windows.Forms.ComboBox();
            this.dateofbirth_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.telephone_textbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eposta_texttbox = new System.Windows.Forms.TextBox();
            this.eposta_backpanel = new System.Windows.Forms.Panel();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.admins_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.back_label = new System.Windows.Forms.Label();
            this.update_aadmin_button = new System.Windows.Forms.Button();
            this.delete_admin_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.eposta_backpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admins_dataGridView)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.position_comboBox);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.sex_label);
            this.panel1.Controls.Add(this.verification_checkBox);
            this.panel1.Controls.Add(this.dob_label);
            this.panel1.Controls.Add(this.create_admin_button);
            this.panel1.Controls.Add(this.sex_comboBox);
            this.panel1.Controls.Add(this.dateofbirth_TimePicker);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.eposta_backpanel);
            this.panel1.Location = new System.Drawing.Point(654, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 541);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(243, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Pozisyonu";
            // 
            // position_comboBox
            // 
            this.position_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.position_comboBox.FormattingEnabled = true;
            this.position_comboBox.Items.AddRange(new object[] {
            "AnaYonetici",
            "Yonetici"});
            this.position_comboBox.Location = new System.Drawing.Point(244, 367);
            this.position_comboBox.Name = "position_comboBox";
            this.position_comboBox.Size = new System.Drawing.Size(148, 28);
            this.position_comboBox.TabIndex = 35;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.surname_textBox);
            this.panel5.Location = new System.Drawing.Point(223, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(169, 48);
            this.panel5.TabIndex = 35;
            // 
            // surname_textBox
            // 
            this.surname_textBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.surname_textBox.BackColor = System.Drawing.Color.White;
            this.surname_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surname_textBox.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname_textBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.surname_textBox.Location = new System.Drawing.Point(6, 11);
            this.surname_textBox.Name = "surname_textBox";
            this.surname_textBox.Size = new System.Drawing.Size(160, 26);
            this.surname_textBox.TabIndex = 8;
            this.surname_textBox.Text = "Soyad";
            // 
            // sex_label
            // 
            this.sex_label.AutoSize = true;
            this.sex_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sex_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sex_label.Location = new System.Drawing.Point(240, 263);
            this.sex_label.Name = "sex_label";
            this.sex_label.Size = new System.Drawing.Size(82, 25);
            this.sex_label.TabIndex = 34;
            this.sex_label.Text = "Cinsiyet";
            // 
            // verification_checkBox
            // 
            this.verification_checkBox.Location = new System.Drawing.Point(83, 419);
            this.verification_checkBox.Name = "verification_checkBox";
            this.verification_checkBox.Size = new System.Drawing.Size(332, 45);
            this.verification_checkBox.TabIndex = 37;
            this.verification_checkBox.Text = " Kaydı Gerçekleşecek ÜyeninBilgilerinin \r\n Doğru Olduğunu Onaylıyorum.";
            this.verification_checkBox.UseVisualStyleBackColor = true;
            this.verification_checkBox.CheckedChanged += new System.EventHandler(this.verification_checkBox_CheckedChanged);
            // 
            // dob_label
            // 
            this.dob_label.AutoSize = true;
            this.dob_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dob_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dob_label.Location = new System.Drawing.Point(29, 263);
            this.dob_label.Name = "dob_label";
            this.dob_label.Size = new System.Drawing.Size(135, 25);
            this.dob_label.TabIndex = 33;
            this.dob_label.Text = "Doğum Tarihi:";
            // 
            // create_admin_button
            // 
            this.create_admin_button.BackColor = System.Drawing.Color.ForestGreen;
            this.create_admin_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_admin_button.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_admin_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.create_admin_button.Location = new System.Drawing.Point(103, 475);
            this.create_admin_button.Name = "create_admin_button";
            this.create_admin_button.Size = new System.Drawing.Size(250, 47);
            this.create_admin_button.TabIndex = 1;
            this.create_admin_button.Text = "Kayıt Et";
            this.create_admin_button.UseVisualStyleBackColor = false;
            this.create_admin_button.Click += new System.EventHandler(this.create_admin_button_Click);
            // 
            // sex_comboBox
            // 
            this.sex_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sex_comboBox.FormattingEnabled = true;
            this.sex_comboBox.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.sex_comboBox.Location = new System.Drawing.Point(241, 291);
            this.sex_comboBox.Name = "sex_comboBox";
            this.sex_comboBox.Size = new System.Drawing.Size(148, 28);
            this.sex_comboBox.TabIndex = 32;
            // 
            // dateofbirth_TimePicker
            // 
            this.dateofbirth_TimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateofbirth_TimePicker.Location = new System.Drawing.Point(31, 291);
            this.dateofbirth_TimePicker.Name = "dateofbirth_TimePicker";
            this.dateofbirth_TimePicker.Size = new System.Drawing.Size(185, 30);
            this.dateofbirth_TimePicker.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.password_textbox);
            this.panel4.Location = new System.Drawing.Point(31, 354);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 48);
            this.panel4.TabIndex = 27;
            // 
            // password_textbox
            // 
            this.password_textbox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.password_textbox.BackColor = System.Drawing.Color.White;
            this.password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_textbox.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.password_textbox.Location = new System.Drawing.Point(6, 11);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(176, 26);
            this.password_textbox.TabIndex = 8;
            this.password_textbox.Text = "Şifreniz";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.telephone_textbox);
            this.panel3.Location = new System.Drawing.Point(31, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 48);
            this.panel3.TabIndex = 28;
            // 
            // telephone_textbox
            // 
            this.telephone_textbox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.telephone_textbox.BackColor = System.Drawing.Color.White;
            this.telephone_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telephone_textbox.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephone_textbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.telephone_textbox.Location = new System.Drawing.Point(6, 11);
            this.telephone_textbox.Name = "telephone_textbox";
            this.telephone_textbox.Size = new System.Drawing.Size(340, 26);
            this.telephone_textbox.TabIndex = 8;
            this.telephone_textbox.Text = "Cep Telefonu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.eposta_texttbox);
            this.panel2.Location = new System.Drawing.Point(31, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 48);
            this.panel2.TabIndex = 29;
            // 
            // eposta_texttbox
            // 
            this.eposta_texttbox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.eposta_texttbox.BackColor = System.Drawing.Color.White;
            this.eposta_texttbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eposta_texttbox.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eposta_texttbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.eposta_texttbox.Location = new System.Drawing.Point(6, 11);
            this.eposta_texttbox.Name = "eposta_texttbox";
            this.eposta_texttbox.Size = new System.Drawing.Size(352, 26);
            this.eposta_texttbox.TabIndex = 8;
            this.eposta_texttbox.Text = "E-posta";
            // 
            // eposta_backpanel
            // 
            this.eposta_backpanel.BackColor = System.Drawing.Color.White;
            this.eposta_backpanel.Controls.Add(this.name_textbox);
            this.eposta_backpanel.Location = new System.Drawing.Point(31, 36);
            this.eposta_backpanel.Name = "eposta_backpanel";
            this.eposta_backpanel.Size = new System.Drawing.Size(174, 48);
            this.eposta_backpanel.TabIndex = 30;
            // 
            // name_textbox
            // 
            this.name_textbox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.name_textbox.BackColor = System.Drawing.Color.White;
            this.name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_textbox.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.name_textbox.Location = new System.Drawing.Point(6, 11);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(158, 26);
            this.name_textbox.TabIndex = 8;
            this.name_textbox.Text = "Ad";
            // 
            // admins_dataGridView
            // 
            this.admins_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admins_dataGridView.Location = new System.Drawing.Point(12, 61);
            this.admins_dataGridView.Name = "admins_dataGridView";
            this.admins_dataGridView.RowHeadersWidth = 51;
            this.admins_dataGridView.RowTemplate.Height = 24;
            this.admins_dataGridView.Size = new System.Drawing.Size(626, 430);
            this.admins_dataGridView.TabIndex = 38;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panel6.Controls.Add(this.back_label);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1073, 40);
            this.panel6.TabIndex = 39;
            // 
            // back_label
            // 
            this.back_label.AutoSize = true;
            this.back_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.back_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_label.Location = new System.Drawing.Point(1027, 9);
            this.back_label.Name = "back_label";
            this.back_label.Size = new System.Drawing.Size(32, 24);
            this.back_label.TabIndex = 0;
            this.back_label.Text = "<<";
            this.back_label.Click += new System.EventHandler(this.back_label_Click);
            // 
            // update_aadmin_button
            // 
            this.update_aadmin_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.update_aadmin_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_aadmin_button.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_aadmin_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.update_aadmin_button.Location = new System.Drawing.Point(49, 511);
            this.update_aadmin_button.Name = "update_aadmin_button";
            this.update_aadmin_button.Size = new System.Drawing.Size(250, 47);
            this.update_aadmin_button.TabIndex = 40;
            this.update_aadmin_button.Text = "Yonetici Güncelle";
            this.update_aadmin_button.UseVisualStyleBackColor = false;
            this.update_aadmin_button.Click += new System.EventHandler(this.update_aadmin_button_Click);
            // 
            // delete_admin_button
            // 
            this.delete_admin_button.BackColor = System.Drawing.Color.Crimson;
            this.delete_admin_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_admin_button.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_admin_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delete_admin_button.Location = new System.Drawing.Point(344, 511);
            this.delete_admin_button.Name = "delete_admin_button";
            this.delete_admin_button.Size = new System.Drawing.Size(250, 47);
            this.delete_admin_button.TabIndex = 41;
            this.delete_admin_button.Text = "Yonetici Kaldır";
            this.delete_admin_button.UseVisualStyleBackColor = false;
            this.delete_admin_button.Click += new System.EventHandler(this.delete_admin_button_Click);
            // 
            // CreateAdminAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 577);
            this.Controls.Add(this.delete_admin_button);
            this.Controls.Add(this.update_aadmin_button);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.admins_dataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAdminAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAdminAccount";
            this.Load += new System.EventHandler(this.CreateAdminAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.eposta_backpanel.ResumeLayout(false);
            this.eposta_backpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admins_dataGridView)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox position_comboBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox surname_textBox;
        private System.Windows.Forms.Label sex_label;
        private System.Windows.Forms.Label dob_label;
        private System.Windows.Forms.ComboBox sex_comboBox;
        private System.Windows.Forms.DateTimePicker dateofbirth_TimePicker;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox telephone_textbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox eposta_texttbox;
        private System.Windows.Forms.Panel eposta_backpanel;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Button create_admin_button;
        private System.Windows.Forms.CheckBox verification_checkBox;
        private System.Windows.Forms.DataGridView admins_dataGridView;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label back_label;
        private System.Windows.Forms.Button update_aadmin_button;
        private System.Windows.Forms.Button delete_admin_button;
    }
}
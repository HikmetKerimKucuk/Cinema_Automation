namespace Gumele_Cinema_Automation
{
    partial class MainPanel
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
            this.top_panel = new System.Windows.Forms.Panel();
            this.close_button = new System.Windows.Forms.Label();
            this.customer_or_admin_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_radioButton = new System.Windows.Forms.RadioButton();
            this.customer_radioButton = new System.Windows.Forms.RadioButton();
            this.forgot_password_label = new System.Windows.Forms.Label();
            this.signuppanel_label = new System.Windows.Forms.Label();
            this.signup_mainlabel = new System.Windows.Forms.Label();
            this.line_label = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.password_backpanel = new System.Windows.Forms.Panel();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.eposta_backpanel = new System.Windows.Forms.Panel();
            this.eposta_texttbox = new System.Windows.Forms.TextBox();
            this.enterance_text = new System.Windows.Forms.Label();
            this.left_pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.top_panel.SuspendLayout();
            this.customer_or_admin_panel.SuspendLayout();
            this.password_backpanel.SuspendLayout();
            this.eposta_backpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.left_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.top_panel.Controls.Add(this.close_button);
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1150, 45);
            this.top_panel.TabIndex = 4;
            // 
            // close_button
            // 
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.ForeColor = System.Drawing.Color.White;
            this.close_button.Location = new System.Drawing.Point(1104, 2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(42, 42);
            this.close_button.TabIndex = 4;
            this.close_button.Text = "X";
            this.close_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // customer_or_admin_panel
            // 
            this.customer_or_admin_panel.Controls.Add(this.label2);
            this.customer_or_admin_panel.Controls.Add(this.label1);
            this.customer_or_admin_panel.Controls.Add(this.admin_radioButton);
            this.customer_or_admin_panel.Controls.Add(this.customer_radioButton);
            this.customer_or_admin_panel.Location = new System.Drawing.Point(745, 419);
            this.customer_or_admin_panel.Name = "customer_or_admin_panel";
            this.customer_or_admin_panel.Size = new System.Drawing.Size(365, 37);
            this.customer_or_admin_panel.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(234, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Türü:";
            // 
            // admin_radioButton
            // 
            this.admin_radioButton.AutoSize = true;
            this.admin_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admin_radioButton.Location = new System.Drawing.Point(139, 8);
            this.admin_radioButton.Name = "admin_radioButton";
            this.admin_radioButton.Size = new System.Drawing.Size(89, 24);
            this.admin_radioButton.TabIndex = 1;
            this.admin_radioButton.TabStop = true;
            this.admin_radioButton.Text = "Yönetici";
            this.admin_radioButton.UseVisualStyleBackColor = true;
            // 
            // customer_radioButton
            // 
            this.customer_radioButton.AutoSize = true;
            this.customer_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customer_radioButton.Location = new System.Drawing.Point(260, 8);
            this.customer_radioButton.Name = "customer_radioButton";
            this.customer_radioButton.Size = new System.Drawing.Size(86, 24);
            this.customer_radioButton.TabIndex = 0;
            this.customer_radioButton.TabStop = true;
            this.customer_radioButton.Text = "Müşteri";
            this.customer_radioButton.UseVisualStyleBackColor = true;
            // 
            // forgot_password_label
            // 
            this.forgot_password_label.AutoSize = true;
            this.forgot_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.forgot_password_label.Location = new System.Drawing.Point(974, 378);
            this.forgot_password_label.Name = "forgot_password_label";
            this.forgot_password_label.Size = new System.Drawing.Size(130, 20);
            this.forgot_password_label.TabIndex = 21;
            this.forgot_password_label.Text = "Şifremi Unuttum";
            this.forgot_password_label.Click += new System.EventHandler(this.forgot_password_label_Click);
            // 
            // signuppanel_label
            // 
            this.signuppanel_label.AutoSize = true;
            this.signuppanel_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signuppanel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signuppanel_label.Location = new System.Drawing.Point(930, 632);
            this.signuppanel_label.Name = "signuppanel_label";
            this.signuppanel_label.Size = new System.Drawing.Size(74, 24);
            this.signuppanel_label.TabIndex = 20;
            this.signuppanel_label.Text = "Buraya";
            this.signuppanel_label.Click += new System.EventHandler(this.Signuppanel_label_Click);
            // 
            // signup_mainlabel
            // 
            this.signup_mainlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signup_mainlabel.Location = new System.Drawing.Point(733, 620);
            this.signup_mainlabel.Name = "signup_mainlabel";
            this.signup_mainlabel.Size = new System.Drawing.Size(391, 92);
            this.signup_mainlabel.TabIndex = 19;
            this.signup_mainlabel.Text = "Henüz Üye Dğilseniz               Tıklayarak \r\nKayıt OLun ve Ayrıcalıklardan Fayd" +
    "alanın.\r\n";
            this.signup_mainlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line_label
            // 
            this.line_label.AutoSize = true;
            this.line_label.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line_label.Location = new System.Drawing.Point(725, 592);
            this.line_label.Name = "line_label";
            this.line_label.Size = new System.Drawing.Size(346, 24);
            this.line_label.TabIndex = 18;
            this.line_label.Text = "--------------------------------------------------------";
            // 
            // Login_button
            // 
            this.Login_button.AutoEllipsis = true;
            this.Login_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login_button.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login_button.Location = new System.Drawing.Point(772, 509);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(301, 62);
            this.Login_button.TabIndex = 17;
            this.Login_button.Text = "Giris Yap";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // password_backpanel
            // 
            this.password_backpanel.BackColor = System.Drawing.Color.White;
            this.password_backpanel.Controls.Add(this.password_textbox);
            this.password_backpanel.Location = new System.Drawing.Point(745, 320);
            this.password_backpanel.Name = "password_backpanel";
            this.password_backpanel.Size = new System.Drawing.Size(365, 48);
            this.password_backpanel.TabIndex = 16;
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
            this.password_textbox.Size = new System.Drawing.Size(355, 26);
            this.password_textbox.TabIndex = 9;
            this.password_textbox.Text = "Parola\r\n";
            this.password_textbox.Click += new System.EventHandler(this.Password_textbox_Click);
            this.password_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_textbox_KeyDown);
            this.password_textbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Password_textbox_KeyUp);
            // 
            // eposta_backpanel
            // 
            this.eposta_backpanel.BackColor = System.Drawing.Color.White;
            this.eposta_backpanel.Controls.Add(this.eposta_texttbox);
            this.eposta_backpanel.Location = new System.Drawing.Point(745, 243);
            this.eposta_backpanel.Name = "eposta_backpanel";
            this.eposta_backpanel.Size = new System.Drawing.Size(365, 48);
            this.eposta_backpanel.TabIndex = 15;
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
            this.eposta_texttbox.Size = new System.Drawing.Size(356, 26);
            this.eposta_texttbox.TabIndex = 8;
            this.eposta_texttbox.Text = "E-posta";
            this.eposta_texttbox.Click += new System.EventHandler(this.Eposta_texttbox_Click);
            this.eposta_texttbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Eposta_texttbox_KeyDown);
            this.eposta_texttbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Eposta_texttbox_KeyUp);
            // 
            // enterance_text
            // 
            this.enterance_text.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterance_text.ForeColor = System.Drawing.Color.Peru;
            this.enterance_text.Location = new System.Drawing.Point(705, 73);
            this.enterance_text.Name = "enterance_text";
            this.enterance_text.Size = new System.Drawing.Size(437, 116);
            this.enterance_text.TabIndex = 14;
            this.enterance_text.Text = "Zaten Hesabın Var mı?\r\nGiris Yap ve \r\nAyrıcalıklardan Faydalan !";
            this.enterance_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // left_pictureBox
            // 
            this.left_pictureBox.BackgroundImage = global::Gumele_Cinema_Automation.Properties.Resources.Left_panel;
            this.left_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.left_pictureBox.Location = new System.Drawing.Point(-1, 45);
            this.left_pictureBox.Name = "left_pictureBox";
            this.left_pictureBox.Size = new System.Drawing.Size(700, 655);
            this.left_pictureBox.TabIndex = 5;
            this.left_pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(700, 684);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 16);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customer_or_admin_panel);
            this.Controls.Add(this.forgot_password_label);
            this.Controls.Add(this.signuppanel_label);
            this.Controls.Add(this.signup_mainlabel);
            this.Controls.Add(this.line_label);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.password_backpanel);
            this.Controls.Add(this.eposta_backpanel);
            this.Controls.Add(this.enterance_text);
            this.Controls.Add(this.left_pictureBox);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPanel";
            this.top_panel.ResumeLayout(false);
            this.customer_or_admin_panel.ResumeLayout(false);
            this.customer_or_admin_panel.PerformLayout();
            this.password_backpanel.ResumeLayout(false);
            this.password_backpanel.PerformLayout();
            this.eposta_backpanel.ResumeLayout(false);
            this.eposta_backpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.left_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label close_button;
        private System.Windows.Forms.PictureBox left_pictureBox;
        private System.Windows.Forms.Panel customer_or_admin_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton admin_radioButton;
        private System.Windows.Forms.RadioButton customer_radioButton;
        private System.Windows.Forms.Label forgot_password_label;
        private System.Windows.Forms.Label signuppanel_label;
        private System.Windows.Forms.Label signup_mainlabel;
        private System.Windows.Forms.Label line_label;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Panel password_backpanel;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Panel eposta_backpanel;
        private System.Windows.Forms.TextBox eposta_texttbox;
        private System.Windows.Forms.Label enterance_text;
        private System.Windows.Forms.Button button1;
    }
}
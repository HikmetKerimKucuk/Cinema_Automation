namespace Gumele_Cinema_Automation
{
    partial class CustomerPanel
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
            this.components = new System.ComponentModel.Container();
            this.top_panel = new System.Windows.Forms.Panel();
            this.previous_panel_label = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.films_panel_button = new System.Windows.Forms.Button();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.campaign_panel_button = new System.Windows.Forms.Button();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.account_panel_button = new System.Windows.Forms.Button();
            this.secret_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tickets_management_button = new System.Windows.Forms.Button();
            this.buyticket_panelbutton = new System.Windows.Forms.Button();
            this.welcome_label = new System.Windows.Forms.Label();
            this.active_customer_label = new System.Windows.Forms.Label();
            this.ads_pictureBox = new System.Windows.Forms.PictureBox();
            this.top_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ads_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.top_panel.Controls.Add(this.previous_panel_label);
            this.top_panel.Controls.Add(this.close_button);
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1150, 45);
            this.top_panel.TabIndex = 1;
            // 
            // previous_panel_label
            // 
            this.previous_panel_label.AutoSize = true;
            this.previous_panel_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previous_panel_label.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous_panel_label.ForeColor = System.Drawing.Color.White;
            this.previous_panel_label.Location = new System.Drawing.Point(12, 6);
            this.previous_panel_label.Name = "previous_panel_label";
            this.previous_panel_label.Size = new System.Drawing.Size(183, 36);
            this.previous_panel_label.TabIndex = 20;
            this.previous_panel_label.Text = "Oturumu Sonlandır";
            this.previous_panel_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.previous_panel_label.Click += new System.EventHandler(this.Previous_panel_label_Click);
            // 
            // close_button
            // 
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.ForeColor = System.Drawing.Color.White;
            this.close_button.Location = new System.Drawing.Point(1104, 0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(42, 42);
            this.close_button.TabIndex = 19;
            this.close_button.Text = "X";
            this.close_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this.films_panel_button;
            // 
            // films_panel_button
            // 
            this.films_panel_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.films_panel_button.FlatAppearance.BorderSize = 0;
            this.films_panel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.films_panel_button.Font = new System.Drawing.Font("Agency FB", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.films_panel_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.films_panel_button.Location = new System.Drawing.Point(54, 122);
            this.films_panel_button.Name = "films_panel_button";
            this.films_panel_button.Size = new System.Drawing.Size(340, 80);
            this.films_panel_button.TabIndex = 8;
            this.films_panel_button.Text = "Vizyondaki  Filmlere Göz At";
            this.films_panel_button.UseVisualStyleBackColor = false;
            this.films_panel_button.Click += new System.EventHandler(this.Films_panel_button_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 50;
            this.bunifuElipse2.TargetControl = this.campaign_panel_button;
            // 
            // campaign_panel_button
            // 
            this.campaign_panel_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.campaign_panel_button.FlatAppearance.BorderSize = 0;
            this.campaign_panel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.campaign_panel_button.Font = new System.Drawing.Font("Agency FB", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campaign_panel_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.campaign_panel_button.Location = new System.Drawing.Point(54, 221);
            this.campaign_panel_button.Name = "campaign_panel_button";
            this.campaign_panel_button.Size = new System.Drawing.Size(340, 80);
            this.campaign_panel_button.TabIndex = 9;
            this.campaign_panel_button.Text = "Bana Özel Kampanyalar";
            this.campaign_panel_button.UseVisualStyleBackColor = false;
            this.campaign_panel_button.Click += new System.EventHandler(this.Campaign_panel_button_Click);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 50;
            this.bunifuElipse3.TargetControl = this.account_panel_button;
            // 
            // account_panel_button
            // 
            this.account_panel_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.account_panel_button.FlatAppearance.BorderSize = 0;
            this.account_panel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account_panel_button.Font = new System.Drawing.Font("Agency FB", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_panel_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.account_panel_button.Location = new System.Drawing.Point(59, 326);
            this.account_panel_button.Name = "account_panel_button";
            this.account_panel_button.Size = new System.Drawing.Size(340, 80);
            this.account_panel_button.TabIndex = 10;
            this.account_panel_button.Text = "Hesap Bilgilerim";
            this.account_panel_button.UseVisualStyleBackColor = false;
            this.account_panel_button.Click += new System.EventHandler(this.Account_panel_button_Click);
            // 
            // secret_label
            // 
            this.secret_label.AutoSize = true;
            this.secret_label.Location = new System.Drawing.Point(921, 147);
            this.secret_label.Name = "secret_label";
            this.secret_label.Size = new System.Drawing.Size(0, 17);
            this.secret_label.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BackgroundImage = global::Gumele_Cinema_Automation.Properties.Resources.colorfull_bg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tickets_management_button);
            this.panel1.Controls.Add(this.films_panel_button);
            this.panel1.Controls.Add(this.account_panel_button);
            this.panel1.Controls.Add(this.buyticket_panelbutton);
            this.panel1.Controls.Add(this.welcome_label);
            this.panel1.Controls.Add(this.active_customer_label);
            this.panel1.Controls.Add(this.campaign_panel_button);
            this.panel1.Location = new System.Drawing.Point(701, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 655);
            this.panel1.TabIndex = 15;
            // 
            // tickets_management_button
            // 
            this.tickets_management_button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.tickets_management_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tickets_management_button.Font = new System.Drawing.Font("Agency FB", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickets_management_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tickets_management_button.Location = new System.Drawing.Point(109, 545);
            this.tickets_management_button.Name = "tickets_management_button";
            this.tickets_management_button.Size = new System.Drawing.Size(240, 52);
            this.tickets_management_button.TabIndex = 14;
            this.tickets_management_button.Text = "Biletlerim";
            this.tickets_management_button.UseVisualStyleBackColor = false;
            this.tickets_management_button.Click += new System.EventHandler(this.tickets_management_button_Click);
            // 
            // buyticket_panelbutton
            // 
            this.buyticket_panelbutton.BackColor = System.Drawing.Color.ForestGreen;
            this.buyticket_panelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyticket_panelbutton.Font = new System.Drawing.Font("Agency FB", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyticket_panelbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buyticket_panelbutton.Location = new System.Drawing.Point(109, 465);
            this.buyticket_panelbutton.Name = "buyticket_panelbutton";
            this.buyticket_panelbutton.Size = new System.Drawing.Size(240, 55);
            this.buyticket_panelbutton.TabIndex = 11;
            this.buyticket_panelbutton.Text = "Bilet Satın Al";
            this.buyticket_panelbutton.UseVisualStyleBackColor = false;
            this.buyticket_panelbutton.Click += new System.EventHandler(this.Buyticket_panelbutton_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.BackColor = System.Drawing.Color.Transparent;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.welcome_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcome_label.Location = new System.Drawing.Point(161, 21);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(129, 31);
            this.welcome_label.TabIndex = 12;
            this.welcome_label.Text = "Hoşgeldin";
            this.welcome_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // active_customer_label
            // 
            this.active_customer_label.BackColor = System.Drawing.Color.Transparent;
            this.active_customer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.active_customer_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.active_customer_label.Location = new System.Drawing.Point(49, 60);
            this.active_customer_label.Name = "active_customer_label";
            this.active_customer_label.Size = new System.Drawing.Size(350, 40);
            this.active_customer_label.TabIndex = 13;
            this.active_customer_label.Text = "Kullanıcı Ad Soyad";
            this.active_customer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ads_pictureBox
            // 
            this.ads_pictureBox.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ads_pictureBox.BackgroundImage = global::Gumele_Cinema_Automation.Properties.Resources.cinema_seats;
            this.ads_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ads_pictureBox.Location = new System.Drawing.Point(0, 45);
            this.ads_pictureBox.Name = "ads_pictureBox";
            this.ads_pictureBox.Size = new System.Drawing.Size(700, 655);
            this.ads_pictureBox.TabIndex = 2;
            this.ads_pictureBox.TabStop = false;
            // 
            // CustomerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.secret_label);
            this.Controls.Add(this.ads_pictureBox);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerPanel";
            this.Load += new System.EventHandler(this.CustomerPanel_Load);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ads_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label previous_panel_label;
        private System.Windows.Forms.Label close_button;
        private System.Windows.Forms.PictureBox ads_pictureBox;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Button films_panel_button;
        private System.Windows.Forms.Button campaign_panel_button;
        private System.Windows.Forms.Button account_panel_button;
        private System.Windows.Forms.Button buyticket_panelbutton;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label active_customer_label;
        private System.Windows.Forms.Label secret_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tickets_management_button;
    }
}

namespace Gumele_Cinema_Automation
{
    partial class CustomerTicketPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerTicketPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.change_seat_button = new System.Windows.Forms.Button();
            this.user_name_surname_label = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.ticket_price_label = new System.Windows.Forms.Label();
            this.seat = new System.Windows.Forms.Label();
            this.filmhour = new System.Windows.Forms.Label();
            this.filmdate = new System.Windows.Forms.Label();
            this.saloon = new System.Windows.Forms.Label();
            this.film = new System.Windows.Forms.Label();
            this.rezervation_hours_label = new System.Windows.Forms.Label();
            this.saloon_no_label = new System.Windows.Forms.Label();
            this.rezervation_date_label = new System.Windows.Forms.Label();
            this.film_name_label = new System.Windows.Forms.Label();
            this.name_surname = new System.Windows.Forms.Label();
            this.delete_ticket_button = new System.Windows.Forms.Button();
            this.mytickets_dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buydate_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.seat_no_label_textBox = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mytickets_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 25);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(953, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "<<";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(295, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 25);
            this.label7.TabIndex = 46;
            this.label7.Text = "TL";
            // 
            // change_seat_button
            // 
            this.change_seat_button.BackColor = System.Drawing.Color.White;
            this.change_seat_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_seat_button.FlatAppearance.BorderSize = 0;
            this.change_seat_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_seat_button.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_seat_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.change_seat_button.Location = new System.Drawing.Point(323, 566);
            this.change_seat_button.Name = "change_seat_button";
            this.change_seat_button.Size = new System.Drawing.Size(10, 10);
            this.change_seat_button.TabIndex = 45;
            this.change_seat_button.Text = "Koltuk Degistir";
            this.change_seat_button.UseVisualStyleBackColor = false;
            this.change_seat_button.Click += new System.EventHandler(this.change_seat_button_Click);
            // 
            // user_name_surname_label
            // 
            this.user_name_surname_label.BackColor = System.Drawing.Color.Transparent;
            this.user_name_surname_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.user_name_surname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.user_name_surname_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.user_name_surname_label.Location = new System.Drawing.Point(62, 66);
            this.user_name_surname_label.Name = "user_name_surname_label";
            this.user_name_surname_label.Size = new System.Drawing.Size(270, 38);
            this.user_name_surname_label.TabIndex = 43;
            this.user_name_surname_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.price.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.price.Location = new System.Drawing.Point(202, 438);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(96, 20);
            this.price.TabIndex = 42;
            this.price.Text = "Bilet Tutarı:";
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // ticket_price_label
            // 
            this.ticket_price_label.BackColor = System.Drawing.Color.Transparent;
            this.ticket_price_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ticket_price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ticket_price_label.ForeColor = System.Drawing.Color.White;
            this.ticket_price_label.Location = new System.Drawing.Point(199, 458);
            this.ticket_price_label.Name = "ticket_price_label";
            this.ticket_price_label.Size = new System.Drawing.Size(132, 38);
            this.ticket_price_label.TabIndex = 41;
            this.ticket_price_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seat
            // 
            this.seat.AutoSize = true;
            this.seat.BackColor = System.Drawing.Color.Transparent;
            this.seat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seat.Location = new System.Drawing.Point(195, 347);
            this.seat.Name = "seat";
            this.seat.Size = new System.Drawing.Size(137, 20);
            this.seat.TabIndex = 40;
            this.seat.Text = "Koltuk Numarası:";
            // 
            // filmhour
            // 
            this.filmhour.AutoSize = true;
            this.filmhour.BackColor = System.Drawing.Color.Transparent;
            this.filmhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmhour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filmhour.Location = new System.Drawing.Point(61, 347);
            this.filmhour.Name = "filmhour";
            this.filmhour.Size = new System.Drawing.Size(99, 20);
            this.filmhour.TabIndex = 38;
            this.filmhour.Text = "Seans Saati";
            // 
            // filmdate
            // 
            this.filmdate.AutoSize = true;
            this.filmdate.BackColor = System.Drawing.Color.Transparent;
            this.filmdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filmdate.Location = new System.Drawing.Point(61, 270);
            this.filmdate.Name = "filmdate";
            this.filmdate.Size = new System.Drawing.Size(108, 20);
            this.filmdate.TabIndex = 37;
            this.filmdate.Text = "Seans Tarihi:";
            // 
            // saloon
            // 
            this.saloon.AutoSize = true;
            this.saloon.BackColor = System.Drawing.Color.Transparent;
            this.saloon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saloon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saloon.Location = new System.Drawing.Point(61, 192);
            this.saloon.Name = "saloon";
            this.saloon.Size = new System.Drawing.Size(139, 20);
            this.saloon.TabIndex = 36;
            this.saloon.Text = "Gösterim Salonu:";
            // 
            // film
            // 
            this.film.AutoSize = true;
            this.film.BackColor = System.Drawing.Color.Transparent;
            this.film.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.film.ForeColor = System.Drawing.SystemColors.Control;
            this.film.Location = new System.Drawing.Point(61, 115);
            this.film.Name = "film";
            this.film.Size = new System.Drawing.Size(106, 20);
            this.film.TabIndex = 35;
            this.film.Text = "Seçilen Film:";
            // 
            // rezervation_hours_label
            // 
            this.rezervation_hours_label.BackColor = System.Drawing.Color.Transparent;
            this.rezervation_hours_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rezervation_hours_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezervation_hours_label.ForeColor = System.Drawing.Color.White;
            this.rezervation_hours_label.Location = new System.Drawing.Point(63, 370);
            this.rezervation_hours_label.Name = "rezervation_hours_label";
            this.rezervation_hours_label.Size = new System.Drawing.Size(106, 38);
            this.rezervation_hours_label.TabIndex = 34;
            this.rezervation_hours_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saloon_no_label
            // 
            this.saloon_no_label.BackColor = System.Drawing.Color.Transparent;
            this.saloon_no_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.saloon_no_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saloon_no_label.ForeColor = System.Drawing.Color.White;
            this.saloon_no_label.Location = new System.Drawing.Point(63, 217);
            this.saloon_no_label.Name = "saloon_no_label";
            this.saloon_no_label.Size = new System.Drawing.Size(270, 38);
            this.saloon_no_label.TabIndex = 33;
            this.saloon_no_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rezervation_date_label
            // 
            this.rezervation_date_label.BackColor = System.Drawing.Color.Transparent;
            this.rezervation_date_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rezervation_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezervation_date_label.ForeColor = System.Drawing.Color.White;
            this.rezervation_date_label.Location = new System.Drawing.Point(63, 293);
            this.rezervation_date_label.Name = "rezervation_date_label";
            this.rezervation_date_label.Size = new System.Drawing.Size(270, 38);
            this.rezervation_date_label.TabIndex = 32;
            this.rezervation_date_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // film_name_label
            // 
            this.film_name_label.BackColor = System.Drawing.Color.Transparent;
            this.film_name_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.film_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.film_name_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.film_name_label.Location = new System.Drawing.Point(63, 139);
            this.film_name_label.Name = "film_name_label";
            this.film_name_label.Size = new System.Drawing.Size(270, 38);
            this.film_name_label.TabIndex = 31;
            this.film_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_surname
            // 
            this.name_surname.AutoSize = true;
            this.name_surname.BackColor = System.Drawing.Color.Transparent;
            this.name_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name_surname.ForeColor = System.Drawing.SystemColors.Control;
            this.name_surname.Location = new System.Drawing.Point(60, 43);
            this.name_surname.Name = "name_surname";
            this.name_surname.Size = new System.Drawing.Size(90, 20);
            this.name_surname.TabIndex = 44;
            this.name_surname.Text = "Satın Alan:";
            // 
            // delete_ticket_button
            // 
            this.delete_ticket_button.BackColor = System.Drawing.Color.Crimson;
            this.delete_ticket_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_ticket_button.FlatAppearance.BorderSize = 0;
            this.delete_ticket_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_ticket_button.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_ticket_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delete_ticket_button.Location = new System.Drawing.Point(59, 523);
            this.delete_ticket_button.Name = "delete_ticket_button";
            this.delete_ticket_button.Size = new System.Drawing.Size(274, 53);
            this.delete_ticket_button.TabIndex = 47;
            this.delete_ticket_button.Text = "Bilet İptal Et";
            this.delete_ticket_button.UseVisualStyleBackColor = false;
            this.delete_ticket_button.Click += new System.EventHandler(this.delete_ticket_button_Click);
            // 
            // mytickets_dataGridView
            // 
            this.mytickets_dataGridView.AllowUserToAddRows = false;
            this.mytickets_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mytickets_dataGridView.Location = new System.Drawing.Point(369, 94);
            this.mytickets_dataGridView.Name = "mytickets_dataGridView";
            this.mytickets_dataGridView.ReadOnly = true;
            this.mytickets_dataGridView.RowHeadersWidth = 51;
            this.mytickets_dataGridView.RowTemplate.Height = 24;
            this.mytickets_dataGridView.Size = new System.Drawing.Size(587, 482);
            this.mytickets_dataGridView.TabIndex = 49;
            this.mytickets_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mytickets_dataGridView_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(62, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Alım Tarihi.";
            // 
            // buydate_label
            // 
            this.buydate_label.BackColor = System.Drawing.Color.Transparent;
            this.buydate_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.buydate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buydate_label.ForeColor = System.Drawing.Color.White;
            this.buydate_label.Location = new System.Drawing.Point(64, 458);
            this.buydate_label.Name = "buydate_label";
            this.buydate_label.Size = new System.Drawing.Size(106, 38);
            this.buydate_label.TabIndex = 50;
            this.buydate_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(376, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 36);
            this.label3.TabIndex = 52;
            this.label3.Text = "Satın Alınan Biletler:";
            // 
            // seat_no_label_textBox
            // 
            this.seat_no_label_textBox.BackColor = System.Drawing.Color.Transparent;
            this.seat_no_label_textBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat_no_label_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seat_no_label_textBox.ForeColor = System.Drawing.Color.White;
            this.seat_no_label_textBox.Location = new System.Drawing.Point(199, 370);
            this.seat_no_label_textBox.Name = "seat_no_label_textBox";
            this.seat_no_label_textBox.Size = new System.Drawing.Size(132, 38);
            this.seat_no_label_textBox.TabIndex = 53;
            this.seat_no_label_textBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerTicketPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 600);
            this.Controls.Add(this.seat_no_label_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buydate_label);
            this.Controls.Add(this.mytickets_dataGridView);
            this.Controls.Add(this.delete_ticket_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.change_seat_button);
            this.Controls.Add(this.name_surname);
            this.Controls.Add(this.user_name_surname_label);
            this.Controls.Add(this.price);
            this.Controls.Add(this.ticket_price_label);
            this.Controls.Add(this.seat);
            this.Controls.Add(this.filmhour);
            this.Controls.Add(this.filmdate);
            this.Controls.Add(this.saloon);
            this.Controls.Add(this.film);
            this.Controls.Add(this.rezervation_hours_label);
            this.Controls.Add(this.saloon_no_label);
            this.Controls.Add(this.rezervation_date_label);
            this.Controls.Add(this.film_name_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerTicketPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerTicketPanel";
            this.Load += new System.EventHandler(this.CustomerTicketPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mytickets_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button change_seat_button;
        private System.Windows.Forms.Label user_name_surname_label;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label ticket_price_label;
        private System.Windows.Forms.Label seat;
        private System.Windows.Forms.Label filmhour;
        private System.Windows.Forms.Label filmdate;
        private System.Windows.Forms.Label saloon;
        private System.Windows.Forms.Label film;
        private System.Windows.Forms.Label rezervation_hours_label;
        private System.Windows.Forms.Label saloon_no_label;
        private System.Windows.Forms.Label rezervation_date_label;
        private System.Windows.Forms.Label film_name_label;
        private System.Windows.Forms.Label name_surname;
        private System.Windows.Forms.Button delete_ticket_button;
        private System.Windows.Forms.DataGridView mytickets_dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label buydate_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label seat_no_label_textBox;
    }
}
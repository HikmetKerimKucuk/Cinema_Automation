using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gumele_Cinema_Automation.Properties;
using Oracle.ManagedDataAccess.Client;

namespace Gumele_Cinema_Automation
{
    public partial class BuyTicketPanel : Form
    {
        public BuyTicketPanel()
        {
            InitializeComponent();
        }
        //Button btn = new Button();
        int cou1 = 0;
        int cou2 = 0;
        string save_user_id_info_string = "";
        OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
        int afis_sayaci = 0;
        public string user_id_text;
        public string user_name_text;
        public string user_surname_text;
        public string seans_idd;
        public string film_idd;
        public string saloon_idd;
        public string saloon_name;
        string bugun;
        private void Film_Afisi_Goster(string sql_film_adi)
        {
            //OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut_film_adi = new OracleCommand(sql_film_adi, baglanti);
            //OracleCommand komut_afis_gorseli = new OracleCommand(sql_afis_gorseli, baglanti);
            baglanti.Open();
            OracleDataReader oku_film_adi = komut_film_adi.ExecuteReader();
            //OracleDataReader oku_afis_gorseli = komut_afis_gorseli.ExecuteReader();

            while (oku_film_adi.Read())
            {
                afis_sayaci = afis_sayaci + 1;

                if (afis_sayaci == 1)
                {
                    kanvas1_pictureBox.ImageLocation = oku_film_adi["poster"].ToString();
                    kanvas1_film_label.Text = oku_film_adi["film_adi"].ToString();
                    kanvas1_pictureBox.Visible = true;
                    kanvas1_film_label.Visible = true;
                }
                else if (afis_sayaci == 2)
                {
                    kanvas2_pictureBox.ImageLocation = oku_film_adi["poster"].ToString();
                    kanvas2_film_label.Text = oku_film_adi["film_adi"].ToString();
                    kanvas2_pictureBox.Visible = true;
                    kanvas2_film_label.Visible = true;
                }
                else if (afis_sayaci == 3)
                {
                    kanvas3_pictureBox.ImageLocation = oku_film_adi["poster"].ToString();
                    kanvas3_film_label.Text = oku_film_adi["film_adi"].ToString();
                    kanvas3_pictureBox.Visible = true;
                    kanvas3_film_label.Visible = true;
                }
                else if (afis_sayaci == 4)
                {
                    kanvas4_pictureBox.ImageLocation = oku_film_adi["poster"].ToString();
                    kanvas4_film_label.Text = oku_film_adi["film_adi"].ToString();
                    kanvas4_pictureBox.Visible = true;
                    kanvas4_film_label.Visible = true;
                    //label5.Visible = true;
                }
                else if (afis_sayaci == 5)
                {
                    kanvas5_pictureBox.ImageLocation = oku_film_adi["poster"].ToString();
                    kanvas5_film_label.Text = oku_film_adi["film_adi"].ToString();
                    kanvas5_pictureBox.Visible = true;
                    kanvas5_film_label.Visible = true;
                }
                else if (afis_sayaci == 6)
                {
                    kanvas6_pictureBox.ImageLocation = oku_film_adi["poster"].ToString();
                    kanvas6_film_label.Text = oku_film_adi["film_adi"].ToString();
                    kanvas6_pictureBox.Visible = true;
                    kanvas6_film_label.Visible = true;
                }
                else if (afis_sayaci == 7)
                {
                    kanvas7_pictureBox.ImageLocation = oku_film_adi["poster"].ToString();
                    kanvas7_film_label.Text = oku_film_adi["film_adi"].ToString();
                    kanvas7_pictureBox.Visible = true;
                    kanvas7_film_label.Visible = true;
                }
                else if (afis_sayaci == 8)
                {
                    kanvas8_pictureBox.ImageLocation = oku_film_adi["poster"].ToString();
                    kanvas8_film_label.Text = oku_film_adi["film_adi"].ToString();
                    kanvas8_pictureBox.Visible = true;
                    kanvas8_film_label.Visible = true;
                }
                else if (afis_sayaci == 9)
                {
                    kanvas9_pictureBox.ImageLocation = oku_film_adi["poster"].ToString();
                    kanvas9_film_label.Text = oku_film_adi["film_adi"].ToString();
                    kanvas9_pictureBox.Visible = true;
                    kanvas9_film_label.Visible = true;
                    scroll_down_label.Visible = true;
                }
                else if (afis_sayaci == 10)
                {
                    kanvas10_pictureBox.ImageLocation = oku_film_adi["poster"].ToString();
                    kanvas10_film_label.Text = oku_film_adi["film_adi"].ToString();
                    kanvas10_pictureBox.Visible = true;
                    kanvas10_film_label.Visible = true;
                    
                }
                else if (afis_sayaci == 11)
                {
                    kanvas11_pictureBox.ImageLocation = oku_film_adi["poster"].ToString();
                    kanvas11_film_label.Text = oku_film_adi["film_adi"].ToString();
                    kanvas11_pictureBox.Visible = true;
                    kanvas11_film_label.Visible = true;
                }
                else if (afis_sayaci == 12)
                {
                    kanvas12_pictureBox.ImageLocation = oku_film_adi["poster"].ToString();
                    kanvas12_film_label.Text = oku_film_adi["film_adi"].ToString();
                    kanvas12_pictureBox.Visible = true;
                    kanvas12_film_label.Visible = true;
                }
            }
            baglanti.Close();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e) /*previous_panel_button*/
        {
            CustomerPanel cp = new CustomerPanel();
            //cp.call_succesfull_id_info(save_user_id_info_string);
            cp.call_succesfull_eposta_text(user_id_text, user_name_text, user_surname_text);
            this.Hide();
            cp.Show();
        }

        /*public void fetch_user_id_info(string user_id_info)
        {
            save_user_id_info_string = user_id_info;
        }*/

        private void BuyTicketPanel_Load(object sender, EventArgs e)
        {
            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand("SELECT * FROM musteriler", baglanti);
            baglanti.Open();
            OracleDataReader oku = komut.ExecuteReader();
            //SqlCommand komut = new SqlCommand(sqltum, baglanti);
            //SqlDataReader oku = komut.ExecuteReader();
            cinema_seats_layout_panel();
            while (oku.Read() == true)
            {
                if (user_id_text == oku["musteri_id"].ToString())
                {
                    user_name_surname_label.Text = oku["ad"].ToString()+" "+ oku["soyad"].ToString();
                    //user_id_info_text = oku["MUSTERİ_İD"].ToString();

                }
            }
            //Choose_film_label_Click(object sender, EventArgs e);
            //choose_film_label();
            film_choose_window_show();
            baglanti.Close();

            
        }

        private void cinema_seats_layout_panel()
        {
            int sayac = 107;
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 14; x++)
                {

                    Button btn = new Button();
                    //btn.Image = Image.FromFile(@"C:\Users\MorCivciv\Desktop\anank.jpg");
                    btn.Size = new Size(37, 37);

                    if (x == 9 && y != 6 && y != 7 && y != 8)
                        continue;
                    if (y == 5)
                    {
                        continue;

                    }
                    else
                    {
                        object seats_picture = Resources.ResourceManager.GetObject("red_seat_piture"); //Return an object from the image chan1.png in the project
                        btn.BackgroundImage = (Image)seats_picture; //Set the Image property of channelPic to the returned object as Image
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.Location = new Point(x * 37 + 9, y * 37 + 9);
                        btn.Name = sayac.ToString();
                        btn.Text = sayac.ToString();
                        btn.ForeColor = Color.White;
                        btn.BackColor = Color.Transparent;
                        sayac--;
                        this.seats_groupBox.Controls.Add(btn);
                        btn.Click += Btn_Click;

                    }

                }

            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            if (tiklanan.ForeColor == Color.White)
            {
                seat_no_label.Text = tiklanan.Text;
            }
        }

        private void Kanvas1_pictureBox_Click(object sender, EventArgs e)
        {
            film_name_label.Text = kanvas1_film_label.Text;
            session_choose_clear();
            Seans_Tarih();
            Yeniden_Renklendir_red();
        }

        private void Kanvas2_pictureBox_Click(object sender, EventArgs e)
        {
            film_name_label.Text = kanvas2_film_label.Text;
            session_choose_clear();
            Seans_Tarih();
            Yeniden_Renklendir_red();
        }

        private void Kanvas3_pictureBox_Click(object sender, EventArgs e)
        {
            film_name_label.Text = kanvas3_film_label.Text;
            session_choose_clear();
            Seans_Tarih();
            Yeniden_Renklendir_red();
        }

        private void Kanvas4_pictureBox_Click(object sender, EventArgs e)
        {
            film_name_label.Text = kanvas4_film_label.Text;
            session_choose_clear();
            Seans_Tarih();
            Yeniden_Renklendir_red();
        }

        private void Kanvas5_pictureBox_Click(object sender, EventArgs e)
        {
            film_name_label.Text = kanvas5_film_label.Text;
            session_choose_clear();
        }

        private void Kanvas6_pictureBox_Click(object sender, EventArgs e)
        {
            film_name_label.Text = kanvas6_film_label.Text;
            session_choose_clear();
        }

        private void Kanvas7_pictureBox_Click(object sender, EventArgs e)
        {
            film_name_label.Text = kanvas7_film_label.Text;
            session_choose_clear();
        }

        private void Kanvas8_pictureBox_Click(object sender, EventArgs e)
        {
            film_name_label.Text = kanvas8_film_label.Text;
            session_choose_clear();
        }

        private void Kanvas9_pictureBox_Click(object sender, EventArgs e)
        {
            film_name_label.Text = kanvas9_film_label.Text;
            session_choose_clear();
        }

        private void Kanvas10_pictureBox_Click(object sender, EventArgs e)
        {
            film_name_label.Text = kanvas10_film_label.Text;
            session_choose_clear();
        }

        private void Kanvas11_pictureBox_Click(object sender, EventArgs e)
        {
            film_name_label.Text = kanvas11_film_label.Text;
            session_choose_clear();
        }

        private void Kanvas12_pictureBox_Click(object sender, EventArgs e)
        {
            film_name_label.Text = kanvas12_film_label.Text;
            session_choose_clear();
        }

        private void Rezervation_date_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(rezervation_date_comboBox.Text);
            //MessageBox.Show(dt.ToShortDateString());
            rezervation_date_label.Text = dt.ToShortDateString();
            rezervation_hours_comboBox.Items.Clear();
            rezervation_hours_comboBox.Text = "";
            Seans_Saat();
        }

        private void Seans_Tarih()
        {
            //baglanti.Open();
            film_id_find();
            rezervation_date_comboBox.Items.Clear();
            OracleCommand komut = new OracleCommand("SELECT * FROM seanslar", baglanti);
            baglanti.Open();
            OracleDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (film_idd == oku["film_id"].ToString())
                {
                   // rezervation_date_comboBox.Items.Add(oku["yayin_tarihi"].ToString());
                    //if (DateTime.Parse(oku["tarih"].ToString()) >= DateTime.Parse(DateTime.Now.ToShortDateString()))
                    //{
                    if (!rezervation_date_comboBox.Items.Contains(oku["seans_tarihi"].ToString()))
                        {
                       /* DateTime dt = DateTime.Parse(oku["seans_tarihi"].ToString());
                       //  MessageBox.Show(dt.ToShortDateString());
                         rezervation_date_comboBox.Items.Add(dt.ToShortDateString());*/
                        rezervation_date_comboBox.Items.Add(oku["seans_tarihi"].ToString());
                    }
                    //}

                }


            }

            baglanti.Close();
        }
        private void Seans_salon()
        {
            saloon_no_comboBox.Items.Clear();
            //baglanti.Open();
            OracleCommand komut = new OracleCommand("SELECT * FROM seanslar", baglanti);
            OracleCommand komut2 = new OracleCommand("SELECT * FROM salonlar", baglanti);
            baglanti.Open();
            OracleDataReader oku = komut.ExecuteReader();
            OracleDataReader oku2 = komut2.ExecuteReader();
            while (oku.Read())
            {
                if (film_idd == oku["film_id"].ToString())
                {
                    if (rezervation_date_comboBox.Text == oku["seans_tarihi"].ToString())
                    {
                        if (rezervation_hours_label.Text == oku["seans_saati"].ToString())
                        {
                            if (!saloon_no_comboBox.Items.Contains(oku["seans_tarihi"].ToString()))
                            {
                                ticket_price_label.Text = oku["bilet_ucreti"].ToString();
                                //MessageBox.Show(saloon_idd);
                                salon_id_find_beginning();
                                //MessageBox.Show(saloon_idd);
                                while (oku2.Read())
                                {
                                    if (saloon_idd == oku2["salon_id"].ToString())
                                    {
                                        //saloon_name = oku["salon_adi"].ToString();
                                        //baglanti.Close();
                                        //return seansid;
                                        saloon_no_comboBox.Items.Add(oku2["salon_adi"].ToString());
                                        //ticket_price_label.Text = oku["bilet_ucreti"].ToString();
                                    }
                                }
                                
                            }
                        }
                    }
                    // rezervation_date_comboBox.Items.Add(oku["yayin_tarihi"].ToString());
                    //if (DateTime.Parse(oku["tarih"].ToString()) >= DateTime.Parse(DateTime.Now.ToShortDateString()))
                    //{
                    
                    //}

                }


            }

            baglanti.Close();
        }

        private void Choose_film_button_Click(object sender, EventArgs e)
        {
            
           /* if (cou1 ==0)
            {
                Film_Afisi_Goster("select film_adi,utl_raw.cast_to_varchar2(dbms_lob.substr(afis_gorseli)) as poster from filmler");
                cou1 += 1;

            }
            //Film_Afisi_Goster("select film_adi,utl_raw.cast_to_varchar2(dbms_lob.substr(afis_gorseli)) as poster from filmler");
            tabControl1.SelectTab(0);*/
        }

        private void Rezervation_seat_button_Click(object sender, EventArgs e)
        {
           /* if (cou2 == 0)
            {
                //Film_Afisi_Goster("select film_adi,utl_raw.cast_to_varchar2(dbms_lob.substr(afis_gorseli)) as poster from filmler");
                Seans_Tarih();
                //Seans_Saat();
                cou2 += 1;

            }
            tabControl1.SelectTab(2);*/
        }

        private void Seans_Saat()
        {
            rezervation_hours_comboBox.Items.Clear();
            //baglanti.Open();
            OracleCommand komut = new OracleCommand("SELECT * FROM seanslar", baglanti);
            baglanti.Open();
            OracleDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (DateTime.Parse(oku["seans_tarihi"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (DateTime.Parse(oku["seans_tarihi"].ToString()) > DateTime.Parse(DateTime.Now.ToShortTimeString()))
                    {
                        if (film_idd == oku["film_id"].ToString())
                        {
                            if (rezervation_date_comboBox.Text == oku["seans_tarihi"].ToString())
                            {
                                if (!rezervation_hours_comboBox.Items.Contains(oku["seans_saati"].ToString()))
                                {
                                    rezervation_hours_comboBox.Items.Add(oku["seans_saati"].ToString());
                                    
                                }

                            }
                        }
                    }
                }

                else if (DateTime.Parse(oku["seans_tarihi"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (film_idd == oku["film_id"].ToString())
                    {
                        if (rezervation_date_comboBox.Text == oku["seans_tarihi"].ToString())
                        {
                            if (!rezervation_hours_comboBox.Items.Contains(oku["seans_saati"].ToString()))
                            {
                                rezervation_hours_comboBox.Items.Add(oku["seans_saati"].ToString());
                                
                            }
                        }
                    }
                }

            }

            baglanti.Close();
        }

        private void Rezervation_hours_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rezervation_hours_label.Text = rezervation_hours_comboBox.Text;
            saloon_no_comboBox.Items.Clear();
            saloon_no_comboBox.Text = "";
            //Seans_Saat();
            Seans_salon();
        }

        private void Saloon_no_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cinema_seats_layout_panel();
            //Yeniden_Renklendir_red();
            saloon_no_label.Text = saloon_no_comboBox.Text;
            salon_id_find();
            Veri_Tabanindaki_Dolu_Koltuklar();
            //Seans_salon();
        }

        private void Kanvas4_film_label_Click(object sender, EventArgs e)
        {

        }


        public void topla_bilgileri(string id, string name_text, string surname_text)
        {
            user_id_text = id;
            user_name_text = name_text;
            user_surname_text = surname_text;
        }

        private void Buy_ticket_button_Click(object sender, EventArgs e)
        {
            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand();

            //komut.CommandText = "signincontrol";
            //  komut.CommandType = CommandType.Text;
            //string seans_id_ = seans_id_find();
            for (int i = 0; i < 1; i++)
            {
                bugun = System.DateTime.Today.ToShortDateString();
               // MessageBox.Show(bugun);
            }
            seans_id_find();
            try
            {
                baglanti.Open();
                //komut.CommandText = "INSERT INTO biletler VALUES (DEFAULT," + Convert.ToInt64(user_id_text) + ",'" + user_name_text + "','" + user_surname_text + "'," + Convert.ToInt64(seans_idd) + ",'" + film_name_label.Text + "','" + saloon_no_label.Text + "','" + rezervation_date_label.Text + "','" + rezervation_hours_label.Text + "'," + Convert.ToInt64(seat_no_label.Text) + "," + Convert.ToInt64(ticket_price_label.Text) + ",'" + bugun + "')";
                komut.CommandText = "INSERT INTO biletler VALUES (DEFAULT," + Convert.ToInt64(user_id_text) + "," + Convert.ToInt64(seans_idd) + "," + Convert.ToInt64(seat_no_label.Text) + ",'" + bugun + "')";
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();
                // ExecuteQuery("M0002", "Yasin Kuru", "yasin", Convert.ToInt32(5557541255), "1999-01-01", "Erkek", "456");
                baglanti.Close();
                MessageBox.Show("Biletiniz Başarı İle Oluşturuldu !");
                Yeniden_Renklendir();
                seat_no_label.Text = "";
                //Yeniden_Renklendir();
            }
            catch (Exception)
            {
                MessageBox.Show("hata");
            }
            


        }

        private void seans_id_find()
        {
            //String seansid="";
            //aktif_kisi_no = kullanici_panel.aktif_kisi_no;

            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand("select * from seanslar", baglanti);
            baglanti.Open();
            OracleDataReader oku = komut.ExecuteReader();
            film_id_find();
            while (oku.Read() == true)
            {
                if (film_idd == oku["film_id"].ToString() && saloon_idd == oku["salon_id"].ToString() && rezervation_date_comboBox.Text == oku["seans_tarihi"].ToString() && rezervation_hours_label.Text == oku["seans_saati"].ToString())
                
                {
                    seans_idd= oku["seans_id"].ToString();
                    //baglanti.Close();
                    //return seansid;

                }
            }
            baglanti.Close();
        }
        private void film_id_find()
        {
            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand("select * from filmler", baglanti);
            baglanti.Open();
            OracleDataReader oku = komut.ExecuteReader();

            while (oku.Read() == true)
            {
                if (film_name_label.Text == oku["film_adi"].ToString())
                 {
                        film_idd = oku["film_id"].ToString();
                        //baglanti.Close();
                        //return seansid;

                 }
            }
            baglanti.Close();
        }
        private void salon_id_find()
        {
            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand("select * from salonlar", baglanti);
            baglanti.Open();
            OracleDataReader oku = komut.ExecuteReader();

            while (oku.Read() == true)
            {
                if (saloon_no_label.Text == oku["salon_adi"].ToString())
                {
                    saloon_idd = oku["salon_id"].ToString();
                    //saloon_name = oku["salon_adi"].ToString();
                    //baglanti.Close();
                    //return seansid;

                }
            }
            baglanti.Close();
        }
        private void salon_id_find_beginning()
        {
            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand("select * from salonlar", baglanti);
            OracleCommand komut2 = new OracleCommand("select * from seanslar", baglanti);
            baglanti.Open();
            OracleDataReader oku = komut.ExecuteReader();
            OracleDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read() == true)
            {
                //if (saloon_no_label.Text == oku["salon_adi"].ToString())
                if (film_idd == oku2["film_id"].ToString() && rezervation_date_comboBox.Text == oku2["seans_tarihi"].ToString() && rezervation_hours_label.Text == oku2["seans_saati"].ToString())
                {
                    saloon_idd = oku2["salon_id"].ToString();
                    //saloon_name = oku["salon_adi"].ToString();
                    //baglanti.Close();
                    //return seansid;

                }
            }
            baglanti.Close();
        }

        private void Yeniden_Renklendir()
        {
            foreach (Control item in seats_groupBox.Controls)
            {
                if (item is Button)
                {
                    if (seat_no_label.Text == item.Text)
                    {
                        object seats_picture = Resources.ResourceManager.GetObject("yellow_seat_picture"); //Return an object from the image chan1.png in the project
                        item.BackgroundImage = (Image)seats_picture; //Set the Image property of channelPic to the returned object as Image
                        item.BackgroundImageLayout = ImageLayout.Stretch;
                        //item.BackColor = Color.White;
                        item.ForeColor = Color.Gray;

                        //object seats_picture = Resources.ResourceManager.GetObject("yellow_seat_picture");


                    }

                }
            }
        }
        private void Yeniden_Renklendir_red()
        {
            foreach (Control item in seats_groupBox.Controls)
            {
                if (item is Button)
                {
                    
                        object seats_picture = Resources.ResourceManager.GetObject("red_seat_piture"); //Return an object from the image chan1.png in the project
                        item.BackgroundImage = (Image)seats_picture; //Set the Image property of channelPic to the returned object as Image
                        item.BackgroundImageLayout = ImageLayout.Stretch;
                    //item.BackColor = Color.Transparent;
                    item.ForeColor = Color.White;
                    //object seats_picture = Resources.ResourceManager.GetObject("yellow_seat_picture");




                }
            }
        }

        private void Veri_Tabanindaki_Dolu_Koltuklar()
        {
            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand("select * from biletler", baglanti);
            baglanti.Open();
            OracleDataReader oku = komut.ExecuteReader();
            seans_id_find();
            //MessageBox.Show(seans_idd + "wanna");
            while (oku.Read())
            {
                foreach (Control item in seats_groupBox.Controls)
                {
                    if (item is Button)
                    {
                        //if (rezervation_date_comboBox.Text == oku["seans_tarihi"].ToString() && rezervation_hours_comboBox.Text == oku["seans_saati"].ToString()&& saloon_no_comboBox.Text == oku["filmin_salonu"].ToString())
                        
                        if (seans_idd == oku["seans_id"].ToString())
                        {
                            if (oku["koltukno"].ToString() == item.Text)
                            {
                                object seats_picture = Resources.ResourceManager.GetObject("yellow_seat_picture"); //Return an object from the image chan1.png in the project
                                item.BackgroundImage = (Image)seats_picture; //Set the Image property of channelPic to the returned object as Image
                                item.BackgroundImageLayout = ImageLayout.Stretch;
                                //item.BackColor = Color.Blue;
                                item.ForeColor = Color.Gray;
                                //object seats_picture = Resources.ResourceManager.GetObject("yellow_seat_picture");


                            }
                        }
                        

                    }
                }
            }
            baglanti.Close();

        }

        private void Chose_session_label_Click(object sender, EventArgs e)
        {
            session_choose_window_show();
        }

        private void Choose_film_label_Click(object sender, EventArgs e)
        {
            film_choose_window_show();
            seat_no_label.Text = "";
            saloon_no_label.Text = "";
            rezervation_date_label.Text = "";
            rezervation_hours_label.Text = "";
        }
        public void film_choose_window_show()
        {
            if (cou1 == 0)
            {
                Film_Afisi_Goster("select film_adi,utl_raw.cast_to_varchar2(dbms_lob.substr(afis_gorseli)) as poster from filmler");
                cou1 += 1;

            }
            //Film_Afisi_Goster("select film_adi,utl_raw.cast_to_varchar2(dbms_lob.substr(afis_gorseli)) as poster from filmler");

            tabControl1.SelectTab(0);
        }
        public void session_choose_window_show()
        {
            if (cou2 == 0)
            {
                //Film_Afisi_Goster("select film_adi,utl_raw.cast_to_varchar2(dbms_lob.substr(afis_gorseli)) as poster from filmler");
                Seans_Tarih();
                //Seans_Saat();
                cou2 += 1;

            }
            tabControl1.SelectTab(2);
        }
        public void session_choose_clear()
        {
            rezervation_date_comboBox.Text = "";
            rezervation_hours_comboBox.Text = "";
            saloon_no_comboBox.Text = "";
        }

        private void labelke_Click(object sender, EventArgs e)
        {

        }
    }////////
}/////////

using Gumele_Cinema_Automation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging;

namespace Gumele_Cinema_Automation
{
    public partial class AdminPanel : Form
    {
        public object ConfigurationManager { get; private set; }

        public AdminPanel()
        {
            InitializeComponent();
        }

        public string user_id_text;
        public string user_name_text;
        public string user_surname_text;
        public string user_position_text;

        string manta = "asdfsdf";
        string Canta = "DDD";
        string filmid_text = "";
        string salonid_text = "";
        //public int[] dizi;
        public int[] film_id_list = new int[20];
        public int[] salon_id_list = new int[20];

        private void Close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Saloon_add_button_Click(object sender, EventArgs e)
        {
            all_tabControl.SelectTab(0);
        }

        private void Film_add_button_Click(object sender, EventArgs e)
        {
            all_tabControl.SelectTab(1);
        }

        private void Seans_add_button_Click(object sender, EventArgs e)
        {
            all_tabControl.SelectTab(2);
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            cinema_seats_layout_panel();
            checboxa_film_getirme("SELECT film_adi,film_id FROM filmler");
            checboxa_seans_getirme("SELECT salon_adi,salon_id FROM salonlar");
            active_admin_label.Text = user_name_text + " " + user_surname_text;
            if (true)
            {

            }
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
                    btn.Size = new Size(40, 40);
                    if (x == 9 && y != 6 && y != 7 && y != 8)
                        continue;
                    if (y == 5)
                    {
                        continue;
                        /*  btn.Image = Image.FromFile(@"C:\Users\MorCivciv\Desktop\sinema_otomasyon_dosyaları\redkoltuk20.jpg");
                          btn.Location = new Point(x * 40 + 9, y * 40 + 9);
                          btn.Name = sayac.ToString();
                          btn.Text = " ";
                          btn.Text = sayac.ToString();
                          btn.ForeColor = Color.White;
                          // lab.setFont(new Font("Serif", Font.BOLD, 24));
                          //btn.Font = new Font("Verdana", 8, FontStyle.Bold);
                          sayac++;
                          this.koltuklar.Controls.Add(btn);*/
                    }
                    else
                    {
                        //btn.Image = Image.FromFile(@"C:\Users\MorCivciv\Desktop\sinema_otomasyon\redkoltuk20.jpg");
                        //btn.Image = Image.FromFile;
                        object seats_picture = Resources.ResourceManager.GetObject("red_seat_piture"); //Return an object from the image chan1.png in the project
                        btn.BackgroundImage = (Image)seats_picture; //Set the Image property of channelPic to the returned object as Image
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.Location = new Point(x * 40 + 9, y * 40 + 9);
                        btn.Name = sayac.ToString();
                        btn.Text = sayac.ToString();
                        btn.ForeColor = Color.White;
                        btn.BackColor = Color.Transparent;
                        sayac--;
                        this.seats_layout_panel.Controls.Add(btn);

                    }

                }

            }
        }

        private void Add_film_poster_button_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            film_poster_pictureBox.ImageLocation = openFileDialog1.FileName;
            // film_poster_pictureBox.DrawToBitmap()
           // film_poster_pictureBox.Image.RawFormat = ;

        }
        
        private void fonk()
        {
            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            //OracleCommand komut = new OracleCommand();
            string sql = " INSERT INTO FİLM01 (COLUMN1,FİLM_POSTER) VALUES(:COLUMN1, :FİLM_POSTER) ";
           // string sql1 = "insert into FİLM01 (COLUMN1,FİLM_POSTER) values('sadfasd', utl_raw.cast_to_raw('C:\Users\MorCivciv\Desktop\sinema_otomasyon\ADSFASDF.jpg'))";
            //string strconn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            // using (OracleConnection conn = new OracleConnection(baglanti.ToString())

            baglanti.Open();

            // using (OracleCommand cmd = new OracleCommand(sql, conn))
            OracleCommand cmd = new OracleCommand(sql,baglanti);

            cmd.Parameters.Add("COLUMN1", OracleDbType.Varchar2, "BJJHBA", ParameterDirection.Input);
            cmd.Parameters.Add("FİLM_POSTER", OracleDbType.Blob, film_poster_pictureBox.ImageLocation,ParameterDirection.Input);
                    //cmd.Parameters.Add("COLUMN1", OracleDbType.Varchar2, "any thing here", ParameterDirection.Input);
                    cmd.ExecuteNonQuery();
                
            
            /* OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
             OracleCommand komut = new OracleCommand();
             try
             {
                 // kullanicix.kullanici_ekle(adsoyadtext.Text, epostatext.Text, Convert.ToInt64(ceptelefonutext.Text), dogumtarihi.Value.ToShortDateString(), cinsiyetbox.Text, kayitsifretext.Text);

                 //CreateCustomerAdapter(baglanti);
                 //ExecuteQuery("M0002", "Yasin Kuru", "yasin", Convert.ToInt32(5557541255), "1999-01-01", "Erkek", "456");

                 //string sql = "INSERT INTO FİLM_POSTER VALUES(?,?) ";
                 //Oracle

                 string sql = " INSERT INTO BlobStore(ID,BLOBFILE,DESCRIPTION) VALUES(:ID, :BLOBFILE, :DESCRIPTION) ";
                 string strconn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                 using (OracleConnection conn = new OracleConnection(strconn))
                 {
                     conn.Open();

                     using (OracleCommand cmd = new OracleCommand(sql, conn))
                     {
                         cmd.Parameters.Add("ID", OracleDbType.Int32, 1, ParameterDirection.Input);
                         cmd.Parameters.Add("BLOBFILE", OracleDbType.Blob, byteArray, ParameterDirection.Input);
                         cmd.Parameters.Add("DESCRIPTION", OracleDbType.Varchar2, "any thing here", ParameterDirection.Input);
                         cmd.ExecuteNonQuery();
                     }
                 }



                 baglanti.Open();
                 komut.CommandText = "INSERT INTO MUSTERİ_TABLOSU VALUES ('M0009','" + name_textbox.Text + "','" + eposta_texttbox.Text + "'," + Convert.ToInt64(telephone_textbox.Text) + ",'" + dateofbirth_TimePicker.Value.ToShortDateString() + "','" + sex_comboBox.SelectedItem.ToString() + "','" + password_textbox.Text + "') ";
                 komut.Connection = baglanti;
                 komut.ExecuteNonQuery();
                 // ExecuteQuery("M0002", "Yasin Kuru", "yasin", Convert.ToInt32(5557541255), "1999-01-01", "Erkek", "456");
                 baglanti.Close();
                 
                 /* komut.Connection = baglanti; MessageBox.Show("basarıyla salon eklendi");
                  komut.CommandText = "INSERT INTO MUSTERİ_TABLOSU VALUES ('M0002','Yasin Kuru','yasin',5557541255,DATE'1999-01-01','Erkek','456',)";
                  baglanti.Open();

                  OracleCommand komutx = new OracleCommand();

                  OracleDataAdapter yaz = new OracleDataAdapter(komutx);
                  MessageBox.Show("basarıyla salon eklendi");*/

            // oku = komut.ExecuteReader();
            //    oku.Read();
            //  label1.Text = oku["TELEFON"].ToString();
            // label1.Text = oku.GetString(0);
            // richTextBox1.Text = oku.ToString();
            //  baglanti.Close();

        }

        private void Add_film_info_button_Click(object sender, EventArgs e)
        {
            //fonk();
            add_film_function();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(movie_score_textBox.Text);
            //Veri_Tabaindaki_Bilgileri_Getir("select * FROM FİLM02");
            // Veri_Tabaindaki_Bilgileri_Getir2("select film_adi,utl_raw.cast_to_varchar2(dbms_lob.substr(FOTO)) as coco from FİLM02 where AD = '1'");
            // Veri_Tabaindaki_Bilgileri_Getir("select FOTO from FİLM02 where AD = '1'");
            //MessageBox.Show(manta);
        }

        /* private void Veri_Tabanindaki_Dolu_Koltuklar()
         {
             //baglanti.Open();
             //SqlCommand komuta = new SqlCommand("select * from satis_info where film_adi= '" + film_label.Text + "' and seans_tarihi='" + seansin_tarihi.Text + "' and seans_saati='" + seans_label.Text + "' and salon_adi='" + salon_no_text.Text + "'  ", baglanti);
             //SqlDataReader oku = komuta.ExecuteReader();

             while (oku.Read())
             {
                 foreach (Control item in seats_layout_panel.Controls)
                 {
                     if (item is Button)
                     {
                         if (oku["koltuk_no"].ToString() == item.Text)
                         {

                             item.BackColor = Color.Blue;
                             item.BackgroundImage = Image.FromFile(@"C:\Users\MorCivciv\Desktop\sinema_otomasyon\anank.jpg");

                         }

                     }
                 }
             }
             baglanti.Close();

         }*/



        /*private void Yeniden_Renklendir()
        {
            foreach (Control item in koltuklar.Controls)
            {
                if (item is Button)
                {
                    //item.BackColor = Color.Transparent;
                    item.BackgroundImage = Image.FromFile(@"C:\Users\MorCivciv\Desktop\sinema_otomasyon\kirmizi_koltuk0.png");
                }
            }
        }*/

        /* public void  anan()
         {
             using (MemoryStream imageMemStream = new MemoryStream(fileData))
             {
                 using (Bitmap bitmap = new Bitmap(imageMemStream))
                 {
                     ImageFormat imageFormat = bitmap.RawFormat;
                     if (bitmap.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg))
             //It's a JPEG;
                     else if (bitmap.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
             //It's a PNG;
     }
             }
         }*/
        public void Veri_Tabaindaki_Bilgileri_Getir(string sqltum)
        {
            MessageBox.Show("girdim FONK");
            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand(sqltum, baglanti);
            baglanti.Open();
            OracleDataReader oku = komut.ExecuteReader();
            //SqlCommand komut = new SqlCommand(sqltum, baglanti);
            //SqlDataReader oku = komut.ExecuteReader();
            string ceg = "1";
           // film_name_textBox.Text = oku["AD"].ToString();
           // manta = oku["AD"].ToString();
            while (oku.Read() == true)
            {
                MessageBox.Show("girdim WHİLW");
                if (ceg == oku["AD"].ToString())
                {

                    MessageBox.Show("girdim İFE");
                    film_name_textBox.Text = oku["AD"].ToString();
                    directors_textBox.Text = oku["FOTO"].ToString();
                    //film_poster_pictureBox.ImageLocation = oku["FOTO"].GetHashCode();
                    //Canta = ToString1(oku["FOTO"].ToString());
                    //System.Text.Encoding.UTF8.GetString(oku["FOTO"].ToString());
                    manta = oku["AD"].ToString();
                    
                    
                }
                

                
                
            }
            baglanti.Close();
        }

        private string ToString1(byte[] bytes)
        {
            string response = string.Empty;

            foreach (byte b in bytes)
                response += (Char)b;

            return response;
        }



        public void Veri_Tabaindaki_Bilgileri_Getir2(string sqltum)
        {
            //MessageBox.Show("girdim FONK");
            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand(sqltum, baglanti);
            baglanti.Open();
            OracleDataReader oku = komut.ExecuteReader();
            //SqlCommand komut = new SqlCommand(sqltum, baglanti);
            //SqlDataReader oku = komut.ExecuteReader();
            string ceg = "1";
            // film_name_textBox.Text = oku["AD"].ToString();
            // manta = oku["AD"].ToString();
            while (oku.Read() == true)
            {
               // MessageBox.Show("girdim WHİLW");
                if (true/*ceg == oku["AD"].ToString()*/)
                {

                    film_poster_pictureBox.ImageLocation = oku["coco"].ToString();


                }




            }
            baglanti.Close();
        }

        private void Add_saloon_button_Click(object sender, EventArgs e)
        {
            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand();
            
            try
            {
                baglanti.Open();
                komut.CommandText = "INSERT INTO salonlar VALUES (DEFAULT,'" + saloon_no_textBox.Text + "'," + Convert.ToInt64(total_seat_textBox.Text) + ")";
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();
                // ExecuteQuery("M0002", "Yasin Kuru", "yasin", Convert.ToInt32(5557541255), "1999-01-01", "Erkek", "456");
                baglanti.Close();
                MessageBox.Show("Salon Başarı İle Eklendi !");
            }
            catch (Exception)
            {
                MessageBox.Show("Salon Ekeleme Başarısız, Alanları Doğru ve Eksiksiz Doldurduğunuzdan Emin Olun !");
            }
        }

        private void add_film_function()
        {
            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand();
            string afiske = "utl_raw.cast_to_raw('" + film_poster_pictureBox.ImageLocation + "')";
            //MessageBox.Show(afiske);
            String film_kinds = film_kind_comboBox.SelectedItem.ToString()+" - "+ film_kind_comboBox2.SelectedItem.ToString();
            double db = 4f;
            
            try
            {
                baglanti.Open();
                komut.CommandText = "INSERT INTO filmler  VALUES (DEFAULT,'" + film_name_textBox.Text + "','" + directors_textBox.Text + "','"+cast_textBox.Text+"','"+ film_kinds + "','" + relaese_dateTimePicker.Value.ToShortDateString() + "'," + Convert.ToInt64(running_time_textBox.Text) + ",'" +subject_of_the_movie_richTextBox.Text.ToString() + "'," + Convert.ToDouble(movie_score_textBox.Text)+ "," + afiske+ ") ";
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();
                // ExecuteQuery("M0002", "Yasin Kuru", "yasin", Convert.ToInt32(5557541255), "1999-01-01", "Erkek", "456");
                baglanti.Close();
                MessageBox.Show("Film Başarı İle Eklendi !");
            }
            catch (Exception)
            {
                MessageBox.Show("Film Ekeleme Başarısız, Alanları Doğru ve Eksiksiz Doldurduğunuzdan Emin Olun !");
            }
        }

        string seans ;
        private void RadioButtonSeciliyse()
        {
          //if (radioButton1.Checked == true) seans = radioButton1.Text;
            if (radioButton2.Checked == true) seans = radioButton2.Text;
            else if (radioButton2.Checked == true) seans = radioButton2.Text;
            else if (radioButton3.Checked == true) seans = radioButton3.Text;
            else if (radioButton4.Checked == true) seans = radioButton4.Text;
            else if (radioButton5.Checked == true) seans = radioButton5.Text;
            else if (radioButton6.Checked == true) seans = radioButton6.Text;
            else if (radioButton7.Checked == true) seans = radioButton7.Text;
            else if (radioButton8.Checked == true) seans = radioButton8.Text;
            else if (radioButton9.Checked == true) seans = radioButton9.Text;
            else if (radioButton10.Checked == true) seans = radioButton10.Text;
            else if (radioButton11.Checked == true) seans = radioButton11.Text;
            else if (radioButton12.Checked == true) seans = radioButton12.Text;
            else if (radioButton13.Checked == true) seans = radioButton13.Text;
            //else if (radioButton14.Checked == true) seans = radioButton14.Text;
            else if (radioButton15.Checked == true) seans = radioButton15.Text;
            else if (radioButton16.Checked == true) seans = radioButton16.Text;
            else if (radioButton17.Checked == true) seans = radioButton17.Text;
            else if (radioButton18.Checked == true) seans = radioButton18.Text;
            else if (radioButton19.Checked == true) seans = radioButton19.Text;
            else if (radioButton20.Checked == true) seans = radioButton20.Text;
            else if (radioButton21.Checked == true) seans = radioButton21.Text;
            else if (radioButton22.Checked == true) seans = radioButton22.Text;
            else if (radioButton23.Checked == true) seans = radioButton23.Text;
            else if (radioButton24.Checked == true) seans = radioButton24.Text;
            else if (radioButton25.Checked == true) seans = radioButton25.Text;
            else if (radioButton26.Checked == true) seans = radioButton26.Text; 

        }

        private void Button1_Click(object sender, EventArgs e) /*seans ekle button*/
        {
            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand();
            
            RadioButtonSeciliyse();
            bul();
            //MessageBox.Show(filmid_text);

            //DateTime yeni = DateTime.Parse(seans_date_monthCalendar.SelectionRange.Start.ToShortDateString());
            //String tarih = seans_date_monthCalendar.SelectionRange.Start.ToShortDateString();
            if (seans!=null)
            {
                try
                {
                    baglanti.Open();
                    komut.CommandText = "INSERT INTO seanslar VALUES(DEFAULT," + Convert.ToInt64(filmid_text) + "," + Convert.ToInt64(salonid_text) + ",'" + seans_date_monthCalendar.SelectionRange.Start.ToShortDateString() + "','" + seans.ToString() + "'," + Convert.ToInt64(ticket_price_textBox.Text) + ")";
                    // komut.CommandText = "INSERT INTO seanslar VALUES (DEFAULT ," + Convert.ToInt64(filmid_text.ToString()) + ",'"+ film_name_comboBox.SelectedItem.ToString() + "',"+ Convert.ToInt64(salonid_text.ToString()) + ",'" +saloon_no_comboBox.SelectedItem.ToString()+ "','" +seans_date_dateTimePicker.Value.ToShortDateString()+ "', '" +seans.ToString()+ "'," +Convert.ToInt64(ticket_price_textBox.Text)+ ")";
                    komut.Connection = baglanti;
                    // komut.CommandText = "INSERT INTO seanslar VALUES (DEFAULT," + Convert.ToInt64(filmid_text) + ",'" + film_name_comboBox.SelectedItem.ToString() + "'," + Convert.ToInt64(salonid_text) + ",'" + saloon_no_comboBox.SelectedItem.ToString() + "','" + seans_date_monthCalendar.SelectionRange.Start.ToShortDateString() + "', '" + seans + "'," + Convert.ToInt64(ticket_price_textBox.Text) + ")";
                    komut.ExecuteNonQuery();
                    // ExecuteQuery("M0002", "Yasin Kuru", "yasin", Convert.ToInt32(5557541255), "1999-01-01", "Erkek", "456");
                    baglanti.Close();
                    MessageBox.Show("Seans Başarı İle Eklendi !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Film Ekeleme Başarısız, Alanları Doğru ve Eksiksiz Doldurduğunuzdan Emin Olun !");
                }
            }
            
        }

        private void checboxa_film_getirme(string sql)
        {
            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand(sql, baglanti);
            baglanti.Open();
            OracleDataReader oku = komut.ExecuteReader();
            int sayac = 0;

            while (oku.Read() == true)
            {
                film_id_list[sayac] = Convert.ToInt32(oku["film_id"].ToString());
                film_name_comboBox.Items.Add(oku["film_adi"].ToString());
                sayac = sayac + 1;

               /* if (film_name_comboBox.ıt)
                {
                    int index = film_name_comboBox.FindString(film_name_comboBox.SelectedText);
                    //comboBox1.SelectedIndex = index;
                }*/

            }

            baglanti.Close();
        }
        
        private void checboxa_seans_getirme(string sql)
        {
            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand(sql, baglanti);
            baglanti.Open();
            OracleDataReader oku = komut.ExecuteReader();
            int sayac = 0;

            while (oku.Read() == true)
            {
                salon_id_list[sayac] = Convert.ToInt32(oku["salon_id"].ToString());
                saloon_no_comboBox.Items.Add(oku["salon_adi"].ToString());
                sayac = sayac + 1;
            }

            baglanti.Close();
        }
        private void bul()
        {
            //int sayac = 0;
            int film_index = film_name_comboBox.FindString(film_name_comboBox.Text);
            int salon_index = saloon_no_comboBox.FindString(saloon_no_comboBox.Text);
            filmid_text = film_id_list[film_index].ToString();
            salonid_text = salon_id_list[salon_index].ToString();
            //MessageBox.Show(filmid_text);
           // MessageBox.Show(salonid_text);

            /* while (oku.Read() == true)
             {
                 dizi[sayac] = Convert.ToInt64(oku["film_id"].ToString());
                 film_name_comboBox.Items.Add(oku["film_adi"].ToString());
                 sayac = sayac + 1;

                 if (dizi[index] == index)
                 {

                     filmid_text = dizi[index].ToString();
                 }

             }*/

        }

        private void all_film_buttons_Click(object sender, EventArgs e)
        {
            ArrangementPanels ap = new ArrangementPanels();
            ap.Show();
            ap.tab_choose(1);

        }

        private void sign_out_label_Click(object sender, EventArgs e)
        {
            MainPanel mp = new MainPanel();
            this.Close();
            mp.Show();
        }

        private void all_saloons_buttons_Click(object sender, EventArgs e)
        {
            ArrangementPanels ap = new ArrangementPanels();
            ap.Show();
            ap.tab_choose(0);
        }

        private void all_sesssions_buttons_Click(object sender, EventArgs e)
        {
            ArrangementPanels ap = new ArrangementPanels();
            ap.Show();
            ap.tab_choose(2);
        }

        private void all_tickets_button_Click(object sender, EventArgs e)
        {
            ArrangementPanels ap = new ArrangementPanels();
            ap.Show();
            ap.tab_choose(3);
        }

        private void main_admins_button_Click(object sender, EventArgs e)
        {
            if (user_position_text == "AnaYonetici")
            {
                CreateAdminAccount caa = new CreateAdminAccount();
                //this.Hide();
                caa.Show();
            }
            else
            {
                MessageBox.Show("Bu Pencere İçin Yetkiniz Bulunmamaktadır !");
            }
            
            
        }

        public void call_succesfull_eposta_text(string id, string name_text, string surname_text, string position_text)
        {
            user_id_text = id;
            user_name_text = name_text;
            user_surname_text = surname_text;
            user_position_text = position_text;

            //secret_label.Text = text_field;
        }

        private void account_button_Click(object sender, EventArgs e)
        {
            AdminAccountPanel acp = new AdminAccountPanel();
            //ap.call_succesfull_eposta_text(kad);
            acp.bilgi(user_id_text,user_name_text,user_surname_text);
            //this.Hide();
            acp.Show();
        }

        private void total_seat_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ticket_price_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void campaign_button_Click(object sender, EventArgs e)
        {
            ArrangementPanels ap = new ArrangementPanels();
            ap.Show();
            ap.tab_choose(4);
        }
    }////////
}/////////

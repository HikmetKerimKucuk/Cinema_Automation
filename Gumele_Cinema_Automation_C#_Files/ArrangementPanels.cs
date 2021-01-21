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

namespace Gumele_Cinema_Automation
{
    public partial class ArrangementPanels : Form
    {
        public ArrangementPanels()
        {
            InitializeComponent();
        }
        string noeditioanable_seans_id;

        /*private void Back_label_Click(object sender, EventArgs e)
      {
          AdminPanel ap = new AdminPanel();
          this.Close();
          //ap.Show();
      }*/

        public void campaign_read_db()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;"))
                using (OracleCommand cmd = new OracleCommand("select * from kampanyalar", conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        campaign_dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Servis Hatası Meydana Geldi !");
            }
        }
        public void saloons_read_db()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;"))
                using (OracleCommand cmd = new OracleCommand("select * from salonlar", conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        saloons_dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Servis Hatası Meydana Geldi !");
            }
        }

        public void films_read_db()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;"))
                using (OracleCommand cmd = new OracleCommand("select film_id,film_adi,yonetmenler,oyuncular,tur,yayin_tarihi,sure,konu,puani,utl_raw.cast_to_varchar2(dbms_lob.substr(afis_gorseli)) as poster from filmler", conn))
                {

                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        films_dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Servis Hatası Meydana Geldi !");
            }
        }

        public void sessions_read_db()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;"))
                using (OracleCommand cmd = new OracleCommand("select * from seanslar_view", conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        sessions_dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Servis Hatası Meydana Geldi !");
            }
        }

        public void tickets_read_db()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;"))
                using (OracleCommand cmd = new OracleCommand("select * from biletler_view", conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        tickets_dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Servis Hatası Meydana Geldi !");
            }
        }
        /* private void tabPage1_Click(object sender, EventArgs e)
         {
             //read();
         }*/

        private void back_label_Click(object sender, EventArgs e)
        {
            // seans_read_db();
        }

        public void sessions_update_fonc()
        {
            
            string id = sessions_dataGridView.CurrentRow.Cells[0].Value.ToString();
            string film_name = sessions_dataGridView.CurrentRow.Cells[1].Value.ToString();
            string saloon = sessions_dataGridView.CurrentRow.Cells[2].Value.ToString();
            //string buydate= saloons_dataGridView.CurrentRow.Cells[3].Value.ToString();
            string buyhour = sessions_dataGridView.CurrentRow.Cells[4].Value.ToString();
            string price = sessions_dataGridView.CurrentRow.Cells[5].Value.ToString();

            //DateTime dt = 
            DateTime dt = DateTime.Parse(sessions_dataGridView.CurrentRow.Cells[3].Value.ToString());
            //  MessageBox.Show(dt.ToShortDateString());
            //rezervation_date_comboBox.Items.Add(dt.ToShortDateString()); */

            //MessageBox.Show(id+film_name+saloon+buydate+buyhour+price);


            try
            {
                OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
                OracleCommand komut = new OracleCommand();
                baglanti.Open();

                //dob_dateTimePicker.Format = DateTimePickerFormat.Custom;
                //dob_dateTimePicker.CustomFormat = "dd-MM-yyyy";
                //string op = dob_dateTimePicker.Value.ToShortDateString();
                //MessageBox.Show(op);
                komut.CommandText = "UPDATE seanslar SET  seans_tarihi= '" + dt.ToShortDateString() + "',seans_saati='" + buyhour + "', bilet_ucreti= " + Convert.ToInt64(price) + "  WHERE seans_id=" + Convert.ToInt64(id) + " ";
                //komut.CommandText = "UPDATE MUSTERİ_TABLOSU SET AD_SOYAD = 'Anan Sch', E_POSTA= 'cegid',TELEFON=5541593963 , CİNSİYET='Kadın',SİFRE= '333' WHERE MUSTERİ_İD='M0009'";
                komut.CommandType = CommandType.Text;
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Seans Güncelleme Başarıyla Tamamlandı !");

            }
            catch (Exception)
            {
                MessageBox.Show("Seans Güncelleme Başarısız, Alanları Doğru ve Eksiksiz Doldurduğunuzdan Emin Olun !");
            }
        }


        public void campaign_update_fonc()
        {
            string id = campaign_dataGridView.CurrentRow.Cells[0].Value.ToString();
            //string kampanya_metni = campaign_read_db.CurrentRow.Cells[1].Value.ToString();
            string kampanya_metni = campaign_richTextBox.Text;


            try
            {
                OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
                OracleCommand komut = new OracleCommand();
                baglanti.Open();

                komut.CommandText = "UPDATE kampanyalar SET kampanya_metni= '" + kampanya_metni + "' WHERE kampanya_id=" + Convert.ToInt64(id) + " ";
                //komut.CommandText = "UPDATE MUSTERİ_TABLOSU SET AD_SOYAD = 'Anan Sch', E_POSTA= 'cegid',TELEFON=5541593963 , CİNSİYET='Kadın',SİFRE= '333' WHERE MUSTERİ_İD='M0009'";
                komut.CommandType = CommandType.Text;
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kampanya Güncelleme Başarıyla Tamamlandı !");

            }
            catch (Exception)
            {
                MessageBox.Show("Kampanya Güncelleme Başarısız, Alanları Doğru ve Eksiksiz Doldurduğunuzdan Emin Olun !");
            }
        }

        public void saloons_update_fonc()
        {
            string id = saloons_dataGridView.CurrentRow.Cells[0].Value.ToString();
            string saloon_name = saloons_dataGridView.CurrentRow.Cells[1].Value.ToString();
            string seats = saloons_dataGridView.CurrentRow.Cells[2].Value.ToString();


            try
            {
                OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
                OracleCommand komut = new OracleCommand();
                baglanti.Open();

                //dob_dateTimePicker.Format = DateTimePickerFormat.Custom;
                //dob_dateTimePicker.CustomFormat = "dd-MM-yyyy";
                //string op = dob_dateTimePicker.Value.ToShortDateString();
                //MessageBox.Show(op);
                komut.CommandText = "UPDATE salonlar SET salon_adi= '" + saloon_name + "', koltuk_sayisi= " + Convert.ToInt64(seats) + "  WHERE salon_id=" + Convert.ToInt64(id) + " ";
                //komut.CommandText = "UPDATE MUSTERİ_TABLOSU SET AD_SOYAD = 'Anan Sch', E_POSTA= 'cegid',TELEFON=5541593963 , CİNSİYET='Kadın',SİFRE= '333' WHERE MUSTERİ_İD='M0009'";
                komut.CommandType = CommandType.Text;
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Salon Güncelleme Başarıyla Tamamlandı !");

            }
            catch (Exception)
            {
                MessageBox.Show("Salon Güncelleme Başarısız, Alanları Doğru ve Eksiksiz Doldurduğunuzdan Emin Olun !");
            }
        }

        public void films_update_fonc()
        {
            string id = films_dataGridView.CurrentRow.Cells[0].Value.ToString();
            string film_name = films_dataGridView.CurrentRow.Cells[1].Value.ToString();
            string directors = films_dataGridView.CurrentRow.Cells[2].Value.ToString();
            string cast = films_dataGridView.CurrentRow.Cells[3].Value.ToString();
            string type = films_dataGridView.CurrentRow.Cells[4].Value.ToString();
            //string re_date = films_dataGridView.CurrentRow.Cells[5].Value.ToString();
            string run_time = films_dataGridView.CurrentRow.Cells[6].Value.ToString();
            string subject = films_dataGridView.CurrentRow.Cells[7].Value.ToString();
            string score = films_dataGridView.CurrentRow.Cells[8].Value.ToString();
            // float flt1 = float.Parse(score);
            //double db = Math.Round(Convert.ToDouble(score), 0);
            //MessageBox.Show(db.ToString());
            // string str = "1.225222222";
            // string value = Math.Round(Convert.ToDouble(score), 2).ToString();
            string posterke_re;
            //posterke_re = "utl_raw.cast_to_raw('" + films_dataGridView.CurrentRow.Cells[9].Value.ToString() + "')";
            //MessageBox.Show(poster_pictureBox.ImageLocation);
            if (poster_pictureBox.ImageLocation == null)
            {
                 posterke_re = "utl_raw.cast_to_raw('" + films_dataGridView.CurrentRow.Cells[9].Value.ToString() + "')";
            }
            else
            {
                 posterke_re = "utl_raw.cast_to_raw('" + poster_pictureBox.ImageLocation + "')";
            }
             //string posterke_re = "utl_raw.cast_to_raw('" + poster_pictureBox.ImageLocation + "')";
             string posterke = films_dataGridView.CurrentRow.Cells[9].Value.ToString();

            DateTime dtt = DateTime.Parse(films_dataGridView.CurrentRow.Cells[5].Value.ToString());
            /// MessageBox.Show(id+film_name+directors+cast+type+dtt.ToShortDateString()+run_time+subject+score+posterke);
            //rezervation_date_comboBox.Items.Add(dt.ToShortDateString()); */

            //MessageBox.Show(id+film_name+saloon+buydate+buyhour+price);
            

            try
            {
                OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
                OracleCommand komut = new OracleCommand();
                baglanti.Open();

                komut.CommandText = "UPDATE filmler SET film_adi= '" + film_name + "', yonetmenler= '" + directors + "', oyuncular= '" + cast + "', tur='" + type + "', yayin_tarihi= '" + dtt.ToShortDateString() + "', sure= " + Convert.ToInt64(run_time) + ", konu= '" + subject + "', puani= " + Convert.ToInt64(score) + ",afis_gorseli ="+posterke_re+"  WHERE film_id=" + Convert.ToInt64(id) + " ";
                komut.CommandType = CommandType.Text;
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Film Güncelleme Başarıyla Tamamlandı !");

            }
            catch (Exception)
            {
                MessageBox.Show("Film Güncelleme Başarısız, Alanları Doğru ve Eksiksiz Doldurduğunuzdan Emin Olun !");
            }


            // string afiske = "utl_raw.cast_to_raw('" + film_poster_pictureBox.ImageLocation + "')"; // eklemek için updatede
            // Film_Afisi_Goster("select film_adi,utl_raw.cast_to_varchar2(dbms_lob.substr(afis_gorseli)) as poster from filmler"); // getirirken konum geliyor
         


        }

        public void saloons_delete_fonc()
        {
            string id = saloons_dataGridView.CurrentRow.Cells[0].Value.ToString();
           // string saloon_name = saloons_dataGridView.CurrentRow.Cells[1].Value.ToString();
          //  string seats = saloons_dataGridView.CurrentRow.Cells[2].Value.ToString();


            try
            {
                OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
                OracleCommand komut = new OracleCommand();
                baglanti.Open();

                //dob_dateTimePicker.Format = DateTimePickerFormat.Custom;
                //dob_dateTimePicker.CustomFormat = "dd-MM-yyyy";
                //string op = dob_dateTimePicker.Value.ToShortDateString();
                //MessageBox.Show(op);
                komut.CommandText = "  DELETE FROM salonlar WHERE salon_id=" + Convert.ToInt64(id) + " ";
                //DELETE FROM customers WHERE last_name = 'Smith';
                //komut.CommandText = "UPDATE MUSTERİ_TABLOSU SET AD_SOYAD = 'Anan Sch', E_POSTA= 'cegid',TELEFON=5541593963 , CİNSİYET='Kadın',SİFRE= '333' WHERE MUSTERİ_İD='M0009'";
                komut.CommandType = CommandType.Text;
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Salon Başarı ile Kaldırıldı");

            }
            catch (Exception)
            {
                MessageBox.Show("Salon Kaldırma Başarısız, Sistem Hatası Meydana Geldi !");
            }
        }
        public void films_delete_fonc()
        {
            string id = films_dataGridView.CurrentRow.Cells[0].Value.ToString();
            
            try
            {
                OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
                OracleCommand komut = new OracleCommand();
                baglanti.Open();

                komut.CommandText = "  DELETE FROM filmler WHERE film_id=" + Convert.ToInt64(id) + " ";
                komut.CommandType = CommandType.Text;
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Film Başarı ile Kaldırıldı");

            }
            catch (Exception)
            {
                MessageBox.Show("Film Kaldırma Başarısız, Sistem Hatası Meydana Geldi !");
            }
        }

        public void sessions_delete_fonc()
        {
            string id = sessions_dataGridView.CurrentRow.Cells[0].Value.ToString();
            // string saloon_name = saloons_dataGridView.CurrentRow.Cells[1].Value.ToString();
            //  string seats = saloons_dataGridView.CurrentRow.Cells[2].Value.ToString();


            try
            {
                OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
                OracleCommand komut = new OracleCommand();
                baglanti.Open();

                //dob_dateTimePicker.Format = DateTimePickerFormat.Custom;
                //dob_dateTimePicker.CustomFormat = "dd-MM-yyyy";
                //string op = dob_dateTimePicker.Value.ToShortDateString();
                //MessageBox.Show(op);
                komut.CommandText = "  DELETE FROM seanslar WHERE seans_id=" + Convert.ToInt64(id) + " ";
                //DELETE FROM customers WHERE last_name = 'Smith';
                //komut.CommandText = "UPDATE MUSTERİ_TABLOSU SET AD_SOYAD = 'Anan Sch', E_POSTA= 'cegid',TELEFON=5541593963 , CİNSİYET='Kadın',SİFRE= '333' WHERE MUSTERİ_İD='M0009'";
                komut.CommandType = CommandType.Text;
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Seans Başarı ile Kaldırıldı");

            }
            catch (Exception)
            {
                MessageBox.Show("Seans Kaldırma Başarısız, Sistem Hatası Meydana Geldi !");
            }
        }

        public void tickets_update_fonc()
        {

            string id = tickets_dataGridView.CurrentRow.Cells[0].Value.ToString();
            string koltuk_no = tickets_dataGridView.CurrentRow.Cells[8].Value.ToString();
            


            try
            {
                OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
                OracleCommand komut = new OracleCommand();
                baglanti.Open();

                //dob_dateTimePicker.Format = DateTimePickerFormat.Custom;
                //dob_dateTimePicker.CustomFormat = "dd-MM-yyyy";
                //string op = dob_dateTimePicker.Value.ToShortDateString();
                //MessageBox.Show(op);
                komut.CommandText = "UPDATE biletler SET koltukno= " + Convert.ToInt64(koltuk_no) + "  WHERE bilet_id=" + Convert.ToInt64(id) + " ";
                //komut.CommandText = "UPDATE MUSTERİ_TABLOSU SET AD_SOYAD = 'Anan Sch', E_POSTA= 'cegid',TELEFON=5541593963 , CİNSİYET='Kadın',SİFRE= '333' WHERE MUSTERİ_İD='M0009'";
                komut.CommandType = CommandType.Text;
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Bilet Güncelleme Başarıyla Tamamlandı !");

            }
            catch (Exception)
            {
                MessageBox.Show("Bilet Güncelleme Başarısız, Alanları Doğru ve Eksiksiz Doldurduğunuzdan Emin Olun !");
            }
        }

        public void tickets_delete_fonc()
        {
            string id = tickets_dataGridView.CurrentRow.Cells[0].Value.ToString();

            try
            {
                OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
                OracleCommand komut = new OracleCommand();
                baglanti.Open();

                //dob_dateTimePicker.Format = DateTimePickerFormat.Custom;
                //dob_dateTimePicker.CustomFormat = "dd-MM-yyyy";
                //string op = dob_dateTimePicker.Value.ToShortDateString();
                //MessageBox.Show(op);
                komut.CommandText = "  DELETE FROM biletler WHERE bilet_id=" + Convert.ToInt64(id) + " ";
                //DELETE FROM customers WHERE last_name = 'Smith';
                //komut.CommandText = "UPDATE MUSTERİ_TABLOSU SET AD_SOYAD = 'Anan Sch', E_POSTA= 'cegid',TELEFON=5541593963 , CİNSİYET='Kadın',SİFRE= '333' WHERE MUSTERİ_İD='M0009'";
                komut.CommandType = CommandType.Text;
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Bilet Başarı ile Silindi");

            }
            catch (Exception)
            {
                MessageBox.Show("Bilet Silme Başarısız, Sistem Hatası Meydana Geldi !");
            }
        }

        private void update_films_button_Click(object sender, EventArgs e)
        {
            films_update_fonc();
            films_read_db();
        }

        private void update_tickets_button_Click(object sender, EventArgs e)
        {
            //Total_para_btn_Click();
            total_money_calculator_db();
        }

        private void update_saloons_button_Click(object sender, EventArgs e)
        {
            saloons_update_fonc();
            saloons_read_db();
        }

        private void ArrangementPanels_Leave(object sender, EventArgs e)
        {

        }

        private void ArrangementPanels_Load(object sender, EventArgs e)
        {
            films_read_db();
            sessions_read_db();
            tickets_read_db();
            saloons_read_db();
            campaign_read_db();
        }

        private void update_sessions_button_Click(object sender, EventArgs e)
        {
            sessions_update_fonc();
            sessions_read_db();
        }

        private void poster_button_Click(object sender, EventArgs e)
        {
            
        }

        private void poster_button_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            poster_pictureBox.ImageLocation = openFileDialog1.FileName;
        }

        private void delete_saloons_button_Click(object sender, EventArgs e)
        {
            saloons_delete_fonc();
            saloons_read_db();
        }

        private void delete_films_button_Click(object sender, EventArgs e)
        {
            films_delete_fonc();
            films_read_db();
        }

        private void delete_sessions_button_Click(object sender, EventArgs e)
        {
            sessions_delete_fonc();
            sessions_read_db();
        }

        private void Total_para_btn_Click()
        {
            int toplampra = 0;
            for (int i = 0; i < tickets_dataGridView.RowCount; i++)
            {
                toplampra += Convert.ToInt32(tickets_dataGridView.Rows[i].Cells["bilet_ucreti"].Value);
            }
            total_ticket_price.Text = "Toplam Satış=" + toplampra + "TL";
        }

        private void total_money_calculator_db()
        {
           OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand("select kazanc from toplamkazanc", baglanti);
            baglanti.Open();
            OracleDataReader oku = komut.ExecuteReader();
           
            while (oku.Read() == true)
            {
                total_ticket_price.Text = oku["kazanc"].ToString();
              
            }
            baglanti.Close();
            //return maan;
        }

        private void close_window_label_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void tab_choose(int tabno)
        {
            tabControl1.SelectTab(tabno);
        }

        private void tickets_update_button_Click(object sender, EventArgs e)
        {
            tickets_update_fonc();
            tickets_read_db();
        }

        private void tickets_delete_button_Click(object sender, EventArgs e)
        {
            tickets_delete_fonc();
            tickets_read_db();
        }

        private void update_campaign_button_Click(object sender, EventArgs e)
        {
            campaign_update_fonc();
            campaign_read_db();
        }

        private void search_customer_name_label_TextChanged(object sender, EventArgs e)
        {
            if (search_customer_name_label.Text == "")
            {
                tickets_read_db();
            }
            else
            {
                string src_text ;
                src_text = search_customer_name_label.Text;
                //tickets_dataGridView.cle
                search_customer_name(src_text);
            }
            
        }
        public void search_customer_name(string name_text)
        {
            string sorgu = "select * from biletler_view where ad LIKE '" + name_text + "%' ";
            try
            {
                using (OracleConnection conn = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;"))
                using (OracleCommand cmd = new OracleCommand(sorgu, conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        tickets_dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Servis Hatası Meydana Geldi !");
            }
        }

    }//
}////////

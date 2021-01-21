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
    public partial class FilmsPanel : Form
    {
        public FilmsPanel()
        {
            InitializeComponent();
        }
        public string user_id_text;
        public string user_name_text ;
        public string user_surname_text;

        OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
        public string save_user_id_info_string = "";

        int afis_sayaci = 0;
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
                }
                else if (afis_sayaci == 10)
                {
                    kanvas10_pictureBox.ImageLocation = oku_film_adi["poster"].ToString();
                    kanvas10_film_label.Text = oku_film_adi["film_adi"].ToString();
                    kanvas10_pictureBox.Visible = true;
                    kanvas10_film_label.Visible = true;
                    scroll_down_label.Visible = true;
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

        private void Previous_panel_label_Click(object sender, EventArgs e)
        {
            CustomerPanel cp = new CustomerPanel();
            cp.call_succesfull_eposta_text(user_id_text, user_name_text, user_surname_text);
            //cp.call_succesfull_id_info(save_user_id_info_string);
            this.Hide();
            cp.Show();
        }

        public void fetch_user_id_info(string user_id_info)
        {
            save_user_id_info_string = user_id_info;
        }

        private void Buyticket_panel_button_Click(object sender, EventArgs e)
        {
            BuyTicketPanel btp = new BuyTicketPanel();
            btp.topla_bilgileri(user_id_text, user_name_text, user_surname_text);
            this.Hide();
            btp.Show();
        }

        private void FilmsPanel_Load(object sender, EventArgs e)
        {
            Film_Afisi_Goster("select film_adi,utl_raw.cast_to_varchar2(dbms_lob.substr(afis_gorseli)) as poster from filmler");
        }


        private void Film_Bilgileri_Getir(string kanvas)
        {
            film_name_label.Text = "";
            film_kind_label.Text = "";
            directors_label.Text = "";

            baglanti.Open();
            OracleCommand komut = new OracleCommand("SELECT * FROM filmler", baglanti);
            OracleDataReader oku = komut.ExecuteReader();
            //SqlCommand komuta = new SqlCommand("select * from film_info", baglanti);
            //SqlDataReader oku = komuta.ExecuteReader();
            while (oku.Read())
            {
                if (kanvas == oku["film_adi"].ToString())
                {
                    film_name_label.Text = oku["film_adi"].ToString();
                    film_kind_label.Text = oku["tur"].ToString();
                    directors_label.Text = oku["yonetmenler"].ToString(); // xxxxxxxxxxxxxxxxxxxxxxxxxxxXXXXXXxxxxxxxxxxxxxxxxxx
                    cast_label.Text = oku["oyuncular"].ToString();
                    release_label.Text = oku["yayin_tarihi"].ToString();
                    running_time_label.Text = oku["sure"].ToString();
                    subject_of_movie_label.Text = oku["konu"].ToString();
                    movie_score_label.Text = oku["puani"].ToString();
                }

            }
            baglanti.Close();
            left_info_panel.AutoScroll = true;
        }

        private void Kanvas1_pictureBox_Click(object sender, EventArgs e)
        {
            secili_filmin_afisi.Image = kanvas1_pictureBox.Image;
            Film_Bilgileri_Getir(kanvas1_film_label.Text);
            
        }

        private void Kanvas2_pictureBox_Click(object sender, EventArgs e)
        {
            secili_filmin_afisi.Image = kanvas2_pictureBox.Image;
            Film_Bilgileri_Getir(kanvas2_film_label.Text);
        }
        public void topla_bilgileri(string id, string name_text, string surname_text)
        {
            user_id_text = id;
            user_name_text = name_text;
            user_surname_text = surname_text;
        }

        private void Release_label_Click(object sender, EventArgs e)
        {

        }

        private void Kanvas3_pictureBox_Click(object sender, EventArgs e)
        {
            secili_filmin_afisi.Image = kanvas3_pictureBox.Image;
            Film_Bilgileri_Getir(kanvas3_film_label.Text);
        }

        private void Kanvas4_pictureBox_Click(object sender, EventArgs e)
        {
            secili_filmin_afisi.Image = kanvas4_pictureBox.Image;
            Film_Bilgileri_Getir(kanvas4_film_label.Text);
        }

        private void kanvas5_pictureBox_Click(object sender, EventArgs e)
        {
            secili_filmin_afisi.Image = kanvas5_pictureBox.Image;
            Film_Bilgileri_Getir(kanvas5_film_label.Text);
        }

        private void kanvas6_pictureBox_Click(object sender, EventArgs e)
        {
            secili_filmin_afisi.Image = kanvas6_pictureBox.Image;
            Film_Bilgileri_Getir(kanvas6_film_label.Text);
        }
    }////////
}////////

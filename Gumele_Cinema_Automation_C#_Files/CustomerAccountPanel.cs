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
    public partial class CustomerAccountPanel : Form
    {
        public CustomerAccountPanel()
        {
            InitializeComponent();
        }
        string save_user_id_info_string = "";
        public string user_id_text;
        public string user_name_text;
        public string user_surname_text;

        private void Close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void Label1_Click(object sender, EventArgs e)
        {
            CustomerPanel cp = new CustomerPanel();
            //cp.call_succesfull_id_info(save_user_id_info_string);
            cp.call_succesfull_eposta_text(user_id_text, user_name_text, user_surname_text);
            this.Hide();
            cp.Show();
        }

        private void Update_account_Button_Click(object sender, EventArgs e)
        {
            UpdateMyAccountInformation();
           /* baglanti.Open();
            komut.CommandText = "UPDATE MUSTERİ_TABLOSU SET AD_SOYAD ='" + name_lastname_Textbox.Text + "', E_POSTA= '" + eposta_Textbox.Text + "',TELEFON= " + Convert.ToInt64(telephone_Textbox.Text) + ", CİNSİYET='" + sex_ComboBox.SelectedItem.ToString() + "', SİFRE= '" + new_password_Textbox.Text + "' WHERE MUSTERİ_İD='M0010' ";
            komut.Connection = baglanti;
            komut.ExecuteNonQuery();

            baglanti.Close();
            */
        }

         private void UpdateMyAccountInformation()
         {
            //baglanti.Open();
            // SqlCommand cmd = new SqlCommand();
            //con.Open();
            // cmd.Connection = baglanti;
            //cmd.CommandText = " UPDATE kullanicilar SET ad_soyad=@as, cep_telefonu=@ct, dogum_tarihi=@dt, cinsiyet=@c, parola=@p  ";
            //  cmd.CommandText = " update kullanicilar  set ad_soyad= '" + adsoyadtext.Text + "' ,e_posta= '" + epostatext.Text + "',cep_telefonu= '" + ceptelefonutext.Text + "',dogum_tarihi= '" + dogumtarihi_hesap.Value.ToShortDateString() + "',cinsiyet='" + cinsiyetbox.Text + "',parola='" + yeni_sifre_text.Text + "'  where e_posta='" + epostatext_gizli.Text + "'";
            //cmd.ExecuteNonQuery();
            if (confirmation_checkBox.Checked == true)
            {
                try
                {
                    // if (kayitsifretext.Text == eski_sifre)
                    //{
                    /*cmd.ExecuteNonQuery();
                    MessageBox.Show("güncelleme başarılı");
                    MessageBox.Show("güncellemenin ardından sistem oturumunuzu sonladırıyor");
                    baglanti.Close();
                    ciktim(Convert.ToInt32(sonlandirmak));
                    Application.Exit();*/
                    // string op = dob_dateTimePicker.Value.ToShortDateString();
                    // MessageBox.Show(op);
                    OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
                    OracleCommand komut = new OracleCommand();
                    baglanti.Open();

                    dob_dateTimePicker.Format = DateTimePickerFormat.Custom;
                    dob_dateTimePicker.CustomFormat = "dd-MM-yyyy";
                    //string op = dob_dateTimePicker.Value.ToShortDateString();
                    //MessageBox.Show(op);
                    komut.CommandText = "UPDATE musteriler SET ad= '" + name_Textbox.Text + "', soyad= '" + surname_textBox.Text + "', eposta= '" + eposta_Textbox.Text + "',telefon= " + Convert.ToInt64(telephone_Textbox.Text) + ",dogum_tarihi='" + dob_dateTimePicker.Value.ToShortDateString() + "', cinsiyet='" + sex_ComboBox.SelectedItem.ToString() + "',sifre= '" + new_password_Textbox.Text + "' WHERE musteri_id='" + user_id_text + "' ";
                    //komut.CommandText = "UPDATE MUSTERİ_TABLOSU SET AD_SOYAD = 'Anan Sch', E_POSTA= 'cegid',TELEFON=5541593963 , CİNSİYET='Kadın',SİFRE= '333' WHERE MUSTERİ_İD='M0009'";
                    //komut.CommandType = CommandType.Text;
                    komut.Connection = baglanti;
                    komut.ExecuteNonQuery();

                    baglanti.Close();
                    MessageBox.Show("Bilgileriniz Başarı İle Güncellendi !");


                    //}
                    /*  else
                      {
                          MessageBox.Show("Eski  Şifrenizi hatalı girdiniz lütfen düzeltin");
                      }*/
                }
                catch (Exception)
                {
                    MessageBox.Show("Servis Hatası Meydana Geldi !");
                }
            }

            else
            {
                MessageBox.Show("Lütfen Değişiklik İçin Onay Kutucuğunu İşaretleyin !");
            }
             
         }

        public void Veri_Tabaindaki_Bilgileri_Getir(string sqltum)
        {
            String aktif_kisi_no;
            //aktif_kisi_no = kullanici_panel.aktif_kisi_no;

            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand(sqltum,baglanti);
            baglanti.Open();
            OracleDataReader oku = komut.ExecuteReader();
            //SqlCommand komut = new SqlCommand(sqltum, baglanti);
            //SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read() == true)
            {
                if (user_id_text == oku["musteri_id"].ToString())
                {
                    name_Textbox.Text = oku["ad"].ToString();
                    surname_textBox.Text = oku["soyad"].ToString();
                    eposta_Textbox.Text = oku["eposta"].ToString();
                    //epostatext_gizli.Text = oku["e_posta_aktif"].ToString();
                    telephone_Textbox.Text = oku["telefon"].ToString();
                    old_password_Textbox.Text = oku["sifre"].ToString();
                    //eski_sifre = oku["sifre_aktif"].ToString();
                    sex_ComboBox.Text = oku["cinsiyet"].ToString();
                    DateTime dt = DateTime.Parse(oku["dogum_tarihi"].ToString());
                    dob_dateTimePicker.Value = DateTime.Parse(dt.ToShortDateString());
                }
            }


            baglanti.Close();
            //return maan;
        }

        private void CustomerAccountPanel_Load(object sender, EventArgs e)
        {
            Veri_Tabaindaki_Bilgileri_Getir("SELECT * FROM musteriler");
            user_name_surname_label.Text = user_name_text + " " + user_surname_text;

        }

        public void fetch_user_id_info(string user_id_info)
        {
            save_user_id_info_string = user_id_info;
        }

        private void New_password_Textbox_Click(object sender, EventArgs e)
        {
            if (new_password_Textbox.Text == " Yeni Şifreniz")
            {
                new_password_Textbox.Text = "";
            }
        }

        public void topla_bilgileri(string id, string name_text, string surname_text)
        {
            user_id_text = id;
            user_name_text = name_text;
            user_surname_text = surname_text;
        }
    }////////
}/////////

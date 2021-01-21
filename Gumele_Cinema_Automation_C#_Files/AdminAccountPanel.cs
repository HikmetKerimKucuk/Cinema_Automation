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
    public partial class AdminAccountPanel : Form
    {
        public AdminAccountPanel()
        {
            InitializeComponent();
        }
        public string user_id_text;
        public string user_name_text;
        public string user_surname_text;
        public string pos;

        private void update_account_Button_Click(object sender, EventArgs e)
        {
            UpdateMyAccountInformation();
        }

        private void UpdateMyAccountInformation()
        {
            if (confirmation_checkBox.Checked == true)
            {
                try
                {
                    OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
                    OracleCommand komut = new OracleCommand();
                    baglanti.Open();

                    dob_dateTimePicker.Format = DateTimePickerFormat.Custom;
                    dob_dateTimePicker.CustomFormat = "dd-MM-yyyy";
                    //string op = dob_dateTimePicker.Value.ToShortDateString();
                    //MessageBox.Show(op);
                    komut.CommandText = "UPDATE yoneticiler SET ad= '" + name_Textbox.Text + "'" +
                        ", soyad= '" + surname_textBox.Text + "', eposta= '" + eposta_Textbox.Text + "'" +
                        ",telefon= " + Convert.ToInt64(telephone_Textbox.Text) + ",dogum_tarihi='" + dob_dateTimePicker.Value.ToShortDateString() + "'" +
                        ", cinsiyet='" + sex_ComboBox.SelectedItem.ToString() + "',sifre= '" + new_password_Textbox.Text + "'" +
                        ", pozisyon= '" + pos + "' WHERE admin_id='" + user_id_text + "' ";
                    
                    komut.Connection = baglanti;
                    komut.ExecuteNonQuery();

                    baglanti.Close();
                    MessageBox.Show("Bilgileriniz Başarı İle Güncellendi");


                    //}
                    /*  else
                      {
                          MessageBox.Show("Eski  Şifrenizi hatalı girdiniz lütfen düzeltin");
                      }*/
                }
                catch (Exception)
                {
                    MessageBox.Show("Bilgileriniz Güncelleme İşlemi Başarısız, Alanları Doğru ve Eksiksiz Doldurduğunuzdan Emin Olun !");
                }
            }

            else
            {
                MessageBox.Show("Lütfen Değişikliliği Onaylayın !");
            }

        }

        public void Veri_Tabaindaki_Bilgileri_Getir(string sqltum)
        {
            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand(sqltum, baglanti);
            baglanti.Open();
            OracleDataReader oku = komut.ExecuteReader();
            //SqlCommand komut = new SqlCommand(sqltum, baglanti);
            //SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read() == true)
            {
                if (user_id_text == oku["admin_id"].ToString())
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
                    pos = oku["pozisyon"].ToString();
                }
            }


            baglanti.Close();
            //return maan;
        }

        private void AdminAccountPanel_Load(object sender, EventArgs e)
        {
            Veri_Tabaindaki_Bilgileri_Getir("SELECT * FROM yoneticiler");
            user_name_surname_label.Text = user_name_text + " " + user_surname_text;
        }

        public void bilgi(string id, string name_text, string surname_text)
        {
            user_id_text = id;
            user_name_text = name_text;
            user_surname_text = surname_text;
            //secret_label.Text = text_field;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           // AdminPanel ap = new AdminPanel();
            this.Hide();
            //ap.Show(); 
        }
    }///////
}////////

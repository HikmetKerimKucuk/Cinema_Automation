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
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
        }
        Boolean eposta_text_del = false;
        Boolean password_text_del = false;
        //Boolean ep;
       // Boolean mail_and_password_compliance;
        public String sussesfull_eposta_text = "";
        public string mid;
        public string mad;
        public string msoyad;
        public string mconf;

        public string aid;
        public string aad;
        public string asoyad;
        public string apozisyon;
        public string aconf;




        OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
        OracleCommand komut = new OracleCommand();
        //OracleDataReader oku;

        private void Close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            int hatasayac = 0;

            if (customer_radioButton.Checked == true)
            {
                string customer_entrance_confirmed = sign_in_control2(eposta_texttbox.Text, password_textbox.Text);
                if (customer_entrance_confirmed == "evet")
                {
                    try
                    {
                        CustomerPanel cp = new CustomerPanel();
                        cp.call_succesfull_eposta_text(mid,mad,msoyad);
                        //cp.user_id_info_text = kad;
                        hatasayac = hatasayac + 1;
                        this.Hide();
                        cp.Show();
                    }
                    catch (Exception)
                    {
                        if (hatasayac == 0)
                        {
                            MessageBox.Show("Servis Hatası Oluştu !");
                            
                        }

                    }


                }
                else if (customer_entrance_confirmed == "hayir")
                {
                    MessageBox.Show("Girdiğiniz Bilgiler Hatalı !");
                }
            }
            
                
            else if (admin_radioButton.Checked == true)
            {
                string admin_entrance_confirmed = sign_in_control(eposta_texttbox.Text, password_textbox.Text);
               
                if (admin_entrance_confirmed == "evet")
                {
                    try
                    {
                        AdminPanel ap = new AdminPanel();
                        //ap.call_succesfull_eposta_text(kad);
                        ap.call_succesfull_eposta_text(aid, aad, asoyad,apozisyon);
                        hatasayac = hatasayac + 1;
                        this.Hide();
                        ap.Show();
                    }
                    catch (Exception)
                    {
                        if (hatasayac == 0)
                        {
                            MessageBox.Show("Servis Hatası Oluştu");

                        }

                    }

                }
                else if (admin_entrance_confirmed == "hayir")
                {
                   MessageBox.Show("Girdiğiniz Bilgiler Hatalı !");
                }
                
            }
            else if (admin_radioButton.Checked== false && customer_radioButton.Checked == false)
            {
                MessageBox.Show("Lütfen kullanıcı tipini belirtiniz");
            }


            /* else
             {
                 MessageBox.Show("Lütfen kullanıcı tipini belirtiniz");
             }*/

        }

      /*  public void successful_entrance()
        {
            baglanti.Open();
            OracleCommand komutx = new OracleCommand();
            komutx.Connection = baglanti;
            komutx.CommandText = "SELECT * FROM MUSTERİ_TABLOSU WHERE E_POSTA='" + eposta_texttbox.Text + "' AND SİFRE='" + password_textbox.Text + "'";
            OracleDataReader oku = komutx.ExecuteReader();
            if (oku.Read() == true)
            {
                baglanti.Close();
                mail_and_password_compliance = true;
                sussesfull_eposta_text = eposta_texttbox.Text;
            }
            baglanti.Close();
        }*/

        private void Signuppanel_label_Click(object sender, EventArgs e)
        {
            SignupPanel sp = new SignupPanel();
            this.Hide();
            sp.Show();
            
        }

        private void Eposta_texttbox_Click(object sender, EventArgs e)
        {
            if (eposta_text_del == false)
            {
                eposta_texttbox.Text = "";
                eposta_text_del = true;

            }
        }

        private void Eposta_texttbox_KeyDown(object sender, KeyEventArgs e)
        {
            eposta_texttbox.ForeColor = Color.Black;
            if (eposta_texttbox.Text == "E-posta")

                eposta_texttbox.Text = "";
            //eposta_text.ForeColor = Color.Black;
        }

        private void Eposta_texttbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (eposta_texttbox.Text == "")
            {

                eposta_texttbox.Text = "E-posta";
                eposta_texttbox.ForeColor = Color.Gray;
            }

        }

        private void Password_textbox_Click(object sender, EventArgs e)
        {
            password_textbox.Font = new Font("Berlin Sans FB", 16);
            if (password_text_del == false)
            {
                password_textbox.Text = "";
                password_textbox.PasswordChar = '*';
                password_text_del = true;

            }
        }

        private void Password_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            password_textbox.Font = new Font("Berlin Sans FB", 16);
            password_textbox.ForeColor = Color.Black;
            password_textbox.PasswordChar = '*';
            if (password_textbox.Text == "Şifre")
            {
                password_textbox.Text = "";

            }
        }

        private void Password_textbox_KeyUp(object sender, KeyEventArgs e)
        {
            password_textbox.ForeColor = Color.Black;
            if (password_textbox.Text == "")
            {
                //jjjjjjjjjjjjn btn.Font = new Font("Verdana", 8, FontStyle.Bold);
                // sifre_text.Font = new Font("Berlin Sans FB", 18);
                password_textbox.Text = "Şifre";
                password_textbox.ForeColor = Color.Gray;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*string date = DateTime.Now.ToString();
            MessageBox.Show(date);*/
            /*AdminPanel ap = new AdminPanel();
        this.Hide();
        ap.Show();*/
        }

        public string sign_in_control(string fonc_user_id, string fonc_pass)
        {
            string onay;
            OracleConnection baglantix = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komutx = new OracleCommand();

            komutx.CommandText = "signincontroladmin";
            komutx.CommandType = CommandType.StoredProcedure;
            komutx.Connection = baglantix;


            komutx.Parameters.Clear();

            komutx.Parameters.Add("entrance_eposta", OracleDbType.Varchar2, 2000).Value = fonc_user_id;
            komutx.Parameters["entrance_eposta"].Direction = ParameterDirection.Input;

            komutx.Parameters.Add("entrance_pass", OracleDbType.Varchar2, 2000).Value = fonc_pass;
            komutx.Parameters["entrance_pass"].Direction = ParameterDirection.Input;

            komutx.Parameters.Add("ido", OracleDbType.Varchar2, 20).Direction = ParameterDirection.Output;
            komutx.Parameters.Add("ado", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            komutx.Parameters.Add("soyado", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            komutx.Parameters.Add("pozisyono", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            komutx.Parameters.Add("confirmation", OracleDbType.Varchar2, 20).Direction = ParameterDirection.Output;

            baglantix.Open();
            komutx.ExecuteNonQuery();
            aid = komutx.Parameters["ido"].Value.ToString();
            aad = komutx.Parameters["ado"].Value.ToString();
            asoyad = komutx.Parameters["soyado"].Value.ToString();
            apozisyon = komutx.Parameters["pozisyono"].Value.ToString();
            onay = komutx.Parameters["confirmation"].Value.ToString();
            baglantix.Close();
            return onay;
        }
        public string sign_in_control2(string fonc_user_id, string fonc_pass)
        {
            string onay;
            OracleConnection baglantix = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komutx = new OracleCommand();

            komutx.CommandText = "signincontrol";
            komutx.CommandType = CommandType.StoredProcedure;
            komutx.Connection = baglantix;


            komutx.Parameters.Clear();

            komutx.Parameters.Add("entrance_eposta", OracleDbType.Varchar2, 2000).Value = fonc_user_id;
            komutx.Parameters["entrance_eposta"].Direction = ParameterDirection.Input;

            komutx.Parameters.Add("entrance_pass", OracleDbType.Varchar2, 2000).Value = fonc_pass;
            komutx.Parameters["entrance_pass"].Direction = ParameterDirection.Input;

            komutx.Parameters.Add("ido", OracleDbType.Varchar2, 20).Direction = ParameterDirection.Output;
            komutx.Parameters.Add("ado", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            komutx.Parameters.Add("soyado", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            komutx.Parameters.Add("confirmation", OracleDbType.Varchar2, 20).Direction = ParameterDirection.Output;

            baglantix.Open();
            komutx.ExecuteNonQuery();
            mid = komutx.Parameters["ido"].Value.ToString();
            mad = komutx.Parameters["ado"].Value.ToString();
            msoyad = komutx.Parameters["soyado"].Value.ToString();
            onay = komutx.Parameters["confirmation"].Value.ToString();
            baglantix.Close();
            return onay;
        }

        private void forgot_password_label_Click(object sender, EventArgs e)
        {

        }
    }/////////
}/////////

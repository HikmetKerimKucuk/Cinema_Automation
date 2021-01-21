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
    public partial class CustomerPanel : Form
    {
        public CustomerPanel()
        {
            InitializeComponent();
        }
        public string user_id_text;
        public string user_name_text ;
        public string user_surname_text;
        public string user_id_info_text = "";
        private void Close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Previous_panel_label_Click(object sender, EventArgs e)
        {
            MainPanel mp = new MainPanel();
            this.Hide();
            mp.Show();
        }

        private void Films_panel_button_Click(object sender, EventArgs e)
        {
            FilmsPanel fp = new FilmsPanel();
            //fp.fetch_user_id_info(user_id_info_text);
            fp.topla_bilgileri(user_id_text, user_name_text, user_surname_text);
            this.Hide();
            fp.Show();
        }

        private void Campaign_panel_button_Click(object sender, EventArgs e)
        {
            CampaignPanel cp = new CampaignPanel();
            //cp.fetch_user_id_info(user_id_info_text);
            cp.topla_bilgileri(user_id_text, user_name_text, user_surname_text);
            this.Hide();
            cp.Show();
        }

        private void Account_panel_button_Click(object sender, EventArgs e)
        {
            CustomerAccountPanel cap = new CustomerAccountPanel();
            //cap.fetch_user_id_info(user_id_info_text);
            cap.topla_bilgileri(user_id_text, user_name_text, user_surname_text);
            this.Hide();
            cap.Show();


        }

        private void Buyticket_panelbutton_Click(object sender, EventArgs e)
        {
            BuyTicketPanel btp = new BuyTicketPanel();
            //btp.fetch_user_id_info(user_id_info_text);
            btp.topla_bilgileri(user_id_text, user_name_text, user_surname_text);
            this.Hide();
            btp.Show();
        }

        private void CustomerPanel_Load(object sender, EventArgs e)
        {/*
            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand("SELECT * FROM MUSTERİ_TABLOSU", baglanti);
            baglanti.Open();
            OracleDataReader oku = komut.ExecuteReader();
            

            while (oku.Read() == true)
            {
                if (user_name_surname_text == oku["E_POSTA"].ToString() || user_id_info_text == oku["MUSTERİ_İD"].ToString())
                {
                    active_customer_label.Text = oku["AD_SOYAD"].ToString();
                    user_id_info_text = oku["MUSTERİ_İD"].ToString();

                }
            }
            baglanti.Close();*/
            //MainPanel mp = new MainPanel();
            active_customer_label.Text = user_name_text+" "+user_surname_text;
        }

        public void call_succesfull_eposta_text(string id,string name_text, string surname_text)
        {
            user_id_text = id;
            user_name_text = name_text;
            user_surname_text = surname_text;
            //secret_label.Text = text_field;
        }

        public string al_sakla()
        {
            return user_id_info_text;
        }

        public void call_succesfull_id_info(string text_field)
        {
            user_id_info_text = text_field;
        }

        public void bilgi_gonder (string id, string name_text, string surname_text)
        {
            user_id_text = id;
            user_name_text = name_text;
            user_surname_text = surname_text;
            //secret_label.Text = text_field;
        }

        private void tickets_management_button_Click(object sender, EventArgs e)
        {
            CustomerTicketPanel ctp = new CustomerTicketPanel();
            ctp.topla_bilgileri(user_id_text, user_name_text, user_surname_text);
            ctp.Show();
            
        }
    }
}

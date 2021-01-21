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
    public partial class CampaignPanel : Form
    {
        public CampaignPanel()
        {
            InitializeComponent();
        }
        public string user_id_text;
        public string user_name_text;
        public string user_surname_text;

        public string save_user_id_info_string = "";
        private void CampaignPanel_Load(object sender, EventArgs e)
        {
            kampanya_bilgileri_getir();
            left_description_label.Visible = false;
            middle_description_label.Visible = false;
            right_description_panel.Visible = false;
            


        }
        private void Close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Middle_description_label_MouseLeave(object sender, EventArgs e)
        {
            middle_description_label.Visible = false;
            middle_pictureBox.Visible = true;
        }

        private void Middle_pictureBox_MouseHover(object sender, EventArgs e)
        {
            middle_pictureBox.Visible = false;
            middle_description_label.Visible = true;
        }

        private void Left_pictureBox_MouseHover(object sender, EventArgs e)
        {
            left_pictureBox.Visible = false;
            left_description_label.Visible = true;
        }

        private void Left_description_label_MouseLeave(object sender, EventArgs e)
        {
            left_description_label.Visible = false;
            left_pictureBox.Visible = true;
        }

        private void Right_pictureBox_MouseHover(object sender, EventArgs e)
        {
            right_pictureBox.Visible = false;
            right_description_panel.Visible = true;
        }

        private void Right_description_panel_MouseLeave(object sender, EventArgs e)
        {
            right_description_panel.Visible = false;
            right_pictureBox.Visible = true;
        }

        private void Previous_panel_label_Click(object sender, EventArgs e)
        {
            CustomerPanel cp = new CustomerPanel();
            //cp.call_succesfull_id_info(save_user_id_info_string);
            cp.call_succesfull_eposta_text(user_id_text, user_name_text, user_surname_text);
            this.Hide();
            cp.Show();
        }

        public void fetch_user_id_info(string user_id_info)
        {
            save_user_id_info_string = user_id_info;
        }
        public void topla_bilgileri(string id, string name_text, string surname_text)
        {
            user_id_text = id;
            user_name_text = name_text;
            user_surname_text = surname_text;
        }

        public void kampanya_bilgileri_getir()
        {
            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand("SELECT * FROM kampanyalar",baglanti);
            baglanti.Open();
            OracleDataReader oku = komut.ExecuteReader();
            try
            {
                
                
                while (oku.Read() == true)
                {
                    if (oku["kampanya_id"].ToString()=="1")
                    {
                        left_description_label.Text = oku["kampanya_metni"].ToString();
                        
                    }
                    else if (oku["kampanya_id"].ToString() == "2")
                    {
                        middle_description_label.Text = oku["kampanya_metni"].ToString();

                    }
                    else if (oku["kampanya_id"].ToString() == "3")
                    {
                        right_description_panel.Text = oku["kampanya_metni"].ToString();

                    }
                }


                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem Hatası Meydana Geldi !");
            }
        }

    }//////
}//////

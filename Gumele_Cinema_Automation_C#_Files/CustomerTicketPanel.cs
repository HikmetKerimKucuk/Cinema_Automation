using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gumele_Cinema_Automation
{
    public partial class CustomerTicketPanel : Form
    {
        public CustomerTicketPanel()
        {
            InitializeComponent();
        }
        public string user_id_text;
        public string user_name_text;
        public string user_surname_text;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)/*Exit Buttuon*/
        {
            //Application.Exit();
            this.Hide();
        }
        public void tickets_read_db()
        {
            try
            {
                OracleConnection conn = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
                OracleCommand cmd = new OracleCommand("select * from biletler_view", conn);
                conn.Open();
                OracleDataReader oku = cmd.ExecuteReader();
                while (oku.Read() == true)
                {
                    if (user_name_text == oku["ad"].ToString() && user_surname_text == oku["soyad"].ToString())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(oku);
                        mytickets_dataGridView.DataSource = dataTable;
                    }
                }
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Servis Hatası Meydana Geldi !");
            }

        }

        private void CustomerTicketPanel_Load(object sender, EventArgs e)
        {
            // bilet_bilgileri_getir();
            //tickets_read_db();
            tablo_olustur();
            //tickets_read_db();
            bilet_bilgileri_getir();
        }

        public void bilet_bilgileri_getir()
        {
                OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
                OracleCommand komut = new OracleCommand("SELECT * FROM biletler_view", baglanti);
                baglanti.Open();
                OracleDataReader oku = komut.ExecuteReader();
                
                while (oku.Read() == true)
                {
                    if (user_name_text == oku["ad"].ToString() && user_surname_text== oku["soyad"].ToString())
                    {
                    string a = oku["bilet_id"].ToString();
                    string b = oku["ad"].ToString();
                    string bb = oku["soyad"].ToString();
                    string c = oku["film_adi"].ToString();
                    string d = oku["salon_adi"].ToString();
                    string e = oku["seans_tarihi"].ToString();
                    string f = oku["seans_saati"].ToString();
                    string g = oku["bilet_ucreti"].ToString();
                    string h = oku["koltukno"].ToString();
                    string i = oku["alim_tarihi"].ToString();

                    // mytickets_dataGridView.a
                    //mytickets_dataGridView.Rows.Add(oku["bilet_id"].ToString(),oku["ad"].ToString(), oku["soyad"].ToString(), oku["film_adi"].ToString(), oku["salon_adi"].ToString(), oku["seans_tarihi"].ToString(),oku["seans_saati"].ToString(), oku["koltukno"].ToString(), oku["bilet_ucreti"].ToString(), oku["alim_tarihi"].ToString());
                    //mytickets_dataGridView.Rows.Add(g, user_name_surname_label.Text, film_name_label.Text, saloon_no_label.Text, rezervation_date_label.Text, rezervation_hours_label.Text, seat_no_label_textBox.Text, ticket_price_label.Text, o);
                    mytickets_dataGridView.Rows.Add(a,b,bb,c,d,e,f,g,h,i);
                }
                }


                baglanti.Close();
                //return maan;
            
        }
        public void topla_bilgileri(string id, string name_text, string surname_text)
        {
            user_id_text = id;
            user_name_text = name_text;
            user_surname_text = surname_text;
        }

        private void change_seat_button_Click(object sender, EventArgs e)
        {
            //tablo_olustur();
            //tickets_read_db();
           // bilet_bilgileri_getir();
        }

        private void tablo_olustur()
        {
            mytickets_dataGridView.ColumnCount = 10;

            mytickets_dataGridView.Columns[0].Name = "Bilet ID";
            mytickets_dataGridView.Columns[1].Name = "Ad";
           mytickets_dataGridView.Columns[2].Name =  "Soyad";
            mytickets_dataGridView.Columns[3].Name = "Film Adı";
            mytickets_dataGridView.Columns[4].Name = "Salon Adı";
            mytickets_dataGridView.Columns[5].Name = "Seans Tarihi";
            mytickets_dataGridView.Columns[6].Name = "Seans Saati";
            mytickets_dataGridView.Columns[7].Name = "Bilet Ücreti";
            mytickets_dataGridView.Columns[8].Name = "Koltuk No";
            mytickets_dataGridView.Columns[9].Name = "Alım Tarihi";

        }
        private void tablodan_veri_cek()
        {
            try
            {
                string id = mytickets_dataGridView.CurrentRow.Cells[0].Value.ToString();
                user_name_surname_label.Text = mytickets_dataGridView.CurrentRow.Cells[1].Value.ToString() + " " + mytickets_dataGridView.CurrentRow.Cells[2].Value.ToString();
                film_name_label.Text = mytickets_dataGridView.CurrentRow.Cells[3].Value.ToString();
                saloon_no_label.Text = mytickets_dataGridView.CurrentRow.Cells[4].Value.ToString();
                rezervation_date_label.Text = mytickets_dataGridView.CurrentRow.Cells[5].Value.ToString();
                rezervation_hours_label.Text = mytickets_dataGridView.CurrentRow.Cells[6].Value.ToString();
                seat_no_label_textBox.Text = mytickets_dataGridView.CurrentRow.Cells[8].Value.ToString();
                ticket_price_label.Text = mytickets_dataGridView.CurrentRow.Cells[7].Value.ToString();
                buydate_label.Text = mytickets_dataGridView.CurrentRow.Cells[9].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Servis Hatası Meydana Geldi !");

            }

        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void mytickets_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tablodan_veri_cek();
        }

        public void tickets_delete_fonc()
        {
            string id = mytickets_dataGridView.CurrentRow.Cells[0].Value.ToString();

            try
            {
                OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
                OracleCommand komut = new OracleCommand();
                baglanti.Open();
                komut.CommandText = "  DELETE FROM biletler WHERE bilet_id=" + Convert.ToInt64(id) + " ";
                komut.CommandType = CommandType.Text;
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Bilet Başarı ile Silindi, Ana Pencereye Yönlendiriliyorsunuz !");
                this.Hide();

            }
            catch (Exception)
            {
                MessageBox.Show("Bilet Silme Başarısız, Sistem Hatası Meydana Geldi !");
            }
        }

        private void delete_ticket_button_Click(object sender, EventArgs e)
        {
            tickets_delete_fonc();
           // mytickets_dataGridView.Columns.Clear();
            //MessageBox.Show("Bir ");
            
            //mytickets_dataGridView
            //bilet_bilgileri_getir();
        }
    }/////
}////////

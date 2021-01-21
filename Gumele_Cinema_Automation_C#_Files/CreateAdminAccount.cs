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
    public partial class CreateAdminAccount : Form
    {
        public CreateAdminAccount()
        {
            InitializeComponent();
        }
        

        private void create_admin_button_Click(object sender, EventArgs e)
        {
            OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
            OracleCommand komut = new OracleCommand();
            try
            {
                
                    if (verification_checkBox.Checked == true)
                    {
                        baglanti.Open();
                        komut.CommandText = "INSERT INTO yoneticiler VALUES (DEFAULT,'" + name_textbox.Text + "','" + surname_textBox.Text + "','" + eposta_texttbox.Text + "'," + Convert.ToInt64(telephone_textbox.Text) + ",'" + dateofbirth_TimePicker.Value.ToShortDateString() + "','" + sex_comboBox.SelectedItem.ToString() + "','" + password_textbox.Text + "','" + position_comboBox.SelectedItem.ToString() + "') ";
                        komut.Connection = baglanti;
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Yeni Yönetici Kaydı Başarı İle Gerçekleştirildi !");
                        
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Onayını Okuyun ve Onay Kutusunu İşaretleyin !");
                    }
                
                




            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Başarısız, Sistem Hatası Meydana Geldi !");
            }
            //foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            sex_comboBox.Text = " Cinsiyet";
            admins_read_db();
        }

        public void admins_read_db()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;"))
                using (OracleCommand cmd = new OracleCommand("select * from yoneticiler", conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        admins_dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Sistem Hatası Meydana Geldi !");
            }
        }

        public void admins_update_fonc()
        {
            string id = admins_dataGridView.CurrentRow.Cells[0].Value.ToString();
            string name = admins_dataGridView.CurrentRow.Cells[1].Value.ToString();
            string surname = admins_dataGridView.CurrentRow.Cells[2].Value.ToString();
            string eposta = admins_dataGridView.CurrentRow.Cells[3].Value.ToString();
            string telephone = admins_dataGridView.CurrentRow.Cells[4].Value.ToString();
            //string dob = admins_dataGridView.CurrentRow.Cells[5].Value.ToString();
            string sex = admins_dataGridView.CurrentRow.Cells[6].Value.ToString();
            string pass = admins_dataGridView.CurrentRow.Cells[7].Value.ToString();
            string position = admins_dataGridView.CurrentRow.Cells[8].Value.ToString();
            DateTime dt = DateTime.Parse(admins_dataGridView.CurrentRow.Cells[5].Value.ToString());

            //MessageBox.Show(id+name+surname+eposta+telephone+dt.ToShortDateString()+sex+pass+position);
            try
            {
                OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
                OracleCommand komut = new OracleCommand();
                baglanti.Open();

                //dob_dateTimePicker.Format = DateTimePickerFormat.Custom;
                //dob_dateTimePicker.CustomFormat = "dd-MM-yyyy";
                //string op = dob_dateTimePicker.Value.ToShortDateString();
                //MessageBox.Show(op);
                komut.CommandText = "UPDATE yoneticiler SET ad= '" + name + "', soyad= '" + surname + "', eposta= '" + eposta + "', telefon= " + Convert.ToInt64(telephone) + ", dogum_tarihi= '" + dt.ToShortDateString() + "', cinsiyet= '" + sex + "', sifre= '" + pass + "', pozisyon= '" + position + "' WHERE admin_id=" + Convert.ToInt64(id) + " ";
                //komut.CommandText = "UPDATE MUSTERİ_TABLOSU SET AD_SOYAD = 'Anan Sch', E_POSTA= 'cegid',TELEFON=5541593963 , CİNSİYET='Kadın',SİFRE= '333' WHERE MUSTERİ_İD='M0009'"; 
                komut.CommandType = CommandType.Text;
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kişi Bilgileri Başarı İle Güncellendi !");

            }
            catch (Exception)
            {
                MessageBox.Show("Bilgi Güncelleme İşlemi Başarısız, Sistem Hatası Meydana Geldi !");
            }
        }

        public void admins_delete_fonc()
        {
            string id = admins_dataGridView.CurrentRow.Cells[0].Value.ToString();
            
            try
            {
                OracleConnection baglanti = new OracleConnection("Data Source=localhost:1521/XEPDB1;User Id=SYSTEM;Password=girkanima06;");
                OracleCommand komut = new OracleCommand();
                baglanti.Open();
                komut.CommandText = "  DELETE FROM yoneticiler WHERE admin_id=" + Convert.ToInt64(id) + " ";
                komut.CommandType = CommandType.Text;
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kişinin Sistem Kaydı Başarı ile Kaldırıldı");

            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Silme Başarısız, Sistem Hatası Meydana Geldi !");
            }
        }

        private void CreateAdminAccount_Load(object sender, EventArgs e)
        {
            admins_read_db();
        }

        private void update_aadmin_button_Click(object sender, EventArgs e)
        {
            admins_update_fonc();
            admins_read_db();
        }

        private void delete_admin_button_Click(object sender, EventArgs e)
        {
            admins_delete_fonc();
            admins_read_db();
        }

        private void back_label_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void verification_checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }//////
}/////

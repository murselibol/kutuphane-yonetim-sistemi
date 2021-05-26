using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Kutuphane2
{
    public partial class FormProfilAyarlari : Form
    {

        public static string baglanti_adresi = Helper.baglanti_adresi;

        public FormProfilAyarlari()
        {
            InitializeComponent();
        }

        string tablo = Helper.secim;
        //FORM YÜKLENDİĞİNDE ÜYENİN VERİLERİNİ ÇEKER.
        private void FormProfilAyarlari_Load(object sender, EventArgs e)
        {


            try
            {
                using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
                {
                    MySqlCommand command = new MySqlCommand($"Select ad,soyad,eMail, sifre, telefon, adres From {tablo} where {tablo}ID={Helper.girisYapID} ", connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        adTxt.Text = reader[0].ToString();
                        soyadTxt.Text = reader[1].ToString();
                        emailTxt.Text = reader[2].ToString();
                        sifreTxt.Text = reader[3].ToString();
                        telefonTxt.Text = reader[4].ToString();
                        adresTxt.Text = reader[5].ToString();

                    };
                    connection.Close();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Veritabanı hatası.");
            }

        }



        //UYENİN ŞİFRE TELEFON ADRES VERİLERİNİ GÜNCELLER
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (sifreTxt.Text != "")
            {
                using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
                {
                    MySqlCommand command = new MySqlCommand($"UPDATE {tablo} SET sifre='{sifreTxt.Text}', telefon='{telefonTxt.Text}', adres='{adresTxt.Text}'  where {tablo}ID={Helper.girisYapID} ", connection);
                    connection.Open();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        label7.Text = "Başarıyla Değiştirildi...";
                        label7.ForeColor = Color.DarkGreen;
                        label7.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Hata...");
                    }

                    connection.Close();

                }
            }
            else
            {
                label7.Text = "Şifreyi Boş bırakmayın.";
                label7.ForeColor = Color.Red;
                label7.Visible = true;
            }
        }



        //FORMDAN ÇIKIŞ
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using ClassLibrary;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Kutuphane2
{
    public class Helper
    {

        public static string baglanti_adresi = SqlConnector.baglanti_adresi;
        public static string girisYapID; //sisteme kim giriş yaparsa ID sini burada tutar. Gerekli yerlere gönderir.
        public static string secim;

        //datagride veri çekme
        public Helper(string sorgu, string v, DataGridView dataGridView1)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
                {
                    if (v == "uye")
                    {
                        connection.Open();

                        // Bir üye kitabı geç getirdiğinde ceza tarihi verilir. Bu ceza süresi bitmişse üyeyi aktif yapar.
                        MySqlCommand command = new MySqlCommand($"UPDATE uye SET uyelikDurumu = 1 where cezaTarihi < current_date() AND uyelikDurumu = 0", connection);
                        // Bir üye kitabı geç getirdiğinde ceza tarihi verilir. Bu ceza süresi bitmişse üyeyi aktif yapar.
                        MySqlCommand comman2 = new MySqlCommand($"UPDATE uye SET uyelikDurumu = 0 where uyelikDurumu = 1 AND uyeID IN (SELECT uyeID FROM islem where iadeTarihi < current_date())", connection);
                        command.ExecuteNonQuery();
                        comman2.ExecuteNonQuery();
                        connection.Close();

                    }

                    MySqlDataAdapter da = new MySqlDataAdapter($"Select {sorgu} From {v}", connection);
                    DataSet ds = new DataSet();
                    connection.Open();
                    da.Fill(ds, v);
                    dataGridView1.DataSource = ds.Tables[v];
                    connection.Close();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Veritabanı hatası...");
            }
        }


        //combobox
        public Helper(string sorgu, string v, ComboBox combo)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
                {
                    MySqlCommand command = new MySqlCommand($"Select {sorgu} From {v}", connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        combo.Items.Add(reader.GetString(sorgu));
                    };
                    connection.Close();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Veritabanı hatası...");
            }
        }


        // Uye ve admin
        public Helper(string sorgu, string v, string arama, DataGridView dataGridView1)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
                {

                    //UPDATE uye SET uyelikDurumu = 1 where cezaTarihi<current_date()
                    MySqlDataAdapter da = new MySqlDataAdapter($"Select {sorgu} From {v} where ad LIKE '%{arama}%' OR soyad LIKE '%{arama}%' OR eMail LIKE '%{arama}%'", connection);
                    DataSet ds = new DataSet();
                    connection.Open();
                    da.Fill(ds, v);
                    dataGridView1.DataSource = ds.Tables[v];
                    connection.Close();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Veritabanı hatası...");
            }
        }


        // Kitap
        public Helper(string kitap, string sorgu, string v, string arama, DataGridView dataGridView1)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
                {

                    MySqlDataAdapter da = new MySqlDataAdapter($"Select {sorgu} From {v} where t1.ad LIKE '%{arama}%' OR t1.yazar LIKE '%{arama}%' OR t3.kategoriAdi LIKE '%{arama}%' OR t1.ISBN LIKE '%{arama}%'", connection);
                    DataSet ds = new DataSet();
                    connection.Open();
                    da.Fill(ds, v);
                    dataGridView1.DataSource = ds.Tables[v];
                    connection.Close();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Veritabanı hatası...");
            }
        }


        // İşlem
        public Helper(int kitap, string sorgu, string v, string arama, DataGridView dataGridView1)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter($"Select {sorgu} From {v} where t1.islemID LIKE '%{arama}%' OR t3.ad LIKE '%{arama}%' OR t2.ad LIKE '%{arama}%' OR t3.soyad LIKE '%{arama}%' OR t2.ISBN LIKE '%{arama}%'", connection);
                    DataSet ds = new DataSet();
                    connection.Open();
                    da.Fill(ds, v);
                    dataGridView1.DataSource = ds.Tables[v];
                    connection.Close();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Veritabanı hatası...");
            }
        }


    }
}

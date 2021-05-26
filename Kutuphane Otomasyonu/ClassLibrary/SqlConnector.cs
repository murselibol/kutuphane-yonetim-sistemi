using MySql.Data.MySqlClient;
using System.Data;


namespace ClassLibrary
{
    public class SqlConnector   //BURASI MYSQL DE OLUŞTURULMUŞ PROCEDURELERİN ÇALIŞTIRILMASINI SAĞLAR.
    {

        //BAĞLANTI ADRESİNİ SADECE BURADAN ALIR....
        public static string baglanti_adresi = @"Server = db4free.net; Database = kutuphane; Uid = erensaskin; Pwd =87b25750 ;";
        bool status;



        //KİTAP İŞLEMLERİ.........................
        public bool kitapOlustur(Kitap kitap)
        {
            using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
            {
                MySqlParameter[] pms = new MySqlParameter[10];
                pms[0] = new MySqlParameter("p_ISBN", MySqlDbType.VarChar);
                pms[0].Value = kitap.ISBN;

                pms[1] = new MySqlParameter("p_ad", MySqlDbType.VarChar);
                pms[1].Value = kitap.ad;

                pms[2] = new MySqlParameter("p_yazar", MySqlDbType.VarChar);
                pms[2].Value = kitap.yazar;

                pms[3] = new MySqlParameter("p_baskiYili", MySqlDbType.VarChar);
                pms[3].Value = kitap.baskiYili;

                pms[4] = new MySqlParameter("p_yayinEvi", MySqlDbType.VarChar);
                pms[4].Value = kitap.yayinEvi;

                pms[5] = new MySqlParameter("p_sayfaSayisi", MySqlDbType.VarChar);
                pms[5].Value = kitap.sayfaSayisi;
                pms[6] = new MySqlParameter("p_fotograf", MySqlDbType.Blob);
                pms[6].Value = kitap.fotograf;
                pms[7] = new MySqlParameter("p_aciklama", MySqlDbType.VarChar);
                pms[7].Value = kitap.aciklama;
                pms[8] = new MySqlParameter("p_kategoriAd", MySqlDbType.VarChar);
                pms[8].Value = kitap.kategori;
                pms[9] = new MySqlParameter("p_adminID", MySqlDbType.Int32);
                pms[9].Value = kitap.adminID;


                MySqlCommand command = new MySqlCommand();

                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "p_kitapEkle";

                command.Parameters.AddRange(pms);

                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                    status = true;
                else
                    status = false;
                connection.Close();
            }
            return status;
        }
        public bool kitapGuncelle(Kitap kitap)
        {
            using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
            {
                MySqlParameter[] pms = new MySqlParameter[10];
                pms[0] = new MySqlParameter("p_ISBN", MySqlDbType.VarChar);
                pms[0].Value = kitap.ISBN;

                pms[1] = new MySqlParameter("p_ad", MySqlDbType.VarChar);
                pms[1].Value = kitap.ad;

                pms[2] = new MySqlParameter("p_yazar", MySqlDbType.VarChar);
                pms[2].Value = kitap.yazar;

                pms[3] = new MySqlParameter("p_baskiYili", MySqlDbType.VarChar);
                pms[3].Value = kitap.baskiYili;

                pms[4] = new MySqlParameter("p_yayinEvi", MySqlDbType.VarChar);
                pms[4].Value = kitap.yayinEvi;

                pms[5] = new MySqlParameter("p_sayfaSayisi", MySqlDbType.VarChar);
                pms[5].Value = kitap.sayfaSayisi;
                pms[6] = new MySqlParameter("p_fotograf", MySqlDbType.Blob);
                pms[6].Value = kitap.fotograf;
                pms[7] = new MySqlParameter("p_aciklama", MySqlDbType.LongText);
                pms[7].Value = kitap.aciklama;
                pms[8] = new MySqlParameter("p_kategoriAd", MySqlDbType.VarChar);
                pms[8].Value = kitap.kategori;
                pms[9] = new MySqlParameter("p_adminID", MySqlDbType.Int32);
                pms[9].Value = kitap.adminID;


                MySqlCommand command = new MySqlCommand();

                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "p_kitapGuncelle";

                command.Parameters.AddRange(pms);

                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                    status = true;
                else
                    status = false;
                connection.Close();
            }
            return status;
        }
        public bool kitapSil(Kitap kitap)
        {
            using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
            {
                MySqlParameter[] pms = new MySqlParameter[2];
                pms[0] = new MySqlParameter("p_ISBN", MySqlDbType.VarChar);
                pms[0].Value = kitap.ISBN;
                pms[1] = new MySqlParameter("p_adminID", MySqlDbType.Int32);
                pms[1].Value = kitap.adminID;

                MySqlCommand command = new MySqlCommand();

                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "p_kitapSil";

                command.Parameters.AddRange(pms);

                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                    status = true;
                else
                    status = false;
                connection.Close();
            }
            return status;
        }
        public bool kitapUzat(Islem islem)
        {
            using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
            {
                MySqlParameter[] pms = new MySqlParameter[2];
                pms[0] = new MySqlParameter("p_islemID", MySqlDbType.Int32);
                pms[0].Value = islem.islemID;

                pms[1] = new MySqlParameter("p_iadeTarihi", MySqlDbType.VarChar);
                pms[1].Value = islem.iadeTarihi;

                MySqlCommand command = new MySqlCommand();

                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "p_kitapUzat";

                command.Parameters.AddRange(pms);

                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                    status = true;
                else
                    status = false;
                connection.Close();
            }
            return status;
        }
        //.......................................



        //ADMİN İŞLEMLERİ.........................
        public bool adminOlustur(Admin admin)
        {
            using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
            {
                MySqlParameter[] pms = new MySqlParameter[5];
                pms[0] = new MySqlParameter("p_ad", MySqlDbType.VarChar);
                pms[0].Value = admin.ad;

                pms[1] = new MySqlParameter("p_soyad", MySqlDbType.VarChar);
                pms[1].Value = admin.soyad;

                pms[2] = new MySqlParameter("p_eMail", MySqlDbType.VarChar);
                pms[2].Value = admin.eMail;

                pms[3] = new MySqlParameter("p_telefon", MySqlDbType.VarChar);
                pms[3].Value = admin.telefon;

                pms[4] = new MySqlParameter("p_adres", MySqlDbType.VarChar);
                pms[4].Value = admin.adres;

                MySqlCommand command = new MySqlCommand();

                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "p_adminEkle";

                command.Parameters.AddRange(pms);

                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                    status = true;
                else
                    status = false;
                connection.Close();
            }
            return status;
        }
        public bool adminGuncelle(Admin admin)
        {
            using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
            {
                MySqlParameter[] pms = new MySqlParameter[5];
                pms[0] = new MySqlParameter("p_ad", MySqlDbType.VarChar);
                pms[0].Value = admin.ad;

                pms[1] = new MySqlParameter("p_soyad", MySqlDbType.VarChar);
                pms[1].Value = admin.soyad;

                pms[2] = new MySqlParameter("p_eMail", MySqlDbType.VarChar);
                pms[2].Value = admin.eMail;

                pms[3] = new MySqlParameter("p_telefon", MySqlDbType.VarChar);
                pms[3].Value = admin.telefon;

                pms[4] = new MySqlParameter("p_adres", MySqlDbType.VarChar);
                pms[4].Value = admin.adres;

                MySqlCommand command = new MySqlCommand();

                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "p_adminGuncelle";

                command.Parameters.AddRange(pms);

                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                    status = true;
                else
                    status = false;
                connection.Close();
            }
            return status;
        }
        public bool adminSil(Admin admin)
        {
            using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
            {
                MySqlParameter[] pms = new MySqlParameter[1];

                pms[0] = new MySqlParameter("p_eMail", MySqlDbType.VarChar);
                pms[0].Value = admin.eMail;

                MySqlCommand command = new MySqlCommand();

                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "p_adminSil";

                command.Parameters.AddRange(pms);

                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                    status = true;
                else
                    status = false;
                connection.Close();
            }
            return status;
        }
        //........................................




        //UYE İŞLEMLERİ....................
        public bool uyeOlustur(Uye uye)
        {
            using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
            {
                MySqlParameter[] pms = new MySqlParameter[7];
                pms[0] = new MySqlParameter("p_ad", MySqlDbType.VarChar);
                pms[0].Value = uye.ad;

                pms[1] = new MySqlParameter("p_soyad", MySqlDbType.VarChar);
                pms[1].Value = uye.soyad;

                pms[2] = new MySqlParameter("p_eMail", MySqlDbType.VarChar);
                pms[2].Value = uye.eMail;

                pms[3] = new MySqlParameter("p_telefon", MySqlDbType.VarChar);
                pms[3].Value = uye.telefon;

                pms[4] = new MySqlParameter("p_adres", MySqlDbType.VarChar);
                pms[4].Value = uye.adres;
                pms[5] = new MySqlParameter("p_adminID", MySqlDbType.Int32);
                pms[5].Value = uye.adminID;
                pms[6] = new MySqlParameter("p_cezaTarihi", MySqlDbType.Date);
                pms[6].Value = uye.cezaTarihi;

                MySqlCommand command = new MySqlCommand();

                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "p_uyeEkle";

                command.Parameters.AddRange(pms);

                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                    status = true;
                else
                    status = false;
                connection.Close();
            }
            return status;
        }
        public bool uyeGuncelle(Uye uye)
        {
            using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
            {
                MySqlParameter[] pms = new MySqlParameter[5];
                pms[0] = new MySqlParameter("p_ad", MySqlDbType.VarChar);
                pms[0].Value = uye.ad;

                pms[1] = new MySqlParameter("p_soyad", MySqlDbType.VarChar);
                pms[1].Value = uye.soyad;

                pms[2] = new MySqlParameter("p_eMail", MySqlDbType.VarChar);
                pms[2].Value = uye.eMail;

                pms[3] = new MySqlParameter("p_telefon", MySqlDbType.VarChar);
                pms[3].Value = uye.telefon;

                pms[4] = new MySqlParameter("p_adres", MySqlDbType.VarChar);
                pms[4].Value = uye.adres;


                MySqlCommand command = new MySqlCommand();

                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "p_uyeGuncelle";

                command.Parameters.AddRange(pms);

                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                    status = true;
                else
                    status = false;
                connection.Close();
            }
            return status;
        }
        public bool uyeSil(Uye uye)
        {
            using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
            {
                MySqlParameter[] pms = new MySqlParameter[2];

                pms[0] = new MySqlParameter("p_eMail", MySqlDbType.VarChar);
                pms[0].Value = uye.eMail;
                pms[1] = new MySqlParameter("p_adminID", MySqlDbType.Int32);
                pms[1].Value = uye.adminID;

                MySqlCommand command = new MySqlCommand();

                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "p_uyeSil";

                command.Parameters.AddRange(pms);

                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                    status = true;
                else
                    status = false;
                connection.Close();
            }
            return status;
        }
        //.................................



        //EMANET İŞLEMLERİ.....................
        public bool islemOlustur(Islem islem)
        {
            using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
            {
                MySqlParameter[] pms = new MySqlParameter[6];
                pms[0] = new MySqlParameter("p_uyeID", MySqlDbType.Int32);
                pms[0].Value = islem.uyeID;

                pms[1] = new MySqlParameter("p_kitapID", MySqlDbType.Int32);
                pms[1].Value = islem.kitapID;

                pms[2] = new MySqlParameter("p_adminID", MySqlDbType.Int32);
                pms[2].Value = islem.adminID;

                pms[3] = new MySqlParameter("p_islemTarihi", MySqlDbType.Date);
                pms[3].Value = islem.islemTarihi;

                pms[4] = new MySqlParameter("p_iadeTarihi", MySqlDbType.Date);
                pms[4].Value = islem.iadeTarihi;
                pms[5] = new MySqlParameter("p_emanetDurumu", MySqlDbType.VarChar);
                pms[5].Value = islem.emanetDurumu;




                MySqlCommand command = new MySqlCommand();

                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "p_islemEkle";

                command.Parameters.AddRange(pms);

                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                    status = true;
                else
                    status = false;
                connection.Close();
            }
            return status;
        }
        public bool islemSil(Islem islem)
        {
            using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
            {
                MySqlParameter[] pms = new MySqlParameter[1];
                pms[0] = new MySqlParameter("p_islemID", MySqlDbType.Int32);
                pms[0].Value = islem.islemID;


                MySqlCommand command = new MySqlCommand();

                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "p_islemSil";

                command.Parameters.AddRange(pms);

                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                    status = true;
                else
                    status = false;
                connection.Close();
            }
            return status;
        }
        //.....................................



        //GİRİŞ YAP
        public bool girisYap(Login login, string secim)
        {
            using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
            {
                MySqlCommand command = new MySqlCommand();
                MySqlDataReader rd;
                command.Connection = connection;
                connection.Open();
                command.CommandText = $"SELECT {secim}ID, ad, soyad FROM " + secim + " where eMail = '" + login.eMail + "' AND sifre='" + login.sifre + "'";

                rd = command.ExecuteReader();

                if (rd.Read())
                {
                    login.girisYapID = rd.GetValue(0).ToString();
                    login.adSoyad = rd.GetValue(1).ToString() + " " + rd.GetValue(2).ToString();
                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();
                    return false;
                }




            }

        }






    }
}

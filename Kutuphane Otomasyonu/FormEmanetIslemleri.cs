using ClassLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kutuphane2
{
    public partial class FormEmanetIslemleri : Form
    {
        public FormEmanetIslemleri()
        {
            InitializeComponent();
        }


        public string sorguUye = "uyeID as ID,ad as Ad, soyad as Soyad, eMail as Email, telefon as Tel, uyelikDurumu as Durumu";
        public string sorguKitap = "t1.kitapID as ID,t1.ISBN,t1.ad as Ad,t1.yazar as Yazar, t3.kategoriAdi as Kategori, t1.baskiYili as Yıl, t1.yayinEvi as Yayın, t1.fotograf as Foto";
        public string tabloKitap = "kitap t1  INNER JOIN kitap_kategori t2 ON t1.kitapID = t2.kitapID INNER JOIN kategori t3 ON t2.kategoriID = t3.kategoriID";
        public string sorguIslem = "t1.islemID as ID, t3.ad as Ad, t3.soyad as Soyad, t3.eMail as Email,t2.ISBN as ISBN,t2.ad as Kitap, t2.fotograf as Fotoğraf, t1.iadeTarihi as İadeTarihi";
        public string tabloIslem = "islem t1 INNER JOIN kitap t2 ON t1.kitapID = t2.kitapID INNER JOIN uye t3 ON t1.uyeID = t3.uyeID";



        public int islemID = 0;

        private void FormEmanetIslemleri_Load(object sender, EventArgs e)
        {
            yetkiliIDTxt.Text = Helper.girisYapID;

            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today.AddDays(15);

            // Kitap gridine veri çekme
            {
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Helper kitapHelper = new Helper(sorguKitap, tabloKitap, dataGridView2);
            }

            // uye gridine veri çekme
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Helper help = new Helper(sorguUye, "uye", this.dataGridView1);
            }

            //İşlem gridine veri çekme
            {
                dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Helper help = new Helper(sorguIslem, tabloIslem, this.dataGridView3);
            }


        }




        // BUTON İŞLEVLERİ...........................
        private void kitapAraBtn_Click(object sender, EventArgs e)
        {
            if (kitapAraTxt.Text == "Kitap Adı, Yazar Adı, ISBN, Kategori Adı")
            {
                Helper kitapHelper = new Helper(sorguKitap, tabloKitap, dataGridView2);
            }
            else
            {
                Helper kitapHelper2 = new Helper("difCon", sorguKitap, tabloKitap, kitapAraTxt.Text, dataGridView2);
            }
        }
        private void uyeAraBtn_Click(object sender, EventArgs e)
        {

            if (uyeAraTxt.Text == "Ad, Soyad, E-Mail")
            {
                Helper help = new Helper(sorguUye, "uye", this.dataGridView1); // listeleme işlemi
            }
            else
            {
                Helper help = new Helper(sorguUye, "uye", uyeAraTxt.Text, this.dataGridView1); //arama işlemi
            }
        }
        private void islemAraBtn_Click(object sender, EventArgs e)
        {
            if (islemAraTxt.Text == "İşlem ID, Uye Adı, Kitap Adı, ISBN")
            {
                Helper islemHelper = new Helper(sorguIslem, tabloIslem, dataGridView3);
            }
            else
            {
                Helper islemhelper2 = new Helper(1, sorguIslem, tabloIslem, islemAraTxt.Text, dataGridView3);
            }
        }
        private void verTemizleBtn_Click(object sender, EventArgs e)
        {
            kitapIDTxt.Clear();
            uyeIDTxt.Clear();
            durumTxt.BackColor = Color.White;
            uyariLbl.Visible = false;
        }
        private void verBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (durum == "1" && kitapIDTxt.Text != "" && uyeIDTxt.Text != "")
                {
                    Islem islem = new Islem();
                    islem.adminID = int.Parse(yetkiliIDTxt.Text);
                    islem.kitapID = int.Parse(kitapIDTxt.Text);
                    islem.uyeID = int.Parse(uyeIDTxt.Text);
                    islem.islemTarihi = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                    islem.iadeTarihi = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
                    islem.emanetDurumu = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");

                    SqlConnector sql = new SqlConnector();
                    bool olusturdumu = sql.islemOlustur(islem);
                    if (olusturdumu)
                    {
                        uyariLbl.Visible = false;
                        kitapIDTxt.Clear();
                        Helper help = new Helper(sorguIslem, tabloIslem, this.dataGridView3);
                        Helper kitapHelper = new Helper(sorguKitap, tabloKitap, dataGridView2);
                    }
                    else
                    {
                        uyariLbl.Text = "Hata...";
                        uyariLbl.Visible = true;
                    }


                }
                else if (durum == "0")
                {
                    uyariLbl.Text = "Bu kişi cezalıdır.";
                    uyariLbl.Visible = true;
                }
                else
                {
                    uyariLbl.Text = "Boş bırakmayınız.";
                    uyariLbl.Visible = true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kitap işlem görüyor. Bilgileri kontrol edin.");
            }
        }
        private void alBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (islemID != 0)
                {
                    Islem islem = new Islem();
                    islem.islemID = islemID;
                    SqlConnector sql = new SqlConnector();
                    bool silindimi = sql.islemSil(islem);

                    if (silindimi)
                    {
                        MessageBox.Show("Kitap Teslim Alındı...");
                        Helper help = new Helper(sorguIslem, tabloIslem, this.dataGridView3);
                        Helper kitapHelper = new Helper(sorguKitap, tabloKitap, dataGridView2);
                        islemID = 0;
                    }
                    else
                    {
                        MessageBox.Show("Hata");
                    }

                }
                else
                {
                    MessageBox.Show("kitap seç");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Veritabanı hatası. Bilgileri kontrol edin.");
            }
        }





        //DATAGRİDLERDEN VERİ ÇEKME

        string durum;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //uyenin
        {
            try
            {
                uyeIDTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                durum = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                if (durum == "0") durumTxt.BackColor = Color.Red;
                else durumTxt.BackColor = Color.Green;

            }
            catch (Exception)
            {
                //nothing
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e) // kitabın
        {
            try
            {
                kitapIDTxt.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                //nothing
            }
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e) // datagride islem id çekme
        {
            islemID = int.Parse(dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString());
        }








        //TEXTBOX TASARIM İÇİN ........................

        private void uyeAraTxt_Enter(object sender, EventArgs e)
        {
            if (uyeAraTxt.Text == "Ad, Soyad, E-Mail")
            {
                uyeAraTxt.Text = "";
                uyeAraTxt.ForeColor = Color.Black;
            }
        }
        private void uyeAraTxt_Leave(object sender, EventArgs e)
        {
            if (uyeAraTxt.Text == "")
            {
                uyeAraTxt.Text = "Ad, Soyad, E-Mail";
                uyeAraTxt.ForeColor = Color.FromArgb(173, 173, 173);
            }
        }
        private void kitapAraTxt_Enter(object sender, EventArgs e)
        {
            if (kitapAraTxt.Text == "Kitap Adı, Yazar Adı, ISBN, Kategori Adı")
            {
                kitapAraTxt.Text = "";
                kitapAraTxt.ForeColor = Color.Black;
            }
        }
        private void kitapAraTxt_Leave(object sender, EventArgs e)
        {
            if (kitapAraTxt.Text == "")
            {
                kitapAraTxt.Text = "Kitap Adı, Yazar Adı, ISBN, Kategori Adı";
                kitapAraTxt.ForeColor = Color.FromArgb(173, 173, 173);
            }
        }
        private void islemAraTxt_Leave(object sender, EventArgs e)
        {
            if (islemAraTxt.Text == "")
            {
                islemAraTxt.Text = "İşlem ID, Uye Adı, Kitap Adı, ISBN";
                islemAraTxt.ForeColor = Color.FromArgb(173, 173, 173);
            }
        }
        private void islemAraTxt_Enter(object sender, EventArgs e)
        {
            if (islemAraTxt.Text == "İşlem ID, Uye Adı, Kitap Adı, ISBN")
            {
                islemAraTxt.Text = "";
                islemAraTxt.ForeColor = Color.Black;
            }
        }


    }
}




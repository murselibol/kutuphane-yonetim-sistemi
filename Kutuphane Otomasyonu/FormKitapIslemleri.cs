using ClassLibrary;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kutuphane2
{
    public partial class FormKitapIslemleri : Form
    {

        string sorgu = "t1.ISBN,t1.ad as Ad,t1.yazar as Yazar, t3.kategoriAdi as Kategori, t1.baskiYili as Yıl, t1.yayinEvi as Yayın, t1.sayfaSayisi as Sayfa, t1.fotograf as Foto, t1.aciklama as Detay";
        string tablo = "kitap t1  INNER JOIN kitap_kategori t2 ON t1.kitapID = t2.kitapID INNER JOIN kategori t3 ON t2.kategoriID = t3.kategoriID";

        string isbn, ad, yazar, baskiYili, yayinEvi, sayfaSayisi, aciklama, kategori;
        byte[] fotograf;
        MemoryStream ms = new MemoryStream();



        public FormKitapIslemleri()
        {
            InitializeComponent();
        }


        private void FormKitapIslemleri_Load(object sender, EventArgs e)
        {

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Helper kitapHelper = new Helper(sorgu, tablo, dataGridView1);


        }





        //Kategori ekle formunu açar..
        private void kategoriEkleBtn_Click(object sender, EventArgs e)
        {
            FormKategoriEkle katEkle = new FormKategoriEkle();
            katEkle.ShowDialog();
        }

        //Kategorileri comboboxa çeker.
        private void kategoriCombobox_Click(object sender, EventArgs e)
        {
            kategoriCombobox.Items.Clear();
            Helper comboHelper = new Helper("kategoriAdi", "kategori", kategoriCombobox);
        }





        //picturebox a resim yüklemek..... (resimi boyutlandırır)
        private void btnResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            //opf.Filter = "Choose Image(*.jpg; .png)|.jpg; *.png";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                fotografPic.Image = Image.FromFile(opf.FileName);
                fotografPic.Image.Tag = "";
                Bitmap bmp = new Bitmap(fotografPic.Image, 85, 105);
                fotografPic.Image = bmp;
            }


        }






        //KİTAP VERİLERİNİ VERİTABANINA EKLER.
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                if (CheckIt())
                {
                    MemoryStream ms = new MemoryStream();

                    fotografPic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    Kitap kitap = new Kitap();
                    kitap.ISBN = btnISBN.Text;
                    kitap.ad = adTxt.Text;
                    kitap.yazar = yazarTxt.Text;
                    kitap.yayinEvi = yayinEviTxt.Text;
                    kitap.kategori = kategoriCombobox.Text;
                    kitap.sayfaSayisi = sayfaSayisiTxt.Text;
                    kitap.baskiYili = baskiYiliTxt.Text;
                    kitap.fotograf = ms.ToArray();
                    kitap.aciklama = aciklamaTxt.Text;
                    kitap.adminID = int.Parse(Helper.girisYapID);


                    SqlConnector sql = new SqlConnector();


                    if (sql.kitapGuncelle(kitap))
                    {
                        textTemizle();
                        Helper kitapHelper = new Helper(sorgu, tablo, dataGridView1);
                        MessageBox.Show("Güncellendi...");
                        btnISBN.ReadOnly = false;
                        btnISBN.BackColor = Color.White;
                    }

                    else if (sql.kitapOlustur(kitap))
                    {
                        textTemizle();
                        Helper kitapHelper = new Helper(sorgu, tablo, dataGridView1);
                        MessageBox.Show("Eklendi...");
                    }

                    else
                    {
                        MessageBox.Show("Hata...");
                    }

                }

                else
                {
                    MessageBox.Show("Boş bırakmayın..");
                }

                isbn = ""; ad = ""; yazar = ""; baskiYili = ""; yayinEvi = ""; sayfaSayisi = ""; aciklama = ""; kategori = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Veritabanı hatası. Bilgileri kontrol edin.");
            }
        }

        //ISBN VERİSİNE GÖRE SİLME İŞLEMİ YAPAR
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckIt())
                {
                    Kitap kitap = new Kitap();
                    kitap.ISBN = btnISBN.Text;
                    kitap.adminID = int.Parse(Helper.girisYapID);


                    SqlConnector sql = new SqlConnector();



                    if (sql.kitapSil(kitap))
                    {
                        textTemizle();
                        Helper kitapHelper = new Helper(sorgu, tablo, dataGridView1);
                        MessageBox.Show("Silindi...");
                        btnISBN.ReadOnly = false;
                        btnISBN.BackColor = Color.White;
                    }
                    else
                    {
                        MessageBox.Show("Hata...");
                    }
                }

                else
                {
                    MessageBox.Show("Boş bırakmayın..");
                }
                isbn = ""; ad = ""; yazar = ""; baskiYili = ""; yayinEvi = ""; sayfaSayisi = ""; aciklama = ""; ; kategori = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Kitap kullanıcı tarafında işlem görüyor.");
            }
        }

        //gridden çekilen verileri yerleştirme
        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            btnISBN.Text = isbn;
            adTxt.Text = ad;
            yazarTxt.Text = yazar;
            kategoriCombobox.Text = kategori;
            btnISBN.ReadOnly = true;
            btnISBN.BackColor = Color.FromArgb(171, 171, 171);
            baskiYiliTxt.Text = baskiYili;
            yayinEviTxt.Text = yayinEvi;
            sayfaSayisiTxt.Text = sayfaSayisi;
            aciklamaTxt.Text = aciklama;
            //fotografPic.Image = Image.FromStream(ms);

            if (btnISBN.Text == "")
            {
                btnISBN.ReadOnly = false;
                btnISBN.BackColor = Color.White;

            }
        }

        // Ara textboxına girileni veritabanında sorgular ve gridde listeletir.
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (kitapAraTxt.Text == "Kitap Adı, Yazar Adı, ISBN, Kategori Adı")
            {
                Helper kitapHelper = new Helper(sorgu, tablo, dataGridView1);
            }
            else
            {
                Helper kitapHelper2 = new Helper("Hiiç öyle", sorgu, tablo, kitapAraTxt.Text, dataGridView1);
            }
        }





        //grideki seçili satırın verilerini cekme
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textTemizle();
                isbn = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                ad = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                yazar = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                kategori = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                baskiYili = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                yayinEvi = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                sayfaSayisi = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                fotograf = (Byte[])dataGridView1.CurrentRow.Cells[7].Value;
                MemoryStream stream = new MemoryStream(fotograf);
                fotografPic.Image = Image.FromStream(stream);

                aciklama = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }





        //Textbox içini temizler
        public void textTemizle()
        {
            btnISBN.Text = "";
            adTxt.Text = "";
            yazarTxt.Text = "";
            sayfaSayisiTxt.Text = "";
            yayinEviTxt.Text = "";
            kategoriCombobox.Text = "";
            baskiYiliTxt.Text = "";
            aciklamaTxt.Text = "";
            fotografPic.Image = null;
        }

        //alanların dolu olup olmadığını kontol eder
        private bool CheckIt()
        {
            bool output = true;

            if (btnISBN.Text == "" || adTxt.Text == "" || yazarTxt.Text == "" || kategoriCombobox.Text == "" || baskiYiliTxt.Text == "" || yayinEviTxt.Text == "" || sayfaSayisiTxt.Text == "" || aciklamaTxt.Text == "" || fotografPic.Image == null)
            {
                output = false;
            }

            return output;
        }





        //TASARIM...............
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
        void gridStyle()
        {
            int i;
            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                if (i % 2 == 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control);
                }
            }
        }
        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            gridStyle();
        }
    }
}

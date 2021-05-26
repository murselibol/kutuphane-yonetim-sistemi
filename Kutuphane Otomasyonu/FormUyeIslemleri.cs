using ClassLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kutuphane2
{
    public partial class FormUyeIslemleri : Form
    {
        public FormUyeIslemleri()
        {
            InitializeComponent();
        }


        string sorgu = "ad as Ad, soyad as Soyad, eMail as Email, telefon as Tel, adres as Adres";




        private void FormUyeIslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Helper help = new Helper(sorgu, "uye", this.dataGridView1);
        }




        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckIt())
                {
                    Uye uye = new Uye();
                    uye.ad = adTxt.Text;
                    uye.soyad = soyadTxt.Text;
                    uye.telefon = telefonTxt.Text;
                    uye.eMail = emailTxt.Text;
                    uye.adres = adresTxt.Text;
                    uye.adminID = int.Parse(Helper.girisYapID);
                    uye.cezaTarihi = DateTime.Today.ToString("yyyy-MM-dd");

                    SqlConnector sql = new SqlConnector();



                    if (sql.uyeGuncelle(uye))
                    {
                        textTemizle();
                        Helper help = new Helper(sorgu, "uye", this.dataGridView1);
                        MessageBox.Show("Güncellendi...");
                        emailTxt.ReadOnly = false;
                        emailTxt.BackColor = Color.White;
                    }

                    else if (sql.uyeOlustur(uye))
                    {
                        textTemizle();
                        Helper help = new Helper(sorgu, "uye", this.dataGridView1);
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
                adTxt2 = ""; soyadTxt2 = ""; emailTxt2 = ""; telefonTxt2 = ""; adresTxt2 = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Karakter sayınız fazla. Kontrol edin..");
            }
        }
        private void btnDüzenle_Click(object sender, EventArgs e)
        {

            adTxt.Text = adTxt2;
            soyadTxt.Text = soyadTxt2;
            emailTxt.Text = emailTxt2;
            emailTxt.ReadOnly = true;
            emailTxt.BackColor = Color.FromArgb(171, 171, 171);
            telefonTxt.Text = telefonTxt2;
            adresTxt.Text = adresTxt2;

            if (emailTxt.Text == "")
            {
                emailTxt.ReadOnly = false;
                emailTxt.BackColor = Color.White;

            }


        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (uyeAraTxt.Text == "Ad, Soyad, E-Mail")
            {
                Helper help = new Helper(sorgu, "uye", this.dataGridView1); // listeleme işlemi
            }
            else
            {
                Helper help = new Helper(sorgu, "uye", uyeAraTxt.Text, this.dataGridView1); //arama işlemi
            }

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckIt())
                {
                    Uye uye = new Uye();
                    uye.eMail = emailTxt.Text;
                    uye.adminID = int.Parse(Helper.girisYapID);

                    SqlConnector sql = new SqlConnector();

                    if (sql.uyeSil(uye))
                    {
                        textTemizle();
                        Helper help = new Helper(sorgu, "uye", this.dataGridView1);
                        MessageBox.Show("Silindi...");
                        emailTxt.ReadOnly = false;
                        emailTxt.BackColor = Color.White;
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

                adTxt2 = ""; soyadTxt2 = ""; emailTxt2 = ""; telefonTxt2 = ""; adresTxt2 = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Bu üyenin üzerinde kitap kayıtlıdır. Silemezsiniz!");
            }
        }



        //tıklandığında verileri alanlara çeker.
        string adTxt2, soyadTxt2, emailTxt2, telefonTxt2, adresTxt2;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                adTxt2 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                soyadTxt2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                emailTxt2 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                telefonTxt2 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                adresTxt2 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }




        // TASARIM
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
                uyeAraTxt.ForeColor = Color.FromArgb(171, 171, 171);
            }
        }




        public void textTemizle()
        {
            adTxt.Text = "";
            soyadTxt.Text = "";
            telefonTxt.Text = "";
            emailTxt.Text = "";
            adresTxt.Text = "";

        }

        private bool CheckIt()
        {
            bool output = true;


            //Önemli bir kontrol şekli için aç.
            {/*
             int placeNumber =0;
             bool placeNumberValidNumber = int.Parse(placeNumberText.text, out placeNumber);

            if(placeNumberValidNumber = False) output= False;
             */
            }
            if (adTxt.Text == "" || soyadTxt.Text == "" || emailTxt.Text == "" || telefonTxt.Text == "" || adresTxt.Text == "")
            {
                output = false;
            }

            return output;
        }
    }
}

using ClassLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kutuphane2
{
    public partial class FormYetkiliIslemleri : Form
    {
        string sorgu = "ad as Ad, soyad as Soyad, eMail as Email, telefon as Tel, adres as Adres";

        public FormYetkiliIslemleri()
        {
            InitializeComponent();
        }


        // Log ve admin tablosun gridi için..
        // log gridi her adminin yaptığı işlemleri listeler.
        private void FormYetkiliIslemleri_Load(object sender, EventArgs e)
        {
            yetkiliTxt.Text = Helper.girisYapID;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Helper help = new Helper(sorgu, "admin", this.dataGridView1);
            Helper logGetir = new Helper("*", "log", this.dataGridView2);
        }





        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckIt())
                {
                    Admin admin = new Admin();
                    admin.ad = adTxt.Text;
                    admin.soyad = soyadTxt.Text;
                    admin.telefon = telefonTxt.Text;
                    admin.eMail = emailTxt.Text;
                    admin.adres = adresTxt.Text;

                    SqlConnector sql = new SqlConnector();



                    if (sql.adminGuncelle(admin))
                    {
                        textTemizle();
                        Helper help = new Helper(sorgu, "admin", this.dataGridView1);

                        MessageBox.Show("Güncellendi...");
                        emailTxt.ReadOnly = false;
                        emailTxt.BackColor = Color.White;
                    }

                    else if (sql.adminOlustur(admin))
                    {
                        textTemizle();
                        Helper help = new Helper(sorgu, "admin", this.dataGridView1);

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

                MessageBox.Show("Veritabanı hatası...");
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
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckIt())
                {
                    Admin admin = new Admin();
                    admin.eMail = emailTxt.Text;


                    SqlConnector sql = new SqlConnector();

                    if (sql.adminSil(admin))
                    {
                        textTemizle();
                        Helper help = new Helper(sorgu, "admin", this.dataGridView1);

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

                MessageBox.Show("Veritabanı hatası...");
            }
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (yetkiliAraTxt.Text == "Ad, Soyad, E-Mail")
            {
                Helper help = new Helper(sorgu, "admin", this.dataGridView1);
            }
            else
            {
                Helper help = new Helper(sorgu, "admin", yetkiliAraTxt.Text, this.dataGridView1); //arama işlemi
            }
        }




        //GRİD İŞLEMLERİ.............

        string adTxt2, soyadTxt2, emailTxt2, telefonTxt2, adresTxt2;
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

                //nothing
            }
        }
        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            gridStyle();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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

                //nothing
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



            if (adTxt.Text == "" || soyadTxt.Text == "" || emailTxt.Text == "" || telefonTxt.Text == "" || adresTxt.Text == "")
            {
                output = false;
            }

            return output;
        }


        private void yetkiliAraTxt_Enter(object sender, EventArgs e)
        {
            if (yetkiliAraTxt.Text == "Ad, Soyad, E-Mail")
            {
                yetkiliAraTxt.Text = "";
                yetkiliAraTxt.ForeColor = Color.Black;
            }
        }
        private void yetkiliAraTxt_Leave(object sender, EventArgs e)
        {
            if (yetkiliAraTxt.Text == "")
            {
                yetkiliAraTxt.Text = "Ad, Soyad, E-Mail";
                yetkiliAraTxt.ForeColor = Color.FromArgb(173, 173, 173);
            }
        }


    }
}

using ClassLibrary;
using Kutuphane2.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kutuphane2
{
    public partial class FormGirisYap : Form
    {
        public FormGirisYap()
        {
            InitializeComponent();
        }

        string secim;
        public static FormFirstScreen obj = (FormFirstScreen)Application.OpenForms["FormFirstScreen"];


        // Giriş yapan kişinin kaydının olup olmadığının kontrolü, kayıtlıysa sisteme giriş yapması değilse gerekli hata mesajlarını göstermesi...
        private void girisBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckIt())
                {
                    Login giris = new Login();
                    giris.eMail = kAdi.Text;
                    giris.sifre = sifre.Text;

                    SqlConnector sql = new SqlConnector();

                    bool girisYapildimi = sql.girisYap(giris, secim);


                    if (girisYapildimi)
                    {
                        if (secim == "admin")
                        {
                            FormAdminAnasayfa adminAnasayfa = new FormAdminAnasayfa();
                            FormAdminAnasayfa.alAdSoyad = giris.adSoyad;
                            FormAdminAnasayfa.mail = giris.eMail;
                            Helper.girisYapID = giris.girisYapID; //girisyapanın ıd sini formlarla paylaşma
                            Helper.secim = secim;

                            obj.Visible = false;
                            this.Close();
                            adminAnasayfa.Show();
                        }
                        else if (secim == "uye")
                        {
                            FormUyeAnasayfa uyeAnasayfa = new FormUyeAnasayfa();
                            FormUyeAnasayfa.alAdSoyad = giris.adSoyad;
                            Helper.girisYapID = giris.girisYapID; //girisyapanın ıd sini formlarla paylaşma
                            Helper.secim = secim;
                            FormUyeAnasayfa.mail = giris.eMail;
                            FormFirstKitapScreen.girisKapat = false;

                            obj.Visible = false;
                            this.Close();
                            uyeAnasayfa.Show();

                        }

                        // GİRİŞ YAPTIĞINDA BİR ÖNCEDEN AÇIK OLAN FORMU ( FİRSTSCREEN ) kapatmak


                    }
                    else
                    {
                        errMessage.Visible = true;
                    }
                }
                else
                {
                    errMessage.Visible = true;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Veritabanı hatası. Bilgileri kontrol edin.");
            }

        }



        //ilk başladığımız yer... Textbox içlerini kontrol eder.
        private bool CheckIt()
        {
            bool output = true;

            if (kAdi.Text == "E-Mail")
            {
                output = false;
            }
            if (sifre.Text == "Şifre")
            {
                output = false;

            }
            if (radioAdmin.Checked)
            {
                secim = "admin";
            }

            else if (radioKullanici.Checked)
            {
                secim = "uye";
            }
            else
            {
                output = false;
            }
            return output;
        }


        // Form Çıkış Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // TASARIM İÇİN................
        private void kAdi_Enter(object sender, EventArgs e)
        {
            if (kAdi.Text == "E-Mail")
            {
                kAdi.Text = "";
                kAdi.ForeColor = Color.Black;
            }
        }
        private void kAdi_Leave(object sender, EventArgs e)
        {
            if (kAdi.Text == "")
            {
                kAdi.Text = "E-Mail";
                kAdi.ForeColor = Color.FromArgb(173, 173, 173);
            }
        }
        private void sifre_Enter(object sender, EventArgs e)
        {
            if (sifre.Text == "Şifre")
            {
                sifre.Text = "";
                sifre.ForeColor = Color.Black;
            }
        }
        private void sifre_Leave(object sender, EventArgs e)
        {
            if (sifre.Text == "")
            {
                sifre.Text = "Şifre";
                sifre.ForeColor = Color.FromArgb(173, 173, 173);
            }
        }

    }
}

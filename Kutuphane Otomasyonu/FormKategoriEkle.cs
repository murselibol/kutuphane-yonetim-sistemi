using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Kutuphane2
{
    public partial class FormKategoriEkle : Form
    {

        public static string baglanti_adresi = Helper.baglanti_adresi;


        string temp = "";

        public FormKategoriEkle()
        {
            InitializeComponent();
        }



        private void FormKategoriEkle_Load(object sender, EventArgs e)
        {
            Helper comboHelper = new Helper("kategoriAdi", "kategori", araCombobox);
        }




        // Comboboxtan textboxa çekilen veriyi temp değişkeninde tutarak update işlemi yapar.
        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (KateEkleTxt.Text != "" && temp != "")
                {
                    using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
                    {

                        MySqlCommand cmd = new MySqlCommand($"Update kategori set kategoriAdi = '{KateEkleTxt.Text}' where kategoriAdi = '{temp}' ", connection);

                        connection.Open();
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            label3.Text = "güncellendi..";
                            textTemizle();
                            Helper comboHelper = new Helper("kategoriAdi", "kategori", araCombobox);
                        }
                        else
                        {
                            label3.Text = "güncelleme hata...";
                            label3.Visible = true;
                        }
                        connection.Close();
                    }

                }
                else if (temp == "" && KateEkleTxt.Text != "")
                {
                    using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
                    {

                        MySqlCommand cmd = new MySqlCommand($"INSERT INTO kategori(kategoriAdi) VALUES ('{KateEkleTxt.Text}')", connection);

                        connection.Open();
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            label3.Text = "Eklendi..";
                            textTemizle();
                            Helper comboHelper = new Helper("kategoriAdi", "kategori", araCombobox);
                        }
                        else
                        {
                            label3.Text = "Ekleme Hata...";
                            label3.Visible = true;
                        }
                        connection.Close();
                    }
                }
                else
                {
                    label3.Text = "Boş Olamaz...";
                    label3.Visible = true;
                }
            }
            catch (Exception)
            {

                label3.Text = "Kategori Mevcut";
                label3.Visible = true;
            }
        }



        // Comboboxtan textboxa çekilen veriyi temp değişkeninde tutarak delete işlemi yapar.
        private void silBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (KateEkleTxt.Text != "" && temp != "")
                {
                    using (MySqlConnection connection = new MySqlConnection(baglanti_adresi))
                    {

                        MySqlCommand cmd = new MySqlCommand($"DELETE FROM kategori WHERE kategoriAdi='{temp}' ", connection);

                        connection.Open();
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            label3.Text = "Silindi..";
                            textTemizle();
                            Helper comboHelper = new Helper("kategoriAdi", "kategori", araCombobox);
                        }
                        else
                        {
                            label3.Text = "Silinme hata...";
                            label3.Visible = true;
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bu kategoriye ait kitap mevcut! Silemezsiniz!");
            }
        }



        //comboboxtaki verinin textboxa aktarılması işlemi yapar.
        private void duzenleBtn_Click(object sender, EventArgs e)
        {
            if (araCombobox.Text != "")
            {
                KateEkleTxt.Text = araCombobox.SelectedItem.ToString();
                temp = KateEkleTxt.Text;

                label3.Visible = false;
            }

            else
            {
                label3.Visible = true;
                label3.Text = "Bir Değer Seçiniz...";
            }

        }




        public void textTemizle()
        {
            label3.Visible = true;
            KateEkleTxt.Clear();
            temp = "";
            araCombobox.Items.Clear();
            araCombobox.Text = "";
        }




        //Formdan çıkış yapar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

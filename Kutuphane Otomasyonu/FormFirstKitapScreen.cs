using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kutuphane2
{
    public partial class FormFirstKitapScreen : Form
    {
        public FormFirstKitapScreen()
        {
            InitializeComponent();
        }
        string sorgu = "t1.ISBN,t1.ad as Ad,t1.yazar as Yazar, t3.kategoriAdi as Kategori, t1.baskiYili as Yıl, t1.yayinEvi as Yayın, t1.sayfaSayisi as Sayfa, t1.fotograf as Foto, t1.aciklama as Detay, IFNULL(t4.emanetDurumu,'Rafta') as Durum";
        string tablo = "kitap t1  INNER JOIN kitap_kategori t2 ON t1.kitapID = t2.kitapID INNER JOIN kategori t3 ON t2.kategoriID = t3.kategoriID LEFT JOIN islem t4 ON t1.kitapID = t4.kitapID";
        static public bool girisKapat = true;


        private void FormFirstKitapScreen_Load(object sender, EventArgs e)
        {

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            girisGitBtn.Visible = girisKapat;
        }


        private void araBtn_Click(object sender, EventArgs e)
        {
            if (araTxt.Text == "Kitap Adı, Yazar Adı, ISBN")
            {
                Helper kitapHelper = new Helper(sorgu, tablo, dataGridView1);
                dataGridView1.Visible = true;
                icerikPanel.Visible = false;
            }
            else
            {
                Helper kitapHelper2 = new Helper("Hiiç öyle", sorgu, tablo, araTxt.Text, dataGridView1);
                dataGridView1.Visible = true;
                icerikPanel.Visible = false;
            }
        }
        private void kategoriBox_Click_1(object sender, EventArgs e)
        {
            kategoriBox.Items.Clear();
            Helper comboHelper = new Helper("kategoriAdi", "kategori", kategoriBox);
        }
        private void kategoriBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            Helper kitapHelper2 = new Helper("Hiiç öyle", sorgu, tablo, kategoriBox.Text, dataGridView1);
            dataGridView1.Visible = true;
            icerikPanel.Visible = false;
        }


        // LOGİN OLDUĞUMUZ FORMU AÇAR
        private void girisGitBtn_Click(object sender, EventArgs e)
        {
            FormGirisYap girisGit = new FormGirisYap();
            girisGit.ShowDialog();  // Bİ ÖNCEKİ FORMU KİTLEMEK İÇİN SHOW DİALOG KULLANDIK.
        }





        //TEXTBOX TASARIM
        private void araTxt_Enter(object sender, EventArgs e)
        {
            if (araTxt.Text == "Kitap Adı, Yazar Adı, ISBN")
            {
                araTxt.Text = "";
                araTxt.ForeColor = Color.Black;
            }
        }
        private void araTxt_Leave(object sender, EventArgs e)
        {
            if (araTxt.Text == "")
            {
                araTxt.Text = "Kitap Adı, Yazar Adı, ISBN";
                araTxt.ForeColor = Color.FromArgb(173, 173, 173);
            }
        }





        // GRİD TASARIM
        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            gridStyle();
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


    }
}

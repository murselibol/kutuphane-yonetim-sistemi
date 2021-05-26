using ClassLibrary;
using System;
using System.Windows.Forms;

namespace Kutuphane2
{
    public partial class FormUyeUzerimdekiler : Form
    {


        public string sorguIslem = "t1.islemID as ID, t2.ad as Kitap, t2.yazar as Yazar, t2.fotograf as Fotoğraf, t1.iadeTarihi as İadeTarihi";
        public string tabloIslem = $"islem t1 INNER JOIN kitap t2 ON t1.kitapID = t2.kitapID INNER JOIN uye t3 ON t1.uyeID = t3.uyeID where t1.uyeID = {Helper.girisYapID} ";
        int islemID;
        DateTime iadeTarihi, bugun;
        TimeSpan sonuc;
        int day;


        public FormUyeUzerimdekiler()
        {
            InitializeComponent();
        }


        //UYENİN ÜZERİNDE BULUNAN KİTAPLARI LİSTELER..
        private void FormUyeUzerimdekiler_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Helper help = new Helper(sorguIslem, tabloIslem, this.dataGridView1);
        }




        //ÜYENİN ALDIĞI KİTABIN İADE TARİHİE 1 GÜN KALA 15 GÜN UZATMA HAKKI TANIR.. 
        private void uzatBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (day == 1)
                {

                    Islem uzat = new Islem();
                    uzat.islemID = islemID;
                    uzat.iadeTarihi = (iadeTarihi.AddDays(15)).ToString("yyyy-MM-dd");
                    uzat.emanetDurumu = (iadeTarihi.AddDays(15)).ToString("yyyy-MM-dd");
                    SqlConnector sql = new SqlConnector();

                    bool uzattiMi = sql.kitapUzat(uzat);

                    if (uzattiMi)
                    {
                        Helper help = new Helper(sorguIslem, tabloIslem, this.dataGridView1);
                        label4.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Hata..");
                    }

                }
                else
                {
                    MessageBox.Show("Kitabı uzatma işlemi iade tarihinden 1 gün önce yapılır...");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Vertabanı hatası...");
            }
        }




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                islemID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                iadeTarihi = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                bugun = DateTime.Today;
                sonuc = iadeTarihi - bugun;
                day = sonuc.Days;
                label4.Text = day.ToString();

            }
            catch (Exception)
            {

                //nothing
            }
        }
    }
}

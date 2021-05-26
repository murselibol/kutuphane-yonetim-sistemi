using System;
using System.Windows.Forms;

namespace Kutuphane2
{
    public partial class FormUyeIadeEt : Form
    {

        string sorgu = "t1.ad, t1.yazar, t1.fotograf, t2.iadeTarihi";
        string tablo = $"kitap t1 INNER JOIN log t2 ON t1.kitapID = t2.kitapID WHERE t2.uyeID = {Helper.girisYapID} AND t2.aciklama = 'Kitap alındı..'";


        public FormUyeIadeEt()
        {
            InitializeComponent();
        }


        //GİRİŞ YAPAN ÜYENİN İADE ETTİĞİ KİTAPLARI LİSTELER
        private void FormUyeIadeEt_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Helper help = new Helper(sorgu, tablo, this.dataGridView1);
        }
    }
}

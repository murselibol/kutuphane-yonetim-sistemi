namespace ClassLibrary
{
    public class Kitap
    {
        public int kitapID { get; set; }
        public string ISBN { get; set; }
        public string ad { get; set; }
        public string yazar { get; set; }
        public string baskiYili { get; set; }
        public string yayinEvi { get; set; }
        public string sayfaSayisi { get; set; }
        public byte[] fotograf { get; set; }
        public string aciklama { get; set; }
        public string kategori { get; set; }
        public bool kitapDurumu { get; set; }
        public int islemSayisi { get; set; } //(En çok okunanları tutabilmek için) Buraya veri girişi olmayacak işlem gördükçe artacak.
        public int adminID { get; set; }
    }
}

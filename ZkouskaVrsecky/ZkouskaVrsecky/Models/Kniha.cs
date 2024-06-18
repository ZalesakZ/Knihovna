namespace ZkouskaVrsecky.Models
{
    public class Kniha
    {
        public string Nazev { get; set; }
        public string Autor { get; set; }
        public string RokVydani { get; set; }
        public string Zanr { get; set; }
        public string Isbn { get; set; }

        private int pocetKusu;
        public int PocetKusu
        {
            get => pocetKusu;
            set => pocetKusu = value >= 0 ? value : 0;
        }

        public Umisteni Umisteni { get; set; }
        public ZaznamPujcek ZaznamPujcek { get; set; }

        public Kniha() { }

        public Kniha(string nazev, string autor, string rokVydani, string zanr, string isbn, int pocetKusu)
        {
            Nazev = nazev;
            Autor = autor;
            RokVydani = rokVydani;
            Zanr = zanr;
            Isbn = isbn;
            PocetKusu = pocetKusu >= 0 ? pocetKusu : 0;
            Umisteni = new Umisteni();
            ZaznamPujcek = new ZaznamPujcek();
        }
    }
}

namespace ZkouskaVrsecky.Models
{
    public class Umisteni
    {
        public string Police { get; set; }
        public string Patro { get; set; }
        public string Cislo { get; set; }

        public Umisteni() { }

        public Umisteni(string police, string patro, string cislo)
        {
            Police = police;
            Patro = patro;
            Cislo = cislo;
        }
    }
}

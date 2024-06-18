namespace ZkouskaVrsecky.Models
{
    public class ZaznamPujcek
    {
        public string JmenoPujcil {  get; set; }
        public DateTime DatumPujcky { get; set; }
        public DateTime DatumMaxVraceni { get; private set; }
        public string NazevK {  get; set; }

        public ZaznamPujcek() { }

        public ZaznamPujcek(string jmenoPujcil, string nazevK, DateTime datumPujcky) {
            JmenoPujcil = jmenoPujcil;
            NazevK = nazevK;
            DatumPujcky = datumPujcky;
            DatumMaxVraceni = datumPujcky.AddDays(31);
        }
    }
}

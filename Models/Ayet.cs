namespace GununAyeti.Models
{
    public class Ayet
    {
        public int Id { get; set; }
        public String? ArapcaMetin { get; set; }=String.Empty;
        public String? Aciklama { get; set;}=String.Empty;
        public String? SureIsmi { get; set;}=String.Empty;
        public int AyetNo { get; set; }
    }
}
namespace CineUb.API.Core.Model
{
    public class CineSection :BaseClass
    {
        public DateTime Time { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
    }
}

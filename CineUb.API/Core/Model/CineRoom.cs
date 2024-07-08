namespace CineUb.API.Core.Model
{
    public class CineRoom : BaseClass
    {
        public int NumberOfSeats { get; set; }
        public List<CineSection> Sections { get; set; } = [];
    }
}

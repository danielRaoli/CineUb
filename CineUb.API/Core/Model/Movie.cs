namespace CineUb.API.Core.Model
{
    public class Movie : BaseClass
    {
        public string Name { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public int Duration { get; set; }
        public string Banner { get; set; } = string.Empty;
        public List<CineSection> CineSections { get; set; } = [];
        

    }
}

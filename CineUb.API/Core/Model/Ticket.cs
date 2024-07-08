namespace CineUb.API.Core.Model
{
    public class Ticket : BaseClass
    {
        public int UserId { get; set; }
        public CineSection Section { get; set; }
        public decimal Price { get; set; }
    }
}

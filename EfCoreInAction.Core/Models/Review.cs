namespace EfCoreInAction.Core.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string VoterName { get; set; }
        public byte NumStars { get; set; }
        public string Comment { get; set; }

        public int BookId { get; set; }
    }
}
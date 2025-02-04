namespace Reatil_Backend.Model
{
    public class Power
    {
        public int Id { get; set; }
        public string Rating { get; set; }
    
        public ICollection<Product> Products { get; set; }
    }
}

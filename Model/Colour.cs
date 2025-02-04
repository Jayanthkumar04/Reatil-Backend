namespace Reatil_Backend.Model
{
    public class Colour
    {
        public int Id { get; set; }
        public string Shade { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}

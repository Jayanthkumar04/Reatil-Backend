using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reatil_Backend.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Brand { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }

        [ForeignKey("Colour")]
        public int ColourId { get; set; }

        public Colour Colour { get; set; }

        [ForeignKey("Power")]
        public int PowerId { get; set; }

        public Power Power { get; set; }
       
    }
}

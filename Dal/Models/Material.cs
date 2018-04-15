using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Dal
{
    public abstract  class Material
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(20)]
        public string Brand { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public double Volume { get; set; }
        [Required]
        public int QuantityBottles { get; set; }
        [Required]
        public double QuantityGeneralVolume { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        public string Color { get; set; }
        public virtual ICollection<Service> Service { get; set; }

    }

    public class Shampoo : Material { }
    public class Balsam : Material { }
    public class HairColor : Material { }
    public class Laque : Material { }
    public class Lipstick : Material { }
    public class Mascara : Material { }
    public class Foundation : Material { }
    public class Powder : Material { }
    public class Shadows : Material { }
    public class NailPolish : Material { }
    public class NailTop : Material { }
    public class NailBase : Material { }

}
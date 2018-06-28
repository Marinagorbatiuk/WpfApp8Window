using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class Material
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public double Volume { get; set; }
        [Required]
        public int QuantityBottles { get; set; }
        [Required]
        public double QuantityGeneralVolume { get; set; }

        public virtual ICollection<Services> Service { get; set; }
        [Required]
        public double QuntityCount { get; set; }
    }


    public class Shampoo : Material
    {
        public string Description { get; set; }
    }
    public class Balsam : Material { }
    public class HairColor : Material
    {
        public string Description { get; set; }
        [Required]
        public string Color { get; set; }
    }
    public class Laque : Material { }
    public class Lipstick : Material
    {
        public string Description { get; set; }
        [Required]
        public string Color { get; set; }
    }
    public class Mascara : Material
    {
        public string Color { get; set; }
    }
    public class Foundation : Material
    {
        public string Description { get; set; }
        [Required]
        public string Color { get; set; }
    }
    public class Powder : Material
    {
        [Required]
        public string Color { get; set; }
    }
    public class Shadows : Material
    {
        [Required]
        public string Color { get; set; }
    }
    public class NailPolish : Material
    {
        public string Color { get; set; }
    }
    public class NailTop : Material { }
    public class NailBase : Material { }

}

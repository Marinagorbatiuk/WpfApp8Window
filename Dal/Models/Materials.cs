using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class Materials
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
        // public string Description { get; set; }
        // public string Color { get; set; }
        public virtual ICollection<Services> Service { get; set; }
        [Required]
        public double QuntityCount { get; set; }
    }


    public class Shampoo : Materials
    {
        public string Description { get; set; }
    }
    public class Balsam : Materials { }
    public class HairColor : Materials
    {
        public string Description { get; set; }
        [Required]
        public string Color { get; set; }
    }
    public class Laque : Materials { }
    public class Lipstick : Materials
    {
        public string Description { get; set; }
        [Required]
        public string Color { get; set; }
    }
    public class Mascara : Materials
    {
        public string Color { get; set; }
    }
    public class Foundation : Materials
    {
        public string Description { get; set; }
        [Required]
        public string Color { get; set; }
    }
    public class Powder : Materials
    {
        [Required]
        public string Color { get; set; }
    }
    public class Shadows : Materials
    {
        [Required]
        public string Color { get; set; }
    }
    public class NailPolish : Materials
    {
        public string Color { get; set; }
    }
    public class NailTop : Materials { }
    public class NailBase : Materials { }

}

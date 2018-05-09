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
        public string Description { get; set; }
        public string Color { get; set; }
        public virtual ICollection<Services> Service { get; set; }
    }
        public class Shampoo : Materials { }
        public class Balsam : Materials { }
        public class HairColor : Materials { }
        public class Laque : Materials { }
        public class Lipstick : Materials { }
        public class Mascara : Materials { }
        public class Foundation : Materials { }
        public class Powder : Materials { }
        public class Shadows : Materials { }
        public class NailPolish : Materials { }
        public class NailTop : Materials { }
        public class NailBase : Materials { }
    
}

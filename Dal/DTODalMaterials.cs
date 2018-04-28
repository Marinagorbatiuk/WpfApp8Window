using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
   public class DTODalMaterials
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
        //public virtual ICollection<Service> Service { get; set; }

        
    }
    public class DTOShampoo: DTODalMaterials
    {

    }

    public class DalConvertation
    {
        public static DTOShampoo ConvertShampooFromEntityToDTO(Shampoo shampoo)
        {
            DTOShampoo dTOShampoo = new DTOShampoo() {
                Id= shampoo.Id,
                Name= shampoo.Name,
                Brand= shampoo.Brand,
                Price= shampoo.Price,
                Volume= shampoo.Volume,
                QuantityBottles= shampoo.QuantityBottles,
                QuantityGeneralVolume= shampoo.QuantityGeneralVolume,
                Description= shampoo.Description,
                Color= shampoo.Color
            };
            return dTOShampoo;
        }
    }
}

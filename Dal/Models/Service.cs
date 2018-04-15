using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Dal
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public virtual ICollection<Material> Materials { get; set; }

    }
}
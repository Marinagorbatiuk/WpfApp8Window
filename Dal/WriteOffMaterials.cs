using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class WriteOffMaterials
    {
        public int Id { get; set; }
        [Required]
        public int UsedQuantity { get; set; }
        public virtual Materials Material { get; set; }
    }
}

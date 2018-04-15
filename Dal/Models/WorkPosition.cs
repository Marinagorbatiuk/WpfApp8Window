using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Dal
{
    public class WorkPosition
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }
    }
}
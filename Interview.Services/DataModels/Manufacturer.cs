using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Interview.Services.DataModels
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            Ranges = new HashSet<Range>();
        }

        [Key]
        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public virtual ICollection<Range> Ranges { get; set; }
    }
}
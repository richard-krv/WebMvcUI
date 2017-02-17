using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Interview.Services.DataModels
{
    public class Range
    {
        [Key]
        public int RangeId { get; set; }
        public string RangeName { get; set; }
        public string ImageFile { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }

        [ForeignKey("Manufacturer")]
        public int ManufacturerId { get; set; }
    }
}
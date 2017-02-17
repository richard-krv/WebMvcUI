using System.Collections.Generic;

namespace Interview.Services.Models
{
    public class ManufacturerModelRange
    {
        public string Name { get; set; }

        public IEnumerable<ModelRangeItem> ModelRangeItems { get; set; }
    }
}
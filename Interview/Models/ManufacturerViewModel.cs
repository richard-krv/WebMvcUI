using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interview.Models
{
    public class ManufacturerViewModel
    {
        public string Name { get; set; }
        public IEnumerable<RangeItemViewModel> RangeItems { get; set; }
    }
}
using Interview.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Services.Contracts
{
    public interface IModelRangeService
    {
        ManufacturerModelRange GetManufacturerModelRange(string manufacturerName);
    }
}

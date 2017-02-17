using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Services.Mapping
{
    public static class MappingConfig
    {
        public static void TriggerAutomapperConfig()
        {
            AutoMapper.Mapper.Initialize(config => config.AddProfile<ManufacturerRangeMappingProfile>());
        }

        public static TResult Map<TResult>(object source)
        {
            TriggerAutomapperConfig();
            return AutoMapper.Mapper.Map<TResult>(source);
        }
    }
}

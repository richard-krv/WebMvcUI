using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interview.ModelMapping
{
    public class ManufacturerRangeServiceToViewMappingProfile: Profile
    {
        public override string ProfileName
        {
            get { return typeof(ManufacturerRangeServiceToViewMappingProfile).Name; }
        }

        public ManufacturerRangeServiceToViewMappingProfile()
        {
            AllowNullCollections = true;
            AllowNullDestinationValues = true;

            CreateMap<Services.Models.ModelRangeItem, Models.RangeItemViewModel>()
                .ForMember(m => m.ImageFileName, opt => opt.MapFrom(s => s.ImageFileName));

            CreateMap<Services.Models.ManufacturerModelRange, Models.ManufacturerViewModel>()
                .ForMember(m => m.RangeItems, opt => opt.MapFrom(s => s.ModelRangeItems.ToList()));

        }
    }
}
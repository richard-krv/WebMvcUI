using AutoMapper;
using Interview.Models;
using Interview.Services.Models;
using System.Linq;

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

            CreateMap<ModelRangeItem, RangeItemViewModel>()
                //.ForMember(m => m.ImageFileName, opt => opt.MapFrom(s => s.ImageFileName))
                .ReverseMap();

            CreateMap<ManufacturerModelRange, ManufacturerViewModel>()
                .ForMember(m => m.RangeItems, opt => opt.MapFrom(s => s.ModelRangeItems.ToList()))
                .ReverseMap();

        }
    }
}
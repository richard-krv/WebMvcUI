using AutoMapper;

namespace Interview.Services.Mapping
{
    public class ManufacturerRangeMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return typeof(ManufacturerRangeMappingProfile).Name; }
        }

        public ManufacturerRangeMappingProfile()
        {
            AllowNullCollections = true;
            AllowNullDestinationValues = true;

            CreateMap<DataModels.Range, Models.ModelRangeItem>()
                .ForMember(m => m.Name, opt => opt.MapFrom(s => s.RangeName))
                //.ForMember(m => m.RangeId, opt => opt.MapFrom(s => s.RangeId))
                .ForMember(m => m.ImageFileName, opt => opt.MapFrom(s => s.ImageFile));

            CreateMap<DataModels.Manufacturer, Models.ManufacturerModelRange>()
                .ForMember(m => m.Name, opt => opt.MapFrom(s => s.ManufacturerName))
                .ForMember(m => m.ModelRangeItems, opt => opt.MapFrom(s => s.Ranges));
        }
    }
}

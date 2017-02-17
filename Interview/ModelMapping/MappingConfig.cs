namespace Interview.ModelMapping
{
    public static class MappingConfig
    {
        public static void TriggerAutomapperConfig()
        {
            AutoMapper.Mapper.Initialize(config => config.AddProfile<ManufacturerRangeServiceToViewMappingProfile>());
        }

        public static TResult Map<TResult>(object source)
        {
            TriggerAutomapperConfig();
            return AutoMapper.Mapper.Map<TResult>(source);
        }
    }
}

using AutoMapper;
using EveningSchool.ViewModels.Mappings;

namespace EveningSchool
{
    public class AutoMapperConfig
    {
        public static void RegisterMappers()
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile<UserMappingProfile>();
            });

            mapperConfig.AssertConfigurationIsValid();
        }
    }
}

using AutoMapper;
using System.Web;
using System.Web.Optimization;

namespace Quality.WebApp
{
    public class AutoMapperConfig
    {
        public static void Init()
        {
            //var configuration = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<DataAccess.Anomaly, Domain.Anomaly>();
            //});
            //// only during development, validate your mappings; remove it before release
            //configuration.AssertConfigurationIsValid();
            //// use DI (http://docs.automapper.org/en/latest/Dependency-injection.html) or create the mapper yourself
            //var mapper = configuration.CreateMapper();
        }
    }
}

using AutoMapper;
using System.Web;
using System.Web.Optimization;

namespace Quality.WebApp
{
    public class AutoMapperConfig
    {
        public static void Init()
        {

            //Mapper.Reset();
            //Mapper.Initialize(cfg =>
            //{
            //    cfg.AddProfile<DomainToViewModelMappingProfile>();
            //    cfg.AddProfile<ViewModelToDomainMappingProfile>();

            //});
            //Mapper.AssertConfigurationIsValid();


            Mapper.Initialize(cfg =>
            {
                InitDataToDomain(cfg);
                InitDomainToData(cfg);
                InitViewModelToDomain(cfg);
            });



            //var configuration = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<DataAccess.Anomaly, Domain.Anomaly>().ForMember(d => d.Id, opt => opt.MapFrom(src => src.AnomalyId));
            //    cfg.CreateMap<DataAccess.ref_Machine, Domain.Machine>().ForMember(d => d.MachineId, opt => opt.MapFrom(src => src.ref_MachineId));
            //});
            //// only during development, validate your mappings; remove it before release
            //configuration.AssertConfigurationIsValid();
            //// use DI (http://docs.automapper.org/en/latest/Dependency-injection.html) or create the mapper yourself
            //var mapper = configuration.CreateMapper();
        }
        private static void InitViewModelToDomain(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TicketNCViewModel, Domain.TicketNC>()
                .ForMember(d=>d.ref_CQId, opt=>opt.MapFrom(src=>src.CQId))
                .ForMember(d => d.ref_MachineId, opt => opt.MapFrom(src => src.MachineId))
                .ForMember(d => d.ref_PieceTypeId, opt => opt.MapFrom(src => src.PieceTypeId))
                .ForMember(d => d.ref_ProductCodeId, opt => opt.MapFrom(src => src.ProductCodeId))
                .ForMember(d => d.ref_ProductTypeId, opt => opt.MapFrom(src => src.ProductTypeId))
                .ForMember(d => d.ref_UnitId, opt => opt.MapFrom(src => src.UnitId))
                .ForMember(d => d.ref_ProductionAreaId, opt => opt.MapFrom(src => src.ProductionAreaId));
        }

        private static void InitDomainToData(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Domain.TicketNC, DataAccess.TicketNC>();
        }

        private static void InitDataToDomain(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<DataAccess.Anomaly, Domain.Anomaly>().ForMember(d => d.Id, opt => opt.MapFrom(src => src.AnomalyId));
            cfg.CreateMap<DataAccess.ref_Machine, Domain.Machine>().ForMember(d => d.MachineId, opt => opt.MapFrom(src => src.ref_MachineId));
            cfg.CreateMap<DataAccess.ref_ProductType, Domain.ProductType>().ForMember(d => d.ProductTypeId, opt => opt.MapFrom(src => src.ref_ProductTypeId));
            cfg.CreateMap<DataAccess.ref_ProductCode, Domain.ProductCode>().ForMember(d => d.ProductCodeId, opt => opt.MapFrom(src => src.ref_ProductCodeId));
            cfg.CreateMap<DataAccess.ref_CQ, Domain.CQ>().ForMember(d => d.CQId, opt => opt.MapFrom(src => src.ref_CQId));
            cfg.CreateMap<DataAccess.ref_PieceType, Domain.PieceType>().ForMember(d => d.PieceTypeId, opt => opt.MapFrom(src => src.ref_PieceTypeId));
            cfg.CreateMap<DataAccess.ref_Unit, Domain.Unit>().ForMember(d => d.UnitId, opt => opt.MapFrom(src => src.ref_UnitId));
            cfg.CreateMap<DataAccess.ref_ProductionArea, Domain.ProductionArea>().ForMember(d => d.ProductionAreaId, opt => opt.MapFrom(src => src.ref_ProductionAreaId));
        }
    }
}

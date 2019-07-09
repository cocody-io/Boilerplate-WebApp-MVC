using System.Collections.Generic;
using Quality.DataAccess.Repositories;
using Quality.DataAccess;
using Dto = Quality.DataAccess;
using System.Linq;
using System.Collections;
using Domain=Quality.Domain;
using System;
using AutoMapper;

namespace Quality.Service
{
    public class RefTablesService : IRefTablesService
    {
        /// <summary>
        /// GetAllMachine
        /// </summary>
        /// <returns>IEnumerable<Domain.Machine> </returns>
        public IEnumerable<Domain.Machine> GetAllMachine()
        {
            using (var unitOfWork = new UnitOfWork(new QualityContext()))
            {
                IEnumerable<DataAccess.ref_Machine> machines = unitOfWork.MachineRepository.GetAll();
                return Mapper.Map<IEnumerable<DataAccess.ref_Machine>, IEnumerable<Domain.Machine>>(machines);
            }
        }

        /// <summary>
        /// GetAllProductType
        /// </summary>
        /// <returns>IEnumerable<ProductType> </returns>
        public IEnumerable<Domain.ProductType> GetAllProductType()
        {
            using (var unitOfWork = new UnitOfWork(new QualityContext()))
            {
                IEnumerable<DataAccess.ref_ProductType> productTypes = unitOfWork.ProductTypeRepository.GetAll();
                return Mapper.Map<IEnumerable<DataAccess.ref_ProductType>, IEnumerable<Domain.ProductType>>(productTypes);
            }
        }

        /// <summary>
        /// GetAllProductCode
        /// </summary>
        /// <returns>IEnumerable<ProductCode> </returns>
        public IEnumerable<Domain.ProductCode> GetAllProductCode()
        {
            using (var unitOfWork = new UnitOfWork(new QualityContext()))
            {
                IEnumerable<DataAccess.ref_ProductCode> productCodes = unitOfWork.ProductCodeRepository.GetAll();
                return Mapper.Map<IEnumerable<DataAccess.ref_ProductCode>, IEnumerable<Domain.ProductCode>>(productCodes);
            }
        }

        /// <summary>
        /// GetAllCQ
        /// </summary>
        /// <returns>IEnumerable<ProductCode> </returns>
        public IEnumerable<Domain.CQ> GetAllCQ()
        {
            using (var unitOfWork = new UnitOfWork(new QualityContext()))
            {
                IEnumerable<DataAccess.ref_CQ> cqs = unitOfWork.CQRepository.GetAll();
                return Mapper.Map<IEnumerable<DataAccess.ref_CQ>, IEnumerable<Domain.CQ>>(cqs);
            }
        }

        /// <summary>
        /// GetAllPieceTypes
        /// </summary>
        /// <returns>IEnumerable<PieceType> </returns>
        public IEnumerable<Domain.PieceType> GetAllPieceTypes()
        {
            using (var unitOfWork = new UnitOfWork(new QualityContext()))
            {
                IEnumerable<DataAccess.ref_PieceType> pieceTypes = unitOfWork.PieceTypeRepository.GetAll();
                return Mapper.Map<IEnumerable<DataAccess.ref_PieceType>, IEnumerable<Domain.PieceType>>(pieceTypes);
            }
        }


        /// <summary>
        /// GetAllUnits
        /// </summary>
        /// <returns>IEnumerable<PieceType> </returns>
        public IEnumerable<Domain.Unit> GetAllUnits()
        {
            using (var unitOfWork = new UnitOfWork(new QualityContext()))
            {
                IEnumerable<DataAccess.ref_Unit> units = unitOfWork.UnitRepository.GetAll();
                return Mapper.Map<IEnumerable<DataAccess.ref_Unit>, IEnumerable<Domain.Unit>>(units);
            }
        }

        /// <summary>
        /// GetAllProductionAreas
        /// </summary>
        /// <returns>IEnumerable<PieceType> </returns>
        public IEnumerable<Domain.ProductionArea> GetAllProductionAreas()
        {
            using (var unitOfWork = new UnitOfWork(new QualityContext()))
            {
                IEnumerable<DataAccess.ref_ProductionArea> productionAreas = unitOfWork.ProductionAreaRepository.GetAll();
                return Mapper.Map<IEnumerable<DataAccess.ref_ProductionArea>, IEnumerable<Domain.ProductionArea>>(productionAreas);
            }
        }
    }
}

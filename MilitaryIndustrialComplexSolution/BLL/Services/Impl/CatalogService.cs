using AutoMapper;
using BLL.DTO;
using BLL.Services.Interfaces;
using CCL.Security;
using CCL.Security.Identity;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Impl
{
    public class CatalogService : ICatalogService
    {
        private readonly IUnitOfWork database;
        private int pageSize = 10;

        public CatalogService(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
                throw new ArgumentNullException(nameof(unitOfWork));
            database = unitOfWork;
        }

        public IEnumerable<string> GetProductionList(int psId, int page)
        {
            var user = SecurityContext.GetUser();
            var userType = user.GetType();

            if (userType != typeof(CCL.Security.Identity.Admin) && userType != typeof(Moderator))
                throw new MethodAccessException();
            ProductionStore productionStoreEntity = database.ProductionStore.Find(ps => ps.ProductionStoreId == psId, page, pageSize).FirstOrDefault();
            var mapper =
                new MapperConfiguration(
                    cfg => cfg.CreateMap<ProductionStore, ProductionStoreDTO>()
                    ).CreateMapper();
            var ListOfProductsDTO = mapper.Map<IEnumerable<string>, IEnumerable<string>>(
                        productionStoreEntity.ProductList);
            return ListOfProductsDTO;
        }
    }
}

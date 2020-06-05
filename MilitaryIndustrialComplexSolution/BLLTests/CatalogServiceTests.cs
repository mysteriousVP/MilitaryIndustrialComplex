using BLL.Services.Impl;
using BLL.Services.Interfaces;
using CCL.Security;
using CCL.Security.Identity;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace BLLTests
{
    public class CatalogServiceTests
    {
        [Fact]
        public void Ctor_InputNull_ThrowArgumentNullException()
        {
            // Arrange
            IUnitOfWork nullUnitOfWork = null;
            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(
                () => new CatalogService(nullUnitOfWork)
            );
        }

        [Fact]
        public void GetProductsList_UserIsAdmin_ThrowMethodAccessException()
        {
            // Arrange
            User user = new PersonForTest(1, "hasNotPermissions");
            SecurityContext.SetUser(user);
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            ICatalogService catalogService = new CatalogService(mockUnitOfWork.Object);
            // Act
            // Assert
            Assert.Throws<MethodAccessException>(() => catalogService.GetProductionList(1, 0));
        }

        [Fact]
        public void GetCatalog_CatalogFromDAL_CorrectMappingToStreetDTO()
        {
            // Arrange
            User user = new Moderator(1, "testModerator");
            SecurityContext.SetUser(user);
            var catalogService = GetCatalogService();
            // Act
            var actualCatalogDTO = catalogService.GetProductionList(1, 0);
            // Assert
            Assert.True(
                actualCatalogDTO.FirstOrDefault() == "Hello from the future gun");
        }
        ICatalogService GetCatalogService()
        {
            var mockContext = new Mock<IUnitOfWork>();
            var expectedStore = new ProductionStore()
            {
                ProductionStoreId = 1,
                Name = "New Store",
                Capacity = 100,
                ProductList = new List<string>()
                {
                    "Hello from the future gun"
                }
            };

            var mockDbSet = new Mock<IProductionStoreRepository>();
            mockDbSet
              .Setup(z =>
                z.Find(
                    It.IsAny<Func<ProductionStore, bool>>(),
                    It.IsAny<int>(),
                    It.IsAny<int>()))
                 .Returns(
                     new List<ProductionStore>() { expectedStore }
                  );
            mockContext
                .Setup(context =>
                    context.ProductionStore)
                .Returns(mockDbSet.Object);

            ICatalogService catalogService = new CatalogService(mockContext.Object);
            return catalogService;
        }
    }
}

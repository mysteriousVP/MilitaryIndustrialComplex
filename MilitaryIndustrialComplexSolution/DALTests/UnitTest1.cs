using System;
using Xunit;
using Moq;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Context;
using DataAccessLayer.Entities;

namespace DALTests
{
    public class UnitTest1
    {
        [Fact]
        public void Create_InputAdminInstance_CalledAddMethodOfDBSetWithAdminInstance()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<MilitaryComplexContext>()
                .Options;
            var mockContext = new Mock<MilitaryComplexContext>(opt);
            var mockDbSet = new Mock<DbSet<Admin>>();
            mockContext
               .Setup(context =>
                    context.Set<Admin>(
                        ))
                .Returns(mockDbSet.Object);
            var repository = new TestAdminRepository(mockContext.Object);
            Admin expectedAdmin = new Mock<Admin>().Object;

            // Act
            repository.Create(expectedAdmin);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Add(
                    expectedAdmin
                    ), Times.Once());
        }
        
        [Fact]
        public void Get_InputId_CalledFindMethodOfDBSetWithAdminCorrectId()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<MilitaryComplexContext>()
                .Options;
            var mockContext = new Mock<MilitaryComplexContext>(opt);
            var mockDbSet = new Mock<DbSet<Admin>>();
            mockContext
                .Setup(context =>
                    context.Set<Admin>()).Returns(mockDbSet.Object);
            var repository = new TestAdminRepository(mockContext.Object);
            Admin expectedAdmin = new Admin() { AdminId = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedAdmin.AdminId))
                     .Returns(expectedAdmin);

            // Act
            repository.Get(expectedAdmin.AdminId);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedAdmin.AdminId
                    ), Times.Once());
        }

        [Fact]
        public void Delete_InputId_CalledFindAndRemoveMethodsOfDBSetWithProductionStoreCorrectArg()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<MilitaryComplexContext>()
                .Options;
            var mockContext = new Mock<MilitaryComplexContext>(opt);
            var mockDbSet = new Mock<DbSet<Admin>>();
            mockContext
               .Setup(context =>
                    context.Set<Admin>(
                        ))
                .Returns(mockDbSet.Object);
            var repository = new TestAdminRepository(mockContext.Object);
            
            Admin expectedAdmin = new Admin() { AdminId = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedAdmin.AdminId))
                     .Returns(expectedAdmin);

            // Act
            repository.Delete(expectedAdmin.AdminId);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedAdmin.AdminId
                    ), Times.Once());
            mockDbSet.Verify(
                dbSet => dbSet.Remove(
                    expectedAdmin
                    ), Times.Once());
        }

        [Fact]
        public void Create_InputAdminInstance_CalledAddMethodOfDBSetWithProductionStoreInstance()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<MilitaryComplexContext>()
                .Options;
            var mockContext = new Mock<MilitaryComplexContext>(opt);
            var mockDbSet = new Mock<DbSet<ProductionStore>>();
            mockContext
               .Setup(context =>
                    context.Set<ProductionStore>(
                        ))
                .Returns(mockDbSet.Object);
            var repository = new TestProductionStoreRepository(mockContext.Object);
            ProductionStore expectedProdStore = new Mock<ProductionStore>().Object;

            // Act
            repository.Create(expectedProdStore);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Add(
                    expectedProdStore
                    ), Times.Once());
        }

        [Fact]
        public void Get_InputId_CalledFindMethodOfDBSetWithProductionStoreProductionStoreCorrectId()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<MilitaryComplexContext>()
                .Options;
            var mockContext = new Mock<MilitaryComplexContext>(opt);
            var mockDbSet = new Mock<DbSet<ProductionStore>>();
            mockContext
                .Setup(context =>
                    context.Set<ProductionStore>()).Returns(mockDbSet.Object);
            var repository = new TestProductionStoreRepository(mockContext.Object);
            ProductionStore expectedProdStore = new ProductionStore() { ProductionStoreId = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedProdStore.ProductionStoreId))
                     .Returns(expectedProdStore);

            // Act
            repository.Get(expectedProdStore.ProductionStoreId);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedProdStore.ProductionStoreId
                    ), Times.Once());
        }

        [Fact]
        public void Delete_InputId_CalledFindAndRemoveMethodsOfDBSetWithCorrectArg()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<MilitaryComplexContext>()
                .Options;
            var mockContext = new Mock<MilitaryComplexContext>(opt);
            var mockDbSet = new Mock<DbSet<ProductionStore>>();
            mockContext
               .Setup(context =>
                    context.Set<ProductionStore>(
                        ))
                .Returns(mockDbSet.Object);
            var repository = new TestProductionStoreRepository(mockContext.Object);

            ProductionStore expectedProdStore = new ProductionStore() { ProductionStoreId = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedProdStore.ProductionStoreId))
                     .Returns(expectedProdStore);

            // Act
            repository.Delete(expectedProdStore.ProductionStoreId);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedProdStore.ProductionStoreId
                    ), Times.Once());
            mockDbSet.Verify(
                dbSet => dbSet.Remove(
                    expectedProdStore
                    ), Times.Once());
        }
    }
}

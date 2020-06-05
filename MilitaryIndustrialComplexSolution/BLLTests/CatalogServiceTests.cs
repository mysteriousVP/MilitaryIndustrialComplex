using BLL.Services.Impl;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
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
    }
}

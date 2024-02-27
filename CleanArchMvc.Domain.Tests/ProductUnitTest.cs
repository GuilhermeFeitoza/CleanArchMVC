using CleanArchMvc.Domain.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchMvc.Domain.Tests
{
    public class ProductUnitTest
    {
        [Fact]
        public void CreateProduct_WithValidParameters_ResultObjetValidState()
        {

            Action action = () => new Product(1, "Produto novo ", "Product Desription", 9.99m, 99, "productimg");
            action.Should().NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();


        }

    }
}

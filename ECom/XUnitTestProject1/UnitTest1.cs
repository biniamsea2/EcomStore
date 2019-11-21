using System;
using Xunit;
using ECom.Data;
using ECom.Models;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CreateProduct()
        {
            Product test = new Product();
            test.ID = 1;
            test.Sku = "FDJUNBJH";
            test.Name = "Toyota";
            test.Year = 2019;
            test.Price = 50000.00M;
            test.Color = "Red";
            test.Description = "Testing testing testing";
            test.Image = "";

            Assert.Equal(1, test.ID);
            Assert.Equal("FDJUNBJH", test.Sku);
            Assert.Equal("Toyota", test.Name);
            Assert.Equal(2019, test.Year);
            Assert.Equal("Red", test.Color);
            Assert.Equal("Testing testing testing", test.Description);
            Assert.Equal("", test.Image);

        }
    }
}

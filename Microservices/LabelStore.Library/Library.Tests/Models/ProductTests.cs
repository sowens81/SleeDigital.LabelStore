using System;
using SleeDigital.LabelStore.Library.Models;

namespace SleeDigital.LabelStore.Library.Tests.Models
{
    public class ProductTests
    {
        [Fact]
        public void Assert_Product_Model_Has_String_Id_Property()
        {
            // Arrange

            string id = "abc-123";

            // Act
            Product product = new Product()
            {
                id = id
            };

            // Assert

            Assert.True(id == product.id);

        }

        [Fact]
        public void Assert_Product_Model_Id_Has_Value_After_Initiation()
        {
            // Arrange


            // Act
            Product product = new Product();

            // Assert
            Assert.NotEmpty(product.id);

        }

        [Fact]
        public void Assert_Product_Model_Has_String_Name_Property()
        {
            // Arrange

            string productName = "abc-123";

            // Act
            Product product = new Product()
            {
                Name = productName
            };

            // Assert

            Assert.True(productName == product.Name);

        }

        [Fact]
        public void Assert_Product_Model_Has_Decimal_Price_Property()
        {
            // Arrange

            decimal price = 1.99m;

            // Act
            Product product = new Product()
            {
                Price = price
            };

            // Assert

            Assert.True(price == product.Price);

        }

        [Fact]
        public void Assert_Product_Model_Has_Int_Inventory_Property()
        {
            // Arrange

            int inventory = 1;

            // Act
            Product product = new Product()
            {
                Inventory = inventory
            };

            // Assert

            Assert.True(inventory == product.Inventory);

        }


    }
}


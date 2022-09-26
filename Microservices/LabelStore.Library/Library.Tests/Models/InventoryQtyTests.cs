using System;
using SleeDigital.LabelStore.Library.Models;

namespace SleeDigital.LabelStore.Library.Tests.Models
{
    public class InventoryQtyTests
    {
        [Fact]
        public void Assert_InventoryQty_Model_Has_Int_qty_Property()
        {
            // Arrange

            int qty = 1;

            // Act
            InvetoryQty inventoryQty = new InvetoryQty()
            {
                Qty = qty
            };

            // Assert

            Assert.True(qty == inventoryQty.Qty);

        }

    }
}


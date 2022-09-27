using System;
namespace SleeDigital.LabelStore.Library.Models
{
    public class Product
    {
        public Product()
        {
            id = Guid.NewGuid().ToString();
        }

        public string id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Inventory { get; set; }
    }
}


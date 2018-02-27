using System.Collections.Generic;
using CsvToolDb.Models;
using Microsoft.AspNet.OData;

namespace CsvToolDb.Controllers
{
    public class ProductsController : ODataController
    {
        private List<Product> products = new List<Product>()
        {
            new Product() { Id = 1, Name = "Bread1" },
            new Product() { Id = 2, Name = "Bread2" },
            new Product() { Id = 3, Name = "Bread3" },
            new Product() { Id = 4, Name = "Bread4" }
        };

        [EnableQuery]
        public List<Product> Get()
        {
            return products;
        }

        public Product Get(int key)
        {
            return products.Find(p => p.Id == key);
        }
    }
}

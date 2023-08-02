using Hello_World.Models;
using System.Collections.Generic;
using System.Linq;

namespace Hello_World.Db
{
    public class ProductDb : IProductDb
    {
        private readonly IList<Product> _products;

        public ProductDb()
        {
            
        }

        public Product GetDetail(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts() => _products;
    }
}


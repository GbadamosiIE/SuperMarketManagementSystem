using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.PluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class ProductRepository : IProductRepository
    {
        private readonly MarketContext _context;

        public ProductRepository(MarketContext context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            _context.Add(product);
        }

        public void DeleteProduct(int ProductId)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}

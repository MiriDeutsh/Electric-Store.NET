using Project.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Services
{
    public interface IProductService
    {
        public IEnumerable<Product> GetAllProduct();

        public Product GetProductById(int id);

        public Product PostProduct(Product product);

        public Product PutProduct(int id, Product product);

        public void DeleteProduct(int id);
    }
}

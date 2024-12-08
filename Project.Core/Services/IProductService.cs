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
        public List<Product> GetAllProduct();

        public Product GetProduct(Product product);

        public Product PostProduct(Product product);

        public Product PutProduct(int id, Product product);

        public void DeleteProduct(int id);
    }
}

using Project.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Repositories
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAll();

        public Product GetById(int id);

        public Product Post(Product value);

        public Product Put(int id, Product value);

        public void Delete(int id);
    }
}

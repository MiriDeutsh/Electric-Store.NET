using Project.Core.Model;
using Project.Core.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Repositries
{
    public class ProductRepository:IProductRepository
    {
        static int counter = 0;

        private DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }
        public Product Get(int id)
        {
            var index = _context.Products.FindIndex(p => p.ProductId == id);
            return _context.Products.Tolist()[index];
        }

        public Product Post(Product product)
        {
            product.ProductId = counter++;
            _context.Products.Add(product);
            return product;
        }

        public Product Put(int id, Product product)
        {
            int index = _context.Products.ToList().FindIndex(p => p.ProductId == id);
            _context.Products.ToList()[index].ProductName = value.ProductName;
            _context.Products.ToList()[index].Price = value.Price;
            _context.Products.ToList()[index].Availability = value.Availability;
            return _context.Products.ToList()[index];
        }

        public void Delete(int id)
        {
            int index = _context.Products.ToList().FindIndex(p => p.ProductId == id);
            _context.Products.ToList().Remove(_context.Products.ToList()[index]);
        }
    }
}

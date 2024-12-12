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
        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }
        public Product GetById(int id)
        {
            var index = _context.Products.ToList().FindIndex(p => p.ProductId == id);
            return _context.Products.ToList()[index];
        }

        public Product Post(Product product)
        {
            product.ProductId = counter++;
            _context.Products.ToList().Add(product);
            _context.SaveChanges();
            return product;
        }

        public Product Put(int id, Product product)
        {
            int index = _context.Products.ToList().FindIndex(p => p.ProductId == id);
            _context.Products.ToList()[index].ProductName = product.ProductName;
            _context.Products.ToList()[index].Price = product.Price;
            _context.Products.ToList()[index].Availability = product.Availability;
            _context.SaveChanges();
            return _context.Products.ToList()[index];
        }

        public void Delete(int id)
        {
            int index = _context.Products.ToList().FindIndex(p => p.ProductId == id);
            _context.Products.ToList().Remove(_context.Products.ToList()[index]);
            _context.SaveChanges();
        }
    }
}

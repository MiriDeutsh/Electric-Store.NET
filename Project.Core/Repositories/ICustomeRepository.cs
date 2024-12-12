using Project.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Repositories
{
    public interface ICustomeRepository
    {
        public IEnumerable<Customer> GetAll();

        public Customer GetById(int id);

        public Customer Post(Customer value);

        public Customer Put(int id, Customer value);

        public void Delete(int id);
    }
}

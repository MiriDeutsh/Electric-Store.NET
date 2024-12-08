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
        public List<Customer> GetAll();

        public Customer Get(int id);

        public Customer post(Customer value);

        public Client Put(int id, Customer value);

        public void Delete(int id);
    }
}

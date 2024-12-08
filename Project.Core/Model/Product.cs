using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public double Price { get; set; }
        public bool Availability { get; set; }
    }
}

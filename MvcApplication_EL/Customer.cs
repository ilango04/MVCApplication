using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication_EL
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public string type { get; set; }
        public Customer(int id,string name,int salary,string type)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.type = type;
        }
        public Customer()
        {

        }
    }
}

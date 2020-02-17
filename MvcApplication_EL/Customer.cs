using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication_EL
{
    public class Customer
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public int salary { get; set; }
        [Required]
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

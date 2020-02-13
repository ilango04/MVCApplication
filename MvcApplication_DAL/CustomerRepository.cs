using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcApplication_EL;


namespace MvcApplication_DAL
{
    public class CustomerRepository
    {
        List<Customer> customerDetails = new List<Customer>();
        public List<Customer> AddDetails()
        {
            customerDetails.Add(new Customer("ilango", 25000, "salaried"));
            customerDetails.Add(new Customer("Mahesh", 22000, "salaried"));
            return customerDetails;
        }
    }
}

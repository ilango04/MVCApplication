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
        public static List<Customer> customerDetails = new List<Customer>();
        static CustomerRepository()
        {
            customerDetails.Add(new Customer(1,"ilango", 25000, "salaried"));
            customerDetails.Add(new Customer(2,"Mahesh", 22000, "salaried"));
        }
        public IEnumerable<Customer> AddDetails()
        {
            return customerDetails;
        }
        public void CreateRow(Customer customer)
        {
            customerDetails.Add(customer);
        }
        public Customer GetCustomerById(int customerId)
        {
            return customerDetails.Find(id => id.id == customerId);
        }
        public void DeleteCustomer(int customerId)
        {
            Customer customer = GetCustomerById(customerId);
            if (customer != null)
                customerDetails.Remove(customer);
        }
        public void UpdateCustomer(Customer customer)
        {
            //PackageDetails packages = package.Find(id => id.PackageId == pack.PackageId);
            Customer details = GetCustomerById(customer.id);
            details.name = customer.name;
            details.salary = customer.salary;
        }
    }
}

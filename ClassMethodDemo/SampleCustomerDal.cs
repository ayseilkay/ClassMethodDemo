using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    public class SampleCustomerDal : ICustomerDal
    {
       
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted");
        }

        public List<Customer> GetAll()
        {
            Console.WriteLine("Customer listed !");
            return new List<Customer>();
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer updated");
        }
    }
}

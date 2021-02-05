using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    public class CustomerManager :ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
       
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added !");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted !");
        }

        public List<Customer> GetAll()
        {
           
            return _customerDal.GetAll();
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer updated !");
        }
    }
}

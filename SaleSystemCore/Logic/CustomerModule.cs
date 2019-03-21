using SaleSystemCore.Models;
using SaleSystemCore.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaleSystemCore.Logic
{
    public class CustomerModule 
    {
        private CustomerRepo customerRepo;

        internal CustomerModule()
        {
            customerRepo = new CustomerRepo();
        }

        #region [Customers]
        public void AddCustomer(Customer customer)
        {
            customerRepo.Add(customer);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return customerRepo.GetAll();
        }

        public Customer GetCustomer(int id)
        {
            return customerRepo.Find(id);
        }

        public Customer GetCustomerByMobile(string mobile)
        {
            return customerRepo.GetCustomerByMobile(mobile);
        }

        public void SaveCustomer()
        {
            customerRepo.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            customerRepo.Delete(customer);
        }
        #endregion
    }
}

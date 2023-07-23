using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week10.Front.ViewModel.Customers;
using Week10.Storage.Task1_3.Data;

namespace Week10.Front.Model.Customers
{
    public abstract class Worker
    {
        public abstract string Name { get; }
        public abstract void AddCustomer(CustomerField selectedCustomer);
        public abstract void UpdateCustomer(CustomerField selectedCustomer);
        public List<Customer> GetAll()
        {
            var customers = Customer.GetCustomers();

            return customers;
        }

        public CustomerField GetById(Guid id)
        {
            var customers = Customer.GetCustomers();
            var customer = customers.FirstOrDefault(x => x.Id == id);
            return MapToFields(customer);
        }

        internal abstract CustomerField MapToFields(Customer selectedCustomer);

        public CustomerField CreateCustomerField()
        {
            var customer = new Customer()
            {
                Id = Guid.NewGuid(),
            };

            return MapToFields(customer);
        }
    }
}

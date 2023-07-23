using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week10.Front.ViewModel.Customers;
using Week10.Storage.Task1_3.Data;

namespace Week10.Front.Model.Customers
{
    public interface ICustumerModel
    {
        void AddCustomer(Customer customer);
        void UpdateCustomer(CustomerField selectedCustomer);
        List<Customer> GetAll();
        CustomerField GetById(int id);
    }
}

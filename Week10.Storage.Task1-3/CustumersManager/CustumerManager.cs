using System.Text.Json;
using Week10.Storage.Task1_3.Data;

namespace Week10.Storage.Task1_3.CustumersManager
{
    public class CustumerManager : ICustumerManager
    {
        const string _storageFile = "TestStorage.json";
        public void AddCustomer(Customer customer)
        {
            var json = JsonSerializer.Serialize(customer);
            File.WriteAllText(_storageFile, json);
        }

        public List<Customer> GetAll()
        {
            var customers = GetCustomers();

            return customers;
        }

        public Customer GetById(int id)
        {
            var customers = GetCustomers();
            var customer = customers.FirstOrDefault(x => x.Id == id);
            return customer;
        }

        private List<Customer> GetCustomers()
        {
            var json = File.ReadAllText(_storageFile);
            var result = JsonSerializer.Deserialize<List<Customer>>(json);
            return result;
        }
    }
}

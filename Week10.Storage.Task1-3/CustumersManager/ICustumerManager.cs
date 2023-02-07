using Week10.Storage.Task1_3.Data;

namespace Week10.Storage.Task1_3.CustumersManager
{
    public interface ICustumerManager
    {
        void AddCustomer(Customer customer);
        List<Customer> GetAll();
        Customer GetById(int id);
    }
}
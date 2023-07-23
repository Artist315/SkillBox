using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Week10.Front.ViewModel.Customers;
using Week10.Storage.Task1_3.Data;

namespace Week10.Front.Model.Customers
{
    public class ManagerModel : Worker
    {
        public override string Name =>"Менеджер";

        public override void AddCustomer(CustomerField selectedCustomer)
        {

            if (string.IsNullOrEmpty(selectedCustomer.TelNumber.Value))
            {
                MessageBox.Show("Заполните номер телефона", "Warning");
                return;
            }

            AddRequest addRequest = new AddRequest()
            {
                Id = selectedCustomer.Id.Value,
                FirstName = selectedCustomer.FirstName.Value,
                LastName = selectedCustomer.LastName.Value,
                MiddleName = selectedCustomer.MiddleName.Value,
                PassSeries = selectedCustomer.PassSeries.Value,
                PassNumber = selectedCustomer.PassNumber.Value,
                TelNumber = selectedCustomer.TelNumber.Value,
                UpdatedBy = Name
            };
            Customer.AddCustomer(addRequest);
        }

        public override void UpdateCustomer(CustomerField selectedCustomer)
        {
            if (string.IsNullOrEmpty(selectedCustomer.TelNumber.Value))
            {
                MessageBox.Show("Заполните номер телефона", "Warning");
                return;
            }
            UpdateRequest updateRequest = new UpdateRequest 
            { 
                FirstName = selectedCustomer.FirstName.Value,
                LastName = selectedCustomer.LastName.Value,
                MiddleName = selectedCustomer.MiddleName.Value,
                PassSeries = selectedCustomer.PassSeries.Value,
                PassNumber = selectedCustomer.PassNumber.Value,
                TelNumber = selectedCustomer.TelNumber.Value,
                UpdatedBy = Name
            };

            Customer.UpdateCustomer(selectedCustomer.Id.Value, updateRequest);
        }

        internal override CustomerField MapToFields(Customer selectedCustomer)
        {
            return new CustomerField()
            {
                Id          = new Field<Guid>()   { Value = selectedCustomer.Id, IsReadOnly = true },
                FirstName   = new Field<string>() { Value = selectedCustomer.FirstName, IsReadOnly = false },
                LastName    = new Field<string>() { Value = selectedCustomer.LastName, IsReadOnly = false },
                MiddleName  = new Field<string>() { Value = selectedCustomer.MiddleName, IsReadOnly = false },
                PassNumber  = new Field<string>() { Value = selectedCustomer.PassNumber, IsReadOnly = false },
                PassSeries  = new Field<string>() { Value = selectedCustomer.PassSeries, IsReadOnly = false },
                TelNumber   = new Field<string>() { Value = selectedCustomer.TelNumber, IsReadOnly = false },
                UpdatedAt = selectedCustomer.LastUpdate,
                UpdatedBy = selectedCustomer.UpdatedBy,
                UpdatedType = selectedCustomer.UpdatedType,
                UpdatedFields = selectedCustomer.UpdatedFields,
            };
        }
    }
}

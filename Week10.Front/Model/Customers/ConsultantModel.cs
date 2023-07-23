using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Week10.Front.ViewModel.Customers;
using Week10.Storage.Task1_3.Data;

namespace Week10.Front.Model.Customers
{
    public class ConsultantModel : Worker
    {
        public override string Name => "Консультант";

        public override void AddCustomer(CustomerField selectedCustomer)
        {
            MessageBox.Show("Запрещено создавать новых пользователей", "Warning");
        }
        internal override CustomerField MapToFields(Customer selectedCustomer)
        {
            return new CustomerField()
            {
                Id          = new Field<Guid>()     { Value = selectedCustomer.Id               , IsReadOnly = true },
                FirstName   = new Field<string>()   { Value = selectedCustomer.FirstName        , IsReadOnly = true },
                LastName    = new Field<string>()   { Value = selectedCustomer.LastName         , IsReadOnly = true },
                MiddleName  = new Field<string>()   { Value = selectedCustomer.MiddleName       , IsReadOnly = true },
                PassNumber  = new Field<string>()   { Value = Hide(selectedCustomer.PassNumber) , IsReadOnly = true },
                PassSeries  = new Field<string>()   { Value = Hide(selectedCustomer.PassSeries) , IsReadOnly = true },
                TelNumber   = new Field<string>()   { Value = selectedCustomer.TelNumber        , IsReadOnly = false},
                UpdatedAt   = selectedCustomer.LastUpdate,
                UpdatedBy   = selectedCustomer.UpdatedBy,
                UpdatedType = selectedCustomer.UpdatedType,
                UpdatedFields = selectedCustomer.UpdatedFields,
            };
        }

        private string Hide(string importantInfo)
        {
            return string.IsNullOrEmpty(importantInfo) ? importantInfo : "******************";
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
                TelNumber = selectedCustomer.TelNumber.Value,
                UpdatedBy = Name
            };

            Customer.UpdateCustomer(selectedCustomer.Id.Value, updateRequest);
        }
    }
}

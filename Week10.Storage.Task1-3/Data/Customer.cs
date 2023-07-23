using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Week10.Storage.Task1_3.Constants;

namespace Week10.Storage.Task1_3.Data
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string PassSeries { get; set; }
        public string PassNumber { get; set; }
        public string TelNumber { get; set; }
        public string LastUpdate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedFields { get; set; }
        public string UpdatedType { get; set; }

        private static List<Customer> Customers = new List<Customer>();
        public static List<Customer> GetCustomers()
        {
            var json = File.Exists(ConnectionConstants._cStorageFile) ? File.ReadAllText(ConnectionConstants._cStorageFile) : string.Empty;

            var result = new List<Customer>();

            if (!string.IsNullOrEmpty(json))
            {
                result = JsonSerializer.Deserialize<List<Customer>>(json);
            }
            return result;
        }

        public static bool UpdateCustomer(Guid id, UpdateRequest updateRequest)
        {
            Customers = GetCustomers();
            List<string> changedFileds = new List<string>();
            var customer = Customers.FirstOrDefault(x => x.Id == id);

            if (customer == null)
            {
                return false;
            }

            if (updateRequest.FirstName != null)
            {
                if (customer.FirstName != updateRequest.FirstName)
                {
                    changedFileds.Add(nameof(customer.FirstName));
                }
                customer.FirstName = updateRequest.FirstName; 

            }

            if (updateRequest.LastName != null)
            {
                if (customer.LastName != updateRequest.LastName)
                {
                    changedFileds.Add(nameof(customer.LastName));
                }
                customer.LastName = updateRequest.LastName;
            }

            if (updateRequest.MiddleName != null)
            {
                if (customer.MiddleName != updateRequest.MiddleName)
                {
                    changedFileds.Add(nameof(customer.MiddleName));
                }
                customer.MiddleName = updateRequest.MiddleName;
            }

            if (updateRequest.PassNumber != null)
            {
                if (customer.PassNumber != updateRequest.PassNumber)
                {
                    changedFileds.Add(nameof(customer.PassNumber));
                }
                customer.PassNumber = updateRequest.PassNumber;
            }

            if (updateRequest.PassSeries != null)
            {
                if (customer.PassSeries != updateRequest.PassSeries)
                {
                    changedFileds.Add(nameof(customer.PassSeries));
                }
                customer.PassSeries = updateRequest.PassSeries;
            }

            if (updateRequest.TelNumber != null)
            {
                if (customer.TelNumber != updateRequest.TelNumber)
                {
                    changedFileds.Add(nameof(customer.TelNumber));
                }
                customer.TelNumber = updateRequest.TelNumber;
            }
            customer.LastUpdate = DateTime.UtcNow.ToString();
            customer.UpdatedType = "Update";
            customer.UpdatedBy = updateRequest.UpdatedBy;
            customer.UpdatedFields = string.Join(", ", changedFileds);
            return Save();
        }

        private static bool Save()
        {
            try
            {
                var json = JsonSerializer.Serialize(Customers);

                File.WriteAllText(ConnectionConstants._cStorageFile, json);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool AddCustomer(AddRequest addRequest)
        {
            Customers = GetCustomers();

            Customer customer = new Customer()
            {
                Id = addRequest.Id,
                FirstName = addRequest.FirstName,
                MiddleName = addRequest.MiddleName,
                LastName = addRequest.LastName,
                PassNumber = addRequest.PassNumber,
                PassSeries = addRequest.PassSeries,
                TelNumber = addRequest.TelNumber,
                LastUpdate = DateTime.UtcNow.ToString(),
                UpdatedBy = addRequest.UpdatedBy,
                UpdatedType = "Create",
                UpdatedFields = "All",
                
            };
            Customers.Add(customer);

            return Save();
        }

        private void CompareField(string old, string updated)
        {

        }
    }
}

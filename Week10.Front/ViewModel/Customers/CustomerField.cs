using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week10.Storage.Task1_3.Data;

namespace Week10.Front.ViewModel.Customers
{
    public class CustomerField
    {
        public Field<Guid> Id { get; set; }
        public Field<string> FirstName { get; set; }
        public Field<string> FirstLastNameName { get; set; }

        public Field<string> LastName { get; set; }
        public Field<string> MiddleName { get; set; }
        public Field<string> PassSeries { get; set; }
        public Field<string> PassNumber { get; set; }
        public Field<string> TelNumber { get; set; }
        public string UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedFields { get; set; }
        public string UpdatedType { get; set; }
    }
}

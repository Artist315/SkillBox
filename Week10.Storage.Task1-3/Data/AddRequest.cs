using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10.Storage.Task1_3.Data
{
    public class AddRequest
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string PassSeries { get; set; }
        public string PassNumber { get; set; }
        public string TelNumber { get; set; }
        public string UpdatedBy { get; set; }
    }
}

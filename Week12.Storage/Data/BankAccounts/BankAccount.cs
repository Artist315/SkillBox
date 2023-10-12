using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12.Storage.Data.BankAccounts
{
    public class BankAccount
    {
        public Guid Id { get; set; }
        public float Value { get; set; }
        public enum Name { get; set; }
    }
}

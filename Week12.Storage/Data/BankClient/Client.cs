using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week12.Storage.Data.BankAccounts;

namespace Week12.Storage.Data.BankClient
{
    public class BankClient
    {
        public List<BankAccount> Accounts { get; set; } = new List<BankAccount>();
        public string Name { get; set; }
        public Guid Id { get; set; }
    }
}

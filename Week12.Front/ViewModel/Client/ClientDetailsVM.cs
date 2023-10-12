using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week12.Storage.Data.BankAccounts;
using Week12.Storage.Data.BankClient;

namespace Week12.Front.ViewModel.Client
{
    internal class ClientDetailsVM : ChildVM
    {

        public ClientDetailsVM(object info) : base(info)
        {
            if (info != null && info is BankClient client)
            {
                BankClient = client;
            }
        }
        public BankClient BankClient
        {
            get => _bankClient;
            set => _bankClient = value;
        }

        private BankClient _bankClient;
        private BankAccount selectedAccount;

        public BankAccount SelectedAccount { get => selectedAccount; set => selectedAccount = value; }
    }
}

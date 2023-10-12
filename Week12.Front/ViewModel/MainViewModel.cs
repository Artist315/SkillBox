using Extensions.WPF;
using System.Collections.Generic;
using Week12.Front.ViewModel.Client;
using Week12.Storage.Data.BankClient;
using Week12.Storage.Storage;

namespace Week12.Front.ViewModel
{
    public class MainViewModel : BindableBase
    {
        public MainViewModel()
        {
            LoadData();
            CreateClientCommand     = new RelayCommand(o => CreateClient());
            OpenClientInfoCommand   = new RelayCommand(o => OpenClientInfo(), o => CanOpenClient());
        }

        private bool CanOpenClient()
        {
            return SelectedClient != null;
        }

        private void OpenClientInfo()
        {
            ChildVM = new ClientDetailsVM(SelectedClient);
        }

        private void CreateClient()
        {
            ChildVM = new AddClientVM();
            ChildVM.ListUpdated += LoadData;
        }

        private void LoadData()
        {
            Clients.Clear();
            Clients = new List<BankClient>(DataStorage.GetClients());
        }

        public List<BankClient> Clients { get => _clients; 
            set
            {
                _clients = value;
                OnPropertyChanged();
            }
        }

        private BankClient _selectedClient;
        public BankClient SelectedClient
        {
            get
            {
                return _selectedClient;
            }
            set
            {
                _selectedClient = value;
                OpenClientInfoCommand.RaiseCanExecuteChanged();
            }
        }
        #region Commands

        public RelayCommand CreateClientCommand { get; set; }
        public RelayCommand OpenClientInfoCommand { get; set; }
        public RelayCommand SortCommand { get; set; }
        public RelayCommand SortReverseCommand { get; set; }
        #endregion


        #region ChildComponents
        private ChildVM _childVM;
        private List<BankClient> _clients = new List<BankClient>();

        public ChildVM ChildVM
        {
            get
            {
                return _childVM;
            }
            set
            {
                _childVM = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}

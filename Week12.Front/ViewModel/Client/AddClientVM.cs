using Extensions.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Week12.Storage.Storage;

namespace Week12.Front.ViewModel.Client
{
    public class AddClientVM : ChildVM
    {
        public AddClientVM()
        {
            AddClientCommand = new RelayCommand(o => AddClient(), o => CannAddClient());

        }

        public void AddClient()
        {
            DataStorage.AddClient(Name);

            OnListUpdated();
        }
        #region Commands

        public RelayCommand AddClientCommand { get; set; }
        #endregion
        public bool CannAddClient()
        {
           return !DataStorage.CheckExistingClients(Name);
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged();
                AddClientCommand.RaiseCanExecuteChanged();
            }
        }
    }
}

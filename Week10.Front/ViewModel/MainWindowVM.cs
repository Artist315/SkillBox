using Extensions.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using Week10.Front.Model.Customers;
using Week10.Front.Model.Roles;
using Week10.Front.ViewModel.Customers;
using Week10.Storage.Task1_3.Data;

namespace Week10.Front.ViewModel
{
    public class MainWindowVM : BindableBase
    {

        private Worker customerModel { get; set; }
        public MainWindowVM()
        {
            AddCustomerCommand = new RelayCommand(o => AddCustomer(), o => CanAddCustomer());
            SelectedRole = Roles.FirstOrDefault();
            LoadData();
        }

        private void AddCustomer()
        {
            EditCustomerVM = new EditCustomerVM(null, customerModel);
        }

        private void Test(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (customerModel != null)
            {
                Customers = customerModel.GetAll();
            }
        }

        public void ShowCustomer()
        {
        }

        private List<Customer> _customers = new List<Customer>();
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                OnPropertyChanged();
            }
        }

        private Customer _selectedCustomer;
        public Customer SelectedCustomer
        {
            get { return _selectedCustomer; }
            set
            {
                _selectedCustomer = value;
                OnPropertyChanged();
                if (value != null)
                {
                    EditCustomerVM = new EditCustomerVM(SelectedCustomer.Id, customerModel);
                }
            }
        }

        #region RolesList
        private readonly List<string> _roles = Enum.GetNames(typeof(Roles)).ToList();
        public List<string> Roles
        {
            get
            {
                return _roles;
            }
        }

        private string _selectedRole;
        public string SelectedRole
        {
            get
            {
                return _selectedRole;
            }
            set
            {
                _selectedRole = value;
                EditCustomerVM = null;
                customerModel = RoleFactory.GetModel(value);
                AddCustomerCommand.RaiseCanExecuteChanged();
                if (SelectedCustomer != null)
                {
                    EditCustomerVM = new EditCustomerVM(SelectedCustomer.Id, customerModel);
                }
                OnPropertyChanged();
            }
        }
        #endregion

        #region ChildComponents
        private EditCustomerVM _editCustomerVM;
        public EditCustomerVM EditCustomerVM
        {
            get
            {
                return _editCustomerVM;
            }
            set
            {
                if (_editCustomerVM != null)
                {
                    _editCustomerVM.ListUpdated -= Test;
                }
                _editCustomerVM = value; 
                if (_editCustomerVM != null)
                {
                    _editCustomerVM.ListUpdated += Test;
                }
                OnPropertyChanged();
            }
        }
        #endregion

        #region Commands

        public RelayCommand AddCustomerCommand { get; set; }

        private bool CanAddCustomer()
        {
            return customerModel is ManagerModel;
        }
        #endregion
    }

}

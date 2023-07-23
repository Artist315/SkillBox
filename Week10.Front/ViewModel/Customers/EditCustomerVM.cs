using Extensions.WPF;
using System;
using Week10.Front.Model.Customers;

namespace Week10.Front.ViewModel.Customers
{
    public class EditCustomerVM : BindableBase
    {
        public event EventHandler ListUpdated;
        private readonly Worker _customerManager;
        private readonly bool _isUpdate;
        public EditCustomerVM(Guid? selectedCustomerId, Worker custumerManager, bool isUpdate = true)
        {
            _customerManager = custumerManager;
            SaveCustomerCommand = new RelayCommand(o => SaveCustomer(), o => CanSaveCustomer());
            if (selectedCustomerId != null)
            {
                SelectedCustomer = _customerManager.GetById(selectedCustomerId.Value);
                _isUpdate = true;
            }
            else
            {
                SelectedCustomer = custumerManager.CreateCustomerField();
                _isUpdate = false;
            }
        }

        private void SaveCustomer()
        {
            if (_isUpdate)
            {
                _customerManager.UpdateCustomer(SelectedCustomer);
            }
            else
            {
                _customerManager.AddCustomer(SelectedCustomer);
            }
            SelectedCustomer = _customerManager.GetById(SelectedCustomer.Id.Value);
            ListUpdated?.Invoke(this, EventArgs.Empty);
        }

        public CustomerField SelectedCustomer
        {
            get
            {
                return _selectedCustomer;
            }
            set
            {
                _selectedCustomer = value;
                OnPropertyChanged();
            }
        }
        private CustomerField _selectedCustomer;

        #region Commands

        public RelayCommand SaveCustomerCommand { get; set; }

        private bool CanSaveCustomer()
        {
            return true;
        }
        #endregion
    }
}

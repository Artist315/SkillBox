using Extensions.WPF;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace Week9.Task1.ViewModel
{
    public class MainWindowVM : BindableBase
    {
        public MainWindowVM()
        {
            SplitLineCommand = new RelayCommand(o => SplitLine());
        }

        #region Task2 revert line
        private string _input;
        public string Input
        {
            get
            {
                return _input;
            }
            set
            {
                _input = value;
            }
        }
        #endregion

        #region Task1 split line
        private void SplitLine()
        {
            SplittedElements = InputTask1.Split(" ").ToList();
        }
        public ICommand SplitLineCommand { get; set; }

        private string _inputTask1;
        public string InputTask1
        {
            get
            {
                return _inputTask1;
            }
            set
            {
                _inputTask1 = value;
            }
        }
        private List<string> _splittedElements = new List<string>();
        public List<string> SplittedElements
        {
            get
            {
                return _splittedElements;
            }
            private set
            {
                _splittedElements = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}

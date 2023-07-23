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
            RevertLineCommand = new RelayCommand(o => RevertLine());

        }

        #region Task2 revert line
        private void RevertLine()
        {
            var copy = new List<string>(SplittedElements);
            copy.Reverse();
            RevertedLine = string.Join(", ", copy);
        }
        public ICommand RevertLineCommand { get; set; }

        private string _revertedLine;
        public string RevertedLine
        {
            get
            {
                return _revertedLine;
            }
            private set
            {
                _revertedLine = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Task1 split line
        private void SplitLine()
        {
            SplittedElements = Input.Split(" ").Where(x => !string.IsNullOrEmpty(x)).ToList();
        }
        public ICommand SplitLineCommand { get; set; }

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

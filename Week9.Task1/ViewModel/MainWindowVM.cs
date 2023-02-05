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

        private void SplitLine()
        {
            SplittedElements = Input.Split(" ").ToList();
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
    }
}

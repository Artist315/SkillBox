using Extensions.WPF;

namespace Week12.Front.ViewModel
{
    public class ChildVM : BindableBase
    {
        public delegate void Notify();
        internal readonly object _info;
        public event Notify ListUpdated;

        public void OnListUpdated()
        {
            ListUpdated?.Invoke();
        }

        public ChildVM()
        {
            
        }
        public ChildVM(object info) : base()
        {
            if (info != null)
            {
                _info = info;
            }
        }
    }
}

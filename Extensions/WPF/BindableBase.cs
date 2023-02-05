using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Extensions.WPF
{
    public abstract class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            string propertyName = ((MemberExpression)propertyExpression.Body).Member.Name;
            this.OnPropertyChanged(propertyName);
        }
    }
}

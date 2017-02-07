using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MessageSevenProject.Helper.ModelBase
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void IPropertyChanged(string propertyname)
        {
            PropertyChangedEventHandler Handler = PropertyChanged;
            if (Handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
        protected bool SetProperty<T>(ref T Storage,T Value,[CallerMemberName] string propertyname=null)
        {
            if (EqualityComparer<T>.Default.Equals(Storage, Value)) return false;
            Storage = Value;
            IPropertyChanged(propertyname);
            return true;
        }
    }
}

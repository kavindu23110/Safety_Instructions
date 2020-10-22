using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Safety_Instructions.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        public Data.Models.Profile profile { get; set; }
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}

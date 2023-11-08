using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace SampleUnitConverter {
    public class Viemodel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnpropertyChanged([CallerMemberName] string propertyName = null) {
            if (this.PropertyChanged != null) {
                this.PropertyChanged(this, new PropetyChangedEventArgs(propetyName));
            }
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HUM150_TruthTables.Annotations;

namespace HUM150_TruthTables
{
    public class Proposition : INotifyPropertyChanged
    {

        #region Properties

        private bool _value;
        public bool Value
        {
            get { return _value; }
            set 
            { 
                this._value = value;
                OnPropertyChanged("Value");
            }
        }

        #endregion

        #region Members

        public bool Equals(Proposition prop)
        {
            return Value == prop.Value;
        }

        public bool Hook(Proposition prop)
        {
            if (And(prop))
                return true;
            if (!Value && prop.Value)
                return true;
            return !Value && !prop.Value;
        }

        public bool And(Proposition prop)
        {
            return Value && prop.Value;
        }

        public bool Or(Proposition prop)
        {
            return Value || prop.Value;
        }

        public bool NotEqual(Proposition prop)
        {
            return Value != prop.Value;
        }

        #endregion Members

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}

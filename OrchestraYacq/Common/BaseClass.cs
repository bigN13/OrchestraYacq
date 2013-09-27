using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace OrchestraYacq.Common
{
    public partial class BaseClass : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}

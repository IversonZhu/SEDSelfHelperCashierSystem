using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SEDSelfHelpCashierSystem.Utils
{
    public class ViewHelper : INotifyPropertyChanged
    {
        private static ViewHelper viewHelper = new ViewHelper();

        public static ViewHelper Instance
        {
            get
            {
                return viewHelper;
            }
        }

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }
    }
}

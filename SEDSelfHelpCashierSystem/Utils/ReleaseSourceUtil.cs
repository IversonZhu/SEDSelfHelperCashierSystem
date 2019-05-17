using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SEDSelfHelpCashierSystem.Utils
{
    public class ReleaseSourceUtil : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        protected virtual void DisposedStubborn()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDGUI.ViewModel;

namespace TDGUI.View
{
    interface INavigationService
    {
        void Show(BaseViewModel vm);

        void Close();
    }
}

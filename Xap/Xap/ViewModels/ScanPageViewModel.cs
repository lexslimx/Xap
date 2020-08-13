using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Xap.ViewModels
{
    public class ScanPageViewModel : ViewModelBase
    {
      
        public ScanPageViewModel(INavigationService navigationService)
         : base(navigationService)
        {           
            Title = "Scan";
        }
    }
}

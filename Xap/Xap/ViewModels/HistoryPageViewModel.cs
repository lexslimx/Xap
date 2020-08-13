using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Xap.ViewModels
{
    public class HistoryPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public HistoryPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
        }
    }
}

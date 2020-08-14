using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Xap.ViewModels
{
    public class RegistrationPageViewModel : ViewModelBase
    {
        public RegistrationPageViewModel(INavigationService navigationService)
            :base(navigationService)
        {
            _navigationService = navigationService;
        }

        private DelegateCommand _registerCommand;
        private INavigationService _navigationService;

        public DelegateCommand RegisterCommand => _registerCommand ?? (_registerCommand = new DelegateCommand(Register));

        private void Register()
        {
            _navigationService.NavigateAsync("LoginPage");
        }
    }
}

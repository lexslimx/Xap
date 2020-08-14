using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Xap.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;

        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;

        }

        private string _emailAddress;
        private string _password;

        public string EmailAddress { get => _emailAddress;
            set { SetProperty(ref _emailAddress, value); } }

        public string Password { get => _password; 
            set { SetProperty(ref _password, value); } }

        private DelegateCommand _loginCommand;
        public DelegateCommand LoginCommand => _loginCommand ?? (_loginCommand = new DelegateCommand(Login));

        private void Login()
        {
            _navigationService.NavigateAsync("MainPage");
        }

        private DelegateCommand _goToRegisterCommand;
        public DelegateCommand GoToRegisterCommand => _goToRegisterCommand ?? (_goToRegisterCommand = new DelegateCommand(GoToRegister));

        private void GoToRegister()
        {
            _navigationService.NavigateAsync("RegistrationPage");
        }
    }
}

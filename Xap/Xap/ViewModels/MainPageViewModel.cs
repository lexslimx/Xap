using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace Xap.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "SIMS";
            _navigationService = navigationService;
        }

        async void OpenScannerAsync()
        {
            await _navigationService.NavigateAsync("ScanPage", useModalNavigation:true);
        }
        private DelegateCommand _openScannerCommand;
        public DelegateCommand OpenScannerCommand => _openScannerCommand ?? (_openScannerCommand = new DelegateCommand(OpenScannerAsync));
    }
}

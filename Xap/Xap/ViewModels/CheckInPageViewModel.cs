using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xap.Events;
using Xap.Views;

namespace Xap.ViewModels
{
    public class CheckInPageViewModel : ViewModelBase
    {
        private IEventAggregator _eventAggregator;

        private INavigationService _navigation { get; set; }
        public CheckInPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
            : base(navigationService)
        {
            _eventAggregator = eventAggregator;
            _navigation = navigationService;
            Title = "CheckIn";

        }

        async void OpenScannerAsync()
        {
            await _navigation.NavigateAsync(nameof(ScanPage), useModalNavigation: true);
        }

        private DelegateCommand _openScannerCommand;
        public DelegateCommand OpenScannerCommand => _openScannerCommand ?? (_openScannerCommand = new DelegateCommand(OpenScannerAsync));

        private string _ninNumber;
        public string NinNumber
        {
            get
            {
                return _ninNumber;
            }
            set
            {
                SetProperty(ref _ninNumber, value);
            }
        }


        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            var BarcodeResult = parameters["BarcodeResult"] as string;
            NinNumber = BarcodeResult;
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {

        }
    }
}

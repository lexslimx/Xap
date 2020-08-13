using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using ZXing;

namespace Xap.ViewModels
{
    public class ScanPageViewModel : ViewModelBase
    {
        public ScanPageViewModel(INavigationService navigationService)
         : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Scan";

            PropertyChanged += ScanningViewModel_PropertyChanged;
        }


        private string barcode = string.Empty;
        public string Barcode
        {
            get
            {
                return barcode;
            }
            set
            {
                barcode = value;
            }
        }

        private bool _isAnalyzing = true;
        public bool IsAnalyzing
        {
            get { return _isAnalyzing; }
            set
            {
                if (!Equals(_isAnalyzing, value))
                {
                    _isAnalyzing = value;
                }
            }
        }

        private bool _isScanning = true;
        private INavigationService _navigationService;

        public bool IsScanning
        {
            get { return _isScanning; }
            set
            {
                if (!Equals(_isScanning, value))
                {
                    _isScanning = value;
                }
            }
        }

        public Result Result { get; set; }

        public Command ScanCommand
        {
            get
            {
                return new Command(() =>

                {
                    IsAnalyzing = false;
                    IsScanning = false;

                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        Barcode = Result.Text;
                        var navigationParams = new NavigationParameters
                    {
                        { "BarcodeResult", Barcode }
                    };
                        await _navigationService.GoBackAsync(navigationParams);
                    });

                    IsAnalyzing = true;
                    IsScanning = true;
                });
            }
        }
        private void ScanningViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
        }


    }
}

using Prism.Navigation;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace Xap.Views
{
    public partial class ScanPage : ZXingScannerPage
    {
       
        public ScanPage()
        {             
            this.OnScanResult += (result) =>
            {
                this.IsScanning = false;

                Device.BeginInvokeOnMainThread(async () =>
                {
                    var navigationParams = new NavigationParameters
                    {
                        { "BarcodeResult", result.Text }
                    };

                    await Application.Current.MainPage.Navigation.PopAsync(true);
                });
            };
            InitializeComponent();
        }
    }
}

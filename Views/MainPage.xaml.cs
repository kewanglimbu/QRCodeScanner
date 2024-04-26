using QRScan.ViewModels;
using ZXing.Net.Maui;

namespace QRScan.Views
{
    public partial class MainPage : ContentPage
    {
        private bool _IsAlertDisplayed = false;

        public MainPage( )
        {
            InitializeComponent();
            BindingContext = new MainViewModel();

            cameraBarcodeReaderView.Options = new BarcodeReaderOptions
            {
                Formats = BarcodeFormats.All,
                AutoRotate = true,
                Multiple = false
            };
        }

        private async void cameraBarcodeReaderView_BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                if (_IsAlertDisplayed)
                    return;

                _IsAlertDisplayed = true;
                foreach (var barcode in e.Results)
                {
                    await DisplayAlert("QR or Barcode Detected", $"{barcode.Format} {barcode.Value}", "Ok");
                }

                _IsAlertDisplayed = false;
            });
        }
    }
}

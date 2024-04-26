using QRScan.Views;

namespace QRScan
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new QrScanTabbedPage());
        }
    }
}

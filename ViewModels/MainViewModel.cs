using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ZXing.Net.Maui;

namespace QRScan.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private CameraLocation _CameraLocation;
        [ObservableProperty]
        private bool _IsScanning;

        public MainViewModel()
        {
            CameraLocation = CameraLocation.Rear;
        }

        [RelayCommand]
        private void FlipCamera()
        {
            CameraLocation = CameraLocation == CameraLocation.Rear ? CameraLocation.Front : CameraLocation.Rear;
        }
    }
}

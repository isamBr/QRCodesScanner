using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation;
using QRCodesScanner.Dependency;
using QRCodesScanner.iOS.Dependency;
using UIKit;
using Xamarin.Forms;
using ZXing.Mobile;

[assembly: Dependency(typeof(QrScanningService))]
namespace QRCodesScanner.iOS.Dependency
{
    public class QrScanningService : IQrScanningService
    {
        public async Task<string> ScanAsync()
        {

            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Scan the QR Code",
                BottomText = "Please Wait",
            };

            var scanResult = await scanner.Scan(optionsCustom);
            return scanResult.Text;
        }
    }
}
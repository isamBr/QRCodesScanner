using QRCodesScanner.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QRCodesScanner
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
           
            InitializeComponent();
        }

        private async void btnScan_Clicked(object sender, EventArgs e)
        {
            /* var scanner = new ZXing.Mobile.MobileBarcodeScanner();

            var result = await scanner.Scan();

            if (result != null)
                txtBarcode.Text = result.ToString();
                */
            try
            {
                var scanner = DependencyService.Get<IQrScanningService>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    txtBarcode.Text = result;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

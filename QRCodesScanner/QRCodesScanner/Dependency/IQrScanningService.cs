using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QRCodesScanner.Dependency
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QrCodeApp.Interfaces
{
    public interface IUrlShortenerService
    {
        Task<string> ShortenUrlAsync(string url);
    }
}

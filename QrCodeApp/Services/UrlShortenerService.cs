using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading.Tasks;
using QrCodeApp.Interfaces;

namespace QrCodeApp.Services
{
    public class UrlShortenerService : IUrlShortenerService
    {
        public async Task<string> ShortenUrlAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"https://is.gd/create.php?format=simple&url={System.Uri.EscapeDataString(url)}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}

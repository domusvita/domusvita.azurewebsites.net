using domusvita.azurewebsites.net.Models.NationalParks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace domusvita.azurewebsites.net.Controllers
{
    public class NationalParksController : Controller
    {
        public async Task<IActionResult> Index(int pageNumber = 0)
        {
            int parkStartIndex = pageNumber * 50;
            HttpClient client = new HttpClient();
            Uri fullUri = new($"https://developer.nps.gov/api/v1/parks?start={parkStartIndex}&api_key=yayderadTDHqJI7MUnfH3UqA4Lsb4LTvIVbnC5fc");

            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Get, fullUri);
            HttpResponseMessage httpResponse = await client.SendAsync(httpRequest).ConfigureAwait(false);

            HttpContent content = httpResponse.Content;
            string body = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);

            NationalParksApiResponse<Parks> apiResponse = JsonConvert.DeserializeObject<NationalParksApiResponse<Parks>>(body);
            apiResponse.Start = pageNumber.ToString();
            return View(apiResponse);
        }

        [Route("NationalParks/Details/{parkCode}")]
        public async Task<IActionResult> Details(string parkCode)
        {
            HttpClient client = new HttpClient();
            Uri fullUri = new Uri("https://developer.nps.gov/api/v1/parks?api_key=yayderadTDHqJI7MUnfH3UqA4Lsb4LTvIVbnC5fc&parkCode=" + parkCode);

            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Get, fullUri);
            HttpResponseMessage httpResponse = await client.SendAsync(httpRequest).ConfigureAwait(false);

            string body = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            NationalParksApiResponse<Parks>? apiResponse = string.IsNullOrEmpty(body) ? new NationalParksApiResponse<Parks>() : JsonConvert.DeserializeObject<NationalParksApiResponse<Parks>>(body);

            return View(apiResponse);
        }
    }
}

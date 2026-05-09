using Newtonsoft.Json;
using Sysprog1.Models;

namespace Sysprog1.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public const string PastUrl = "https://api.spacexdata.com/v5/launches/past";
        public const string UpcomingUrl = "https://api.spacexdata.com/v5/launches/upcoming";

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Sinhrono preuzimanje - bezbedno za poziv iz dedicated worker niti
        public List<LaunchSummary> FetchLaunches(string url)
        {
            using var request = new HttpRequestMessage(HttpMethod.Get, url);
            using var response = _httpClient.Send(request);

            if (!response.IsSuccessStatusCode)
                throw new Exception($"SpaceX API greška: {response.ReasonPhrase}");

            using var reader = new StreamReader(response.Content.ReadAsStream());
            string body = reader.ReadToEnd();

            return JsonConvert.DeserializeObject<List<LaunchSummary>>(body) ?? new List<LaunchSummary>();
        }
    }
}

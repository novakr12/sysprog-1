using Newtonsoft.Json;

namespace Sysprog1.Models
{
    public class LaunchLinks
    {
        [JsonProperty("webcast")]
        public string? Webcast { get; set; }

        [JsonProperty("wikipedia")]
        public string? Wikipedia { get; set; }

        [JsonProperty("article")]
        public string? Article { get; set; }
    }

    public class LaunchSummary
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("date_utc")]
        public DateTime DateUtc { get; set; }

        [JsonProperty("success")]
        public bool? Success { get; set; }

        [JsonProperty("flight_number")]
        public int FlightNumber { get; set; }

        [JsonProperty("rocket")]
        public string? Rocket { get; set; }

        [JsonProperty("launchpad")]
        public string? Launchpad { get; set; }

        [JsonProperty("details")]
        public string? Details { get; set; }

        [JsonProperty("upcoming")]
        public bool Upcoming { get; set; }

        [JsonProperty("links")]
        public LaunchLinks? Links { get; set; }
    }
}

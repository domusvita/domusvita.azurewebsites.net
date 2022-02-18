using Newtonsoft.Json;

namespace domusvita.azurewebsites.net.Models.NationalParks;

public class EmailAddress
{
    [JsonProperty(PropertyName = "emailAddress")]
    public string Address { get; set; }

    public string Description { get; set; }
}
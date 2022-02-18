using Newtonsoft.Json;

namespace domusvita.azurewebsites.net.Models.NationalParks;

public class PhoneNumber
{
    [JsonProperty(PropertyName = "phoneNumber")]
    public string Number { get; set; }

    public string Description { get; set; }

    public string Extension { get; set; }

    public string Type { get; set; }
}
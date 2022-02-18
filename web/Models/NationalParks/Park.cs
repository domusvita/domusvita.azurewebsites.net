namespace domusvita.azurewebsites.net.Models.NationalParks;

public class Park
{
    public string ParkCode { get; set; }

    public string FullName { get; set; }

    public string Description { get; set; }

    public string DirectionsInfo { get; set; }

    public List<Address> Addresses { get; set; }

    public Images Images { get; set; }

    public string WeatherInfo { get; set; }

    public Contact Contacts { get; set; }
}
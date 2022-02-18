namespace domusvita.azurewebsites.net.Models.NationalParks;

public class NationalParksApiResponse<T>
{
    public string Total { get; set; }

    public T Data { get; set; }

    public string Limit { get; set; }

    public string Start { get; set; }
}
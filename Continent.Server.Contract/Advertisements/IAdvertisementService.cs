namespace Continent.Server.Contract.Advertisements
{
    public interface IAdvertisementService
    {
        CreateAdvertisementResponse CreateAdvertisement(CreateAdvertisementRequest request);
    }
}

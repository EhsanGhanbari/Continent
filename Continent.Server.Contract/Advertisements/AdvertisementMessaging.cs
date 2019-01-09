namespace Continent.Server.Contract.Advertisements
{
    public class CreateAdvertisementRequest
    {
        internal AdvertisementViewModel AdvertisementViewModel { get; set; }

        public CreateAdvertisementRequest(AdvertisementViewModel advertisementViewModel)
        {
            AdvertisementViewModel = advertisementViewModel;
        }
    }

    public class CreateAdvertisementResponse : BaseResponse
    {
    }

    public class GetAdvertisementRequest
    {

    }

    public class GetAdvertisementResponse : BaseResponse
    {
        public AdvertisementViewModel Advertisement { get; set; }
    }
}

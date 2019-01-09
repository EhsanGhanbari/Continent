using Continent.Server.DataAccess.Advertisements;
using Continent.Server.Model.Advertisements;

namespace Continent.Server.Business.Advertisements
{
    public class AdvertisementBusiness : BusinessBase<AdvertisementRepository>
    {
        public void AddAdvertisement(Advertisement advertisement)
        {
            Data.Add(advertisement);
        }

        public Advertisement GetAdvertisementInDetail()
        {
            return Data.GetAdvertisementInDetail();
        }
    }
}

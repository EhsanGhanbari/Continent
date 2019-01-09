using System;
using Continent.Server.Model.Advertisements;

namespace Continent.Server.DataAccess.Advertisements
{
    public class AdvertisementRepository : BaseRepository<Advertisement, Guid>
    {
        public Advertisement GetAdvertisementInDetail()
        {
            // return Context
            return new Advertisement();
        }
    }
}

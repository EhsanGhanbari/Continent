using System;
using Continent.Server.Business.Advertisements;
using Continent.Server.Model.Advertisements;

namespace Continent.Server.Contract.Advertisements
{
    public class AdvertisementService : IAdvertisementService
    {
        private readonly Lazy<AdvertisementBusiness> _advertisementService = new Lazy<AdvertisementBusiness>(() => new AdvertisementBusiness());

        public CreateAdvertisementResponse CreateAdvertisement(CreateAdvertisementRequest request)
        {
            var response = new CreateAdvertisementResponse();
            
            try
            {
                var advertisement = new Advertisement();// Mapper.Map<AdvertisementViewModel, Advertisement>(request.AdvertisementViewModel);
                _advertisementService.Value.AddAdvertisement(advertisement);
                response.Success = true;
                response.Message = "";
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.Message = "";
            }

            return response;
        }
    }
}

using System.Web.Mvc;
using Continent.Client.Common.Controllers;
using Continent.Server.Contract.Packages;

namespace Continent.Client.MVC.Areas.Administration.Controllers
{
    public class PackageController : BaseController
    {
        private readonly IPackageService _packageService;
        
        public PackageController(IPackageService packageService)
        {
            _packageService = packageService;
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PackageViewModel packageViewModel)
        {
            var request = new CreatePackageRequest(packageViewModel);
            var response = _packageService.CreatePackage(request);
            return JsonResponse(response);
        }
    }
}
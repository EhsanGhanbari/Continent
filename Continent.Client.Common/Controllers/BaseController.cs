using System;
using System.Web.Mvc;
using Continent.Server.Contract;

namespace Continent.Client.Common.Controllers
{
    public class BaseController : Controller
    {
        public JsonResult JsonResponse(BaseResponse response)
        {
            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}

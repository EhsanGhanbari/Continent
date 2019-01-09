using System.Web.Mvc;

namespace Continent.Client.MVC.Areas.Administration
{
    public class AdministrationAreaRegistration : AreaRegistration
    {
        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
               "Administration_default",
               "Administration/{controller}/{action}/{id}",
               new { action = "Index", id = UrlParameter.Optional }
           );
        }

        public override string AreaName
        {
            get
            {
                return "Administration";
            }
        }
    }
}
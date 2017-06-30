using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebUI.IBLL;

namespace WebUI.Controllers
{
 public class AdminFilterController : Controller
    {
        public IUserInfoService iuserinfoservice { get; set; }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            bool Isfiltefr=false;

            if (Request.Cookies["cp1"] != null && Request.Cookies["cp2"] != null)
            {
                var cp1 = Request.Cookies["cp1"].Value;
                var cp2 = Request.Cookies["cp2"].Value;

                var user = iuserinfoservice.LoadEntities(u => u.Username == cp1 && u.Password == cp2).FirstOrDefault();

                if (user != null)
                {
                    Isfiltefr = true;
                }


            }




            if (!Isfiltefr)
            {
                filterContext.HttpContext.Response.Redirect("/ALogin/login");
            }

            base.OnActionExecuting(filterContext);
        }
    }
}

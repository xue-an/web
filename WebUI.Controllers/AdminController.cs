using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebUI.IBLL;
using WebUI.Model;

namespace WebUI.Controllers
{
   public class AdminController: Controller
    {
        public IUserInfoService iuserinfoservice { get; set; }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult addFunshu(ExamTure ex)
        {
            return Content("ok");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.BLL;
using WebUI.IBLL;

namespace WebUI
{

        public abstract class ViewPage<T> : System.Web.Mvc.WebViewPage<T>
        {
        //public UserInfo lgoinUser { get; set; }
              
        protected override void SetViewData(ViewDataDictionary viewData)
            {
            //if (Request.Cookies["sessionId"] != null)
            //{
            //    string memeched = Request.Cookies["sessionId"].Value;
            //    object obj = MemcacheHelper.Get(memeched);
            //    if (obj != null)
            //    {
            //        lgoinUser = SerializerHelper.DeserializeToObject<UserInfo>(obj.ToString());

            //        //ViewBag.loginu = lgoinUser;
            //    }
            //}
    
            //return Json(navts, JsonRequestBehavior.AllowGet);


            base.SetViewData(viewData);
            }

            //protected override void ConfigurePage(WebPageBase parentPage)
            //{
            //    parentPage.Layout = "";


            //    base.ConfigurePage(parentPage);
            //}
            //protected override void InitializePage()
            //{
            //    base.InitializePage();
            //}





        
    }
}
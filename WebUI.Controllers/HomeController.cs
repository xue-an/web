
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebUI.BLL;
using WebUI.Common;
using WebUI.DAL;
using WebUI.DALFtory;
using WebUI.IBLL;
using WebUI.Model;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        // public IUserInfoService Iuserinfoservice { get; set; }

        //var navt = Inavserviceh.LoadEntities(n => n.DelFlag == 0);
        //var navts = (from u in navt select new { u.Id, u.Nname, u.Sort, u.Ntwo_navint }).ToList();
        //    return Json(navts, JsonRequestBehavior.AllowGet);

        public IUserInfoService iuserinfoservice { get; set; }
        

        public ActionResult Index()
        {
            //ViewData["u"] = iuserinfoservice.LoadEntities(u => true).ToList();

            return View();
        }
        public ActionResult loger(string e,string p) {
            if (e == "www@qq.com" && p == "123")
            {
                return Content("ok");
            }
            else {
                return Content("no");
            }

        }
        //public ActionResult dele(int id)
        //{


        //    return View("Index");
        //}


           

        public ActionResult hello()
        {
            user s = new user();
            s.mail = "94";
            s.name = "wsk";

            HttpWebRequest request = WebRequest.Create("http://www.decerp.cc/AjaxUser/Retrieve_Password_Dealer") as HttpWebRequest;
            var UserId = "18933478085";
            var Tel = "14.112.214.253";
            byte[] data = Encoding.ASCII.GetBytes("moble=" + UserId + "&sv_user_ip=" + Tel + "&sv_user_cityname=广东省&sv_code=440000");
            request.ContentLength = data.Length;
            request.Method = "post";
            request.ContentType = "application/x-www-form-urlencoded";

            Stream uploadStream = request.GetRequestStream();
            uploadStream.Write(data, 0, data.Length);
            uploadStream.Close();

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8"));
            string html = sr.ReadToEnd().Trim();
            sr.Close();
            response.Close();




            try
            {
                //string md5 = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(UserId + "0" + Tel + key, "MD5");
                //md5 = md5.ToLower();
                HttpWebRequest request = WebRequest.Create("http://221.194.44.133/SMSInterface.php") as HttpWebRequest;
                var UserId1 = "user";
                byte[] data = Encoding.ASCII.GetBytes("UserId=" + UserId1 + "&phone=" + Tel + "&Md5Str=");
                request.ContentLength = data.Length;
                request.Method = "post";
                request.ContentType = "application/x-www-form-urlencoded";

                Stream uploadStream = request.GetRequestStream();
                uploadStream.Write(data, 0, data.Length);
                uploadStream.Close();

                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                string html = sr.ReadToEnd().Trim();
                sr.Close();
                response.Close();
                if (html.Length > 1) // html=='0'电话号码验证失败 ，html=='1' 帐户余额不足 ,html=='2'表示验证没有通过
                {
                    Session["code"] = html;
                    isbool = true;
                }
                else
                {
                    //Response.Write(html);
                    isbool = false;
                }
            }
            catch
            {
                isbool = false;
            }

            //            moble: 18933478085
            //sv_user_ip: 14.112.214.253
            //sv_user_cityname: 广东省
            // sv_code:440000

            return Json(s,JsonRequestBehavior.AllowGet);
        }







    }
    public class user
    {
        public string name { get; set; }
        public string mail { get; set; }
    } 



}

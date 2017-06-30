using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
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



            var isbool2 = false;
            try
            {
               
                //string md5 = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(UserId + "0" + Tel + key, "MD5");
                //md5 = md5.ToLower();
                HttpWebRequest request1 = WebRequest.Create("http://221.194.44.133/SMSInterface.php") as HttpWebRequest;
                var UserId1 = "user";
                byte[] data1 = Encoding.ASCII.GetBytes("UserId=" + UserId1 + "&phone=" + Tel + "&Md5Str=");
                request1.ContentLength = data1.Length;
                request1.Method = "post";
                request1.ContentType = "application/x-www-form-urlencoded";

                Stream uploadStream1 = request1.GetRequestStream();
                uploadStream1.Write(data1, 0, data1.Length);
                uploadStream1.Close();

                HttpWebResponse respons1e = request1.GetResponse() as HttpWebResponse;
                StreamReader ssr = new StreamReader(respons1e.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                string f = ssr.ReadToEnd().Trim();
                ssr.Close();
                respons1e.Close();
                if (f.Length > 1) // html=='0'电话号码验证失败 ，html=='1' 帐户余额不足 ,html=='2'表示验证没有通过
                {
                   
                    isbool2 = true;
                }
                else
                {
                    //Response.Write(html);
                    isbool2 = false;
                }
            }
            catch(Exception ex)
            {
               
                isbool2 = false;
            }

        }
    }
}

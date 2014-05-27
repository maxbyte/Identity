using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace New.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string userName = tbxUserName.Text;
            //string userPass = tbxUserPass.Text;
            //IUcClient iu = new UcClient();
            //UcUserLogin ul = iu.UserLogin(userName, userPass);
            //if (ul.Success)
            //{
            //    var js = iu.UserSynlogin(ul.Uid);
            //    Response.Write(js);
            //}
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
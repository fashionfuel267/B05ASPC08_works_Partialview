using B05ASPC08_w01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace B05ASPC08_w01.Controllers
{
    public class HomeController : Controller
    {
        Dbclient db = new Dbclient();
        public ActionResult Index(int? id)
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [ChildActionOnly]
        public ActionResult RenderClient()
        {
            var model =db.Clients.OrderBy(c=>c.Name).ToList();
            return PartialView(model);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
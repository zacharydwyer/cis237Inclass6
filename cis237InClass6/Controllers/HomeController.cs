using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cis237InClass6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //I added this call to add "SomethingElse" to the View Bag
            //the ViewBag is a way to send data to the view.
            ViewBag.SomethingElse = "SomethingElse";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Added this Method. Because of the default route, it will
        //get called if I point the browser to /Home/Foo
        public ActionResult Foo()
        {
            //Content is a class that implements ActionResult so we can return it.
            //Content just returnes some text. Nothing fancy.
            //return Content("This is my page");

            //Going to return a new view that we make
            return View();
        }
    }
}
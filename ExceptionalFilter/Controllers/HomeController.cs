using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionalFilter.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        // GET: Home
        //[HandleError]
        public ActionResult Index()
        {
            //int a = 10;
            //int b = 0;
            //int c = a / b;

            //string a = null;
            //int b = a.Length;

            //int[] a = new int[3];
            //a[0] = 11;
            //a[1] = 12;
            //a[2] = 13;
            //a[3] = 15;
            //try
            //{
            //    throw new Exception();
            //}catch(Exception ex)
            //{
            //    return RedirectToAction("ErrorPage", "Home");
            //}

            throw new Exception();
            return View();
        }
        //[HandleError]
        public ActionResult About()
        {
            throw new Exception();
            return View();
        }
        public ActionResult ErrorPage()
        {
            return View();
        }
    }
}
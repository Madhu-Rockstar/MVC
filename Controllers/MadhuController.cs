using MadhuMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MadhuMVC.Controllers
{
    public class MadhuController : Controller
    {
        // GET: Madhu
        public ActionResult Index()
        {
            return View();
        }
        public string display()
        {
            return "Hello, Welcome to my god phani world";
        }
        public Movie dil()
        {
            Movie m = new Movie { id = 1,name ="madhu Rockstar",salary=30000,address="Banglore" };
            return m;
        }
        public int intmadhu()
        {
            return 20;
        }
        public ViewResult dan()
        {
            Movie m = new Movie { id = 99, name = "Ram charan",salary=40000, address="Kolkatha"};
            return View(m);
        }
        public ViewResult database()
        {
            var e = new Database();
            var model = e.getallcust();
            return View(model);
        }
    }
}
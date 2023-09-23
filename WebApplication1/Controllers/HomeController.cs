using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Name = "MD. Shohaibur Rahman";
            ViewBag.Id = "20-42424-1";
            ViewBag.ContactNo = 01882576086 ;
            ViewBag.Email = "shoaibrochi9@gmail.com";
            return View();
        }

        public ActionResult Projects()
        {
            
            return View();
        }
        
        public ActionResult References()
        {
            ViewBag.Ref1 = "DR. MD. MANZURUL HASAN - ";
            ViewBag.Ref1d = "Associate Professor , Computer Science, AIUB";
            ViewBag.Ref2 = "S M ABDULLAH SHAFI - ";
            ViewBag.Ref2d = "Lecturer , Computer Science, AIUB";
            
            return View();
        }

        public ActionResult Education() 
        {

            ViewBag.HscI = "BIAM Model School & College";
            ViewBag.HscY = "2018";
            ViewBag.HscG = "GPA 5.00";
            ViewBag.HscR = "Passed";
            ViewBag.SscI = "BIAM Model School & College";
            ViewBag.SscY = "2016";
            ViewBag.SscG = "GPA 5.00";
            ViewBag.SscR = "Passed";


            return View();

        }

       
    }
}
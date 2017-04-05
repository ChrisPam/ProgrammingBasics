using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private object ressult;

        public ActionResult Index()
        {
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

        public ActionResult Calculate(char letter)
        {
            var word = "ABCA";
            this.ViewBag.letter = letter;
            char[] letters = word.ToCharArray();
            if(letters.Contains(letter))
            {
                ViewBag.result = letter;
            }
            else
            {
                ViewBag.error = "purva chertichka";
            }
            
            return View("Index");
        }
    }
}
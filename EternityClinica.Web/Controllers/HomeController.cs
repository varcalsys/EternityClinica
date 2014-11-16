using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EternityClinica.Web.Models;

namespace EternityClinica.Web.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }       

        #region "Portifolio Demo"

        public ActionResult Portifolio()
        {
            return View();
        }

        public ActionResult Portifolio2()
        {
            return View();
        }

        public ActionResult Portifolio3()
        {
            return View();
        }

        public ActionResult Portifolio4()
        {
            return View();
        }

        public ActionResult PortifolioSingle()
        {
            return View();
        }

        #endregion

        #region "Blog"

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Blog_Alternate()
        {
            return View();
        }

        public ActionResult Blog_Single()
        {
            return View();
        }

        #endregion

        //public ActionResult About()
        //{
            

        //    return View();
        //}

        public ActionResult Service()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Typography()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Partners()
        {
            return View();
        }

        public ActionResult Contact()
        {
           return View(new ContatoViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(ContatoViewModel model)
        {
            return View(new ContatoViewModel());
        }
    }
}
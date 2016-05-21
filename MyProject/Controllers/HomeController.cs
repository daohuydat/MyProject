using MyProjectDBContext.DataAccess;
using MyProjectDBContext.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        AdvisorAccess access = new AdvisorAccess();
        // GET: Home
        public ActionResult Index()
        {
            
            ViewBag.AdvisorDomains = access.GetAllAdvisorDomains();
            return View();
        }

        public ActionResult ChatList(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index","Home");
            }else
            {
                AdvisorDomain domain = access.GetAdvisorDomain(id);
                ViewBag.Advisors = access.GetAdvisorsByDomain(domain);
            
            return View(domain);
            }
        }
    }
}
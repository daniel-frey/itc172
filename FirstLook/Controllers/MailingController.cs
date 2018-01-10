using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstLook.Models;

namespace FirstLook.Controllers
{
    public class MailingController : Controller
    {
        // GET: Mailing
        public ActionResult Index()
        {
            Mailing m1 = new Mailing();
            m1.FirstName = "Dann";
            m1.LastName = "Frey";
            m1.Email = "dann.frey@me.com";

            Mailing m2 = new Mailing();
            m2.FirstName = "Norman";
            m2.LastName = "Mailer";
            m2.Email = "norman.mailer@gmail.com";

            Mailing m3 = new Mailing();
            m3.FirstName = "Steve";
            m3.LastName = "Conger";
            m3.Email = "steve.conger@seattlecolleges.edu";

            List<Mailing> mailings = new List<Mailing>();
            mailings.Add(m1);
            mailings.Add(m2);
            mailings.Add(m3);

            return View(mailings);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_UI_WorkOut.Controllers
{
    public class BeneficiaryController : Controller
    {
        public ActionResult Beneficiaries()
        {
            return View();
        }

        public ActionResult MaritalStatus()
        {
            return View();
        }
    }
}
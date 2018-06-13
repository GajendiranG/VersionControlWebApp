using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebAPI.Models;

namespace MVCWebAPI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            CRUDoperation db = new CRUDoperation();
            List<EmployeeTable> listEmp = db.getData();
            return View(listEmp);
        }
    }
}
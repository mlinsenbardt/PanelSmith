using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PanelSmithDAL.Models;

namespace PanelSmith.Controllers
{
    public class EditorController : Controller
    {
        //
        // GET: /Editor/

        public ActionResult Index()
        {
            Project project = db
            return View();
        }

        public ActionResult Details(int id = 0)
        {
            return View();
        }

    }
}

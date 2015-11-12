using AspNetMvcCms.DAL;
using AspNetMvcCms.Entities.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspNetMvcCms.Controllers
{
    public class HomeController: Controller
    {
        CmsContext db = new CmsContext();

        public ActionResult Index()
        {
            PageData page = db.PageDatas.SingleOrDefault();

            return View("Index", page);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAnCoSo.Namespace;
//Khai bao
using DoAnCoSo.Models;

namespace DoAnCoSo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new QUANLYWEBEntities();

            var model = new HomePageViewModel
            {
                sanphambanchay = db.danhsachbanchay(5),
                sanphamyeuthich = db.danhsachyeuthich(5)                                      
            };
            return View(model);
        }
    }

}
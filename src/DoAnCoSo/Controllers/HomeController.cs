using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Khai bao
using DoAnCoSo.Models;

namespace DoAnCoSo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dbContext = new QUANLYWEBEntities();
                var data = dbContext.Database.SqlQuery<SANPHAM>("SELECT * FROM SANPHAM").ToList();
                return View(data);
        }
    }

}
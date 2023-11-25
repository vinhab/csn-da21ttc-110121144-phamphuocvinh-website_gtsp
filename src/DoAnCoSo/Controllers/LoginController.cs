using DoAnCoSo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnCoSo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult DangNhap()
        {
            var dbContext = new QUANLYWEBEntities();
            var data = dbContext.Database.SqlQuery<USER>("SELECT * FROM [USER]").ToList();
            return View(data);
        }
    }
}
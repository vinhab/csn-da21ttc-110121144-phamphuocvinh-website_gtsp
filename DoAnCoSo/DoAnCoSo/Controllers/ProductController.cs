using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAnCoSo.Models;
namespace DoAnCoSo.Controllers
{
    public class ProductController : Controller
    {
        QUANLYWEBEntities db = new QUANLYWEBEntities();
        // GET: Product
        public ActionResult Detail(int Id)
        {
            var data2 = db.Database.SqlQuery<SANPHAM>("SELECT * FROM SANPHAM").ToList();
            ViewBag.sp = data2;
            var data = db.SANPHAMs.Where(n => n.ID == Id).FirstOrDefault();
            return View(data);
        }
    }
}
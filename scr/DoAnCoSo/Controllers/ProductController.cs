using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using DoAnCoSo.Models;
using DoAnCoSo.Namespace;
using Microsoft.Ajax.Utilities;

namespace DoAnCoSo.Controllers
{
    public class ProductController : Controller
    {
        QUANLYWEBEntities db = new QUANLYWEBEntities();
        // GET: Product
        public ActionResult allProduct(string i)
        {
            var sps = db.SANPHAMs.ToList();
              switch (i)
            {
                case "Giá thấp đến cao":
                    sps = sps.OrderBy(p => p.GiaBan).ToList();
                    break;
                case "Giá cao đến thấp":
                    sps = sps.OrderByDescending(p => p.GiaBan).ToList();
                    break;
                default:

                    sps = sps.OrderBy(p => p.GiaBan).ToList();
                    break;
            }
            return View(sps);
        }
        public ActionResult Detail(int Id)
        {
            var product = db.SANPHAMs.FirstOrDefault(p => p.ID == Id);
            if (product == null)
            {
                // Trả về trang 404 Not Found nếu không tìm thấy sản phẩm
                return HttpNotFound();
            }
            var relatedProducts = db.SANPHAMs
                .Where(p => p.ID != Id)
                .Take(5) // Lấy 5 sản phẩm khác
                .ToList();
            // Gửi dữ liệu đến View thông qua ViewBag
            ViewBag.Product = product;
            ViewBag.RelatedProducts = relatedProducts;
            return View();
        }

        public ActionResult themdon(int Id)
        {
            var Product = db.SANPHAMs.FirstOrDefault(p => p.ID == Id);
            if (Product == null)
            {
                // Trả về trang 404 Not Found hoặc xử lý theo ý của bạn nếu không tìm thấy sản phẩm
                return HttpNotFound();
            }
            // Truyền thông tin sản phẩm đến view
            ViewBag.Product = Product;
            ViewBag.Gia = Product.GiaBan.Value;
            ViewBag.ID = Product.ID;
            return View();
        }
        [HttpPost]
        public ActionResult themdon(DATHANG d)
        {
            db.DATHANGs.Add(d);
            db.SaveChanges();
            return View();
        }

    }


 }

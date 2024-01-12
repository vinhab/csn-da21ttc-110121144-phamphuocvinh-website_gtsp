using DoAnCoSo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnCoSo.Namespace
{
    public class HomePageViewModel
    {
        public List<SANPHAM> sanphambanchay { get; set; }
        public List<SANPHAM> sanphamyeuthich { get; set; }
        // Các thuộc tính khác có thể được thêm vào nếu cần
    }
}
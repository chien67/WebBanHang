using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Areas.Admin.Controllers
{
    public class NewsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/News
        public ActionResult Index()
        {
            var item= db.News.OrderByDescending(x=>x.Id).ToList();
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
    }
}
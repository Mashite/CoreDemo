using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.v1=bm.GetList().Count().ToString();
            ViewBag.v2 = bm.GetList().Count(x => x.WriterId == 1).ToString();
            ViewBag.v3 = bm.GetList().Count(x => x.BlogCreateDate >= DateTime.Today.AddDays(-7)).ToString();
            return View(ViewBag);
        }
    }
}

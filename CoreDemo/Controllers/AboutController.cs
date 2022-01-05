using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class AboutController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        AboutManager abm = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            var values = abm.GetList();
            return View(values);
        }

        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }

        public PartialViewResult LastPosts()
        {
            var values=bm.GetLastByCount(5);
            return PartialView(values);
        }
    }
}

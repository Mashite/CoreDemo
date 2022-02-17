using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Blog
{
    public class BlogListDashboard:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = bm.GetListWithCategory().OrderByDescending(x=>x.BlogId).Take(3).ToList();
            return View(values);
        }
    }
}

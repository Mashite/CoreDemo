using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {
        WriterManager rm = new WriterManager(new EfWriterRepository());

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(Writer p)
        {
            Writer w = rm.Login(p.WriterEmail, p.WriterPassword);
            if(w!=null)
            {
                HttpContext.Session.SetString("username", w.WriterEmail);
                return RedirectToAction("Index", "Writer");
            }
            else
            {

                return View();
            }
        }
    }
}

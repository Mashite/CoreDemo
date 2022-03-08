using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
       
        [Authorize]
        public IActionResult Index()
        {
            var username = User.Identity.Name;
            ViewBag.v = username;
            var usermail = wm.WriterByName(username).WriterEmail;
            ViewBag.v2 = usermail;
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }

        public PartialViewResult WriterNavBarPartial()
        {
            return PartialView();
        }

        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var writerValues = wm.GetById(1);
            return View(writerValues);            
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterEditProfile(Writer w)
        {
            WriterValidator validator = new WriterValidator();
            ValidationResult vr = validator.Validate(w);
            if(vr.IsValid)
            {
                wm.Update(w);
                return RedirectToAction("Index", "Dashboard");

            }
            else
            {
                foreach(var item in vr.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if(p!=null)
            {
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/writer/WriterImageFile/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.WriterImage.CopyTo(stream);
                w.WriterImage = newImageName;
            }
            w.WriterName = p.WriterName;
            w.WriterEmail = p.WriterEmail;
            w.WriterPassword = p.WriterPassword;
            w.WriterAbout = p.WriterAbout;
            w.WriterStatus = p.WriterStatus;
            wm.Update(w);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}

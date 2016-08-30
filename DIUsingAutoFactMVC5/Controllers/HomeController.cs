using DIUsingAutoFactMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIUsingAutoFactMVC5.Controllers
{
    public class HomeController : Controller
    {
        private IServiceBlog _blogService;

        //DI
        public HomeController(IServiceBlog blogService)
        {
            _blogService = blogService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //without DI
        //public ActionResult Blog()
        //{
        //    BlogService blogService = new BlogService();
        //    Blog blog = blogService.GetBlog();
        //    return View(blog);
        //}

        public ActionResult Blog()
        {            
            Blog blog = _blogService.GetBlog();
            return View(blog);
        }
    }
}
using Cloudhostica.BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace Cloudhostica.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = "Book Store - Home Page";
            dynamic data = new ExpandoObject();
            data.Id = 1;
            data.Name="Sharath";
            ViewBag.Data = data;
            ViewBag.Type = new BookModel() { Id = 5, Author = "This is Author" };
            ViewData["property1"] = "Sharath Raj";
            return View();
        }

        public ViewResult AboutUs()
        {
            ViewBag.Title = "Book Store - About Us";
            return View();
        }

        public ViewResult ContactUs()
        {
            ViewBag.Title = "Book Store - Contact Us";
            return View();
        }
    }
}

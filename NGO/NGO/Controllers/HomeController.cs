using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NGO.Models;
using NGO.Models.ViewModel;
namespace NGO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult AboutUs()
=> View(new ListViewModel
{

});
        public ViewResult Blog()
=> View(new ListViewModel
{

});
        public ViewResult Causes()
=> View(new ListViewModel
{

});
        public ViewResult Contact()
=> View(new ListViewModel
{

});
        public ViewResult Donate()
=> View(new ListViewModel
{

});
        public ViewResult Events()
=> View(new ListViewModel
{

});
        public ViewResult Gallery()
=> View(new ListViewModel
{

});

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

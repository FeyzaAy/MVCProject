using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebProject.Models;
using System.Data.SqlClient;
using BusinessDAL;

namespace WebProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public   IActionResult Index()
        {
            HomeModel homeModel = new HomeModel();
            ServiceHelper serviceHelper = new ServiceHelper();
         
        
            var arizalar = serviceHelper.ArizaGetir();
            

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
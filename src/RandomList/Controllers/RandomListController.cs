using Microsoft.AspNetCore.Mvc;
using RandomList.Models;


namespace RandomList.Controllers
{
    public class RandomListController : Controller
    {
        private static readonly RandomData rnd = new RandomData(10000);
        
        public IActionResult Index()
        {
            return View();
        }

        // Generate a list of random numbers and display it on Create page
        public IActionResult Create()
        {
            rnd.SortRandomData();            
            return View(rnd);
        }
        // Render About page
        public IActionResult About()
        {
            return View();
        }        
    }
}

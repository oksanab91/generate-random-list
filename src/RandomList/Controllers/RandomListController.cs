using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomList.Models;
using System.Security.Cryptography;


namespace RandomList.Controllers
{
    public class RandomListController : Controller
    {
        private static readonly RandomData rnd = new RandomData(10000);
        
        public IActionResult Index()
        {
            return View();
        }



        //public static int GetRandomNumber(int min, int max)
        //{
        //    lock (syncLock)
        //    { // synchronize
        //        return getrandom.Next(min, max);
        //    }
        //}

        //public static int GetRandomNumber2(int min, int max)
        //{
        //    rngCsp = System.Security.Cryptography.RandomNumberGenerator.Create();

        //    //using (RNGCryptoServiceProvider rg = new RNGCryptoServiceProvider())
        //    //{
        //    //    byte[] rno = new byte[5];
        //    //    rn.GetBytes(rno);
        //    //    int randomvalue = BitConverter.ToInt32(rno, 0);
        //    //}

        //    return 0;
        //}

        // Generate the list of random numbers
        public IActionResult Create()
        {
            int[] result = rnd.SortRandomData();
            
            return View(rnd);
        }

        public IActionResult About()
        {
            //ViewData["Message"] = "Your application description page.";

            return View();
        }        
    }
}

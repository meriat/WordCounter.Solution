using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
    public class CounterController : Controller
    {
        [HttpGet("/counter")]
        public ActionResult Index()
        {
             return View();
        }

        [HttpPost("/counter")]
        public ActionResult Result()
        {   
            WordChecker newWord = new WordChecker(Request.Form["input"],Request.Form["inputList"]);
            return View("Result",newWord);

        }
    }
}
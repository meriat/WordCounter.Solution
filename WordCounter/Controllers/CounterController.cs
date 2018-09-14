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
            string wordHolder = Request.Form["input"];
            string sentenceHolder = Request.Form["inputList"];
            // List <string> inputList = new List<string> {"hey","hello"};
            WordChecker newWord = new WordChecker(wordHolder,sentenceHolder);

            return View("Result",newWord);

        }
    }
}
using GetVerses.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http.Headers;

namespace GetVerses.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            int STARTING_NUMBER_OF_VERSES = 10;

            VerseModel verses = new VerseModel();

            verses.PageSize = STARTING_NUMBER_OF_VERSES;

            return View(verses);
        }

        [HttpPost]
        public async Task<IActionResult> Index(VerseModel verses)
        {
            if(ModelState.IsValid)
            { 
                VerseBusinessLogic verseBusinessLogic = new VerseBusinessLogic();
                verses = await verseBusinessLogic.fetchVerses(verses);
            }

            return View(verses);
        }

        [HttpPost("/AddFavorite")]
        public string AddFavorite(string id, string verse, string imageLink)
        {
            string result = "success";

            VerseBusinessLogic verseBusinessLogic = new VerseBusinessLogic();
            verseBusinessLogic.addFavorite(id, verse, imageLink);

            return result;
        }

        [HttpGet("/MyFavorites")]
        public IActionResult MyFavorites()
        {
            VerseModel verses = new VerseModel();
            VerseBusinessLogic verseBusinessLogic = new VerseBusinessLogic();
            verses = verseBusinessLogic.getFavorites();

            return View(verses);
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

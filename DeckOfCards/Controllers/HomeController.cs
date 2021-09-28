using DeckOfCards.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace DeckOfCards.Controllers
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

        public async Task<IActionResult> NewDeck(string deck_id)
        {
            string domain = "https://deckofcardsapi.com";
            string path = $"/api/deck/x0fhrx0jli2h/draw/?count=5";
            //Need to store deck_id in variable
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(domain);

            var connection = await client.GetAsync(path);
            Root result = await connection.Content.ReadAsAsync<Root>();
            return View(result);
        }

       
        //Generate a new deck of cards, capture the deck ID returned


        //Draw 5 cards from the deck and display their names and images inside a ciew


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

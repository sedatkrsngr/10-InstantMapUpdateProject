using InstantMapUpdateProject.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InstantMapUpdateProject.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public  IActionResult Index()
        {

            //var client = new MongoClient("mongodb://mobilhastanem:LA0osGIjo8E5f5JT@cluster0-shard-00-00.sqbuu.mongodb.net:27017,cluster0-shard-00-01.sqbuu.mongodb.net:27017,cluster0-shard-00-02.sqbuu.mongodb.net:27017/mh_log?ssl=true&replicaSet=atlas-m6behr-shard-0&authSource=admin&retryWrites=true&w=majority");
            //var database = client.GetDatabase("mh_chat");

            //var collection = database.GetCollection<ChatRoom>("chatrooms");

            //var data = collection.AsQueryable();

            //var list = data.ToList();

            return View();
        }
        public IActionResult Index2()
        {
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

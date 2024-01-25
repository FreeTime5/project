using collections.constants;
using collections.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using System.Diagnostics;
using collections.Services.ThemeManager;
using collections.Services.ThemeManager.DefaultThemeManager;
using collections.Services.CollectionManager;
using System.Reflection.Metadata.Ecma335;
using collections.Services.CollectionManager.DefaultCollectionManager;

namespace collections.Controllers
{
    public class HomeController : Controller
    {
        public IThemeManager ThemeManager { get; } = new ThemeManager();
        public ICollectionManager CollectionManager { get; } = new CollectionManager();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Theme(int id)
        {
            var collectoins = CollectionManager.FindCollectionByTheme(id);
            var themeModel = new ThemeViewModel(collectoins);
            return View(themeModel);
        }

        public IActionResult Index()
        {
            var indexModel = new IndexViewModel(CollectionManager, ThemeManager);
            return View(indexModel);
        }

        public IActionResult CreateCollection()
        {
            return View("Index", new IndexViewModel(null, null));
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

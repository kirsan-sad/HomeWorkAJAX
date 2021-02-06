using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AJAX.WEB.Models;
using AJAX.BL.Interfaces;
using AJAX.DAL.ModelsDAL;
using AJAX.BL.ModelsBl;

namespace AJAX.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositoryGetShop _repositoryGetShop;


        public HomeController(ILogger<HomeController> logger, IRepositoryGetShop repositoryGetShop)
        {
            _logger = logger;
            _repositoryGetShop = repositoryGetShop;
        }

        public IActionResult Index()
        {
            ICollection<ShopBL> shopResult = _repositoryGetShop.GetAllShop(); ;

            return View(shopResult);
        }

        public IActionResult Description(int? id)
        {
            var shopById = _repositoryGetShop.GetShopById(id);
            return PartialView(shopById);
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

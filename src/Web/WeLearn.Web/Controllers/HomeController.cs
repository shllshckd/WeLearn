﻿// <auto-generated />
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeLearn.Services.Interfaces;
using WeLearn.Web.ViewModels;
using WeLearn.Web.ViewModels.Home;

namespace WeLearn.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInformationService _informationService;

        public HomeController(IInformationService informationService)
            => this._informationService = informationService;

        public IActionResult Index()
        {
            IndexViewModel model = this._informationService.GenerateIndexViewModel();
            return this.View(model);
        }

        public IActionResult FAQ()
        {
            FrequentQuestionsViewModel model = this._informationService.GenerateFrequentQuestionsViewModel();
            return this.View(model);
        }

        public IActionResult Privacy() => this.View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
            => this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

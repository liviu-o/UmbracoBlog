using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Core.Models.PublishedContent;
using MyUmbraco.Core.ViewModel.Base;
using MyUmbraco.Core.ViewModel.Blocks;
using Umbraco.Cms.Web.Common.PublishedModels;
using MyUmbraco.Core.ViewModel.Page;
using MyUmbraco.Core.Interfaces;

namespace MyUmbraco.Core.Controller
{
    public class HomePageController : RenderController
    {
        private readonly IPublishedValueFallback _publishedValueFallback;
        public HomePageController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine,
            IUmbracoContextAccessor umbracoContextAccessor, IPublishedValueFallback publishedValueFallback)
        : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
            _publishedValueFallback = publishedValueFallback;
        }
        public override IActionResult Index()
        {

            var home = new HomePage(CurrentPage, _publishedValueFallback);

            return View("~/Views/HomePage.cshtml", home);
        }
    }
}

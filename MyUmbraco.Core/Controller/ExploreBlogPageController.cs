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
    public class ExploreBlogPageController : RenderController
    {
        private readonly IPublishedValueFallback _publishedValueFallback;
        private readonly IBlogService _blogService;
        public ExploreBlogPageController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine,
            IUmbracoContextAccessor umbracoContextAccessor, IPublishedValueFallback publishedValueFallback, IBlogService blogService)
        : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
            _publishedValueFallback = publishedValueFallback;
            _blogService = blogService;
        }
        public IActionResult ExploreBlogPage()
        {

            var exploreBlogPage = new ExploreBlogPage(CurrentPage, _publishedValueFallback);
            var pages = _blogService.GetPageByName(exploreBlogPage.Name);

            var viewModel = new ComposedPageViewModel<ExploreBlogPage, ExploreBlogPageViewModel>
            {
                Page = exploreBlogPage,
                ViewModel = new ExploreBlogPageViewModel
                {
                    ExploreBlogDetailPages = pages
                }
            };
            return View("~/Views/ExploreBlogPage.cshtml", viewModel);
        }
    }
}

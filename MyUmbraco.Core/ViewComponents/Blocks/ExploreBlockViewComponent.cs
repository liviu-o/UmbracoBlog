using Microsoft.AspNetCore.Mvc;
using MyUmbraco.Core.Interfaces;
using MyUmbraco.Core.ViewModel.Base;
using MyUmbraco.Core.ViewModel.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace MyUmbraco.Core.ViewComponents.Blocks
{
    public class exploreBlockViewComponent : ViewComponent
    {
        private IPublishedValueFallback _publishedValueFallback;
        private IExploreService _exploreService;

        public exploreBlockViewComponent(IPublishedValueFallback publishedValueFallback, IExploreService exploreService)
        {
            _publishedValueFallback = publishedValueFallback;
            _exploreService = exploreService;
        }

        public async Task<IViewComponentResult> InvokeAsync(IPublishedElement model)
        {
            var exploreBlock = new ExploreBlock(model, _publishedValueFallback);
            var viewModel = new PublishedElementViewModel<ExploreBlock, ExploreBlockViewModel>
            {
                Block = exploreBlock,
                ViewModel = new ExploreBlockViewModel
                {
                    Page = _exploreService.GetPageById(exploreBlock.ExploreDetailPage.Id)
                }
            };
            return View(viewModel);
        }
    }
}
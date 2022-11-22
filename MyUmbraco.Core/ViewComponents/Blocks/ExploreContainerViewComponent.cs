using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace MyUmbraco.Core.ViewComponents.Blocks
{
    public class exploreContainerViewComponent : ViewComponent
    {
        private IPublishedValueFallback _publishedValueFallback;
        public exploreContainerViewComponent(IPublishedValueFallback publishedValueFallback)
        {
            _publishedValueFallback = publishedValueFallback;
        }

        public async Task<IViewComponentResult> InvokeAsync(IPublishedElement model)
        {
            var exploreContainer = new ExploreContainer(model, _publishedValueFallback);
            return View(exploreContainer);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using MyUmbraco.Core.ViewModel.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace MyUmbraco.Core.ViewComponents.Blocks
{
    public class blogHeaderViewComponent : ViewComponent
    {
        private IPublishedValueFallback _publishedValueFallback;
        public blogHeaderViewComponent(IPublishedValueFallback publishedValueFallback)
        {
            _publishedValueFallback = publishedValueFallback;
        }

        public async Task<IViewComponentResult> InvokeAsync(IPublishedElement model)
        {
            var blog = new BlogHeader(model, _publishedValueFallback);
            return View(blog);
        }
    }


}
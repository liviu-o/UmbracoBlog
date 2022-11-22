using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyUmbraco.Core.Interfaces;
using MyUmbraco.Core.ViewModel.Layouts;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Extensions;

namespace MyUmbraco.Core.ViewComponents.Layouts
{
    public class NavigationViewComponent : ViewComponent
    {
        private IUmbracoContextAccessor _context;
        private IPublishedValueFallback _publishedValueFallback;
        private IMenuService _menuService;
        public NavigationViewComponent(IUmbracoContextAccessor context, IPublishedValueFallback publishedValueFallback, IMenuService menuService)
        {
            _context = context;
            _publishedValueFallback = publishedValueFallback;
            _menuService = menuService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var navigation = new NavigationViewModel()
            {
                MainNavigation = _menuService.MainNavigation,
                SecondNavigation = _menuService.SecondNavigation,
                ThirdNavigation = _menuService.ThirdNavigation

            };


           return View(navigation);
        }
    }

     
}
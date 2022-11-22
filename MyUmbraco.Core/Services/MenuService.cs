using MyUmbraco.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Extensions;

namespace MyUmbraco.Core.Services
{
    public class MenuService : IMenuService
    {
        private IUmbracoContextAccessor _context;
        private IPublishedValueFallback _publishedValueFallback;

        public MenuService(IUmbracoContextAccessor context, IPublishedValueFallback publishedValueFallback)
        {
            _context = context;
            _publishedValueFallback = publishedValueFallback;
        }

        public IEnumerable<NavigationItem> MainNavigation => GetMainNavigation();

        public IEnumerable<NavigationItem> SecondNavigation => GetSecondNavigation();

        public IEnumerable<NavigationItem> ThirdNavigation => GetThirdNavigation();

        private IEnumerable<NavigationItem> GetMainNavigation()
        {
            var cache = _context.GetRequiredUmbracoContext();
            var home = cache.Content.GetAtRoot().DescendantsOrSelf<HomePage>().First();
            var page = new HomePage(home, _publishedValueFallback);
            return page.MainNavigation;
        }

        private IEnumerable<NavigationItem> GetSecondNavigation()
        {
            var cache = _context.GetRequiredUmbracoContext();
            var home = cache.Content.GetAtRoot().DescendantsOrSelf<HomePage>().First();
            var page = new HomePage(home, _publishedValueFallback);
            return page.SecondNavigation;
        }

        private IEnumerable<NavigationItem> GetThirdNavigation()
        {
            var cache = _context.GetRequiredUmbracoContext();
            var home = cache.Content.GetAtRoot().DescendantsOrSelf<HomePage>().First();
            var page = new HomePage(home, _publishedValueFallback);
            return page.ThirdNavigation;
        }
    }
}

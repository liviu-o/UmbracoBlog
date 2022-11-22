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
    public class BlogService : IBlogService
    {
        private IUmbracoContextAccessor _context;
        private IPublishedValueFallback _publishedValueFallback;

        public BlogService(IUmbracoContextAccessor context, IPublishedValueFallback publishedValueFallback)
        {
            _context = context;
            _publishedValueFallback = publishedValueFallback;
        }

        public IEnumerable<ExploreBlogDetailPage> GetPageByName(string Name)
        {
            var cache = _context.GetRequiredUmbracoContext();
            var home = cache.Content.GetAtRoot().DescendantsOrSelf<HomePage>().First();
            var listing = home.DescendantsOrSelf<ExploreBlogPage>().Where(x => x.Name.StartsWith(Name)).First();
            return listing.Descendants<ExploreBlogDetailPage>();
        }
    }
}

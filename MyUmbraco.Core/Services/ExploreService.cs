using MyUmbraco.Core.Interfaces;
using NPoco;
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
    public class ExploreService : IExploreService
    {
        private IUmbracoContextAccessor _context;
        private IPublishedValueFallback _publishedValueFallback;

        public ExploreService(IUmbracoContextAccessor context, IPublishedValueFallback publishedValueFallback)
        {
            _context = context;
            _publishedValueFallback = publishedValueFallback;
        }

        public ExploreDetailPage GetPageById(int id)
        {
            var cache = _context.GetRequiredUmbracoContext();
            var content = cache.Content?.GetById(id);
            var page = new ExploreDetailPage(content, _publishedValueFallback);
            return page;
        }
    }
}

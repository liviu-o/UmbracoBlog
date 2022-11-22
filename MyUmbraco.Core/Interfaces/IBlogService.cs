using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace MyUmbraco.Core.Interfaces
{
    public interface IBlogService
    {
        public IEnumerable<ExploreBlogDetailPage> GetPageByName(string Name);
    }
}

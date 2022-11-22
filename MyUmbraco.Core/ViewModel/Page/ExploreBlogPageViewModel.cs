using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace MyUmbraco.Core.ViewModel.Page
{
    public class ExploreBlogPageViewModel
    {
        public IEnumerable<ExploreBlogDetailPage> ExploreBlogDetailPages { get; set; }
    }
}

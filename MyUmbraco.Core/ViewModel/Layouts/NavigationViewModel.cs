using System.Collections;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace MyUmbraco.Core.ViewModel.Layouts
{
    public class NavigationViewModel
    {
        public IEnumerable<NavigationItem> MainNavigation {get; set; }
        public IEnumerable<NavigationItem> SecondNavigation { get; set; }
        public IEnumerable<NavigationItem> ThirdNavigation { get; set; }
    }
}
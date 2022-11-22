using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace MyUmbraco.Core.Interfaces
{
    public interface IMenuService
    {
        IEnumerable<NavigationItem> MainNavigation { get;  }
        IEnumerable<NavigationItem> SecondNavigation { get; }
        IEnumerable<NavigationItem> ThirdNavigation { get; }
    }
}

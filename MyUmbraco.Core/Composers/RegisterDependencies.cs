using Microsoft.Extensions.DependencyInjection;
using MyUmbraco.Core.Interfaces;
using MyUmbraco.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace MyUmbraco.Core.Composers
{
    public class RegisterDependencies : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.AddTransient<IExploreService, ExploreService>();
            builder.Services.AddTransient<IBlogService, BlogService>();
            builder.Services.AddTransient<IMenuService, MenuService>();
        }
    }
}

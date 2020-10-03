using Microsoft.Owin;
using Owin;
using System;

[assembly: OwinStartupAttribute(typeof(E_shop_books.Startup))]
namespace E_shop_books
{
     
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

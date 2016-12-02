using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CreditScoreCard.Startup))]
namespace CreditScoreCard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

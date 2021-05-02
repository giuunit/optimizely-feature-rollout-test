using OptimizelySDK;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace OptimizelyFeatureRolloutTest
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static bool EnableMessengerChat { get; private set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //setting up Optimizely
            var optimizelyClient = OptimizelyFactory.NewDefaultInstance(ConfigurationManager.AppSettings["Optimizely:sdkKey"]);
            
            //for the sake of the demo we will test for all users
            EnableMessengerChat = optimizelyClient.IsFeatureEnabled("enable_messenger_chat", "");
        }
    }
}

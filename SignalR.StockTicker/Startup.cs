using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalR.StockTicker.Startup))]

namespace SignalR.StockTicker
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			//ConfigureSignalR(GlobalHost.DependencyResolver, GlobalHost.HubPipeline);
			//app.MapSignalR();
			Microsoft.AspNet.SignalR.StockTicker.Startup.ConfigureSignalR(app);
		}

		//public void ConfigureSignalR(IDependencyResolver dependencyResolver, IHubPipeline hubPipeline)
		//{

		//}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Insite.Catalog.EF;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using Microsoft.AspNetCore.OData.Builder;
using Insite.Catalog.Entities;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.Extensions;
using Insite.Catalog.OData;

namespace Insite.Catalog
{
	public class Startup
	{
		public Startup(IHostingEnvironment env)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
				.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
				.AddEnvironmentVariables();
			Configuration = builder.Build();
		}

		public IConfigurationRoot Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			// Add framework services.
			// services.AddMvc();

			services.AddDbContext<EntityContext>(options => options.UseNpgsql(Configuration.GetConnectionString("Entities")));

			services.AddOData(options => options.RoutingConventions.Insert(0, new CustomRoutingConvention()));	
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			loggerFactory.AddConsole(Configuration.GetSection("Logging"));
			loggerFactory.AddDebug();

			var model = GetEdmModel(app);

			app.UseMvc(builder => builder.MapODataRoute("odata", model));
		}

		private static IEdmModel GetEdmModel(IApplicationBuilder app)
		{

			var provider = app.ApplicationServices.GetRequiredService<IAssemblyProvider>();

			var builder = new ODataConventionModelBuilder(provider);
			builder.EntitySet<Product>("Products");

			return builder.GetEdmModel();
		}
	}
}

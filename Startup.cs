using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using TIMO.Services;
using Microsoft.EntityFrameworkCore.Infrastructure;
using TIMO.data;
using Microsoft.EntityFrameworkCore;

namespace TIMO {
	public class Startup {
		public Startup(IHostingEnvironment env) {
			var builder = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
				.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
				.AddEnvironmentVariables();

			Configuration = builder.Build();
		}

		public IConfigurationRoot Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services) {
			services.AddMvc();
			services.AddEntityFramework().AddEntityFrameworkSqlite().AddDbContext<TimoDbContext>(options => options.UseSqlite("TIMO.db"));
			services.AddScoped<IRelatieService, RelatieService>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory) {
			loggerFactory.AddConsole();

			app.UseDeveloperExceptionPage();
			app.UseStaticFiles();

			app.UseMvc(
				routes => {
					routes.MapRoute(
						name: "default",
						template: "{controller=Home}/{action=Index}/{id?}"
					);
				}
			);
		}
	}
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Models;

namespace HotelAPI
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services
				.AddMvc()
				.AddJsonOptions(
					options => options.SerializerSettings.ReferenceLoopHandling = 
						Newtonsoft.Json.ReferenceLoopHandling.Ignore
				);
			
			services.AddDbContext<HotelContext>(options =>
			{
					options.UseMySql(Configuration.GetConnectionString("RemoteConnection"));
//				options.UseMySql(Configuration.GetConnectionString("LocalConnection"));
			});
			
//			services.AddScoped<IHotelRepository, Optimizations.HotelRepository>();
			services.AddScoped<IHotelRepository, Problems.HotelRepository>();
			
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{	
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseMvc();
		}
	}
}

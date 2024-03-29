/*
 * Ready4Tech API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using IO.Swagger.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace IO.Swagger;

/// <summary>
///     Startup
/// </summary>
public class Startup
{
    private readonly IWebHostEnvironment _hostingEnv;

    /// <summary>
    ///     Constructor
    /// </summary>
    /// <param name="env"></param>
    /// <param name="configuration"></param>
    public Startup(IWebHostEnvironment env, IConfiguration configuration)
    {
        _hostingEnv = env;
        Configuration = configuration;
    }

    private IConfiguration Configuration { get; }

    /// <summary>
    ///     This method gets called by the runtime. Use this method to add services to the container.
    /// </summary>
    /// <param name="services"></param>
    public void ConfigureServices(IServiceCollection services)
    {
        // Add framework services.
        services
            .AddHsts(o => o.MaxAge = TimeSpan.FromDays(365))
            .AddMvc(options =>
            {
                options.InputFormatters.RemoveType<SystemTextJsonInputFormatter>();
                options.OutputFormatters.RemoveType<SystemTextJsonOutputFormatter>();
            })
            .AddNewtonsoftJson(opts =>
            {
                opts.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                opts.SerializerSettings.Converters.Add(new StringEnumConverter(new CamelCaseNamingStrategy()));
            })
            .AddXmlSerializerFormatters();


        services
            .AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Ready4Tech API",
                    Description = "Ready4Tech API (ASP.NET Core 6.0)",
                    Contact = new OpenApiContact
                    {
                        Name = "Swagger Codegen Contributors",
                        Url = new Uri("https://github.com/swagger-api/swagger-codegen"),
                        Email = ""
                    }
                });
                c.CustomSchemaIds(type => type.FullName);
                c.IncludeXmlComments(
                    $"{AppContext.BaseDirectory}{Path.DirectorySeparatorChar}{_hostingEnv.ApplicationName}.xml");

                // Include DataAnnotation attributes on Controller Action parameters as Swagger validation rules (e.g required, pattern, ..)
                // Use [ValidateModelState] on Actions to actually validate it in C# as well!
                c.OperationFilter<GeneratePathParamsValidationFilter>();
            });
    }

    /// <summary>
    ///     This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    /// </summary>
    /// <param name="app"></param>
    /// <param name="env"></param>
    /// <param name="loggerFactory"></param>
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
    {
        app.UseRouting();

        //TODO: Uncomment this if you need wwwroot folder
        // app.UseStaticFiles();

        app.UseAuthorization().UseCors(p => p.AllowAnyOrigin());

        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            //TODO: Either use the SwaggerGen generated Swagger contract (generated from C# classes)
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ready4Tech API");

            //TODO: Or alternatively use the original Swagger contract that's included in the static files
            // c.SwaggerEndpoint("/swagger-original.json", "Ready4Tech API Original");
        });

        //TODO: Use Https Redirection
        // app.UseHttpsRedirection();

        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            //TODO: Enable production exception handling (https://docs.microsoft.com/en-us/aspnet/core/fundamentals/error-handling)
            app.UseExceptionHandler("/Error");

            app.UseHsts();
        }
    }
}
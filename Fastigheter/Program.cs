using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.Authorization;
using Fastigheter.AuthProviders;
using Fastigheter.Data.Services;
using System.Net.Http;
using Microsoft.AspNetCore.Http;

namespace Fastigheter
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddSingleton<HttpClient>();
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            builder.Services.AddSingleton<TokenService>();
            builder.Services.AddScoped<CustomLocalStorageService>();
            builder.Services.AddScoped<AuthenticationStateProvider, TestAuthStateProvider>();
            builder.Services.AddScoped<TestAuthStateProvider>();
            builder.Services.AddSingleton<RealEstateService>();
            builder.Services.AddSingleton<CommentsService>();
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            builder.Services.AddHttpContextAccessor();
           

            await builder.Build().RunAsync();
        }
    }
}

using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
 
namespace MarcDias.Api
{
public class Program
{
public static void Main(string[] args)
{
var host = new WebHostBuilder()
.UseKestrel()
.UseStartup<Program>()
.Build();
host.Run();
}
 
public void ConfigureServices(IServiceCollection services)
{
services.AddMvc();
}
 
public void Configure(IApplicationBuilder app)
{
app.UseMvcWithDefaultRoute();
}
}
}
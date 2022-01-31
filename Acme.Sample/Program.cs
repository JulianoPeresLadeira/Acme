using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices(services => StartupExtensions.RegisterDataAccessServices(services, config));

builder.Build().SeedData().Run();
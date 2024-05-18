using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Katis.Function;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults(builder => {
        builder.UseMiddleware<ExceptionalHandlingMiddleware>();
    })
    .ConfigureFunctionsWebApplication()
    //.ConfigureServices(services => {
    //    services.AddApplicationInsightsTelemetryWorkerService();
    //    services.ConfigureFunctionsApplicationInsights();
    //})
    .Build();

    // MAIN COMMENT

    // Second comment from GitHub

host.Run();





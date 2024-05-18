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

    // Fourth comment from VSCODE

    // Third comment from github

    // Exception handling comments

    // Closing the Exception handling comments

    // Try this again to close the issue

    // RS trying again to close this

    // PUSH AND PULL REQUEST

host.Run();





using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Katis.Function
{
    public class HttpTriggerSample
    {
        private readonly ILogger<HttpTriggerSample> _logger;

        public HttpTriggerSample(ILogger<HttpTriggerSample> logger)
        {
            _logger = logger;
        }

        //[Function("HttpFunction")]
        //public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "walkthrough")] HttpRequest req)
        //{
        //    _logger.LogInformation("C# HTTP trigger function processed a request.");
        //    
        //    return new OkObjectResult("Welcome to Azure Functions!");
        //}

        // [Function("HttpFunctionCurrentTime")]
        // public async Task<HttpResponseData> CurrentTime([HttpTrigger(AuthorizationLevel.Anonymous, "get",  Route = "currenttime")] HttpRequestData req)
        // {
        //     _logger.LogInformation("C# HTTP trigger function processed a request.");

        //     var response = req.CreateResponse();

        //     await response.WriteAsJsonAsync( new { CurrentTime = System.DateTime.Now.ToString() });
            
        //     return response;
        // }

        // TODD: Add Exception Handling

        // MORE COMMENTS

        // Double Comments

        // Tripe comments
        

        // Yuck

        // More yuck

        // PGA Title
        
        [Function("HttpFunctionCurrentTime")]
        public async Task<IActionResult> CurrentTime([HttpTrigger(AuthorizationLevel.Anonymous, "get",  Route = "currenttime")] HttpRequestData req)
        {
            //_logger.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonSerializer.Deserialize<dynamic>(requestBody);
            name = name ?? data?.name;

            return name != null
                ? (ActionResult)new OkObjectResult($"Hello, {name}")
                : new BadRequestObjectResult("Please pass a name on the query string or in the request body");  
        }
    }
}

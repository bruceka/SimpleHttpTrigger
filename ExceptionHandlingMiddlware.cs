using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Middleware;
using Microsoft.Extensions.Logging;

namespace Katis.Function;

internal class ExceptionalHandlingMiddleware : IFunctionsWorkerMiddleware
{
    private readonly ILogger<ExceptionalHandlingMiddleware> _logger;

    public ExceptionalHandlingMiddleware(ILogger<ExceptionalHandlingMiddleware> logger)
    {
        _logger = logger;
    }
    
    public async Task Invoke(FunctionContext context, FunctionExecutionDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            //var logger = context.GetLogger<ExceptionalHandlingMiddleware>();
            //logger.LogError(ex, "An error occurred during the execution of the function.");
            throw;
        }
    }
}

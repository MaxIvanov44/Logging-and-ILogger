using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Logging_and_ILogger
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, ILogger<Program> logger)
        {
            app.Run(async (context) =>
            {
                logger.LogCritical("LogCritical {0}", context.Request.Path);
                logger.LogDebug("LogDebug {0}", context.Request.Path);
                logger.LogError("LogError {0}", context.Request.Path);
                logger.LogInformation("LogInformation {0}", context.Request.Path);
                logger.LogWarning("LogWarning {0}", context.Request.Path);

                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}

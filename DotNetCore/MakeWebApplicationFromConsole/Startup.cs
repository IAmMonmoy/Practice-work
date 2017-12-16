using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ConsoleToWeb
{
    public class StartUp
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(context => {
                    return context.Response.WriteAsync("Welcome monmoy to DotNetCore");
            });
        }
    }
}

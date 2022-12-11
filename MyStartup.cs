using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace new_world_31
{
    public class MyStartup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async context => {
                await context.Response.WriteAsync("New World has started");
            });
        }
    }
}
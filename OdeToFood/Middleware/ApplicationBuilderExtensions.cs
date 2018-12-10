using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace OdeToFood.Middleware
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseNodeModules(
            this IApplicationBuilder applicationBuilder,
            string applicationRootDirectory)
        {
            applicationBuilder.UseStaticFiles(new StaticFileOptions {
                RequestPath = "/node_modules",
                FileProvider = new PhysicalFileProvider(Path.Combine(applicationRootDirectory, "node_modules")),
            });

            return applicationBuilder;
        }
    }
}

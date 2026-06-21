using System.Runtime.CompilerServices;
using TheSampleApi.Data;
//using Scalar.AspNetCore;
namespace TheSampleApi.Startup;

public static class DependenciesConfig
{
    public static void AddDependencies(this WebApplicationBuilder builder)
    {
        builder.Services.AddOpenApiServices();
        builder.Services.AddTransient<CourseData>();
    }
}

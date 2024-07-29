using Duckeebs.Core.Interfaces;
using Duckeebs.Infrastructure;
using Duckeebs.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
      // Add DbContext
      services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite("Data Source=D:\\duckeebs.db"));
      services.AddScoped<ApplicationDbContext, ApplicationDbContext>();

      // Add Repositories
      services.AddScoped<IKeycapRepository, KeycapRepository>();

      return services;
    }
}

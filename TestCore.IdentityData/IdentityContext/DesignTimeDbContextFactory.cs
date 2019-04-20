using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using TestCore.Data.IdentityContext;

namespace TestCore.API
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<IdentityDbContext>
    {
        public IdentityDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<IdentityDbContext>();
            var connectionString = configuration.GetConnectionString("IdentityServer4");
            builder.UseSqlServer(connectionString);
            return new IdentityDbContext(builder.Options);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp
{
    public class DataContext : DbContext
    {
        private readonly IConfigurationRoot _configuration;

        public DataContext(IConfigurationRoot configuration)
        {
            this._configuration = configuration;
        }
        
        public DbSet<RecordEntity> Records { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL(_configuration.GetConnectionString("DataConnection"))
                .EnableSensitiveDataLogging();
        }
    }
}
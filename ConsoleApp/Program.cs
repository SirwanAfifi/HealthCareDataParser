using System;
using System.Globalization;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp
{
    class Program
    {
        public static IConfigurationRoot Configuration;
        static void Main(string[] args)
        {
            var data = ReadXml.LoadRecords("data.xml");
            
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var dbContext = serviceProvider.GetService<DataContext>();
            foreach (var record in data.Records)
            {
                
                dbContext.Records.Add(new RecordEntity
                {
                    Type = Enum.GetName(record.Type.GetType(), record.Type),
                    Unit = Enum.GetName(record.Unit.GetType(), record.Unit),
                    Value = record.Value,
                    SourceName = record.SourceName,
                    SourceVersion = record.SourceVersion,
                    Device = record.Device,
                    CreationDate = StringToDateTimeConverter(record.CreationDate),
                    StartDate = StringToDateTimeConverter(record.StartDate),
                    EndDate = StringToDateTimeConverter(record.EndDate),
                });
                // Console.WriteLine($"CreationDate = {StringToDateTimeConverter(record.CreationDate)}");
                // Console.WriteLine($"StartDate = {StringToDateTimeConverter(record.StartDate)}");
                // Console.WriteLine($"EndDate = {StringToDateTimeConverter(record.EndDate)}");
            }
            dbContext.SaveChanges();
            
        }

        private static DateTime StringToDateTimeConverter(string inputDate)
        {
            const string format = "yyyy-MM-dd HH:mm:ss";
            return DateTime.ParseExact(inputDate.Replace("+0430", "").Trim(), format,
                CultureInfo.InvariantCulture);
        }
        
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>();

            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();
            

            // Add access to generic IConfigurationRoot
            services.AddSingleton<IConfigurationRoot>(Configuration);
        }

    }
}
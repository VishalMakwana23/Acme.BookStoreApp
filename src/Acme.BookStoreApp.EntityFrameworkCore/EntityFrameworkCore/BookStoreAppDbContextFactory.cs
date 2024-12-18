using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.BookStoreApp.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class BookStoreAppDbContextFactory : IDesignTimeDbContextFactory<BookStoreAppDbContext>
{
    public BookStoreAppDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        BookStoreAppEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<BookStoreAppDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new BookStoreAppDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.BookStoreApp.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}

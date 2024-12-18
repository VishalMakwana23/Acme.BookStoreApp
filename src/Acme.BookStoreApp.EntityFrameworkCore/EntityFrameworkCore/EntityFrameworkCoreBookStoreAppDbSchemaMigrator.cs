using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.BookStoreApp.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStoreApp.EntityFrameworkCore;

public class EntityFrameworkCoreBookStoreAppDbSchemaMigrator
    : IBookStoreAppDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBookStoreAppDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BookStoreAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BookStoreAppDbContext>()
            .Database
            .MigrateAsync();
    }
}

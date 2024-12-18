using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStoreApp.Data;

/* This is used if database provider does't define
 * IBookStoreAppDbSchemaMigrator implementation.
 */
public class NullBookStoreAppDbSchemaMigrator : IBookStoreAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

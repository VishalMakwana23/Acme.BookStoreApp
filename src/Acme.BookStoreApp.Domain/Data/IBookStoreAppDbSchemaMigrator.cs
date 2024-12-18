using System.Threading.Tasks;

namespace Acme.BookStoreApp.Data;

public interface IBookStoreAppDbSchemaMigrator
{
    Task MigrateAsync();
}

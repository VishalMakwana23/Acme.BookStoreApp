using Acme.BookStoreApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.BookStoreApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookStoreAppEntityFrameworkCoreModule),
    typeof(BookStoreAppApplicationContractsModule)
)]
public class BookStoreAppDbMigratorModule : AbpModule
{
}

using Volo.Abp.Modularity;

namespace Acme.BookStoreApp;

[DependsOn(
    typeof(BookStoreAppDomainModule),
    typeof(BookStoreAppTestBaseModule)
)]
public class BookStoreAppDomainTestModule : AbpModule
{

}

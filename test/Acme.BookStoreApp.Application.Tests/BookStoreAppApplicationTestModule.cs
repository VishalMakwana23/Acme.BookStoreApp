using Volo.Abp.Modularity;

namespace Acme.BookStoreApp;

[DependsOn(
    typeof(BookStoreAppApplicationModule),
    typeof(BookStoreAppDomainTestModule)
)]
public class BookStoreAppApplicationTestModule : AbpModule
{

}

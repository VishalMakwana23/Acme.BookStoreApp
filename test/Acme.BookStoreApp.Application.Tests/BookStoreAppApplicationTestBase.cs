using Volo.Abp.Modularity;

namespace Acme.BookStoreApp;

public abstract class BookStoreAppApplicationTestBase<TStartupModule> : BookStoreAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

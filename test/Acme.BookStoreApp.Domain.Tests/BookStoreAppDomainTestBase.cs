using Volo.Abp.Modularity;

namespace Acme.BookStoreApp;

/* Inherit from this class for your domain layer tests. */
public abstract class BookStoreAppDomainTestBase<TStartupModule> : BookStoreAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

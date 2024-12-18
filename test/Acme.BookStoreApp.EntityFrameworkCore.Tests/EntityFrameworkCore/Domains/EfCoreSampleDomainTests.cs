using Acme.BookStoreApp.Samples;
using Xunit;

namespace Acme.BookStoreApp.EntityFrameworkCore.Domains;

[Collection(BookStoreAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookStoreAppEntityFrameworkCoreTestModule>
{

}

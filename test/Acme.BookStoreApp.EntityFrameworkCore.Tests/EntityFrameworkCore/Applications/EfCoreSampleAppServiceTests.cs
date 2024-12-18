using Acme.BookStoreApp.Samples;
using Xunit;

namespace Acme.BookStoreApp.EntityFrameworkCore.Applications;

[Collection(BookStoreAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookStoreAppEntityFrameworkCoreTestModule>
{

}

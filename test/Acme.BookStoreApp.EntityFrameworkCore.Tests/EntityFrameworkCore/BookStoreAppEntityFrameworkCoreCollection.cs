using Xunit;

namespace Acme.BookStoreApp.EntityFrameworkCore;

[CollectionDefinition(BookStoreAppTestConsts.CollectionDefinitionName)]
public class BookStoreAppEntityFrameworkCoreCollection : ICollectionFixture<BookStoreAppEntityFrameworkCoreFixture>
{

}

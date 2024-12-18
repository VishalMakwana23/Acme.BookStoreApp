using Acme.BookStoreApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStoreApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookStoreAppController : AbpControllerBase
{
    protected BookStoreAppController()
    {
        LocalizationResource = typeof(BookStoreAppResource);
    }
}

using Acme.BookStoreApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Acme.BookStoreApp.Permissions;

public class BookStoreAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookStoreAppPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookStoreAppPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookStoreAppResource>(name);
    }
}

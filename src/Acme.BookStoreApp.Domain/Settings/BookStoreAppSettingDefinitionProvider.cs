using Volo.Abp.Settings;

namespace Acme.BookStoreApp.Settings;

public class BookStoreAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BookStoreAppSettings.MySetting1));
    }
}

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.Modules;
using OrchardCore.ResourceManagement;
using Prism.OrchardCore.Settings;

namespace Prism.OrchardCore
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IConfigureOptions<ResourceManagementOptions>, ResourceManagementOptionsConfiguration>();
            services.AddScoped<IContentPartFieldDefinitionDisplayDriver, HtmlFieldPrismDisplaySettingsDriver>();
            services.AddScoped<IContentTypePartDefinitionDisplayDriver, HtmlBodyPartPrismDisplaySettingsDriver>();
        }
    }
}
using Microsoft.Extensions.DependencyInjection;
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
            services.AddScoped<IResourceManifestProvider, ResourceManifest>();
            services.AddScoped<IContentPartFieldDefinitionDisplayDriver, HtmlFieldPrismDisplaySettingsDriver>();
        }
    }
}
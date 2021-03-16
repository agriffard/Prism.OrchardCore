using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace Prism.OrchardCore
{
    public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
    {
        private static ResourceManifest _manifest;

        static ResourceManagementOptionsConfiguration()
        {
            _manifest = new ResourceManifest();

            _manifest
                .DefineScript("prism")
                .SetUrl("~/Prism.OrchardCore/Scripts/prism.js")
                .SetVersion("1.23.0");

            _manifest
                .DefineStyle("prism")
                .SetUrl("~/Prism.OrchardCore/Styles/prism.css")
                .SetVersion("1.23.0");
        }

        public void Configure(ResourceManagementOptions options)
        {
            options.ResourceManifests.Add(_manifest);
        }
    }
}

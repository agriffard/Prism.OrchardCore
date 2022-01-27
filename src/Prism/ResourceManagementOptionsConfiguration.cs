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
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/prism/1.26.0/prism.min.js", "https://cdnjs.cloudflare.com/ajax/libs/prism/1.26.0/prism.js")
                .SetCdnIntegrity("sha384-BY9kzqr5Nf8qzJhtpkoqjMwSF5u09gE43gyKyjclIdPxut7s3XtPKW+Frd/UKdMN", "sha384-cf6xs4fGO/JfLgLu0ez9JrskpYwlTrjC5U9odJlpieoeaeK1QWi40o/Axbc8nYC4")
                .SetVersion("1.26.0");

            _manifest
                .DefineStyle("prism")
                .SetUrl("~/Prism.OrchardCore/Styles/prism.css")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/prism/1.26.0/themes/prism.min.css", "https://cdnjs.cloudflare.com/ajax/libs/prism/1.26.0/themes/prism.css")
                .SetCdnIntegrity("sha384-rCCjoCPCsizaAAYVoz1Q0CmCTvnctK0JkfCSjx7IIxexTBg+uCKtFYycedUjMyA2", "sha384-fOxUs50supO02q0/iotANfwsR12+8Cf4xzduhJwMRT7de7W6RoTkt6OQa9iv0OaA")
                .SetVersion("1.26.0");
        }

        public void Configure(ResourceManagementOptions options)
        {
            options.ResourceManifests.Add(_manifest);
        }
    }
}

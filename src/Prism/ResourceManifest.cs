using OrchardCore.ResourceManagement;

namespace Prism.OrchardCore
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineScript("prism")
                .SetUrl("~/Prism.OrchardCore/Scripts/prism.min.js", "~/Prism.OrchardCore/Scripts/prism.js")
                //.SetCdn("", "")
                //.SetCdnIntegrity("", "")
                .SetVersion("1.18.0");

            manifest
                .DefineStyle("prism")
                .SetUrl("~/Prism.OrchardCore/Styles/prism.min.css", "~/Prism.OrchardCore/Styles/prism.css")
                .SetVersion("1.18.0");
        }
    }
}

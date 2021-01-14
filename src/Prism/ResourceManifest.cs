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
                .SetUrl("~/Prism.OrchardCore/Scripts/prism.js")
                .SetVersion("1.23.0");

            manifest
                .DefineStyle("prism")
                .SetUrl("~/Prism.OrchardCore/Styles/prism.css")
                .SetVersion("1.23.0");
        }
    }
}

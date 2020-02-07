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
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/prism/1.19.0/prism.min.js", "https://cdnjs.cloudflare.com/ajax/libs/prism/1.19.0/prism.js")
                .SetCdnIntegrity("sha384-n9nIL0sJ2A5r4Uaaw1ktxm08jAZ4nwx0X2XFYEYS472Jy0JLYK0E+0yoUtLjAANz", "sha384-J7GhirXAicmFnrH5uP6Y5ELkaO1uQ1QjzGfUsxen/DdAVuQ/PQA1hAF7teA1Fwg3")
                .SetVersion("1.19.0");

            manifest
                .DefineStyle("prism")
                .SetUrl("~/Prism.OrchardCore/Styles/prism.min.css", "~/Prism.OrchardCore/Styles/prism.css")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/prism/1.19.0/themes/prism.min.css", "https://cdnjs.cloudflare.com/ajax/libs/prism/1.19.0/themes/prism.css")
                .SetCdnIntegrity("sha384-Bxzs1r05j6rNxUaG01qIDC5pnuucWJxoJEIGreZo+9zAz+ilUq9cETaUduMxFlS0", "sha384-SQdp/7TwWmTWN2GHCI6dHLEMo7R2Zye9/03NhSug0ZpLM6bGtZAf5YnWxWsRgPYN")
                .SetVersion("1.19.0");
        }
    }
}

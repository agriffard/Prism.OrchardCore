using OrchardCore.ContentManagement.Metadata.Models;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.DisplayManagement.Handlers;
using OrchardCore.DisplayManagement.Views;
using OrchardCore.Html.Models;
using Prism.OrchardCore.ViewModels;
using System.Threading.Tasks;

namespace Prism.OrchardCore.Settings
{
    public class HtmlBodyPartPrismDisplaySettingsDriver : ContentTypePartDefinitionDisplayDriver<HtmlBodyPart>
    {
        public override IDisplayResult Edit(ContentTypePartDefinition contentTypePartDefinition, BuildEditorContext context)
        {
            return Initialize<PrismSettingsViewModel>("HtmlBodyPartPrismDisplaySettings_Edit", model =>
                {
                    var settings = contentTypePartDefinition.GetSettings<HtmlBodyPartPrismDisplaySettings>();

                    model.Theme = settings.Theme;
                })
                .Location("DisplayMode");
        }

        public override async Task<IDisplayResult> UpdateAsync(ContentTypePartDefinition contentTypePartDefinition, UpdateTypePartEditorContext context)
        {
            if (contentTypePartDefinition.DisplayMode() == "Prism")
            {
                var model = new PrismSettingsViewModel();
                var settings = new HtmlBodyPartPrismDisplaySettings();

                if (await context.Updater.TryUpdateModelAsync(model, Prefix))
                {
                    settings.Theme = model.Theme;

                    context.Builder.WithSettings(settings);
                }
            }

            return Edit(contentTypePartDefinition, context);
        }
    }
}

using System.Threading.Tasks;
using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement.Metadata.Models;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.DisplayManagement.Views;
using Prism.OrchardCore.ViewModels;

namespace Prism.OrchardCore.Settings
{

    public class HtmlFieldPrismDisplaySettingsDriver : ContentPartFieldDefinitionDisplayDriver<HtmlField>
    {
        public override IDisplayResult Edit(ContentPartFieldDefinition partFieldDefinition)
        {
            return Initialize<PrismSettingsViewModel>("HtmlFieldPrismDisplaySettings_Edit", model =>
            {
                var settings = partFieldDefinition.GetSettings<HtmlFieldPrismDisplaySettings>();

                model.Theme = settings.Theme;
            })
            .Location("DisplayMode");
        }

        public override async Task<IDisplayResult> UpdateAsync(ContentPartFieldDefinition partFieldDefinition, UpdatePartFieldEditorContext context)
        {
            if (partFieldDefinition.DisplayMode() == "Prism")
            {
                var model = new PrismSettingsViewModel();
                var settings = new HtmlFieldPrismDisplaySettings();

                await context.Updater.TryUpdateModelAsync(model, Prefix);

                settings.Theme = model.Theme;

                context.Builder.WithSettings(settings);
            }

            return Edit(partFieldDefinition);
        }
    }
}

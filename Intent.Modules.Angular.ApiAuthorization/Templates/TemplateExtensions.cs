using System.Collections.Generic;
using Intent.Modules.Angular.ApiAuthorization.Templates.ApiAuthTypescriptZipFileContent;
using Intent.Modules.Common.Templates;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: DefaultIntentManaged(Mode.Fully, Targets = Targets.Usings)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.TemplateExtensions", Version = "1.0")]

namespace Intent.Modules.Angular.ApiAuthorization.Templates
{
    public static class TemplateExtensions
    {
        public static string GetApiAuthTypescriptZipFileContentName<T>(this IntentTemplateBase<T> template)
        {
            return template.GetTypeName(ApiAuthTypescriptZipFileContentTemplate.TemplateId);
        }

    }
}
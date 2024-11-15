using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Modelers.Types.ServiceProxies.Api;
using Intent.Modules.Common.Registrations;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.TemplateRegistration.FilePerModel", Version = "1.0")]

namespace Intent.Modules.Angular.ServiceProxies.Templates.AngularServiceProxy
{
    [IntentManaged(Mode.Merge, Body = Mode.Merge, Signature = Mode.Fully)]
    public class AngularServiceProxyTemplateRegistration : FilePerModelTemplateRegistration<ServiceProxyModel>
    {
        private readonly IMetadataManager _metadataManager;

        public AngularServiceProxyTemplateRegistration(IMetadataManager metadataManager)
        {
            _metadataManager = metadataManager;
        }

        public override string TemplateId => AngularServiceProxyTemplate.TemplateId;

        [IntentManaged(Mode.Fully)]
        public override ITemplate CreateTemplateInstance(IOutputTarget outputTarget, ServiceProxyModel model)
        {
            return new AngularServiceProxyTemplate(outputTarget, model);
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        public override IEnumerable<ServiceProxyModel> GetModels(IApplication application)
        {
            return Enumerable.Empty<ServiceProxyModel>()
                .Concat(Intent.Modelers.UI.Api.ApiMetadataDesignerExtensions.UserInterface(_metadataManager, application).GetServiceProxyModels())
                //.Concat(_metadataManager.WebClient(application).GetServiceProxyModels())  // because .UserInterface(...) it's fetching by designer's id.
                .DistinctBy(x => x.Id);
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Metadata.Models;
using Intent.Modelers.Services.Api;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("ModuleBuilder.Templates.Api.ApiMetadataProviderExtensions", Version = "1.0")]

namespace Intent.Modules.Modelers.WebClient.Proxies.Api
{
    [IntentManaged(Mode.Merge)]
    public static class ApiMetadataProviderExtensions
    {
        public static IList<ServiceProxyModel> GetServiceProxyModels(this IDesigner designer)
        {
            return designer.GetElementsOfType(ServiceProxyModel.SpecializationTypeId)
                .Select(x => new ServiceProxyModel(x))
                .ToList();
        }

        [IntentManaged(Mode.Ignore)]
        public static IList<ServiceProxyDTOModel> GetServiceProxyDTOModels(this IDesigner designer)
        {
            var dtoModels = new List<ServiceProxyDTOModel>();
            foreach (var moduleModel in designer.GetServiceProxyModels())
            {
                dtoModels.AddRange(moduleModel.GetDTOModels());
            }

            return dtoModels.Distinct().ToList();
        }

        [IntentManaged(Mode.Ignore)]
        public static IEnumerable<ServiceProxyDTOModel> GetDTOModels(this ServiceProxyModel proxy)
        {
            var dtos = proxy.Operations
                .SelectMany(x => x.Parameters)
                .SelectMany(x => GetTypeModels(x.TypeReference))
                .Concat(proxy.Operations.Where(x => x.TypeReference.Element != null).SelectMany(x => GetTypeModels(x.TypeReference)))
                .Where(x => x.SpecializationTypeId == DTOModel.SpecializationTypeId)
                .ToList();

            foreach (var dto in dtos.ToList())
            {
                dtos.AddRange(((IElement)dto).GetChildDTOs());
            }

            return dtos
                .Select(x => new ServiceProxyDTOModel((IElement)x)).ToList()
                .Distinct()
                .ToList();
        }

        [IntentManaged(Mode.Ignore)]
        private static IEnumerable<ICanBeReferencedType> GetTypeModels(ITypeReference typeReference)
        {
            var models = new List<ICanBeReferencedType>() { typeReference.Element };
            models.AddRange(typeReference.GenericTypeParameters.SelectMany(GetTypeModels));
            return models;
        }

        [IntentManaged(Mode.Ignore)]
        private static IEnumerable<IElement> GetChildDTOs(this IElement dto)
        {
            var childDTOs = dto.ChildElements
                .Where(x => x.TypeReference.Element?.SpecializationTypeId == DTOModel.SpecializationTypeId)
                .Select(x => (IElement)x.TypeReference.Element).ToList();
            foreach (var childDtO in childDTOs.ToList())
            {
                childDTOs.AddRange(GetChildDTOs(childDtO));
            }

            return childDTOs;
        }
    }
}
using AutoMapper;
using NerdStore.Catalogo.Application.ViewModels;
using NerdStore.Catalogo.Domain;

namespace NerdStore.Catalogo.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Produto, ProdutoViewModel>()
                .ForMember(pvm => pvm.Largura, o => o.MapFrom(p => p.Dimensoes.Largura))
                .ForMember(pvm => pvm.Altura, o => o.MapFrom(p => p.Dimensoes.Altura))
                .ForMember(pvm => pvm.Profundidade, o => o.MapFrom(p => p.Dimensoes.Profundidade));

            CreateMap<Categoria, CategoriaViewModel>();
        }       
    }
}

using AutoMapper;
using BOBOrderingApp.Shared.Models;
using BOBOrderingApp.Shared.Models.DTOS;

namespace BOBOrderingApp.Server.ApiMappingProfiles;

public class ApiMappingProfile : Profile
{
    public ApiMappingProfile()
    {
        CreateMap<MenuItem, MenuItemDTO>().ReverseMap();
        CreateMap<PreOrder, PreOrderDTO>().ReverseMap();
    }
}

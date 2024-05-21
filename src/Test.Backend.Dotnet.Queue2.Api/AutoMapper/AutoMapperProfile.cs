using Test.Backend.Dotnet.Queue2.Api.Models;
using Test.Backend.Dotnet.Queue2.Core.Entities;

using AutoMapper;

namespace Test.Backend.Dotnet.Queue2.Api.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ItemRequest, Item>();
    }
}

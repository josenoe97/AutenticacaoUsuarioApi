using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;
using AutoMapper;

namespace UsuariosApi.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}

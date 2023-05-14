using AutoMapper;
using WebApplicationCoreGLSI_B.Models.DTO;

namespace WebApplicationCoreGLSI_B.Models
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Categorie, CategorieDTO>();
            CreateMap<CategorieDTO, Categorie>();
        }
    }
}

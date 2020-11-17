using AutoMapper;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Data.Entidades;

namespace LectoresConGloria_SVC.Mapeo
{
    internal class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<MDL_Usuario, TBL_Usuarios>().ReverseMap();
            CreateMap<MDL_Categoria, TBL_Categorias>().ReverseMap();
            CreateMap<MDL_Formato, TBL_Formatos>().ReverseMap();
        }
    }
}

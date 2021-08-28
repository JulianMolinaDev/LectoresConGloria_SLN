using AutoMapper;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Data.Entidades;

namespace LectoresConGloria_SVC.Mapeo
{
    internal class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<MDL_Categoria, TBL_Categorias>().ReverseMap();
            CreateMap<MDL_Click, TBL_Clicks>().ReverseMap();
            CreateMap<MDL_Formato, TBL_Formatos>().ReverseMap();
            CreateMap<MDL_FormatoLibro, TBL_FormatosLibros>().ReverseMap();
            CreateMap<MDL_Lector, TBL_Lectores>().ReverseMap(); 
            CreateMap<MDL_Libro, TBL_Libros>().ReverseMap();
            CreateMap<MDL_Texto, TBL_Textos>().ReverseMap();
            CreateMap<MDL_TextoCategoria, TBL_TextosCategorias>().ReverseMap();
            CreateMap<MDL_TextoLibro, TBL_TextosLibros>().ReverseMap();
        }
    }
}

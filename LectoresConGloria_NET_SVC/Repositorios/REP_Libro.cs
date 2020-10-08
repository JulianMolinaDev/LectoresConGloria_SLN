using AutoMapper;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Data.Entidades;
using LectoresConGloria_SVC.Mapeo;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Libro : ISVC_Libro
    {
        readonly LectoresConGloria_Context _contexto;
        readonly IMapper _mapper;
        public REP_Libro()
        {
            _contexto = new LectoresConGloria_Context();
            _mapper = Automapeo.Instance;
        }
        public async void Delete(int id)
        {
            var entity = _contexto.TBL_Libros.Find(id);
            _contexto.TBL_Libros.Remove(entity);
            await _contexto.SaveChangesAsync();
        }

        public async Task<MDL_Libro> Get(int id)
        {
            var entity = await _contexto.TBL_Libros.FindAsync(id);
            var output = _mapper.Map<MDL_Libro>(entity);
            return output;
        }

        public async Task<IEnumerable<MDL_Libro>> Get()
        {
            var entity = await _contexto.TBL_Libros.ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_Libro>>(entity);
            return output;
        }

        public async void Post(MDL_Libro reg)
        {
            var entity = _mapper.Map<TBL_Libros>(reg);
            _contexto.TBL_Libros.Add(entity);
            await _contexto.SaveChangesAsync();
        }

        public async void Put(int id, MDL_Libro reg)
        {
            var register = _mapper.Map<TBL_Libros>(reg);
            var entity = await _contexto.TBL_Libros.FindAsync(id);
            entity.Nombre = register.Nombre;
            _contexto.Entry(entity).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
        }
    }
}

using AutoMapper;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Data.Entidades;
using LectoresConGloria_SVC.Mapeo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_TextoLibro : ISVC_TextoLibro
    {
        readonly LectoresConGloria_Context _contexto;
        readonly IMapper _mapper;
        public REP_TextoLibro()
        {
            _contexto = new LectoresConGloria_Context();
            _mapper = Automapeo.Instance;
        }
        public async void Delete(int id)
        {
            var entity = _contexto.TBL_TextosCategorias.Find(id);
            _contexto.TBL_TextosCategorias.Remove(entity);
            await _contexto.SaveChangesAsync();
        }
        public async Task<MDL_TextoLibro> Get(int id)
        {
            var entity = await _contexto.TBL_TextosLibros.FindAsync(id);
            var output = _mapper.Map<MDL_TextoLibro>(entity);
            return output;
            }

        public async Task<IEnumerable<MDL_TextoLibro>> Get()
        {
            var entity = await _contexto.TBL_TextosLibros.ToListAsync();
            var output = _mapper.Map<IEnumerable<MDL_TextoLibro>>(entity);
            return output;
        }

        public async Task<IEnumerable<V_Lista>> GetTextosPorLibro(int idLibro)
        {
            var output = await _contexto.TBL_TextosLibros
                .Where(x=> x.IdLibro == idLibro)
                .Include(x=> x.TBL_Textos)
                .Select(x=> new V_Lista() { 
                    Id = x.IdTexto,
                    Valor = x.TBL_Textos.Titulo
                }).ToListAsync();
            return output;
        }

        public async void Post(MDL_TextoLibro reg)
        {
            var entity = _mapper.Map<TBL_TextosLibros>(reg);
            _contexto.TBL_TextosLibros.Add(entity);
            await _contexto.SaveChangesAsync();
        }

        public void Put(int id, MDL_TextoLibro reg)
        {
            throw new NotImplementedException();
        }
    }
}

using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_TextoCategoria : ISVC_TextoCategoria
    {
        readonly REP_TextoCategoria _repositorio;
        public SVC_TextoCategoria()
        {
            _repositorio = new REP_TextoCategoria();
        }
        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public async Task<MDL_TextoCategoria> Get(int id)
        {
            return await _repositorio.Get(id);
        }

        public async Task<IEnumerable<MDL_TextoCategoria>> Get()
        {
            return await _repositorio.Get();
        }

        public async Task<IEnumerable<V_Lista>> GetCategoriaPorTexto(int idTexto)
        {
            return await _repositorio.GetCategoriaPorTexto(idTexto);
        }

        public async Task<IEnumerable<V_Lista>> GetTextoPorCategoria(int idCategoria)
        {
            return await _repositorio.GetTextoPorCategoria(idCategoria);
        }

        public void Post(MDL_TextoCategoria reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_TextoCategoria reg)
        {
            _repositorio.Put(id, reg);
        }
    }
}

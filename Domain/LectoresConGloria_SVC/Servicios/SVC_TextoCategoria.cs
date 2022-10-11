using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LectoresConGloria_SVC.Data;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_TextoCategoria : ISVC_TextoCategoria
    {
        readonly REP_TextoCategoria _repositorio;
        public SVC_TextoCategoria(LectoresConGloria_Context context)
        {
            _repositorio = new REP_TextoCategoria(context);
        }
        public async Task Delete(int id)
        {
            await _repositorio.Delete(id);
        }

        public async Task<IEnumerable<V_Lista>> GetFaltantesCategoriasPorTexto(int idTexto)
        {
            return await _repositorio.GetFaltantesCategoriasPorTexto(idTexto);
        }

        public async Task<MDL_TextoCategoria> Get(int id)
        {
            return await _repositorio.Get(id);
        }

        public async Task<IEnumerable<MDL_TextoCategoria>> Get()
        {
            return await _repositorio.Get();
        }

        public async Task<IEnumerable<V_ListaRelacion>> GetCategoriaPorTexto(int idTexto)
        {
            return await _repositorio.GetCategoriaPorTexto(idTexto);
        }

        public async Task<IEnumerable<V_ListaRelacion>> GetTextoPorCategoria(int idCategoria)
        {
            return await _repositorio.GetTextoPorCategoria(idCategoria);
        }

        public async Task Post(MDL_TextoCategoria reg)
        {
            await _repositorio.Post(reg);
        }

        public async Task Put(int id, MDL_TextoCategoria reg)
        {
            await _repositorio.Put(id, reg);
        }

        public async Task<V_AsociacionDetalle> GetAsociacionDetalle(int id)
        {
            return await _repositorio.GetAsociacionDetalle(id);
        }
    }
}

using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Repositorios;
using System.Collections.Generic;
using System.Threading.Tasks;
using LectoresConGloria_SVC.Data;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_TextoLibro : ISVC_TextoLibro
    {
        readonly REP_TextoLibro _repositorio;
        public SVC_TextoLibro(LectoresConGloria_Context context)
        {
            _repositorio = new REP_TextoLibro(context);
        }
        public async Task Delete(int id)
        {
            await _repositorio.Delete(id);
        }

        public async Task<MDL_TextoLibro> Get(int id)
        {
            return await _repositorio.Get(id);
        }

        public async Task<IEnumerable<MDL_TextoLibro>> Get()
        {
            return await _repositorio.Get();
        }

        public async Task<V_AsociacionDetalle> GetAsociacionDetalle(int id)
        {
            return await _repositorio.GetAsociacionDetalle(id);
        }

        public async Task<IEnumerable<V_ListaRelacion>> GetTextosPorLibro(int idLibro)
        {
            return await _repositorio.GetTextosPorLibro(idLibro);
        }

        public async Task Post(MDL_TextoLibro reg)
        {
            await _repositorio.Post(reg);
        }

        public async Task Put(int id, MDL_TextoLibro reg)
        {
            await _repositorio.Put(id, reg);
        }

        public async Task TextoDesdeLibro(int idLibro, MDL_Texto texto)
        {
            await _repositorio.TextoDesdeLibro(idLibro, texto);
        }
    }
}

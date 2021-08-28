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
        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public MDL_TextoLibro Get(int id)
        {
            return _repositorio.Get(id);
        }

        public IEnumerable<MDL_TextoLibro> Get()
        {
            return _repositorio.Get();
        }

        public V_AsociacionDetalle GetAsociacionDetalle(int id)
        {
            return _repositorio.GetAsociacionDetalle(id);
        }

        public IEnumerable<V_ListaRelacion> GetTextosPorLibro(int idLibro)
        {
            return _repositorio.GetTextosPorLibro(idLibro);
        }

        public void Post(MDL_TextoLibro reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_TextoLibro reg)
        {
            _repositorio.Put(id, reg);
        }

        public void TextoDesdeLibro(int idLibro, MDL_Texto texto)
        {
            _repositorio.TextoDesdeLibro(idLibro, texto);
        }
    }
}

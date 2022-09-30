using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_PRX.Proxies;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace LectoresConGloria_PRX.Servicios
{
    public class SVC_TextoLibro : ISVC_TextoLibro
    {
        readonly PRX_Generico<MDL_TextoLibro, int> _proxie;
        private readonly string _url;
        private string _endpoint;

        public SVC_TextoLibro()
        {
            _url = "";
            _endpoint = "";
            _proxie = new PRX_Generico<MDL_TextoLibro, int>(_url, _endpoint);
        }
        public void Delete(int id)
        {
            var modelo = _proxie.Delete(id);
            modelo.Wait();
        }

        public MDL_TextoLibro Get(int id)
        {
            var modelo = _proxie.Get(id);
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<MDL_TextoLibro> Get()
        {
            var modelo = _proxie.Get();
            modelo.Wait();
            return modelo.Result;
        }

        public V_AsociacionDetalle GetAsociacionDetalle(int id)
        {
            _endpoint += "/GetAsociacionDetalle";
            var prx = new PRX_Custom<V_AsociacionDetalle, int>(_url, _endpoint);
            var modelo = prx.Get(id);
            modelo.Wait();
            return modelo.Result;
        }

        public IEnumerable<V_ListaRelacion> GetTextosPorLibro(int idLibro)
        {
            _endpoint += "/GetTextosPorLibro";
            var prx = new PRX_Custom<V_ListaRelacion, int>(_url, _endpoint);
            var modelo = prx.GetList(idLibro);
            modelo.Wait();
            return modelo.Result;
        }

        public void Post(MDL_TextoLibro reg)
        {
            var modelo = _proxie.Post(reg);
            modelo.Wait();
        }

        public void Put(int id, MDL_TextoLibro reg)
        {
            var modelo = _proxie.Put(id, reg);
            modelo.Wait();
        }

        public void TextoDesdeLibro(int idLibro, MDL_Texto texto)
        {
            _endpoint += "/TextoDesdeLibro";
            var prx = new PRX_Generico<MDL_Texto, int>(_url, _endpoint);
            var modelo = prx.Put(idLibro, texto);
            modelo.Wait();
        }
    }
}

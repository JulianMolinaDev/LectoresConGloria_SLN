using LectoresConGloria_GW.Estaticas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_GW.Proxies
{
    public class PRX_Generico<TEntity, TKEy>
    {
        private readonly string _url;
        private string _endPoint;
        private readonly string _token;
        public string EndPoint { set { _endPoint = value; } }
        public PRX_Generico(string url, string endpoint)
        {
            _url = url;
            _endPoint = endpoint;
            _token = null;
        }
        public PRX_Generico(string url, string endpoint, string token)
        {
            _url = url;
            _endPoint = endpoint;
            _token = token;
        }
        public async Task Delete(TKEy id)
        {
            HttpClient client = ClienteHttp.GetClientBase(_url, _token);
            var url = String.Format(_endPoint + "/{0}", id);
            HttpResponseMessage response = await client.DeleteAsync(url);
            response.EnsureSuccessStatusCode();
        }

        public async Task<IEnumerable<TEntity>> Get()
        {
            HttpClient client = ClienteHttp.GetClientBase(_url, _token);
            var url = String.Format(_endPoint);
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var resp = await response.Content.ReadAsStringAsync();
            var output = JsonConvert.DeserializeObject<IEnumerable<TEntity>>(resp);
            return output;
        }

        public async Task<TEntity> Get(TKEy id)
        {
            HttpClient client = ClienteHttp.GetClientBase(_url, _token);
            var url = String.Format(_endPoint + "/{0}", id);
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var resp = await response.Content.ReadAsStringAsync();
            var output = JsonConvert.DeserializeObject<TEntity>(resp);
            return output;
        }

        public async Task Post(TEntity reg)
        {
            HttpClient client = ClienteHttp.GetClientBase(_url, _token);
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(reg);
            var data = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(_endPoint, data);
            response.EnsureSuccessStatusCode();
        }

        public async Task Put(TKEy id, TEntity reg)
        {
            HttpClient client = ClienteHttp.GetClientBase(_url, _token);
            var url = String.Format(_endPoint + "/{0}", id);
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(reg);
            var data = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(url, data);
            response.EnsureSuccessStatusCode();
        }
    }
}

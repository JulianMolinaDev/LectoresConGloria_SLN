using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace LectoresConGloria_GW.Estaticas
{
    public static class ClienteHttp
    {
        public static HttpClient GetClientBase(string address,
        string token = null)
        {
            HttpClient output = new HttpClient
            {
                BaseAddress = new Uri(address)
            };

            if (token != null)
                output.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace LectoresConGloria_MVC_ADM.Estaticas
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
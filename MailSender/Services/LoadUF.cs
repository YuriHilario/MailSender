using MailSender.Entities;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.Services
{
    class LoadUF
    {
        public static List<JsonUF> LoadDataLocates()
        {
            var client = new RestClient("https://servicodados.ibge.gov.br/api/v1/localidades/estados");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
        
            List<JsonUF> ufs = JsonConvert.DeserializeObject<List<JsonUF>>(response.Content);
            return ufs;
        }
    }
}

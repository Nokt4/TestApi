using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using TestApi.Model;
using System.Collections.Generic;


namespace TestApi.Service
{
    public class RestService
    {

        List<EntryModel> EntryModels { get; set; }
        EntryContainer Container { get; set; }
        JsonSerializerOptions options = new JsonSerializerOptions();
        HttpClient client = new HttpClient();

        public RestService()
        {
            options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };
        }

        async Task<List<EntryModel>> RestApi.GetDataAsync()
        {
            EntryModels = new List<EntryModel>();
            Container = new EntryContainer();
            var httpResponse = await HttpClient.GetAsync(Consts.URI);
            try
            {
                if (httpResponse.IsSuccesStatusCode)
                {
                
                }

            }
            catch ()
            { 
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestApi.Service;

namespace TestApi.Service
{
    public class EntryManager
    {
        IService restsService;
        public EntryManager(IRestService service)
        {
            restsService = service;

        }

        public Task<List<EntryModel>> GetDataAsync
        { 
        
        }
    }
}

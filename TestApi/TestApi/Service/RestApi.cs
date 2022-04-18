using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestApi.Model;

namespace TestApi.Service
{
    public interface RestApi
    {
        Task<List<EntryModel>> RestService.GetDataAsync()
    }
}

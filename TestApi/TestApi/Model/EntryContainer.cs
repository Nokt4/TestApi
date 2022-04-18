using System;
using System.Collections.Generic;
using System.Text;
using TestApi.Model;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace TestApi.Model
{
    public class EntryContainer
    {

        public string Count { get; set; }
        public List<EntryModel> EntryModels { get; set; }
    }
}

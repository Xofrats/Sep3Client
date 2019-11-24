using Newtonsoft.Json;
using System;



namespace Client
{
    class Message : ITranferable
    {
        public String Function { get; set; }
        public String Chat { get; set; }

        public string ToJson()
        {
            String JsonString = JsonConvert.SerializeObject(this);
            return JsonString;
        }
    }
}

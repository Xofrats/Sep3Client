using Newtonsoft.Json;
using System;



namespace Client
{
  [Serializable]
    class Message : ITranferable
    {
        public String Function { get; set; }
        public String Chat { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public int GroupID { get; set; }
        public int Count { get; set; }
        public String File { get; set; }
        public String fileName { get; set; }
        public String Group { get; set; }

    public string ToJson()
        {
            String JsonString = JsonConvert.SerializeObject(this);
            return JsonString;
        }
    }
}

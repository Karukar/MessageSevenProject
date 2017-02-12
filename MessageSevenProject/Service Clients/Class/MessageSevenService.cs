using MessageSevenProject.Service_Clients.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageSevenProject.Model;
using System.Net.Http;
using Newtonsoft.Json;

namespace MessageSevenProject.Service_Clients.Class
{
    public class MessageSevenService : IMessageSevenService
    {
        public IEnumerable<Message> FindData(string Attrib, string Operat, string value)
        {

            List<Message> Data = new List<Message>();
            using (HttpClient Client = new HttpClient())
            {
                Client.BaseAddress = new Uri("http://localhost:8080/");
                Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applications/json"));
                string Cont = "MessageSevenService.svc/FindMessage/" + Attrib.ToString() + "/" + Operat.ToString() + "/" + value.ToString();
                HttpResponseMessage Req = Client.GetAsync(Cont.ToString()).Result;
                if(Req.EnsureSuccessStatusCode()!=null)
                {
                    string json = Req.Content.ReadAsStringAsync().Result;
                    var d = JsonConvert.DeserializeObject<Root>(json);
                    Data = d.RootFindData;
                }
            }

            return Data;

        }

        public IEnumerable<Message> GeAllData()
        {
           
            List<Message> Data = new List<Message>();
            using (HttpClient Client = new HttpClient())
            {
                Client.BaseAddress = new Uri("http://localhost:8080/");
                Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applications/json"));
                HttpResponseMessage Req = Client.GetAsync("MessageSevenService.svc/AllMessage").Result;
                if(Req.EnsureSuccessStatusCode()!=null)
                {
                    string json = Req.Content.ReadAsStringAsync().Result;
                    var d= JsonConvert.DeserializeObject<Root>(json);
                    Data = d.RootAllData;
                }

            }

            return Data;
        }
    }

    public class Root
    {
        [JsonProperty(PropertyName = "AllMessagesResult")]
        public List<Message> RootAllData { get; set; }
        [JsonProperty(PropertyName = "FindMessageResult")]
        public List<Message> RootFindData { get; set; }
    }
}

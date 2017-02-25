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
        public IEnumerable<Message> FindData(string attrib, string operat, string value)
        {

            List<Message> data = new List<Message>();
            data = NewMethod(attrib, operat, value, data);

            return data;

        }

        private static List<Message> NewMethod(string attrib, string operat, string value, List<Message> data)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applications/json"));
                string cont = "MessageSevenService.svc/FindMessage/" + attrib.ToString() + "/" + operat.ToString() + "/" + value.ToString();
                HttpResponseMessage req = client.GetAsync(cont.ToString()).Result;
                if (req.EnsureSuccessStatusCode() != null)
                {
                    string json = req.Content.ReadAsStringAsync().Result;
                    var d = JsonConvert.DeserializeObject<Root>(json);
                    data = d.RootFindData;
                }
            }

            return data;
        }

        public IEnumerable<Message> GeAllData()
        {
           
            List<Message> data = new List<Message>();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applications/json"));
                HttpResponseMessage req = client.GetAsync("MessageSevenService.svc/AllMessage").Result;
                if(req.EnsureSuccessStatusCode()!=null)
                {
                    string json = req.Content.ReadAsStringAsync().Result;
                    var d= JsonConvert.DeserializeObject<Root>(json);
                    data = d.RootAllData;
                }

            }

            return data;
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

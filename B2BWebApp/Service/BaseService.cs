using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace B2BWebApp.Service
{
    public class BaseService
    {
        public HttpClientHandler GetAuthHandle()
        {
            return new HttpClientHandler
            {
                Credentials = new NetworkCredential(GetSettings().API_KEY, GetSettings().PASSWORD),
                PreAuthenticate = true
            };
        }

        public string GetUrl()
        {
            return $@"https://{GetSettings().HOSTNAME}";
        }

        public Settings GetSettings()
        {
            using (StreamReader r = File.OpenText("settings.json"))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<Settings>(json);
            }
        }
    }

    public class Settings
    {
        public string API_KEY { get; set; }
        public string PASSWORD { get; set; }
        public string HOSTNAME { get; set; }
    }
}

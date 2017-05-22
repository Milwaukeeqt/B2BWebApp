using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;

namespace B2BWebApp.Service
{
    public class BaseService
    {
        private readonly Settings _settings;

        public BaseService()
        {
            _settings = GetSettings();
        }

        public HttpClientHandler GetAuthHandle()
        {
            return new HttpClientHandler
            {
                Credentials = new NetworkCredential(_settings.API_KEY, _settings.PASSWORD),
                PreAuthenticate = true
            };
        }

        public string GetUrl()
        {
            return $@"https://{_settings.HOSTNAME}";
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
}

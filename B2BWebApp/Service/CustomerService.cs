using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using B2BWebApp.Models;
using Newtonsoft.Json;

namespace B2BWebApp.Service
{
    public class CustomerService : BaseService
    {
        public async Task<List<Customer>> GetAllAsync()
        {
            string resource = "/admin/customers.json";

            string uri = GetUrl() + resource;

            using (HttpClient httpClient = new HttpClient(GetAuthHandle()))
            {
                return JsonConvert.DeserializeObject<List<Customer>>(await httpClient.GetStringAsync(uri));
            }
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            string resource = $@"/admin/customers.json?ids={id}";

            string uri = GetUrl() + resource;

            using (HttpClient httpClient = new HttpClient(GetAuthHandle()))
            {
                return JsonConvert.DeserializeObject<Customer>(await httpClient.GetStringAsync(uri));
            }
        }

        public async Task<List<Customer>> GetByIdsAsync(List<int> ids)
        {
            string resource = $@"/admin/customers.json?ids={string.Join(",", ids)}";

            string uri = GetUrl() + resource;

            using (HttpClient httpClient = new HttpClient(GetAuthHandle()))
            {
                return JsonConvert.DeserializeObject<List<Customer>>(await httpClient.GetStringAsync(uri));
            }
        }
    }
}

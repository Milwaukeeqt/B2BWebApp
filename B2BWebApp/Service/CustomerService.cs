using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using B2BWebApp.Models.Customer;
using B2BWebApp.Models.Product;
using Newtonsoft.Json;

namespace B2BWebApp.Service
{
    public class CustomerService : BaseService
    {
        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            string resource = "/admin/customers.json";

            string uri = GetUrl() + resource;

            using (HttpClient httpClient = new HttpClient(GetAuthHandle()))
            {
                return JsonConvert.DeserializeObject<List<Customer>>(await httpClient.GetStringAsync(uri));
            }
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            string resource = $@"/admin/customers.json?ids={id}";

            string uri = GetUrl() + resource;

            using (HttpClient httpClient = new HttpClient(GetAuthHandle()))
            {
                return JsonConvert.DeserializeObject<Customer>(await httpClient.GetStringAsync(uri));
            }
        }

        public async Task<List<Customer>> GetCustomerByIdsAsync(List<int> ids)
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

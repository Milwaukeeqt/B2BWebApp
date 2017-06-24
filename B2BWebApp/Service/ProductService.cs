using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using B2BWebApp.Models;
using Newtonsoft.Json;


namespace B2BWebApp.Service
{
    public class ProductService : BaseService
    {
        private readonly string _url;

        public ProductService()
        {
            _url = base.GetUrl();
        }

        public async Task<Products> GetAllAsync()
        {
            string resource = "/admin/products.json";

            string uri = _url + resource;

            using (var httpClient = new HttpClient(GetAuthHandle()))
            {
                return JsonConvert.DeserializeObject<Products>(await httpClient.GetStringAsync(uri));
            }
        }

        public async Task<Products> GetLimitedListAsync(int limit)
        {
            string resource = $@"/admin/products.json?limit={limit}";

            string uri = _url + resource;

            using (var httpClient = new HttpClient(GetAuthHandle()))
            {
                return JsonConvert.DeserializeObject<Products>(await httpClient.GetStringAsync(uri));
            }
        }

        public async Task<int> Count()
        {
            string resource = $@"/admin/products/count.json";

            string uri = _url + resource;

            using (var httpClient = new HttpClient(GetAuthHandle()))
            {
                return JsonConvert.DeserializeObject<dynamic>(await httpClient.GetStringAsync(uri)).count;

            }
        }

        public async Task<Products> GetByIdAsync(int id)
        {
            string resource = $@"/admin/products.json?ids={id}";

            string uri = _url + resource;

            using (var httpClient = new HttpClient(GetAuthHandle()))
            {
                return JsonConvert.DeserializeObject<Products>(await httpClient.GetStringAsync(uri));
            }
        }

        public async Task<Products> GetByIdsAsync(List<int> ids)
        {
            string resource = $@"/admin/products.json?ids={string.Join(",", ids)}";

            string uri = _url + resource;

            using (var httpClient = new HttpClient(GetAuthHandle()))
            {
                return JsonConvert.DeserializeObject<Products>(await httpClient.GetStringAsync(uri));
            }
        }

        public async Task<Products> GetPageAsync(int limit, int page)
        {

            string resource = $@"/admin/products.json?limit={limit}&page={page}";

            string uri = _url + resource;

            using (var httpClient = new HttpClient(GetAuthHandle()))
            {
                return JsonConvert.DeserializeObject<Products>(await httpClient.GetStringAsync(uri));
            }
        }

        //public async Task<ProductVariant> AdjustVariantQuantity(int id, int amount)
        //{
        //    string resource = $@"/admin/variants/#{id}";

        //    string uri = _url + resource;

        //    using (var httpClient = new HttpClient(GetAuthHandle()))
        //    {
        //        return httpClient.PutAsync(uri);
        //    }
        //}
    }
}
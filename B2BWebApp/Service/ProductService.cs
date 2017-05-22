﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using B2BWebApp.Models.Product;
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

        public async Task<Products> GetAllProductsAsync()
        {
            string resource = "/admin/products.json";

            string uri = _url + resource;

            using (HttpClient httpClient = new HttpClient(GetAuthHandle()))
            {
                return JsonConvert.DeserializeObject<Products>(await httpClient.GetStringAsync(uri));
            }
        }

        public async Task<Products> GetProductByIdAsync(int id)
        {
            string resource = $@"/admin/products.json?ids={id}";

            string uri = _url + resource;

            using (HttpClient httpClient = new HttpClient(GetAuthHandle()))
            {
                return JsonConvert.DeserializeObject<Products>(await httpClient.GetStringAsync(uri));
            }
        }

        public async Task<Products> GetProductByIdsAsync(List<int> ids)
        {
            string resource = $@"/admin/products.json?ids={string.Join(",", ids)}";

            string uri = _url + resource;

            using (HttpClient httpClient = new HttpClient(GetAuthHandle()))
            {
                return JsonConvert.DeserializeObject<Products>(await httpClient.GetStringAsync(uri));
            }
        }
    }
}
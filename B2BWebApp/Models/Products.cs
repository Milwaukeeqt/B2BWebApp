using System.Collections.Generic;
using Newtonsoft.Json;

namespace B2BWebApp.Models
{
    public class Products
    {
        [JsonProperty("products")]
        public List<Product> ProductList { get; set; }
    }
}
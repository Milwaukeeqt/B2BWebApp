using System.Collections.Generic;

namespace B2BWebApp.Models.Product
{
    public class Image2
    {
        public object id { get; set; }
        public object product_id { get; set; }
        public int position { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string src { get; set; }
        public List<object> variant_ids { get; set; }
    }
}
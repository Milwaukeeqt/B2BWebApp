using System.Collections.Generic;

namespace B2BWebApp.Models.Product
{
    public class Product
    {
        public object id { get; set; }
        public string title { get; set; }
        public string body_html { get; set; }
        public string vendor { get; set; }
        public string product_type { get; set; }
        public string created_at { get; set; }
        public string handle { get; set; }
        public string updated_at { get; set; }
        public string published_at { get; set; }
        public object template_suffix { get; set; }
        public string published_scope { get; set; }
        public string tags { get; set; }
        public List<Variant> variants { get; set; }
        public List<Option> options { get; set; }
        public List<Image> images { get; set; }
        public Image2 image { get; set; }
    }
}
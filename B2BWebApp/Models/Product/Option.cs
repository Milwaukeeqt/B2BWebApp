using System.Collections.Generic;

namespace B2BWebApp.Models.Product
{
    public class Option
    {
        public object id { get; set; }
        public object product_id { get; set; }
        public string name { get; set; }
        public int position { get; set; }
        public List<string> values { get; set; }
    }
}
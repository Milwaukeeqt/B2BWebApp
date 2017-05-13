using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BWebApp.Models.Customer
{
    public class Customer
    {
        public object id { get; set; }
        public string email { get; set; }
        public bool accepts_marketing { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int orders_count { get; set; }
        public string state { get; set; }
        public string total_spent { get; set; }
        public long? last_order_id { get; set; }
        public object note { get; set; }
        public bool verified_email { get; set; }
        public object multipass_identifier { get; set; }
        public bool tax_exempt { get; set; }
        public object phone { get; set; }
        public string tags { get; set; }
        public string last_order_name { get; set; }
        public DefaultAddress default_address { get; set; }
        public List<object> addresses { get; set; }
    }
}

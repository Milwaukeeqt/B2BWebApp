using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BWebApp.ViewModel
{
    public class CartItemViewModel
    {
        public long ProductId { get; set; }
        public string Title { get; set; }
        public Dictionary<string, int> Variants { get; set; }
    }
}

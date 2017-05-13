namespace B2BWebApp.Models.Product
{
    public class Variant
    {
        public object id { get; set; }
        public object product_id { get; set; }
        public string title { get; set; }
        public string price { get; set; }
        public string sku { get; set; }
        public int position { get; set; }
        public int grams { get; set; }
        public string inventory_policy { get; set; }
        public object compare_at_price { get; set; }
        public string fulfillment_service { get; set; }
        public string inventory_management { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public object option3 { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public bool taxable { get; set; }
        public string barcode { get; set; }
        public object image_id { get; set; }
        public int inventory_quantity { get; set; }
        public double weight { get; set; }
        public string weight_unit { get; set; }
        public int old_inventory_quantity { get; set; }
        public bool requires_shipping { get; set; }
    }
}
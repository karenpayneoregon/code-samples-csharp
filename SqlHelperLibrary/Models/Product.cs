namespace SqlHelperLibrary.Models
{
    public class Product
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public override string ToString() => ProductName;
    }
}

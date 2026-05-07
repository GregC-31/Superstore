public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public int CategoryID { get; set; }
    public int SubcategoryID { get; set; }
    public string Category { get; set; } = string.Empty;
    public string Subcategory { get; set; } = string.Empty;
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
}
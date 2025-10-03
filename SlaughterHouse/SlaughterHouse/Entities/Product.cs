namespace SlaughterHouse.Entities;

public class Product
{
    public int productId { get; set; }
    public int trayId { get; set; }
    public ProductType productType { get; set; }
    public decimal productWeight { get; set; }
}
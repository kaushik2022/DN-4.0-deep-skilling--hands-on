public class LinearSearch
{
    public static Product Search(Product[] products, string keyword)
    {
        foreach (var item in products)
        {
            if (item.ProductName.Equals(keyword, StringComparison.OrdinalIgnoreCase))
            {
                return item;
            }
        }
        return null;
    }
}

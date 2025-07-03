public class BinarySearch
{
    public static Product Search(Product[] sortedProducts, string keyword)
    {
        int low = 0;
        int high = sortedProducts.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int comparison = string.Compare(sortedProducts[mid].ProductName, keyword, StringComparison.OrdinalIgnoreCase);

            if (comparison == 0)
                return sortedProducts[mid];
            else if (comparison < 0)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return null;
    }
}

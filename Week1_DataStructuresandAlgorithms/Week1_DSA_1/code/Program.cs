using System;
class Program
{
    static void Main(string[] args)
    {
        Product[] productList = new Product[]
        {
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Keyboard", "Electronicc accessories"),
            new Product(3, "shoes", "footwear")
        };
 
        Console.WriteLine("Linear Search: Searching for 'Shoes'");
        Product foundLinear = LinearSearch.Search(productList, "Shoes");
        if (foundLinear != null)
            foundLinear.Display();
        else
            Console.WriteLine("Product not found using Linear Search.");

        Array.Sort(productList, (p1, p2) => p1.ProductName.CompareTo(p2.ProductName));

        Console.WriteLine("\nBinary Search: Searching for 'Shoes'");
        Product foundBinary = BinarySearch.Search(productList, "Shoes");
        if (foundBinary != null)
            foundBinary.Display();
        else
            Console.WriteLine("Product not found using Binary Search.");
    }
}

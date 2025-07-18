using RetailStore.Data;
using RetailStore.Models;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();
context.Database.EnsureCreated(); 
if (!context.Categories.Any())
{
    var electronics = new Category { Name = "Electronics" };
    var groceries = new Category { Name = "Groceries" };

    context.Categories.AddRange(electronics, groceries);
    context.Products.AddRange(
        new Product { Name = "Smartphone", Price = 599.99M, Category = electronics },
        new Product { Name = "Apple", Price = 1.50M, Category = groceries }
    );
    context.SaveChanges();
}

foreach (var product in context.Products.Include(p => p.Category))
{
    Console.WriteLine($"{product.Name} - ₹{product.Price} - Category: {product.Category.Name}");
}

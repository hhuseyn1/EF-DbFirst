using EF_DbFirst.DAL;

using var context = new AppDbContext();

foreach (var p in context.Products)
{
    Console.WriteLine($"{p.Id} {p.Name} {p.UnitPrice} {p.Description}");

}

using EF_DbFirst.DAL;
using EF_DbFirst.Models;

using var context = new AppDbContext();

//foreach (var p in context.Products)
//{
//    Console.WriteLine($"{p.Id} {p.Name} {p.UnitPrice} {p.Description}");

//}

using var libContext = new LibraryContext ();

foreach (var p in libContext.Books)
{
    Console.WriteLine($"{p.Id} {p.Name} {p.YearPress}");

}
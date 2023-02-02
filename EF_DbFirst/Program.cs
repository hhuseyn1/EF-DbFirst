using EF_DbFirst.DAL;
using EF_DbFirst.Models;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();
using var libContext = new LibraryContext ();



//Related Data Load

//1)Eager loading
//2)Explicit loading
//3)Lazy loading

//1)Eager loading
//var authors = libContext.Authors.Include(a => a.Books).ThenInclude(b => b.IdCategoryNavigation)
//    .Include(a => a.Books).ThenInclude(b => b.IdThemesNavigation).ToList();


//foreach (var p in authors)
//{
//    Console.WriteLine($"{p.Id} {p.FirstName} {p.LastName}");
//    foreach (var book in p.Books)
//    {
//        Console.WriteLine($"{book.Id} {book.Name} {book.Comment}");

//    }
//}



//2)Explicit loading

//var authors = libContext.Authors.Include(a => a.Books).ToList();


//foreach (var p in authors)
//{
//    Console.WriteLine($"{p.Id} {p.FirstName} {p.LastName}");
//    if (true)
//    {
//        libContext.Entry(p).Collection(x => x.Books).Load();
//        foreach (var book in p.Books)
//        {
//            Console.WriteLine($"{book.Id} {book.Name} {book.Comment}");

//        }
//    }
//}


//Add Nuget package Proxies
//3)Lazy loading

var authors = libContext.Authors.ToList();


foreach (var author in authors)
{
    foreach (var book in author.Books)
    {
        Console.WriteLine(book);
    }
    Console.WriteLine(author.Books.Count);
}





//foreach (var p in context.Products)
//{
//    Console.WriteLine($"{p.Id} {p.Name} {p.UnitPrice} {p.Description}");

//}


//foreach (var p in libContext.Books)
//{
//    Console.WriteLine($"{p.Id} {p.Name} {p.YearPress}");

//}
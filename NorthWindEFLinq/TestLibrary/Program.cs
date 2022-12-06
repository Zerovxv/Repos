using NorthWindEFLinq.Controllers;
using NorthWindEFLinq.Models;


Console.WriteLine("Northwind LINQ EF Library");

AppDbContext _context = new();

CustomersController custCtrl = new(_context);

var customers = await custCtrl.GetByPK(1);




    Print(customers);



void Print(object obj)
{ if (obj is null)
        obj = "(NULL)";
    Console.WriteLine(obj);
    System.Diagnostics.Debug.WriteLine(obj.ToString());
}
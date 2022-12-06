using NorthWindWIthLinq.Models;
            Console.WriteLine("Hello, World!");
 NorthWindContext _context = new();

var suppliers = from supl
                in _context.Suppliers
                select supl;

var sup = from s in _context.Suppliers
          join p in _context.Products
           on s.SupplierID equals p.SupplierId
          orderby s.CompanyName
          select new { Supplier = s.CompanyName,
              Product = p.ProductName, 
              Price = p.UnitPrice, 
              Units = p.UnitsInStock, 
              InventoryCost = p.UnitsInStock * p.UnitPrice};


var products = _context.Products.ToList();
products.ForEach(p => Console.WriteLine(p));

var employees =

                   from empl
                   in _context.Employees
                   where !empl.Country.ToUpper().Equals("USA".ToUpper())
                   orderby empl.LastName
                   select empl;
          
foreach (Employee e in employees) 
{ Console.WriteLine($"{e.FirstName} {e.LastName} {e.Country}"); };
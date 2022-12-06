using NorthWindEFLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindEFLinq.Controllers
{
    public class ProductsController
    {
        private readonly AppDbContext _context = null!;
        public ProductsController(AppDbContext context)
        {

            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.OrderBy(c => c.ProductName);
        }

        public Product GetByPK(int ProductId)
        {
            Product? prod = _context.Products.SingleOrDefault(p => p.ProductId == ProductId);
            return prod;
        }
        public IEnumerable<Product> GetByLastNamePartial(string substring)
        {
            IEnumerable<Product> prod = from p in _context.Products
                                         select p;
            return prod;

        }

        public void Update(int ProductId, Product product)
        {
            if (ProductId != product.ProductId)
            {
                throw new ArgumentException("Invalid customerId");
                _context.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();

                return;
            }
        }

        public Product Insert(int productId, Product product)
        {
            if (product.ProductId != productId) { throw new ArgumentException("INserting a new customer requires the customerId be set to zero"); }
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }
        public void Delete(int productId)
        {
            Product? prod = GetByPK(productId);
            if (prod is null)
            {
                throw new Exception("Customer not found");

            }
            _context.Remove(prod);
            _context.SaveChanges(true);
        }

    }
}

    


using Microsoft.EntityFrameworkCore;
using NorthWindEFLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindEFLinq.Controllers
{
    public class CustomersController
    {
        private readonly AppDbContext _context = null!;
        public CustomersController(AppDbContext context)
        {

            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _context.Customers.OrderBy(c=> c.CompanyName).ToListAsync();        }

        public async Task<Customer> GetByPK(int CustomerId) =>
            //Customer? cust = _context.Customers.SingleOrDefault(c => c.CustomerId == CustomerId);
            await _context.Customers.FindAsync(CustomerId);
        public IEnumerable<Customer> GetByLastNamePartial(string substring)
        {
            IEnumerable<Customer> cust = from c in _context.Customers
                                         select c;
            return cust;

        }

        public async Task Update(int customerId, Customer customer)
        {
            if (customerId != customer.CustomerId)
            {
                throw new ArgumentException("Invalid customerId");
                _context.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
               await  _context.SaveChangesAsync();

                return;
            }
        }

        public async Task <Customer> Insert(int customerId, Customer customer)
        {
            if (customer.CustomerId != customerId) { throw new ArgumentException("INserting a new customer requires the customerId be set to zero"); }
            await _context.Customers.AddAsync(customer);
           await  _context.SaveChangesAsync();
            return customer;
        }
        public async Task Delete(int customerId)
        {
            Customer? cust = await GetByPK(customerId);
            if (cust is null)
            {
                throw new Exception("Customer not found");

            }
            _context.Remove(cust);
            _context.SaveChanges(true);
        }

    }
}

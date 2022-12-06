using NorthWindEFLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindEFLinq.Controllers
{
    public class OrderDeatilsController
    {
        private readonly AppDbContext _context = null!;
        public OrderDeteailsController(AppDbContext context)
        {

            _context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.OrderBy(c => c.CompanyName);
        }

        public OrderDeatil GetByPK(int OrdeDetailrId)
        {
            Customer? cust = _context.Customers.SingleOrDefault(c => c.CustomerId == CustomerId);
            return cust;
        }
        public IEnumerable<Custr> GetByLastNamePartial(string substring)
        {
            IEnumerable<Customer> cust = from c in _context.Customers
                                         select c;
            return cust;

        }

        public void Update(int customerId, Customer customer)
        {
            if (customerId != customer.CustomerId)
            {
                throw new ArgumentException("Invalid customerId");
                _context.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();

                return;
            }
        }

        public Customer Insert(int customerId, Customer customer)
        {
            if (customer.CustomerId != customerId) { throw new ArgumentException("INserting a new customer requires the customerId be set to zero"); }
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }
        public void Delete(int customerId)
        {
            Customer? cust = GetByPK(customerId);
            if (cust is null)
            {
                throw new Exception("Customer not found");

            }
            _context.Remove(cust);
            _context.SaveChanges(true);
        }

    }
}
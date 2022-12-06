using NorthWindEFLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindEFLinq.Controllers
{
    public class OrderController
    {
        private readonly AppDbContext _context = null!;
        public OrderController(AppDbContext context)
        {

            _context = context;
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.OrderBy(o => o.OrderId);
        }

        public async Task <Order> GetByPK(int OrderId)
        {
            Order? ord = _context.Orders.SingleOrDefault(o => o.OrderId == OrderId);
            return ord;
        }
        public IEnumerable<Order> GetByLastNamePartial(string substring)
        {
            IEnumerable<Order> ord = from o in _context.Orders
                                         select o;
            return ord;

        }

        public async Task Update(int OrderId, Order order)
        {
            if (OrderId != order.OrderId)
            {
                throw new ArgumentException("Invalid customerId");
                _context.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
               await  _context.SaveChangesAsync();

                return;
            }
        }

        public async Task <Order> Insert(int orderId, Order order)
        {
            if (order.OrderId != orderId) { throw new ArgumentException("INserting a new customer requires the customerId be set to zero"); }
            _context.Orders.Add(order);
            await _context.SaveChangesAsync ();
            return order;
        }
        public async Task Delete(int orderId)
        {
            Order? ord = await GetByPK(orderId);
            if (ord is null)
            {
                throw new Exception("Customer not found");

            }
            _context.Remove(ord);
            _context.SaveChanges(true);
        }

    }
}

    


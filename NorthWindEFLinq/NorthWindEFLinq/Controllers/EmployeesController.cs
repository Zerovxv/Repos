using NorthWindEFLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindEFLinq.Controllers
{
    public class EmployeesController
    {
        private readonly AppDbContext _context = null!;
        public EmployeesController(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.OrderBy(e => e.LastName);


        }

        public Employee GetByPK(int employeeId)
        {
            Employee? empl = _context.Employees.SingleOrDefault(e => e.EmployeeId == employeeId);
            return _context.Employees.Find(employeeId);
        }

        public IEnumerable<Employee> GetByLastNamePartial(string subString)
        {
            IEnumerable<Employee> employees = from e in _context.Employees
                                              where e.LastName.Contains(subString)
                                              orderby e.LastName
                                              select e;
            return employees;


        }


        public void Update(int employeeId, Employee employee)
        {
            if (employeeId != employee.EmployeeId) { throw new ArgumentException("Onvalid employee id"); }
            _context.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return;


        }

        public Employee Insert(int employeeId, Employee employee)
        {
            if (employee.EmployeeId != 0) { throw new ArgumentException("Inserting a new employee requires the employeeId be set to zero"); }
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }
        public void Delete(int employeeId)
        {
            Employee? empl = GetByPK(employeeId);
            if (empl is null)
            {
                throw new Exception("EMployee not found");
            }
            _context.Remove(empl);
            _context.SaveChanges();
        }
    }
}

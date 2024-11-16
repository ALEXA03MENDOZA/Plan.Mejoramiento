using AlexaApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace AlexaApi.Services
{
    public class EmployeeService
    {
        private readonly AlexaDbContext _context;

        public EmployeeService(AlexaDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public void RegisterEmployee(EmployeeModel employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
    }
}

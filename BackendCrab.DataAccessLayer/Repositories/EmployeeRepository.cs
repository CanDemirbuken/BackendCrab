using BackendCrab.Core.Repositories;
using BackendCrab.EntityLayer.Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCrab.DataAccessLayer.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Employee>> GetEmployeesWithCompany()
        {
            return await _context.Employee.Include(e => e.Company).ToListAsync();
        }
    }
}
